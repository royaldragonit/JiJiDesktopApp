namespace Ji.Poached
{
    partial class frmAddResource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddResource));
            this.PanelWrapper = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtPriceBinding = new DevExpress.XtraEditors.TextEdit();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtQuantityInAUnit = new DevExpress.XtraEditors.TextEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBrandName = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResourceName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelWrapper)).BeginInit();
            this.PanelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceBinding.Properties)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityInAUnit.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResourceName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelWrapper
            // 
            this.PanelWrapper.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelWrapper.Controls.Add(this.panelControl1);
            this.PanelWrapper.Controls.Add(this.groupBox7);
            this.PanelWrapper.Controls.Add(this.groupBox6);
            this.PanelWrapper.Controls.Add(this.groupBox5);
            this.PanelWrapper.Controls.Add(this.groupBox4);
            this.PanelWrapper.Controls.Add(this.groupBox3);
            this.PanelWrapper.Controls.Add(this.groupBox2);
            this.PanelWrapper.Controls.Add(this.groupBox1);
            this.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWrapper.Location = new System.Drawing.Point(0, 0);
            this.PanelWrapper.Name = "PanelWrapper";
            this.PanelWrapper.Size = new System.Drawing.Size(986, 393);
            this.PanelWrapper.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 350);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(986, 42);
            this.panelControl1.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(791, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(889, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtPriceBinding);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(0, 300);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(986, 50);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tiền Theo 1 Đơn vị (KG, Bao, Bọc, ...)";
            // 
            // txtPriceBinding
            // 
            this.txtPriceBinding.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPriceBinding.Enabled = false;
            this.txtPriceBinding.Location = new System.Drawing.Point(3, 20);
            this.txtPriceBinding.Name = "txtPriceBinding";
            this.txtPriceBinding.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPriceBinding.Properties.Appearance.Options.UseFont = true;
            this.txtPriceBinding.Properties.NullValuePrompt = "Bạn nhập nguyên liệu của hãng nào?";
            this.txtPriceBinding.Size = new System.Drawing.Size(980, 26);
            this.txtPriceBinding.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtQuantity);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(0, 250);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(986, 50);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Số lượng (VD nhập 5 chai, 50KG, vv...)";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantity.Location = new System.Drawing.Point(3, 20);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Properties.NullValuePrompt = "Bạn nhập nguyên liệu của hãng nào?";
            this.txtQuantity.Size = new System.Drawing.Size(980, 26);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.txtQuantity_EditValueChanged);
            this.txtQuantity.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtQuantity_EditValueChanging);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtQuantityInAUnit);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(0, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(986, 50);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Số lượng trên một đơn vị (Vd: 1 chai = 700ml thì ghi 700)";
            // 
            // txtQuantityInAUnit
            // 
            this.txtQuantityInAUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuantityInAUnit.Location = new System.Drawing.Point(3, 20);
            this.txtQuantityInAUnit.Name = "txtQuantityInAUnit";
            this.txtQuantityInAUnit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtQuantityInAUnit.Properties.Appearance.Options.UseFont = true;
            this.txtQuantityInAUnit.Properties.NullValuePrompt = "Bạn nhập nguyên liệu của hãng nào?";
            this.txtQuantityInAUnit.Size = new System.Drawing.Size(980, 26);
            this.txtQuantityInAUnit.TabIndex = 0;
            this.txtQuantityInAUnit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtQuantityInAUnit_EditValueChanging);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPrice);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(0, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(986, 50);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giá nguyên liệu (Tính theo giá sỉ, ví dụ 12KG Đường = 155.000đ)";
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrice.Location = new System.Drawing.Point(3, 20);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Properties.NullValuePrompt = "Bạn nhập nguyên liệu của hãng nào?";
            this.txtPrice.Size = new System.Drawing.Size(980, 26);
            this.txtPrice.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbUnit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(0, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(986, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đơn vị tính (Mililit/Gam)";
            // 
            // cbUnit
            // 
            this.cbUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Mililit (ml)",
            "Gam (g)"});
            this.cbUnit.Location = new System.Drawing.Point(3, 20);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(980, 27);
            this.cbUnit.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBrandName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên thương hiệu";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBrandName.Location = new System.Drawing.Point(3, 20);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBrandName.Properties.Appearance.Options.UseFont = true;
            this.txtBrandName.Properties.NullValuePrompt = "Bạn nhập nguyên liệu của hãng nào?";
            this.txtBrandName.Size = new System.Drawing.Size(980, 26);
            this.txtBrandName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResourceName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên nguyên liệu";
            // 
            // txtResourceName
            // 
            this.txtResourceName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResourceName.Location = new System.Drawing.Point(3, 20);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtResourceName.Properties.Appearance.Options.UseFont = true;
            this.txtResourceName.Properties.NullValuePrompt = "Bạn muốn thêm nguyên liệu gì?";
            this.txtResourceName.Size = new System.Drawing.Size(980, 26);
            this.txtResourceName.TabIndex = 0;
            // 
            // frmAddResource
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 393);
            this.Controls.Add(this.PanelWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddResource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới nguyên liệu";
            ((System.ComponentModel.ISupportInitialize)(this.PanelWrapper)).EndInit();
            this.PanelWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceBinding.Properties)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityInAUnit.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtResourceName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelWrapper;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtBrandName;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtResourceName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.TextEdit txtQuantityInAUnit;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private System.Windows.Forms.GroupBox groupBox7;
        private DevExpress.XtraEditors.TextEdit txtPriceBinding;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}