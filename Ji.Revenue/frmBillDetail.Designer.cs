namespace Ji.Revenue
{
    partial class frmBillDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillDetail));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnFoodName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnToppingName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnTotalMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(994, 580);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(990, 516);
            this.panelControl3.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(986, 512);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnIndex,
            this.ColumnFoodName,
            this.ColumnDiscount,
            this.ColumnFoodPrice,
            this.ColumnToppingName,
            this.ColumnQuantity,
            this.ColumnTotalMoney});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnIndex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIndex.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIndex.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.ColumnIndex.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnIndex.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnIndex.AppearanceHeader.Options.UseFont = true;
            this.ColumnIndex.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnIndex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIndex.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIndex.Caption = "STT";
            this.ColumnIndex.FieldName = "cIndex";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.Visible = true;
            this.ColumnIndex.VisibleIndex = 0;
            this.ColumnIndex.Width = 52;
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
            this.ColumnFoodName.Caption = "Tên món";
            this.ColumnFoodName.FieldName = "cFoodName";
            this.ColumnFoodName.Name = "ColumnFoodName";
            this.ColumnFoodName.Visible = true;
            this.ColumnFoodName.VisibleIndex = 1;
            this.ColumnFoodName.Width = 333;
            // 
            // ColumnDiscount
            // 
            this.ColumnDiscount.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.ColumnDiscount.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnDiscount.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnDiscount.AppearanceHeader.Options.UseFont = true;
            this.ColumnDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDiscount.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDiscount.Caption = "Giảm giá";
            this.ColumnDiscount.FieldName = "cDiscount";
            this.ColumnDiscount.Name = "ColumnDiscount";
            this.ColumnDiscount.Width = 71;
            // 
            // ColumnFoodPrice
            // 
            this.ColumnFoodPrice.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnFoodPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnFoodPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnFoodPrice.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.ColumnFoodPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnFoodPrice.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnFoodPrice.AppearanceHeader.Options.UseFont = true;
            this.ColumnFoodPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnFoodPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnFoodPrice.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnFoodPrice.Caption = "Giá";
            this.ColumnFoodPrice.DisplayFormat.FormatString = "{0:n0}";
            this.ColumnFoodPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColumnFoodPrice.FieldName = "cFoodPrice";
            this.ColumnFoodPrice.Name = "ColumnFoodPrice";
            this.ColumnFoodPrice.Visible = true;
            this.ColumnFoodPrice.VisibleIndex = 2;
            this.ColumnFoodPrice.Width = 104;
            // 
            // ColumnToppingName
            // 
            this.ColumnToppingName.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.ColumnToppingName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnToppingName.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnToppingName.AppearanceHeader.Options.UseFont = true;
            this.ColumnToppingName.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnToppingName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnToppingName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnToppingName.Caption = "Topping";
            this.ColumnToppingName.FieldName = "cToppingName";
            this.ColumnToppingName.Name = "ColumnToppingName";
            this.ColumnToppingName.Width = 305;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnQuantity.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnQuantity.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.ColumnQuantity.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnQuantity.AppearanceHeader.Options.UseFont = true;
            this.ColumnQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnQuantity.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnQuantity.Caption = "SL";
            this.ColumnQuantity.FieldName = "cQuantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.Visible = true;
            this.ColumnQuantity.VisibleIndex = 3;
            this.ColumnQuantity.Width = 36;
            // 
            // ColumnTotalMoney
            // 
            this.ColumnTotalMoney.AppearanceHeader.BackColor = System.Drawing.Color.Lime;
            this.ColumnTotalMoney.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ColumnTotalMoney.AppearanceHeader.Options.UseBackColor = true;
            this.ColumnTotalMoney.AppearanceHeader.Options.UseFont = true;
            this.ColumnTotalMoney.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnTotalMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnTotalMoney.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnTotalMoney.Caption = "Tổng tiền";
            this.ColumnTotalMoney.DisplayFormat.FormatString = "{0:n0}";
            this.ColumnTotalMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColumnTotalMoney.FieldName = "cTotalMoney";
            this.ColumnTotalMoney.Name = "ColumnTotalMoney";
            this.ColumnTotalMoney.Visible = true;
            this.ColumnTotalMoney.VisibleIndex = 4;
            this.ColumnTotalMoney.Width = 67;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnPrint);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 518);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(990, 60);
            this.panelControl2.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPrint.Appearance.Options.UseBackColor = true;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(885, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 48);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "In Lại";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 580);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmBillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn: ";
            this.Load += new System.EventHandler(this.frmBillDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnFoodName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnToppingName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnIndex;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnTotalMoney;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDiscount;
    }
}