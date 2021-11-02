namespace Ji.Customer
{
  partial class ucRevenueCustomer
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRevenueCustomer));
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.ColumnOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnCreateOn = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnTotalMoney = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnGlass = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnCashier = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
      this.ColumnDetail = new DevExpress.XtraGrid.Columns.GridColumn();
      this.btnViewDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      this.ColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
      this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnViewDetail)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
      this.SuspendLayout();
      // 
      // gridControl1
      // 
      this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControl1.Location = new System.Drawing.Point(0, 0);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnViewDetail,
            this.btnDelete});
      this.gridControl1.Size = new System.Drawing.Size(1040, 472);
      this.gridControl1.TabIndex = 1;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnOrderID,
            this.ColumnCreateOn,
            this.ColumnTotalMoney,
            this.ColumnDiscountPercent,
            this.ColumnGlass,
            this.ColumnCashier,
            this.ColumnCustomer,
            this.ColumnDetail,
            this.ColumnDelete});
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      // 
      // ColumnOrderID
      // 
      this.ColumnOrderID.AppearanceCell.Options.UseTextOptions = true;
      this.ColumnOrderID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnOrderID.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnOrderID.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnOrderID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnOrderID.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnOrderID.AppearanceHeader.Options.UseFont = true;
      this.ColumnOrderID.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnOrderID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnOrderID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnOrderID.Caption = "ID";
      this.ColumnOrderID.FieldName = "cOrderID";
      this.ColumnOrderID.Name = "ColumnOrderID";
      this.ColumnOrderID.OptionsColumn.AllowEdit = false;
      this.ColumnOrderID.Visible = true;
      this.ColumnOrderID.VisibleIndex = 0;
      this.ColumnOrderID.Width = 53;
      // 
      // ColumnCreateOn
      // 
      this.ColumnCreateOn.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnCreateOn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnCreateOn.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnCreateOn.AppearanceHeader.Options.UseFont = true;
      this.ColumnCreateOn.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnCreateOn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnCreateOn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnCreateOn.Caption = "Thời gian";
      this.ColumnCreateOn.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:tt";
      this.ColumnCreateOn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.ColumnCreateOn.FieldName = "cCreateOn";
      this.ColumnCreateOn.Name = "ColumnCreateOn";
      this.ColumnCreateOn.OptionsColumn.AllowEdit = false;
      this.ColumnCreateOn.Visible = true;
      this.ColumnCreateOn.VisibleIndex = 1;
      this.ColumnCreateOn.Width = 153;
      // 
      // ColumnTotalMoney
      // 
      this.ColumnTotalMoney.AppearanceCell.Options.UseTextOptions = true;
      this.ColumnTotalMoney.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnTotalMoney.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnTotalMoney.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnTotalMoney.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnTotalMoney.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnTotalMoney.AppearanceHeader.Options.UseFont = true;
      this.ColumnTotalMoney.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnTotalMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnTotalMoney.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnTotalMoney.Caption = "Tiền Thực Tế";
      this.ColumnTotalMoney.FieldName = "cTotalMoney";
      this.ColumnTotalMoney.Name = "ColumnTotalMoney";
      this.ColumnTotalMoney.OptionsColumn.AllowEdit = false;
      this.ColumnTotalMoney.ToolTip = "Tổng tiền sau khi giảm";
      this.ColumnTotalMoney.Visible = true;
      this.ColumnTotalMoney.VisibleIndex = 2;
      this.ColumnTotalMoney.Width = 124;
      // 
      // ColumnDiscountPercent
      // 
      this.ColumnDiscountPercent.AppearanceCell.Options.UseTextOptions = true;
      this.ColumnDiscountPercent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnDiscountPercent.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnDiscountPercent.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnDiscountPercent.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnDiscountPercent.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnDiscountPercent.AppearanceHeader.Options.UseFont = true;
      this.ColumnDiscountPercent.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnDiscountPercent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnDiscountPercent.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnDiscountPercent.Caption = "Giảm";
      this.ColumnDiscountPercent.DisplayFormat.FormatString = "{0:n0}";
      this.ColumnDiscountPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.ColumnDiscountPercent.FieldName = "cDiscount";
      this.ColumnDiscountPercent.Name = "ColumnDiscountPercent";
      this.ColumnDiscountPercent.OptionsColumn.AllowEdit = false;
      this.ColumnDiscountPercent.ToolTip = "Giảm giá theo %";
      this.ColumnDiscountPercent.Visible = true;
      this.ColumnDiscountPercent.VisibleIndex = 3;
      this.ColumnDiscountPercent.Width = 113;
      // 
      // ColumnGlass
      // 
      this.ColumnGlass.AppearanceCell.Options.UseTextOptions = true;
      this.ColumnGlass.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnGlass.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnGlass.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnGlass.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnGlass.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnGlass.AppearanceHeader.Options.UseFont = true;
      this.ColumnGlass.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnGlass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnGlass.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnGlass.Caption = "Số Ly";
      this.ColumnGlass.FieldName = "cQuantity";
      this.ColumnGlass.Name = "ColumnGlass";
      this.ColumnGlass.OptionsColumn.AllowEdit = false;
      this.ColumnGlass.Visible = true;
      this.ColumnGlass.VisibleIndex = 5;
      // 
      // ColumnCashier
      // 
      this.ColumnCashier.AppearanceCell.Options.UseTextOptions = true;
      this.ColumnCashier.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnCashier.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnCashier.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnCashier.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnCashier.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnCashier.AppearanceHeader.Options.UseFont = true;
      this.ColumnCashier.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnCashier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnCashier.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnCashier.Caption = "Tổng Tiền";
      this.ColumnCashier.DisplayFormat.FormatString = "{0:n0}";
      this.ColumnCashier.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.ColumnCashier.FieldName = "cTotal";
      this.ColumnCashier.Name = "ColumnCashier";
      this.ColumnCashier.OptionsColumn.AllowEdit = false;
      this.ColumnCashier.ToolTip = "Nhân viên tính tiền";
      this.ColumnCashier.Visible = true;
      this.ColumnCashier.VisibleIndex = 4;
      this.ColumnCashier.Width = 204;
      // 
      // ColumnCustomer
      // 
      this.ColumnCustomer.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnCustomer.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnCustomer.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnCustomer.AppearanceHeader.Options.UseFont = true;
      this.ColumnCustomer.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnCustomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnCustomer.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnCustomer.Caption = "Khách hàng";
      this.ColumnCustomer.FieldName = "CustomerName";
      this.ColumnCustomer.Name = "ColumnCustomer";
      this.ColumnCustomer.OptionsColumn.AllowEdit = false;
      this.ColumnCustomer.Visible = true;
      this.ColumnCustomer.VisibleIndex = 6;
      this.ColumnCustomer.Width = 142;
      // 
      // ColumnDetail
      // 
      this.ColumnDetail.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnDetail.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnDetail.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnDetail.AppearanceHeader.Options.UseFont = true;
      this.ColumnDetail.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnDetail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnDetail.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnDetail.Caption = "Xem Chi Tiết";
      this.ColumnDetail.ColumnEdit = this.btnViewDetail;
      this.ColumnDetail.FieldName = "cViewDetail";
      this.ColumnDetail.Name = "ColumnDetail";
      this.ColumnDetail.Visible = true;
      this.ColumnDetail.VisibleIndex = 7;
      this.ColumnDetail.Width = 141;
      // 
      // btnViewDetail
      // 
      this.btnViewDetail.AutoHeight = false;
      editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
      editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
      serializableAppearanceObject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      serializableAppearanceObject1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
      serializableAppearanceObject1.Options.UseBackColor = true;
      serializableAppearanceObject1.Options.UseFont = true;
      this.btnViewDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Chi tiết", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
      this.btnViewDetail.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.btnViewDetail.Name = "btnViewDetail";
      this.btnViewDetail.Padding = new System.Windows.Forms.Padding(2);
      this.btnViewDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
      // 
      // ColumnDelete
      // 
      this.ColumnDelete.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
      this.ColumnDelete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.ColumnDelete.AppearanceHeader.Options.UseBackColor = true;
      this.ColumnDelete.AppearanceHeader.Options.UseFont = true;
      this.ColumnDelete.AppearanceHeader.Options.UseTextOptions = true;
      this.ColumnDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.ColumnDelete.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.ColumnDelete.Caption = "Xóa";
      this.ColumnDelete.ColumnEdit = this.btnDelete;
      this.ColumnDelete.Name = "ColumnDelete";
      this.ColumnDelete.Visible = true;
      this.ColumnDelete.VisibleIndex = 8;
      this.ColumnDelete.Width = 120;
      // 
      // btnDelete
      // 
      this.btnDelete.AutoHeight = false;
      serializableAppearanceObject5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      serializableAppearanceObject5.Options.UseBackColor = true;
      this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xóa", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
      this.btnDelete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Padding = new System.Windows.Forms.Padding(2);
      this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // ucRevenueCustomer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridControl1);
      this.Name = "ucRevenueCustomer";
      this.Size = new System.Drawing.Size(1040, 472);
      this.Load += new System.EventHandler(this.ucRevenueCustomer_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnViewDetail)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCreateOn;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnTotalMoney;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnGlass;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCashier;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
    }
}
