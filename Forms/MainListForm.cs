using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostServiceAppMax.Models;
using PostServiceAppMax.Services;

namespace PostServiceAppMax.Forms
{
    public partial class MainListForm : Form
    {
        private readonly PostalApiService _service = new();
        private List<PostalItem> _items = new();

        public MainListForm()
        {
            InitializeComponent();
        }

        private async void MainListForm_Load(object sender, EventArgs e)
        {
            txtApiUrl.Text = _service.ServerAddress;
            await RefreshDataAsync();
        }

        private async Task RefreshDataAsync()
        {
            try
            {
                lblStatus.Text = "Оновлення даних...";
                lblStatus.ForeColor = Color.Black;
                btnRefresh.Enabled = false;

                _service.ServerAddress = txtApiUrl.Text.Trim();
                _items = await _service.GetItemsAsync();

                gridItems.DataSource = null;
                gridItems.DataSource = _items;

                lblCount.Text = $"Кількість: {_items.Count}";

                if (_service.IsOfflineMode)
                {
                    lblStatus.Text = "Сервер недоступний (локальний режим)";
                    lblStatus.ForeColor = Color.DarkOrange;
                }
                else
                {
                    lblStatus.Text = "Дані успішно завантажено";
                    lblStatus.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Помилка: {ex.Message}";
                lblStatus.ForeColor = Color.Red;
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }

        private PostalItem? GetSelectedItem()
        {
            if (gridItems.SelectedRows.Count > 0)
            {
                return gridItems.SelectedRows[0].DataBoundItem as PostalItem;
            }
            return null;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new ItemDialogForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                lblStatus.Text = "Додавання запису...";
                await _service.AddItemAsync(form.Item);
                MessageBox.Show("Відправлення успішно збережено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshDataAsync();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedItem();
            if (selected == null)
            {
                MessageBox.Show("Оберіть запис для редагування зі списку", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var copy = new PostalItem
            {
                Id = selected.Id,
                From = selected.From,
                To = selected.To,
                Content = selected.Content,
                DeliveryType = selected.DeliveryType,
                Weight = selected.Weight,
                Width = selected.Width,
                Height = selected.Height,
                Depth = selected.Depth,
                Value = selected.Value,
                Price = selected.Price
            };

            using var form = new ItemDialogForm(copy);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                lblStatus.Text = "Оновлення запису...";
                await _service.UpdateItemAsync(selected.Id, form.Item);
                MessageBox.Show("Зміни успішно збережено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshDataAsync();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedItem();
            if (selected == null)
            {
                MessageBox.Show("Оберіть запис для видалення зі списку", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var res = MessageBox.Show($"Видалити відправлення #{selected.Id} ({selected.Content})?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                lblStatus.Text = "Видалення запису...";
                await _service.DeleteItemAsync(selected.Id);
                MessageBox.Show("Запис видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshDataAsync();
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await RefreshDataAsync();
        }

        private void gridItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnEdit_Click(sender, e);
            }
        }
    }
}
