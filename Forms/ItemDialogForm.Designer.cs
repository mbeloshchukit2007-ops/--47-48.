namespace PostServiceAppMax.Forms
{
    partial class ItemDialogForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDeliveryType;
        private System.Windows.Forms.ComboBox cmbDeliveryType;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label lblDeclaredValue;
        private System.Windows.Forms.NumericUpDown numDeclaredValue;
        private System.Windows.Forms.Label lblDeliveryPrice;
        private System.Windows.Forms.NumericUpDown numDeliveryPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;

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
            this.components = new System.ComponentModel.Container();
            this.lblSender = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDeliveryType = new System.Windows.Forms.Label();
            this.cmbDeliveryType = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lblDeclaredValue = new System.Windows.Forms.Label();
            this.numDeclaredValue = new System.Windows.Forms.NumericUpDown();
            this.lblDeliveryPrice = new System.Windows.Forms.Label();
            this.numDeliveryPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeclaredValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeliveryPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // lblSender
            this.lblSender.Location = new System.Drawing.Point(15, 20);
            this.lblSender.Size = new System.Drawing.Size(120, 20);
            this.lblSender.Text = "Відправник:";
            this.txtSender.Location = new System.Drawing.Point(145, 18);
            this.txtSender.Size = new System.Drawing.Size(260, 23);

            // lblReceiver
            this.lblReceiver.Location = new System.Drawing.Point(15, 55);
            this.lblReceiver.Size = new System.Drawing.Size(120, 20);
            this.lblReceiver.Text = "Одержувач:";
            this.txtReceiver.Location = new System.Drawing.Point(145, 53);
            this.txtReceiver.Size = new System.Drawing.Size(260, 23);

            // lblDescription
            this.lblDescription.Location = new System.Drawing.Point(15, 90);
            this.lblDescription.Size = new System.Drawing.Size(120, 20);
            this.lblDescription.Text = "Опис вмісту:";
            this.txtDescription.Location = new System.Drawing.Point(145, 88);
            this.txtDescription.Size = new System.Drawing.Size(260, 23);

            // lblDeliveryType
            this.lblDeliveryType.Location = new System.Drawing.Point(15, 125);
            this.lblDeliveryType.Size = new System.Drawing.Size(120, 20);
            this.lblDeliveryType.Text = "Спосіб доставки:";
            this.cmbDeliveryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryType.Location = new System.Drawing.Point(145, 123);
            this.cmbDeliveryType.Size = new System.Drawing.Size(260, 23);

            // lblWeight
            this.lblWeight.Location = new System.Drawing.Point(15, 160);
            this.lblWeight.Size = new System.Drawing.Size(120, 20);
            this.lblWeight.Text = "Вага (кг):";
            this.numWeight.DecimalPlaces = 2;
            this.numWeight.Maximum = 1000m;
            this.numWeight.Location = new System.Drawing.Point(145, 158);
            this.numWeight.Size = new System.Drawing.Size(110, 23);

            // lblDepth
            this.lblDepth.Location = new System.Drawing.Point(15, 195);
            this.lblDepth.Size = new System.Drawing.Size(120, 20);
            this.lblDepth.Text = "Довжина (см):";
            this.numDepth.DecimalPlaces = 1;
            this.numDepth.Maximum = 500m;
            this.numDepth.Location = new System.Drawing.Point(145, 193);
            this.numDepth.Size = new System.Drawing.Size(110, 23);

            // lblWidth
            this.lblWidth.Location = new System.Drawing.Point(15, 230);
            this.lblWidth.Size = new System.Drawing.Size(120, 20);
            this.lblWidth.Text = "Ширина (см):";
            this.numWidth.DecimalPlaces = 1;
            this.numWidth.Maximum = 500m;
            this.numWidth.Location = new System.Drawing.Point(145, 228);
            this.numWidth.Size = new System.Drawing.Size(110, 23);

            // lblHeight
            this.lblHeight.Location = new System.Drawing.Point(15, 265);
            this.lblHeight.Size = new System.Drawing.Size(120, 20);
            this.lblHeight.Text = "Висота (см):";
            this.numHeight.DecimalPlaces = 1;
            this.numHeight.Maximum = 500m;
            this.numHeight.Location = new System.Drawing.Point(145, 263);
            this.numHeight.Size = new System.Drawing.Size(110, 23);

            // lblDeclaredValue
            this.lblDeclaredValue.Location = new System.Drawing.Point(15, 300);
            this.lblDeclaredValue.Size = new System.Drawing.Size(120, 20);
            this.lblDeclaredValue.Text = "Оцінка (грн):";
            this.numDeclaredValue.DecimalPlaces = 2;
            this.numDeclaredValue.Maximum = 1000000m;
            this.numDeclaredValue.Location = new System.Drawing.Point(145, 298);
            this.numDeclaredValue.Size = new System.Drawing.Size(110, 23);

            // lblDeliveryPrice
            this.lblDeliveryPrice.Location = new System.Drawing.Point(15, 335);
            this.lblDeliveryPrice.Size = new System.Drawing.Size(120, 20);
            this.lblDeliveryPrice.Text = "Вартість (грн):";
            this.numDeliveryPrice.DecimalPlaces = 2;
            this.numDeliveryPrice.Maximum = 100000m;
            this.numDeliveryPrice.Location = new System.Drawing.Point(145, 333);
            this.numDeliveryPrice.Size = new System.Drawing.Size(110, 23);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(215, 380);
            this.btnSave.Size = new System.Drawing.Size(95, 28);
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(320, 380);
            this.btnCancel.Size = new System.Drawing.Size(85, 28);
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // ItemDialogForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 425);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.lblReceiver);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDeliveryType);
            this.Controls.Add(this.cmbDeliveryType);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.lblDeclaredValue);
            this.Controls.Add(this.numDeclaredValue);
            this.Controls.Add(this.lblDeliveryPrice);
            this.Controls.Add(this.numDeliveryPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Load += new System.EventHandler(this.ItemDialogForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeclaredValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeliveryPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
