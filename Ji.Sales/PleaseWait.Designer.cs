namespace Ji.Sales
{
    partial class PleaseWait
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
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(43, 439);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.EndColor = System.Drawing.Color.Green;
            this.progressBarControl.Properties.StartColor = System.Drawing.Color.Green;
            this.progressBarControl.Size = new System.Drawing.Size(1217, 24);
            this.progressBarControl.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelStatus.Appearance.Options.UseFont = true;
            this.labelStatus.Location = new System.Drawing.Point(475, 365);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(310, 24);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Đang tải dữ liệu, vui lòng chờ ♥ ....";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImage = global::Ji.Sales.Properties.Resources.sdfsfsdf;
            this.pictureEdit1.EditValue = global::Ji.Sales.Properties.Resources.logo150x150;
            this.pictureEdit1.Location = new System.Drawing.Point(556, 160);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.InitialImageOptions.Image = global::Ji.Sales.Properties.Resources.sdfsfsdf;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(150, 156);
            this.pictureEdit1.TabIndex = 8;
            // 
            // PleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 515);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBarControl);
            this.Name = "PleaseWait";
            this.SplashImageOptions.Image = global::Ji.Sales.Properties.Resources._61903;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
