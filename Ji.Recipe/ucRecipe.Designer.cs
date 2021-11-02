namespace Ji.Recipe
{
    partial class ucRecipe
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRecipe));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.PanelWrapper = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPriceSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPriceCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnRecipe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnViewRecipe = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnFoodID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.SearchFood = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnFoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnFoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.btnAddRecipe = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelWrapper)).BeginInit();
            this.PanelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewRecipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchFood.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelWrapper
            // 
            this.PanelWrapper.Controls.Add(this.panelControl2);
            this.PanelWrapper.Controls.Add(this.panelControl1);
            this.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWrapper.Location = new System.Drawing.Point(0, 0);
            this.PanelWrapper.Name = "PanelWrapper";
            this.PanelWrapper.Size = new System.Drawing.Size(666, 438);
            this.PanelWrapper.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(662, 397);
            this.panelControl2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnViewRecipe});
            this.gridControl1.Size = new System.Drawing.Size(658, 393);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnName,
            this.ColumnPriceSell,
            this.ColumnPriceCost,
            this.ColumnRecipe,
            this.ColumnAction,
            this.ColumnID,
            this.ColumnFoodID1,
            this.ColumnNote});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ColumnName
            // 
            this.ColumnName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ColumnName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnName.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnName.AppearanceHeader.Options.UseFont = true;
            this.ColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnName.Caption = "Tên món";
            this.ColumnName.FieldName = "FoodName";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Visible = true;
            this.ColumnName.VisibleIndex = 0;
            this.ColumnName.Width = 245;
            // 
            // ColumnPriceSell
            // 
            this.ColumnPriceSell.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ColumnPriceSell.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnPriceSell.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnPriceSell.AppearanceHeader.Options.UseFont = true;
            this.ColumnPriceSell.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnPriceSell.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPriceSell.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPriceSell.Caption = "Giá bán";
            this.ColumnPriceSell.FieldName = "Price";
            this.ColumnPriceSell.Name = "ColumnPriceSell";
            this.ColumnPriceSell.Visible = true;
            this.ColumnPriceSell.VisibleIndex = 2;
            this.ColumnPriceSell.Width = 77;
            // 
            // ColumnPriceCost
            // 
            this.ColumnPriceCost.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ColumnPriceCost.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnPriceCost.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnPriceCost.AppearanceHeader.Options.UseFont = true;
            this.ColumnPriceCost.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnPriceCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPriceCost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPriceCost.Caption = "Giá Cost";
            this.ColumnPriceCost.DisplayFormat.FormatString = "{0,n0}";
            this.ColumnPriceCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColumnPriceCost.FieldName = "PriceCost";
            this.ColumnPriceCost.Name = "ColumnPriceCost";
            this.ColumnPriceCost.Visible = true;
            this.ColumnPriceCost.VisibleIndex = 1;
            this.ColumnPriceCost.Width = 68;
            // 
            // ColumnRecipe
            // 
            this.ColumnRecipe.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ColumnRecipe.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnRecipe.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnRecipe.AppearanceHeader.Options.UseFont = true;
            this.ColumnRecipe.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnRecipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnRecipe.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnRecipe.Caption = "Công thức";
            this.ColumnRecipe.FieldName = "RecipeName";
            this.ColumnRecipe.Name = "ColumnRecipe";
            this.ColumnRecipe.Visible = true;
            this.ColumnRecipe.VisibleIndex = 3;
            this.ColumnRecipe.Width = 108;
            // 
            // ColumnAction
            // 
            this.ColumnAction.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ColumnAction.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnAction.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnAction.AppearanceHeader.Options.UseFont = true;
            this.ColumnAction.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnAction.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnAction.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnAction.Caption = "Hành động";
            this.ColumnAction.ColumnEdit = this.btnViewRecipe;
            this.ColumnAction.FieldName = "";
            this.ColumnAction.Name = "ColumnAction";
            this.ColumnAction.Visible = true;
            this.ColumnAction.VisibleIndex = 4;
            this.ColumnAction.Width = 142;
            // 
            // btnViewRecipe
            // 
            this.btnViewRecipe.AutoHeight = false;
            editorButtonImageOptions2.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            serializableAppearanceObject5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            serializableAppearanceObject5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject5.Options.UseBackColor = true;
            serializableAppearanceObject5.Options.UseFont = true;
            this.btnViewRecipe.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xem Công Thức", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnViewRecipe.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnViewRecipe.Name = "btnViewRecipe";
            this.btnViewRecipe.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnViewRecipe.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnViewRecipe.Click += new System.EventHandler(this.btnViewRecipe_Click);
            // 
            // ColumnID
            // 
            this.ColumnID.Caption = "ID";
            this.ColumnID.FieldName = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnFoodID1
            // 
            this.ColumnFoodID1.Caption = "FoodID";
            this.ColumnFoodID1.FieldName = "FoodID";
            this.ColumnFoodID1.Name = "ColumnFoodID1";
            // 
            // ColumnNote
            // 
            this.ColumnNote.Caption = "Note";
            this.ColumnNote.FieldName = "Note";
            this.ColumnNote.Name = "ColumnNote";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl5);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(662, 37);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.SearchFood);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(242, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(253, 33);
            this.panelControl4.TabIndex = 27;
            // 
            // SearchFood
            // 
            this.SearchFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchFood.EditValue = "Chọn món";
            this.SearchFood.Location = new System.Drawing.Point(0, 0);
            this.SearchFood.Name = "SearchFood";
            this.SearchFood.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SearchFood.Properties.Appearance.Options.UseFont = true;
            this.SearchFood.Properties.Appearance.Options.UseTextOptions = true;
            this.SearchFood.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SearchFood.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SearchFood.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SearchFood.Properties.NullText = "Chọn món";
            this.SearchFood.Properties.PopupView = this.searchLookUpEdit1View;
            this.SearchFood.Size = new System.Drawing.Size(253, 30);
            this.SearchFood.TabIndex = 0;
            this.SearchFood.EditValueChanged += new System.EventHandler(this.SearchFood_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnFoodName,
            this.ColumnFoodID});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnFoodName
            // 
            this.ColumnFoodName.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.ColumnFoodName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnFoodName.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnFoodName.AppearanceHeader.Options.UseFont = true;
            this.ColumnFoodName.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnFoodName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnFoodName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnFoodName.Caption = "Chọn món";
            this.ColumnFoodName.FieldName = "FoodName";
            this.ColumnFoodName.Name = "ColumnFoodName";
            this.ColumnFoodName.Visible = true;
            this.ColumnFoodName.VisibleIndex = 0;
            // 
            // ColumnFoodID
            // 
            this.ColumnFoodID.Caption = "FoodID";
            this.ColumnFoodID.FieldName = "ID";
            this.ColumnFoodID.Name = "ColumnFoodID";
            // 
            // panelControl5
            // 
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.btnAddRecipe);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl5.Location = new System.Drawing.Point(495, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(165, 33);
            this.panelControl5.TabIndex = 28;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddRecipe.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddRecipe.Appearance.Options.UseBackColor = true;
            this.btnAddRecipe.Appearance.Options.UseFont = true;
            this.btnAddRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRecipe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRecipe.ImageOptions.Image")));
            this.btnAddRecipe.Location = new System.Drawing.Point(0, 0);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(165, 33);
            this.btnAddRecipe.TabIndex = 25;
            this.btnAddRecipe.Text = "Thêm Công Thức";
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(240, 33);
            this.panelControl3.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(226, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn món thêm công thức";
            // 
            // ucRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelWrapper);
            this.Name = "ucRecipe";
            this.Size = new System.Drawing.Size(666, 438);
            ((System.ComponentModel.ISupportInitialize)(this.PanelWrapper)).EndInit();
            this.PanelWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewRecipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchFood.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelWrapper;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAddRecipe;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit SearchFood;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPriceCost;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnRecipe;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnViewRecipe;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnFoodName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPriceSell;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnFoodID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnFoodID1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnNote;
    }
}
