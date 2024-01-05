namespace Ji.Views
{
    partial class Pleasewait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pleasewait));
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.txtAddress = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.txtPhone = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtFacebook = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(399, 105);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(35, 30);
            this.pictureEdit2.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAddress.Appearance.Options.UseFont = true;
            this.txtAddress.Location = new System.Drawing.Point(53, 111);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(332, 17);
            this.txtAddress.TabIndex = 25;
            this.txtAddress.Text = "21 Đường 1, Phước Long B, Quận 9, Quận 9, TP HCM";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(12, 106);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(35, 30);
            this.pictureEdit3.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPhone.Appearance.Options.UseFont = true;
            this.txtPhone.Location = new System.Drawing.Point(440, 111);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(78, 16);
            this.txtPhone.TabIndex = 23;
            this.txtPhone.Text = "0978.123.900";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(116, 71);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(38, 34);
            this.pictureEdit1.TabIndex = 22;
            // 
            // txtFacebook
            // 
            this.txtFacebook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFacebook.Appearance.Options.UseFont = true;
            this.txtFacebook.Location = new System.Drawing.Point(160, 74);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(259, 19);
            this.txtFacebook.TabIndex = 21;
            this.txtFacebook.Text = "https://www.facebook.com/trasuajiji";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.ImageHorzOffset = 20;
            this.progressPanel1.Location = new System.Drawing.Point(199, -1);
            this.progressPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(146, 39);
            this.progressPanel1.TabIndex = 20;
            this.progressPanel1.Text = "Vui lòng chờ";
            // 
            // labelStatus
            // 
            this.labelStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Appearance.Options.UseFont = true;
            this.labelStatus.Appearance.Options.UseForeColor = true;
            this.labelStatus.Location = new System.Drawing.Point(80, 44);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(382, 24);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "Đang tải dữ liệu, vui lòng chờ nhé ♥ ...";
            // 
            // Pleasewait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(524, 147);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.labelStatus);
            this.DoubleBuffered = true;
            this.Name = "Pleasewait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pleasewait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.HyperlinkLabelControl txtAddress;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.HyperlinkLabelControl txtPhone;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.HyperlinkLabelControl txtFacebook;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraEditors.LabelControl labelStatus;
    }
}
