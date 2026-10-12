using System;
using System.Windows.Forms;
using PostServiceAppMax.Models;

namespace PostServiceAppMax.Forms
{
    public partial class ItemDialogForm : Form
    {
        public PostalItem Item { get; private set; }
        public bool IsEdit { get; }

        public ItemDialogForm(PostalItem? existing = null)
        {
            InitializeComponent();
            IsEdit = existing != null;
            Item = existing ?? new PostalItem
            {
                DeliveryType = 0,
                Weight = 1.0m,
                Width = 20.0m,
                Height = 10.0m,
                Depth = 15.0m,
                Value = 100.0m,
                Price = 70.0m
            };

            Text = IsEdit ? $"Редагування відправлення #{Item.Id}" : "Нове відправлення";
        }

        private void ItemDialogForm_Load(object sender, EventArgs e)
        {
            cmbDeliveryType.Items.Clear();
            cmbDeliveryType.Items.Add("У відділення (стандарт)");
            cmbDeliveryType.Items.Add("Кур'єром (адресна)");
            cmbDeliveryType.SelectedIndex = Item.DeliveryType == 1 ? 1 : 0;

            txtSender.Text = Item.From;
            txtReceiver.Text = Item.To;
            txtDescription.Text = Item.Content;
            numWeight.Value = Item.Weight > 0 ? Item.Weight : 1.0m;
            numDepth.Value = Item.Depth > 0 ? Item.Depth : 15.0m;
            numWidth.Value = Item.Width > 0 ? Item.Width : 20.0m;
            numHeight.Value = Item.Height > 0 ? Item.Height : 10.0m;
            numDeclaredValue.Value = Item.Value >= 0 ? Item.Value : 0m;
            numDeliveryPrice.Value = Item.Price >= 0 ? Item.Price : 50m;
        }

        private bool CheckInputs()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtSender.Text))
            {
                errorProvider1.SetError(txtSender, "Вкажіть відправника");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtReceiver.Text))
            {
                errorProvider1.SetError(txtReceiver, "Вкажіть одержувача");
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Вкажіть опис відправлення");
                ok = false;
            }

            if (numWeight.Value <= 0)
            {
                errorProvider1.SetError(numWeight, "Вага має бути більше 0");
                ok = false;
            }

            if (numDepth.Value <= 0 || numWidth.Value <= 0 || numHeight.Value <= 0)
            {
                errorProvider1.SetError(numDepth, "Габарити повинні бути більше 0");
                ok = false;
            }

            return ok;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
            {
                MessageBox.Show("Будь ласка, заповніть усі обов'язкові поля коректно.", "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Item.From = txtSender.Text.Trim();
            Item.To = txtReceiver.Text.Trim();
            Item.Content = txtDescription.Text.Trim();
            Item.DeliveryType = cmbDeliveryType.SelectedIndex;
            Item.Weight = numWeight.Value;
            Item.Depth = numDepth.Value;
            Item.Width = numWidth.Value;
            Item.Height = numHeight.Value;
            Item.Value = numDeclaredValue.Value;
            Item.Price = numDeliveryPrice.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
