namespace Shell
{
    partial class frmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.lblFile = new DevExpress.XtraEditors.LabelControl();
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.btnAddFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.PanelInfoSupporter = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblSupporter = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelInfoSupporter)).BeginInit();
            this.PanelInfoSupporter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.PanelInfoSupporter);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 457);
            this.panelControl1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(796, 354);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl6);
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 405);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(796, 50);
            this.panelControl3.TabIndex = 1;
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.lblFile);
            this.panelControl6.Controls.Add(this.txtMessage);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl6.Location = new System.Drawing.Point(2, 2);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(645, 46);
            this.panelControl6.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.Appearance.Font = new System.Drawing.Font("Tahoma", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFile.Appearance.Options.UseFont = true;
            this.lblFile.Location = new System.Drawing.Point(8, 30);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(139, 11);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "loi-khong-tinh-tien-duoc.jpg";
            this.lblFile.Visible = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(645, 28);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.btnAddFile);
            this.panelControl5.Controls.Add(this.btnSend);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl5.Location = new System.Drawing.Point(647, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(147, 46);
            this.panelControl5.TabIndex = 0;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddFile.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddFile.Appearance.Options.UseBackColor = true;
            this.btnAddFile.Appearance.Options.UseFont = true;
            this.btnAddFile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddFile.ImageOptions.SvgImage")));
            this.btnAddFile.Location = new System.Drawing.Point(6, 4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(41, 37);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSend.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSend.Appearance.Options.UseBackColor = true;
            this.btnSend.Appearance.Options.UseFont = true;
            this.btnSend.Enabled = false;
            this.btnSend.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSend.ImageOptions.SvgImage")));
            this.btnSend.Location = new System.Drawing.Point(53, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 38);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // PanelInfoSupporter
            // 
            this.PanelInfoSupporter.Controls.Add(this.labelControl1);
            this.PanelInfoSupporter.Controls.Add(this.labelControl2);
            this.PanelInfoSupporter.Controls.Add(this.lblSupporter);
            this.PanelInfoSupporter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelInfoSupporter.Location = new System.Drawing.Point(2, 2);
            this.PanelInfoSupporter.Name = "PanelInfoSupporter";
            this.PanelInfoSupporter.Size = new System.Drawing.Size(796, 49);
            this.PanelInfoSupporter.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(473, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(194, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "(Vui lòng không tắt cửa sổ này)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(166, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(301, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Một đại diện của Ji Ji sẽ hỗ trợ bạn trong vài phút";
            // 
            // lblSupporter
            // 
            this.lblSupporter.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupporter.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSupporter.Appearance.Options.UseFont = true;
            this.lblSupporter.Appearance.Options.UseForeColor = true;
            this.lblSupporter.Location = new System.Drawing.Point(215, 24);
            this.lblSupporter.Name = "lblSupporter";
            this.lblSupporter.Size = new System.Drawing.Size(352, 19);
            this.lblSupporter.TabIndex = 0;
            this.lblSupporter.Text = "Hoàng Long đã tham gia phiên chat với bạn";
            this.lblSupporter.Visible = false;
            // 
            // frmChat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hỗ trợ về phần mềm";
            this.Load += new System.EventHandler(this.frmChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelInfoSupporter)).EndInit();
            this.PanelInfoSupporter.ResumeLayout(false);
            this.PanelInfoSupporter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl PanelInfoSupporter;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.SimpleButton btnAddFile;
        private DevExpress.XtraEditors.MemoEdit txtMessage;
        private DevExpress.XtraEditors.LabelControl lblFile;
        private DevExpress.XtraEditors.LabelControl lblSupporter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}