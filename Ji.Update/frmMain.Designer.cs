namespace Ji.Update
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ListDLL = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pbRun = new DevExpress.XtraEditors.ProgressBarControl();
            this.b = new System.ComponentModel.BackgroundWorker();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListDLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRun.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ListDLL
            // 
            this.ListDLL.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ListDLL.Appearance.Options.UseFont = true;
            this.ListDLL.HorizontalScrollbar = true;
            this.ListDLL.Location = new System.Drawing.Point(12, 78);
            this.ListDLL.Name = "ListDLL";
            this.ListDLL.Size = new System.Drawing.Size(776, 323);
            this.ListDLL.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(320, 19);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Đang kiểm tra cập nhật, vui lòng đợi nhé ♥...";
            // 
            // pbRun
            // 
            this.pbRun.Location = new System.Drawing.Point(12, 37);
            this.pbRun.Name = "pbRun";
            this.pbRun.Properties.Step = 1;
            this.pbRun.Size = new System.Drawing.Size(776, 32);
            this.pbRun.TabIndex = 4;
            // 
            // b
            // 
            this.b.WorkerReportsProgress = true;
            this.b.WorkerSupportsCancellation = true;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.Red;
            this.lblPercent.Location = new System.Drawing.Point(694, 12);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(27, 13);
            this.lblPercent.TabIndex = 9;
            this.lblPercent.Text = "0 %";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Blue;
            this.lblItem.Location = new System.Drawing.Point(613, 12);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(41, 13);
            this.lblItem.TabIndex = 10;
            this.lblItem.Text = "0 item";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 404);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.ListDLL);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pbRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra cập nhật mới";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListDLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRun.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ListBoxControl ListDLL;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ProgressBarControl pbRun;
        private System.ComponentModel.BackgroundWorker b;
    private System.Windows.Forms.Label lblPercent;
    private System.Windows.Forms.Label lblItem;
  }
}

