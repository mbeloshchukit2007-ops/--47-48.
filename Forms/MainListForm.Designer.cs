namespace PostServiceAppMax.Forms
{
    partial class MainListForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.DataGridView gridItems;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.gridItems = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();

            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // topPanel
            this.topPanel.Controls.Add(this.btnAdd);
            this.topPanel.Controls.Add(this.btnEdit);
            this.topPanel.Controls.Add(this.btnDelete);
            this.topPanel.Controls.Add(this.btnRefresh);
            this.topPanel.Controls.Add(this.lblUrl);
            this.topPanel.Controls.Add(this.txtApiUrl);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Size = new System.Drawing.Size(900, 42);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(10, 8);
            this.btnAdd.Size = new System.Drawing.Size(90, 26);
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(106, 8);
            this.btnEdit.Size = new System.Drawing.Size(90, 26);
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(202, 8);
            this.btnDelete.Size = new System.Drawing.Size(85, 26);
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(293, 8);
            this.btnRefresh.Size = new System.Drawing.Size(85, 26);
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // lblUrl
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(415, 14);
            this.lblUrl.Size = new System.Drawing.Size(51, 15);
            this.lblUrl.Text = "Сервер:";

            // txtApiUrl
            this.txtApiUrl.Location = new System.Drawing.Point(470, 11);
            this.txtApiUrl.Size = new System.Drawing.Size(260, 23);

            // gridItems
            this.gridItems.AllowUserToAddRows = false;
            this.gridItems.AllowUserToDeleteRows = false;
            this.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colContent,
                this.colFrom,
                this.colTo,
                this.colDelivery,
                this.colWeight,
                this.colSize,
                this.colValue,
                this.colPrice
            });
            this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItems.Location = new System.Drawing.Point(0, 42);
            this.gridItems.MultiSelect = false;
            this.gridItems.ReadOnly = true;
            this.gridItems.RowHeadersVisible = false;
            this.gridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItems.Size = new System.Drawing.Size(900, 430);
            this.gridItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItems_CellDoubleClick);

            // colId
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 40F;
            this.colId.HeaderText = "ID";

            // colContent
            this.colContent.DataPropertyName = "Content";
            this.colContent.FillWeight = 110F;
            this.colContent.HeaderText = "Вміст";

            // colFrom
            this.colFrom.DataPropertyName = "From";
            this.colFrom.FillWeight = 85F;
            this.colFrom.HeaderText = "Відправник";

            // colTo
            this.colTo.DataPropertyName = "To";
            this.colTo.FillWeight = 85F;
            this.colTo.HeaderText = "Одержувач";

            // colDelivery
            this.colDelivery.DataPropertyName = "DeliveryTypeTitle";
            this.colDelivery.FillWeight = 95F;
            this.colDelivery.HeaderText = "Доставка";

            // colWeight
            this.colWeight.DataPropertyName = "Weight";
            this.colWeight.FillWeight = 60F;
            this.colWeight.HeaderText = "Вага (кг)";

            // colSize
            this.colSize.DataPropertyName = "SizeInfo";
            this.colSize.FillWeight = 90F;
            this.colSize.HeaderText = "Розміри";

            // colValue
            this.colValue.DataPropertyName = "Value";
            this.colValue.FillWeight = 70F;
            this.colValue.HeaderText = "Оцінка (грн)";

            // colPrice
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.FillWeight = 70F;
            this.colPrice.HeaderText = "Ціна (грн)";

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatus,
                this.lblCount
            });
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);

            // lblStatus
            this.lblStatus.Size = new System.Drawing.Size(785, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Text = "Готово";

            // lblCount
            this.lblCount.Size = new System.Drawing.Size(100, 17);
            this.lblCount.Text = "Кількість: 0";

            // MainListForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 494);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.topPanel);
            this.MinimumSize = new System.Drawing.Size(720, 380);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік відправлень PostService";
            this.Load += new System.EventHandler(this.MainListForm_Load);

            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
