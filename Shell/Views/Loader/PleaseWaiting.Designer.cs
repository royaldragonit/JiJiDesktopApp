namespace Shell.Views.Loader
{
    partial class PleaseWaiting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PleaseWaiting));
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.txtFacebook = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.txtPhone = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.txtAddress = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Appearance.Options.UseFont = true;
            this.labelStatus.Appearance.Options.UseForeColor = true;
            this.labelStatus.Location = new System.Drawing.Point(53, 57);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(382, 24);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Đang tải dữ liệu, vui lòng chờ nhé ♥ ...";
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.BarAnimationElementThickness = 2;
            this.progressPanel1.ImageHorzOffset = 20;
            this.progressPanel1.Location = new System.Drawing.Point(145, 12);
            this.progressPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(146, 39);
            this.progressPanel1.TabIndex = 9;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFacebook.Appearance.Options.UseFont = true;
            this.txtFacebook.Location = new System.Drawing.Point(133, 87);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(259, 19);
            this.txtFacebook.TabIndex = 10;
            this.txtFacebook.Text = "https://www.facebook.com/trasuajiji";
            // 
            // txtPhone
            // 
            this.txtPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPhone.Appearance.Options.UseFont = true;
            this.txtPhone.Location = new System.Drawing.Point(384, 119);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(78, 16);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.Text = "0978.123.900";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Shell.Properties.Resources.fb_icon;
            this.pictureEdit1.Location = new System.Drawing.Point(89, 81);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.InitialImageOptions.Image = global::Shell.Properties.Resources.fb_icon;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(38, 34);
            this.pictureEdit1.TabIndex = 11;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(12, 114);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(35, 30);
            this.pictureEdit3.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAddress.Appearance.Options.UseFont = true;
            this.txtAddress.Location = new System.Drawing.Point(53, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(279, 16);
            this.txtAddress.TabIndex = 17;
            this.txtAddress.Text = "21 Đường 1, Phước Long B, Quận 9, TP HCM";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(343, 112);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(35, 30);
            this.pictureEdit2.TabIndex = 18;
            // 
            // PleaseWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 164);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.progressPanel1);
            this.Controls.Add(this.labelStatus);
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.Name = "PleaseWaiting";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PleaseWaiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraEditors.HyperlinkLabelControl txtFacebook;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.HyperlinkLabelControl txtPhone;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.HyperlinkLabelControl txtAddress;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}
