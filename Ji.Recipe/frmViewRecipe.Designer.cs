namespace Ji.Recipe
{
    partial class frmViewRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewRecipe));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnResourceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPriceCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtRecipe = new DevExpress.XtraEditors.MemoEdit();
            this.ColumnAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ColumnResourcesID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecipe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(694, 564);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(690, 390);
            this.panelControl2.TabIndex = 0;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.gridControl1);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(2, 44);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(686, 344);
            this.panelControl5.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDelete});
            this.gridControl1.Size = new System.Drawing.Size(682, 340);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnResourceName,
            this.ColumnQuantity,
            this.ColumnUnit,
            this.ColumnPriceCost,
            this.ColumnID,
            this.ColumnAction,
            this.ColumnResourcesID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ColumnResourceName
            // 
            this.ColumnResourceName.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.ColumnResourceName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnResourceName.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnResourceName.AppearanceHeader.Options.UseFont = true;
            this.ColumnResourceName.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnResourceName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnResourceName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnResourceName.Caption = "Tên nguyên liệu";
            this.ColumnResourceName.FieldName = "Name";
            this.ColumnResourceName.Name = "ColumnResourceName";
            this.ColumnResourceName.Visible = true;
            this.ColumnResourceName.VisibleIndex = 0;
            this.ColumnResourceName.Width = 415;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.ColumnQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnQuantity.AppearanceHeader.Options.UseFont = true;
            this.ColumnQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnQuantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnQuantity.Caption = "Định lượng";
            this.ColumnQuantity.FieldName = "Quantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.Visible = true;
            this.ColumnQuantity.VisibleIndex = 1;
            this.ColumnQuantity.Width = 100;
            // 
            // ColumnUnit
            // 
            this.ColumnUnit.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.ColumnUnit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnUnit.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnUnit.AppearanceHeader.Options.UseFont = true;
            this.ColumnUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnUnit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnUnit.Caption = "Đơn Vị Tính";
            this.ColumnUnit.FieldName = "Unit";
            this.ColumnUnit.Name = "ColumnUnit";
            this.ColumnUnit.Visible = true;
            this.ColumnUnit.VisibleIndex = 2;
            this.ColumnUnit.Width = 78;
            // 
            // ColumnPriceCost
            // 
            this.ColumnPriceCost.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.ColumnPriceCost.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnPriceCost.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnPriceCost.AppearanceHeader.Options.UseFont = true;
            this.ColumnPriceCost.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnPriceCost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPriceCost.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPriceCost.Caption = "Giá Cost";
            this.ColumnPriceCost.FieldName = "PriceCost";
            this.ColumnPriceCost.Name = "ColumnPriceCost";
            this.ColumnPriceCost.Visible = true;
            this.ColumnPriceCost.VisibleIndex = 3;
            this.ColumnPriceCost.Width = 71;
            // 
            // ColumnID
            // 
            this.ColumnID.Caption = "ID";
            this.ColumnID.FieldName = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.panelControl6);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(686, 42);
            this.panelControl4.TabIndex = 1;
            // 
            // panelControl6
            // 
            this.panelControl6.Controls.Add(this.btnAdd);
            this.panelControl6.Controls.Add(this.btnSave);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl6.Location = new System.Drawing.Point(2, 2);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(682, 38);
            this.panelControl6.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(80, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(6, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtRecipe);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 392);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(690, 170);
            this.panelControl3.TabIndex = 1;
            // 
            // txtRecipe
            // 
            this.txtRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipe.Location = new System.Drawing.Point(2, 2);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRecipe.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtRecipe.Properties.Appearance.Options.UseFont = true;
            this.txtRecipe.Properties.Appearance.Options.UseForeColor = true;
            this.txtRecipe.Size = new System.Drawing.Size(686, 166);
            this.txtRecipe.TabIndex = 0;
            // 
            // ColumnAction
            // 
            this.ColumnAction.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.ColumnAction.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnAction.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnAction.AppearanceHeader.Options.UseFont = true;
            this.ColumnAction.Caption = "Hành động";
            this.ColumnAction.ColumnEdit = this.btnDelete;
            this.ColumnAction.Name = "ColumnAction";
            this.ColumnAction.Visible = true;
            this.ColumnAction.VisibleIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            serializableAppearanceObject1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject1.Options.UseFont = true;
            this.btnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Xóa", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDelete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ColumnResourcesID
            // 
            this.ColumnResourcesID.Caption = "ResourcesID";
            this.ColumnResourcesID.FieldName = "ResourcesID";
            this.ColumnResourcesID.Name = "ColumnResourcesID";
            // 
            // frmViewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 564);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmViewRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông tin công thức";
            this.Load += new System.EventHandler(this.frmViewRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRecipe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.MemoEdit txtRecipe;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnResourceName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPriceCost;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnUnit;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnID;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnResourcesID;
    }
}