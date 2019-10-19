namespace PSOilBill
{
    partial class frmOilChange
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
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.NumberCellType numberCellType1 = new FarPoint.Win.Spread.CellType.NumberCellType();
            FarPoint.Win.Spread.CellType.NumberCellType numberCellType2 = new FarPoint.Win.Spread.CellType.NumberCellType();
            FarPoint.Win.Spread.CellType.NumberCellType numberCellType3 = new FarPoint.Win.Spread.CellType.NumberCellType();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOilChange));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDateS = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDateE = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillE = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.spread1 = new FarPoint.Win.Spread.FpSpread();
            this.spread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.btnAccept);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtBillE);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtBillS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDateE);
            this.groupBox1.Controls.Add(this.txtDateS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtDateS
            // 
            this.txtDateS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateS.EditValue = null;
            this.txtDateS.Location = new System.Drawing.Point(63, 19);
            this.txtDateS.Name = "txtDateS";
            this.txtDateS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateS.Properties.Appearance.Options.UseFont = true;
            this.txtDateS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateS.Size = new System.Drawing.Size(161, 26);
            this.txtDateS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "วันที่ :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(230, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ถึง :";
            // 
            // txtDateE
            // 
            this.txtDateE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateE.EditValue = null;
            this.txtDateE.Location = new System.Drawing.Point(273, 19);
            this.txtDateE.Name = "txtDateE";
            this.txtDateE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateE.Properties.Appearance.Options.UseFont = true;
            this.txtDateE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateE.Size = new System.Drawing.Size(161, 26);
            this.txtDateE.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "บิลที่ :";
            // 
            // txtBillS
            // 
            this.txtBillS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBillS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBillS.Location = new System.Drawing.Point(63, 58);
            this.txtBillS.Name = "txtBillS";
            this.txtBillS.Size = new System.Drawing.Size(161, 26);
            this.txtBillS.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(230, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ถึง :";
            // 
            // txtBillE
            // 
            this.txtBillE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBillE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtBillE.Location = new System.Drawing.Point(273, 58);
            this.txtBillE.Name = "txtBillE";
            this.txtBillE.Size = new System.Drawing.Size(161, 26);
            this.txtBillE.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.Location = new System.Drawing.Point(454, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 38);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(557, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "ล้างข้อมูล";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // spread1
            // 
            this.spread1.AccessibleDescription = "spread1, Sheet1, Row 0, Column 0, ";
            this.spread1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spread1.Location = new System.Drawing.Point(12, 159);
            this.spread1.Name = "spread1";
            this.spread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spread1_Sheet1});
            this.spread1.Size = new System.Drawing.Size(682, 433);
            this.spread1.TabIndex = 1;
            // 
            // spread1_Sheet1
            // 
            this.spread1_Sheet1.Reset();
            spread1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            spread1_Sheet1.ColumnCount = 6;
            spread1_Sheet1.RowCount = 10;
            this.spread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "บิลที่";
            this.spread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "วันที่";
            this.spread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "ชื่อ";
            this.spread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "ราคาน้ำมัน(ลิตรละ)";
            this.spread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "จำนวนลิตร";
            this.spread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "ราคารวม";
            textCellType1.ReadOnly = true;
            textCellType1.Static = true;
            this.spread1_Sheet1.Columns.Get(0).CellType = textCellType1;
            this.spread1_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(0).Label = "บิลที่";
            this.spread1_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(0).Width = 102F;
            textCellType2.ReadOnly = true;
            textCellType2.Static = true;
            this.spread1_Sheet1.Columns.Get(1).CellType = textCellType2;
            this.spread1_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(1).Label = "วันที่";
            this.spread1_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(1).Width = 102F;
            textCellType3.ReadOnly = true;
            textCellType3.Static = true;
            this.spread1_Sheet1.Columns.Get(2).CellType = textCellType3;
            this.spread1_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(2).Label = "ชื่อ";
            this.spread1_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(2).Width = 102F;
            this.spread1_Sheet1.Columns.Get(3).CellType = numberCellType1;
            this.spread1_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(3).Label = "ราคาน้ำมัน(ลิตรละ)";
            this.spread1_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(3).Width = 102F;
            numberCellType2.ShowSeparator = true;
            this.spread1_Sheet1.Columns.Get(4).CellType = numberCellType2;
            this.spread1_Sheet1.Columns.Get(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(4).Label = "จำนวนลิตร";
            this.spread1_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(4).Width = 102F;
            numberCellType3.ShowSeparator = true;
            this.spread1_Sheet1.Columns.Get(5).CellType = numberCellType3;
            this.spread1_Sheet1.Columns.Get(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(5).Label = "ราคารวม";
            this.spread1_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.spread1_Sheet1.Columns.Get(5).Width = 102F;
            this.spread1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image2")));
            this.btnSave.Location = new System.Drawing.Point(557, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 38);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(9, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "ราคาลิตรละ :";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtPrice.Location = new System.Drawing.Point(112, 105);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 26);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAccept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnAccept.Location = new System.Drawing.Point(279, 105);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 26);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCalculate.Location = new System.Drawing.Point(455, 76);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 36);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "คำนวณราคา";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmOilChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 604);
            this.Controls.Add(this.spread1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOilChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "แก้ไขราคาน้ำมัน";
            this.Load += new System.EventHandler(this.frmOilChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spread1_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.TextBox txtBillE;
        private System.Windows.Forms.TextBox txtBillS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit txtDateE;
        private DevExpress.XtraEditors.DateEdit txtDateS;
        private FarPoint.Win.Spread.FpSpread spread1;
        private FarPoint.Win.Spread.SheetView spread1_Sheet1;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnCalculate;
    }
}