namespace Ji.Sales
{
    partial class frmTopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTopping));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ChooseTopping = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.btnOrder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTopping)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.btnOrder);
            this.panelControl1.Controls.Add(this.ChooseTopping);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(303, 394);
            this.panelControl1.TabIndex = 0;
            // 
            // ChooseTopping
            // 
            this.ChooseTopping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChooseTopping.Location = new System.Drawing.Point(2, 2);
            this.ChooseTopping.MultiColumn = true;
            this.ChooseTopping.Name = "ChooseTopping";
            this.ChooseTopping.Size = new System.Drawing.Size(299, 390);
            this.ChooseTopping.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOrder.Appearance.Options.UseBackColor = true;
            this.btnOrder.Appearance.Options.UseFont = true;
            this.btnOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.ImageOptions.Image")));
            this.btnOrder.Location = new System.Drawing.Point(159, 340);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(132, 42);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Xác nhận";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(303, 394);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTopping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn Topping cho ";
            this.Load += new System.EventHandler(this.frmTopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChooseTopping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl ChooseTopping;
        private DevExpress.XtraEditors.SimpleButton btnOrder;
    }
}