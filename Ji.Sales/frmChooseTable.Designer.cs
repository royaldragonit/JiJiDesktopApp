namespace Ji.Sales
{
    partial class frmChooseTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseTable));
            this.txtTable = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(3, 12);
            this.txtTable.Name = "txtTable";
            this.txtTable.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTable.Properties.Appearance.Options.UseFont = true;
            this.txtTable.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTable.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTable.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtTable.Size = new System.Drawing.Size(216, 26);
            this.txtTable.TabIndex = 0;
            this.txtTable.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTable_EditValueChanging);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(57, 44);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 36);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Đồng ý";
            this.simpleButton1.Click += new System.EventHandler(this.btnOk);
            // 
            // frmChooseTable
            // 
            this.AcceptButton = this.simpleButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 92);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChooseTable";
            this.Text = "Chọn bàn để chuyển";
            ((System.ComponentModel.ISupportInitialize)(this.txtTable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTable;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}