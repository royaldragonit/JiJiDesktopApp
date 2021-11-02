namespace Ji.Customer
{
    partial class ucCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCustomer));
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.ColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnCustomerMail = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnViewDetail = new DevExpress.XtraGrid.Columns.GridColumn();
      this.btnViewDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
      this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
      this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
      this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
      this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
      this.panelControl3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnViewDetail)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
      this.panelControl2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
      this.panelControl5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
      this.panelControl4.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.panelControl3);
      this.panelControl1.Controls.Add(this.panelControl2);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControl1.Location = new System.Drawing.Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(1084, 469);
      this.panelControl1.TabIndex = 0;
      // 
      // panelControl3
      // 
      this.panelControl3.Controls.Add(this.gridControl1);
      this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControl3.Location = new System.Drawing.Point(2, 46);
      this.panelControl3.Name = "panelControl3";
      this.panelControl3.Size = new System.Drawing.Size(1080, 421);
      this.panelControl3.TabIndex = 1;
      // 
      // gridControl1
      // 
      this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControl1.Location = new System.Drawing.Point(2, 2);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnViewDetail});
      this.gridControl1.Size = new System.Drawing.Size(1076, 417);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnID,
            this.ColumnCustomerName,
            this.ColumnCustomerPhone,
            this.ColumnCustomerMail,
            this.ColumnViewDetail});
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.RowHeight = 30;
      // 
      // ColumnID
      // 
      this.ColumnID.Caption = "gridColumn1";
      this.ColumnID.FieldName = "ID";
      this.ColumnID.Name = "ColumnID";
      // 
      // ColumnCustomerName
      // 
      this.ColumnCustomerName.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
      this.ColumnCustomerName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.ColumnCustomerName.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
      this.ColumnCustomerName.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnCustomerName.AppearanceHeader.Options.UseFont = true;
      this.ColumnCustomerName.AppearanceHeader.Options.UseForeColor = true;
      this.ColumnCustomerName.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnCustomerName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnCustomerName.Caption = "Tên khách hàng";
      this.ColumnCustomerName.FieldName = "FullName";
      this.ColumnCustomerName.Name = "ColumnCustomerName";
      this.ColumnCustomerName.OptionsColumn.AllowEdit = false;
      this.ColumnCustomerName.Visible = true;
      this.ColumnCustomerName.VisibleIndex = 0;
      this.ColumnCustomerName.Width = 585;
      // 
      // ColumnCustomerPhone
      // 
      this.ColumnCustomerPhone.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
      this.ColumnCustomerPhone.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.ColumnCustomerPhone.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
      this.ColumnCustomerPhone.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnCustomerPhone.AppearanceHeader.Options.UseFont = true;
      this.ColumnCustomerPhone.AppearanceHeader.Options.UseForeColor = true;
      this.ColumnCustomerPhone.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnCustomerPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnCustomerPhone.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnCustomerPhone.Caption = "Số điện thoại";
      this.ColumnCustomerPhone.FieldName = "Phone";
      this.ColumnCustomerPhone.Name = "ColumnCustomerPhone";
      this.ColumnCustomerPhone.OptionsColumn.AllowEdit = false;
      this.ColumnCustomerPhone.Visible = true;
      this.ColumnCustomerPhone.VisibleIndex = 1;
      this.ColumnCustomerPhone.Width = 171;
      // 
      // ColumnCustomerMail
      // 
      this.ColumnCustomerMail.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
      this.ColumnCustomerMail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.ColumnCustomerMail.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
      this.ColumnCustomerMail.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnCustomerMail.AppearanceHeader.Options.UseFont = true;
      this.ColumnCustomerMail.AppearanceHeader.Options.UseForeColor = true;
      this.ColumnCustomerMail.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnCustomerMail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnCustomerMail.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnCustomerMail.Caption = "E-Mail";
      this.ColumnCustomerMail.FieldName = "Address";
      this.ColumnCustomerMail.Name = "ColumnCustomerMail";
      this.ColumnCustomerMail.OptionsColumn.AllowEdit = false;
      this.ColumnCustomerMail.Visible = true;
      this.ColumnCustomerMail.VisibleIndex = 2;
      this.ColumnCustomerMail.Width = 159;
      // 
      // ColumnViewDetail
      // 
      this.ColumnViewDetail.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
      this.ColumnViewDetail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.ColumnViewDetail.AppearanceHeader.ForeColor = System.Drawing.Color.Red;
      this.ColumnViewDetail.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnViewDetail.AppearanceHeader.Options.UseFont = true;
      this.ColumnViewDetail.AppearanceHeader.Options.UseForeColor = true;
      this.ColumnViewDetail.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnViewDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnViewDetail.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnViewDetail.Caption = "Chi Tiết";
      this.ColumnViewDetail.ColumnEdit = this.btnViewDetail;
      this.ColumnViewDetail.Name = "ColumnViewDetail";
      this.ColumnViewDetail.Visible = true;
      this.ColumnViewDetail.VisibleIndex = 3;
      this.ColumnViewDetail.Width = 143;
      // 
      // btnViewDetail
      // 
      this.btnViewDetail.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.btnViewDetail.Appearance.Options.UseForeColor = true;
      this.btnViewDetail.AutoHeight = false;
      serializableAppearanceObject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      serializableAppearanceObject1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      serializableAppearanceObject1.ForeColor = System.Drawing.Color.Blue;
      serializableAppearanceObject1.Options.UseBackColor = true;
      serializableAppearanceObject1.Options.UseFont = true;
      serializableAppearanceObject1.Options.UseForeColor = true;
      this.btnViewDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xem chi tiết", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
      this.btnViewDetail.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.btnViewDetail.Name = "btnViewDetail";
      this.btnViewDetail.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.btnViewDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
      // 
      // panelControl2
      // 
      this.panelControl2.Controls.Add(this.panelControl5);
      this.panelControl2.Controls.Add(this.panelControl4);
      this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelControl2.Location = new System.Drawing.Point(2, 2);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new System.Drawing.Size(1080, 44);
      this.panelControl2.TabIndex = 0;
      // 
      // panelControl5
      // 
      this.panelControl5.Controls.Add(this.btnAdd);
      this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControl5.Location = new System.Drawing.Point(115, 2);
      this.panelControl5.Name = "panelControl5";
      this.panelControl5.Size = new System.Drawing.Size(963, 40);
      this.panelControl5.TabIndex = 1;
      // 
      // btnAdd
      // 
      this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.btnAdd.Appearance.Options.UseBackColor = true;
      this.btnAdd.Appearance.Options.UseFont = true;
      this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
      this.btnAdd.Location = new System.Drawing.Point(2, 2);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(91, 36);
      this.btnAdd.TabIndex = 7;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // panelControl4
      // 
      this.panelControl4.Controls.Add(this.btnExcel);
      this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelControl4.Location = new System.Drawing.Point(2, 2);
      this.panelControl4.Name = "panelControl4";
      this.panelControl4.Size = new System.Drawing.Size(113, 40);
      this.panelControl4.TabIndex = 0;
      // 
      // btnExcel
      // 
      this.btnExcel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.btnExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
      this.btnExcel.Appearance.Options.UseBackColor = true;
      this.btnExcel.Appearance.Options.UseFont = true;
      this.btnExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
      this.btnExcel.Location = new System.Drawing.Point(2, 2);
      this.btnExcel.Name = "btnExcel";
      this.btnExcel.Size = new System.Drawing.Size(109, 36);
      this.btnExcel.TabIndex = 12;
      this.btnExcel.Text = "Excel";
      // 
      // ucCustomer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panelControl1);
      this.Name = "ucCustomer";
      this.Size = new System.Drawing.Size(1084, 469);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
      this.panelControl3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnViewDetail)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
      this.panelControl2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
      this.panelControl5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
      this.panelControl4.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnViewDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnViewDetail;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}
