namespace Shell.Views.Frm
{
    partial class frmNewOrder
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewOrder));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CoulmnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ColumnOrderIDs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnFoodIDs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnToppingIDs = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(888, 576);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.Fuchsia;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnIndex,
            this.ColumnFood,
            this.gridColumn1,
            this.CoulmnImage,
            this.ColumnQuantity,
            this.ColumnUnit,
            this.ColumnPrice,
            this.ColumnTotal,
            this.ColumnAction,
            this.ColumnOrderIDs,
            this.ColumnFoodIDs,
            this.ColumnToppingIDs});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnIndex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIndex.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIndex.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColumnIndex.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnIndex.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnIndex.AppearanceHeader.Options.UseFont = true;
            this.ColumnIndex.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnIndex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIndex.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIndex.Caption = "STT";
            this.ColumnIndex.FieldName = "cIndex";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.OptionsColumn.AllowEdit = false;
            this.ColumnIndex.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.ColumnIndex.Visible = true;
            this.ColumnIndex.VisibleIndex = 0;
            this.ColumnIndex.Width = 58;
            // 
            // ColumnFood
            // 
            this.ColumnFood.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColumnFood.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnFood.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnFood.AppearanceHeader.Options.UseFont = true;
            this.ColumnFood.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnFood.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnFood.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnFood.Caption = "Thực phẩm";
            this.ColumnFood.FieldName = "cFood";
            this.ColumnFood.Name = "ColumnFood";
            this.ColumnFood.OptionsColumn.AllowEdit = false;
            this.ColumnFood.Visible = true;
            this.ColumnFood.VisibleIndex = 1;
            this.ColumnFood.Width = 217;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "Topping";
            this.gridColumn1.FieldName = "cPriceTopping";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 67;
            // 
            // CoulmnImage
            // 
            this.CoulmnImage.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CoulmnImage.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CoulmnImage.AppearanceHeader.Options.UseBackColor = true;
            this.CoulmnImage.AppearanceHeader.Options.UseFont = true;
            this.CoulmnImage.AppearanceHeader.Options.UseTextOptions = true;
            this.CoulmnImage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CoulmnImage.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CoulmnImage.Caption = "Ảnh";
            this.CoulmnImage.FieldName = "cImage";
            this.CoulmnImage.Name = "CoulmnImage";
            this.CoulmnImage.OptionsColumn.AllowEdit = false;
            this.CoulmnImage.Width = 63;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColumnQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnQuantity.AppearanceHeader.Options.UseFont = true;
            this.ColumnQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnQuantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnQuantity.Caption = "SL";
            this.ColumnQuantity.FieldName = "cQuantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.OptionsColumn.AllowEdit = false;
            this.ColumnQuantity.Visible = true;
            this.ColumnQuantity.VisibleIndex = 3;
            this.ColumnQuantity.Width = 37;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnUnit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnUnit.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColumnUnit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnUnit.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnUnit.AppearanceHeader.Options.UseFont = true;
            this.ColumnUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnUnit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnUnit.Caption = "ĐVT";
            this.ColumnUnit.FieldName = "cUnit";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.OptionsColumn.AllowEdit = false;
            this.ColumnUnit.Width = 59;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColumnPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnPrice.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnPrice.AppearanceHeader.Options.UseFont = true;
            this.ColumnPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPrice.Caption = "Giá tiền";
            this.ColumnPrice.DisplayFormat.FormatString = "{0:n0}";
            this.ColumnPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColumnPrice.FieldName = "cPrice";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.OptionsColumn.AllowEdit = false;
            this.ColumnPrice.Visible = true;
            this.ColumnPrice.VisibleIndex = 4;
            this.ColumnPrice.Width = 62;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColumnTotal.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnTotal.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnTotal.AppearanceHeader.Options.UseFont = true;
            this.ColumnTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnTotal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnTotal.Caption = "Thành tiền";
            this.ColumnTotal.FieldName = "cTotal";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.OptionsColumn.AllowEdit = false;
            this.ColumnTotal.Visible = true;
            this.ColumnTotal.VisibleIndex = 5;
            this.ColumnTotal.Width = 70;
            // 
            // ColumnAction
            // 
            this.ColumnAction.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ColumnAction.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnAction.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnAction.AppearanceHeader.Options.UseFont = true;
            this.ColumnAction.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnAction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnAction.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnAction.Caption = "Hành động";
            this.ColumnAction.ColumnEdit = this.btnDelete;
            this.ColumnAction.Name = "ColumnAction";
            this.ColumnAction.Visible = true;
            this.ColumnAction.VisibleIndex = 6;
            this.ColumnAction.Width = 79;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            serializableAppearanceObject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            serializableAppearanceObject1.Options.UseBackColor = true;
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ColumnOrderIDs
            // 
            this.ColumnOrderIDs.Caption = "OrderID";
            this.ColumnOrderIDs.FieldName = "cOrderID";
            this.ColumnOrderIDs.Name = "ColumnOrderIDs";
            this.ColumnOrderIDs.OptionsColumn.AllowEdit = false;
            this.ColumnOrderIDs.Width = 20;
            // 
            // ColumnFoodIDs
            // 
            this.ColumnFoodIDs.Caption = "FoodID";
            this.ColumnFoodIDs.FieldName = "cFoodID";
            this.ColumnFoodIDs.Name = "ColumnFoodIDs";
            this.ColumnFoodIDs.OptionsColumn.AllowEdit = false;
            this.ColumnFoodIDs.Width = 20;
            // 
            // ColumnToppingIDs
            // 
            this.ColumnToppingIDs.Caption = "ToppingID";
            this.ColumnToppingIDs.FieldName = "cToppingID";
            this.ColumnToppingIDs.Name = "ColumnToppingIDs";
            this.ColumnToppingIDs.OptionsColumn.AllowEdit = false;
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 576);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng mới từ khách hàng";
            this.Load += new System.EventHandler(this.frmNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnIndex;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnFood;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn CoulmnImage;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnUnit;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnTotal;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnAction;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnOrderIDs;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnFoodIDs;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnToppingIDs;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
    }
}