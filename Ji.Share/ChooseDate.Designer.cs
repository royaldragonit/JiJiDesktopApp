namespace Ji
{
    partial class frmChooseDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseDate));
            this.PanelChoose = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PanelChoose)).BeginInit();
            this.PanelChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelChoose
            // 
            this.PanelChoose.Controls.Add(this.btnOK);
            this.PanelChoose.Controls.Add(this.labelControl3);
            this.PanelChoose.Controls.Add(this.labelControl2);
            this.PanelChoose.Controls.Add(this.dtToDate);
            this.PanelChoose.Controls.Add(this.dtFromDate);
            this.PanelChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChoose.Location = new System.Drawing.Point(0, 0);
            this.PanelChoose.Name = "PanelChoose";
            this.PanelChoose.Size = new System.Drawing.Size(419, 110);
            this.PanelChoose.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.ImageOptions.Image")));
            this.btnOK.Location = new System.Drawing.Point(185, 63);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 36);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Đến ngày";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Từ ngày";
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtToDate.Location = new System.Drawing.Point(110, 30);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(299, 27);
            this.dtToDate.TabIndex = 1;
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtFromDate.Location = new System.Drawing.Point(110, 1);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(299, 27);
            this.dtFromDate.TabIndex = 3;
            // 
            // frmChooseDate
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 110);
            this.Controls.Add(this.PanelChoose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChooseDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn ngày";
            ((System.ComponentModel.ISupportInitialize)(this.PanelChoose)).EndInit();
            this.PanelChoose.ResumeLayout(false);
            this.PanelChoose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelChoose;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}