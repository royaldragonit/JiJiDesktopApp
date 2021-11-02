namespace Shell
{
  partial class frmSignUp
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
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.txtPhone = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.txtEmail = new DevExpress.XtraEditors.TextEdit();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.txtShopName = new DevExpress.XtraEditors.TextEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.btnLSignUp = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.cbTypeShop = new DevExpress.XtraEditors.ComboBoxEdit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtShopName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbTypeShop.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(118, 12);
      this.txtName.Name = "txtName";
      this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.txtName.Properties.Appearance.Options.UseFont = true;
      this.txtName.Properties.NullValuePrompt = "Nhập họ tên của bạn";
      this.txtName.Size = new System.Drawing.Size(286, 26);
      this.txtName.TabIndex = 8;
      // 
      // labelControl4
      // 
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new System.Drawing.Point(6, 15);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(74, 19);
      this.labelControl4.TabIndex = 7;
      this.labelControl4.Text = "Họ và tên:";
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(118, 44);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.txtPhone.Properties.Appearance.Options.UseFont = true;
      this.txtPhone.Properties.NullValuePrompt = "Nhập số điện thoại của bạn";
      this.txtPhone.Size = new System.Drawing.Size(286, 26);
      this.txtPhone.TabIndex = 10;
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new System.Drawing.Point(6, 47);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(106, 19);
      this.labelControl1.TabIndex = 9;
      this.labelControl1.Text = "Số Điện Thoại:";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(118, 76);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.txtEmail.Properties.Appearance.Options.UseFont = true;
      this.txtEmail.Properties.NullValuePrompt = "Nhập Email của bạn";
      this.txtEmail.Size = new System.Drawing.Size(286, 26);
      this.txtEmail.TabIndex = 12;
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new System.Drawing.Point(6, 79);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(45, 19);
      this.labelControl2.TabIndex = 11;
      this.labelControl2.Text = "Email:";
      // 
      // txtShopName
      // 
      this.txtShopName.Location = new System.Drawing.Point(118, 108);
      this.txtShopName.Name = "txtShopName";
      this.txtShopName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.txtShopName.Properties.Appearance.Options.UseFont = true;
      this.txtShopName.Properties.NullValuePrompt = "Nhập tên cửa hàng của bạn";
      this.txtShopName.Size = new System.Drawing.Size(286, 26);
      this.txtShopName.TabIndex = 14;
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new System.Drawing.Point(6, 111);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(103, 19);
      this.labelControl3.TabIndex = 13;
      this.labelControl3.Text = "Tên cửa hàng:";
      // 
      // btnLSignUp
      // 
      this.btnLSignUp.Appearance.BackColor = System.Drawing.Color.Green;
      this.btnLSignUp.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
      this.btnLSignUp.Appearance.Options.UseBackColor = true;
      this.btnLSignUp.Appearance.Options.UseFont = true;
      this.btnLSignUp.Location = new System.Drawing.Point(267, 172);
      this.btnLSignUp.Name = "btnLSignUp";
      this.btnLSignUp.Size = new System.Drawing.Size(137, 37);
      this.btnLSignUp.TabIndex = 15;
      this.btnLSignUp.Text = "Đăng ký";
      this.btnLSignUp.Click += new System.EventHandler(this.btnLSignUp_Click);
      // 
      // labelControl5
      // 
      this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new System.Drawing.Point(6, 143);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(105, 19);
      this.labelControl5.TabIndex = 16;
      this.labelControl5.Text = "Loại cửa hàng:";
      // 
      // cbTypeShop
      // 
      this.cbTypeShop.EditValue = "Trà Sữa";
      this.cbTypeShop.Location = new System.Drawing.Point(118, 140);
      this.cbTypeShop.Name = "cbTypeShop";
      this.cbTypeShop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.cbTypeShop.Properties.Appearance.Options.UseFont = true;
      this.cbTypeShop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cbTypeShop.Properties.Items.AddRange(new object[] {
            "Trà Sữa",
            "Cà phê",
            "Cửa hàng nội thất, vv..."});
      this.cbTypeShop.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.cbTypeShop.Size = new System.Drawing.Size(286, 26);
      this.cbTypeShop.TabIndex = 17;
      // 
      // frmSignUp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(410, 213);
      this.Controls.Add(this.cbTypeShop);
      this.Controls.Add(this.labelControl5);
      this.Controls.Add(this.btnLSignUp);
      this.Controls.Add(this.txtShopName);
      this.Controls.Add(this.labelControl3);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.labelControl4);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmSignUp";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Đăng ký dùng thử phần mềm bán hàng";
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtShopName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cbTypeShop.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtShopName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLSignUp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbTypeShop;
    }
}