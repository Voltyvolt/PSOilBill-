namespace PSOilBill
{
    partial class rptBill
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBill));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDate = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCaneNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbFront = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCarNum = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbQuota = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbName = new DevExpress.XtraReports.UI.XRLabel();
            this.lbYear = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbMonth = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDocNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel21,
            this.xrPictureBox2,
            this.xrPictureBox1,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel2,
            this.lbDate,
            this.lbCaneNo,
            this.xrLabel14,
            this.xrLabel9,
            this.lbFront,
            this.lbCarNum,
            this.xrLabel10,
            this.lbQuota,
            this.xrLabel11,
            this.xrLabel7,
            this.lbName,
            this.lbYear,
            this.xrLabel8,
            this.xrLabel5,
            this.lbMonth,
            this.xrLabel6,
            this.xrLabel4,
            this.xrLabel3,
            this.lbDocNo,
            this.xrLabel1});
            this.Detail.HeightF = 506.25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel23
            // 
            this.xrLabel23.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field12")});
            this.xrLabel23.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(122.2503F, 345.8333F);
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(142.6251F, 39.58333F);
            this.xrLabel23.StylePriority.UseBorderColor = false;
            this.xrLabel23.StylePriority.UseBorderDashStyle = false;
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel22
            // 
            this.xrLabel22.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field11")});
            this.xrLabel22.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(482.7916F, 345.8333F);
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(142.6251F, 39.58333F);
            this.xrLabel22.StylePriority.UseBorderColor = false;
            this.xrLabel22.StylePriority.UseBorderDashStyle = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel21
            // 
            this.xrLabel21.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel21.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field10")});
            this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(282.5837F, 345.8333F);
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(142.6251F, 39.58333F);
            this.xrLabel21.StylePriority.UseBorderColor = false;
            this.xrLabel21.StylePriority.UseBorderDashStyle = false;
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(578.1874F, 187.5F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(30.28888F, 23.00003F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(435.5624F, 187.4166F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(30.28888F, 23.00003F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel19
            // 
            this.xrLabel19.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field9")});
            this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(667.3749F, 268.75F);
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(142.6251F, 39.58333F);
            this.xrLabel19.StylePriority.UseBorderColor = false;
            this.xrLabel19.StylePriority.UseBorderDashStyle = false;
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(667.3749F, 229.1666F);
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(142.6251F, 39.58331F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "หมายเหตุ";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel20.Visible = false;
            // 
            // xrLabel18
            // 
            this.xrLabel18.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel18.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field19", "{0:#,#}")});
            this.xrLabel18.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(595.0002F, 268.75F);
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(61.4585F, 39.58331F);
            this.xrLabel18.StylePriority.UseBorderColor = false;
            this.xrLabel18.StylePriority.UseBorderDashStyle = false;
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(482.7916F, 229.1667F);
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(142.6251F, 39.5833F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "จำนวนเงิน";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel17.Visible = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(282.5837F, 229.1667F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(142.6251F, 39.58331F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "ราคา";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel16.Visible = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(122.2503F, 229.1667F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(142.6251F, 39.58331F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "จำนวนลิตร";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel15.Visible = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel13.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Num3", "{0:#,#}")});
            this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(435.5624F, 268.75F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(142.4169F, 39.58331F);
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseBorderDashStyle = false;
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel12.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Num2")});
            this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(282.5837F, 268.75F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(142.6251F, 39.58333F);
            this.xrLabel12.StylePriority.UseBorderColor = false;
            this.xrLabel12.StylePriority.UseBorderDashStyle = false;
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Num1")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(122.2503F, 268.75F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(142.6251F, 39.58333F);
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorderDashStyle = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // lbDate
            // 
            this.lbDate.BorderColor = System.Drawing.Color.Transparent;
            this.lbDate.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lbDate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field2")});
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbDate.LocationFloat = new DevExpress.Utils.PointFloat(367.8741F, 79.16666F);
            this.lbDate.Multiline = true;
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDate.SizeF = new System.Drawing.SizeF(97.9772F, 21.875F);
            this.lbDate.StylePriority.UseBorderColor = false;
            this.lbDate.StylePriority.UseBorderDashStyle = false;
            this.lbDate.StylePriority.UseBorders = false;
            this.lbDate.StylePriority.UseFont = false;
            this.lbDate.StylePriority.UsePadding = false;
            this.lbDate.StylePriority.UseTextAlignment = false;
            this.lbDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // lbCaneNo
            // 
            this.lbCaneNo.BorderColor = System.Drawing.Color.Transparent;
            this.lbCaneNo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lbCaneNo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCaneNo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field8")});
            this.lbCaneNo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbCaneNo.LocationFloat = new DevExpress.Utils.PointFloat(264.8755F, 187.5F);
            this.lbCaneNo.Multiline = true;
            this.lbCaneNo.Name = "lbCaneNo";
            this.lbCaneNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCaneNo.SizeF = new System.Drawing.SizeF(142.6251F, 22.91664F);
            this.lbCaneNo.StylePriority.UseBorderColor = false;
            this.lbCaneNo.StylePriority.UseBorderDashStyle = false;
            this.lbCaneNo.StylePriority.UseBorders = false;
            this.lbCaneNo.StylePriority.UseFont = false;
            this.lbCaneNo.StylePriority.UseTextAlignment = false;
            this.lbCaneNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(195.7087F, 187.5F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(69.16666F, 22.91664F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "เลขที่บิล";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrLabel14.Visible = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(383.6252F, 144.7917F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(92.08331F, 22.91666F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "ป้ายหน้ารถ";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrLabel9.Visible = false;
            // 
            // lbFront
            // 
            this.lbFront.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lbFront.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbFront.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field18")});
            this.lbFront.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbFront.LocationFloat = new DevExpress.Utils.PointFloat(475.7087F, 144.7917F);
            this.lbFront.Multiline = true;
            this.lbFront.Name = "lbFront";
            this.lbFront.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbFront.SizeF = new System.Drawing.SizeF(254.0835F, 22.91666F);
            this.lbFront.StylePriority.UseBorderDashStyle = false;
            this.lbFront.StylePriority.UseBorders = false;
            this.lbFront.StylePriority.UseFont = false;
            this.lbFront.StylePriority.UseTextAlignment = false;
            this.lbFront.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // lbCarNum
            // 
            this.lbCarNum.BorderColor = System.Drawing.Color.Transparent;
            this.lbCarNum.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lbCarNum.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbCarNum.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field7")});
            this.lbCarNum.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbCarNum.LocationFloat = new DevExpress.Utils.PointFloat(101.8755F, 144.7917F);
            this.lbCarNum.Multiline = true;
            this.lbCarNum.Name = "lbCarNum";
            this.lbCarNum.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCarNum.SizeF = new System.Drawing.SizeF(169.5832F, 22.91666F);
            this.lbCarNum.StylePriority.UseBorderColor = false;
            this.lbCarNum.StylePriority.UseBorderDashStyle = false;
            this.lbCarNum.StylePriority.UseBorders = false;
            this.lbCarNum.StylePriority.UseFont = false;
            this.lbCarNum.StylePriority.UseTextAlignment = false;
            this.lbCarNum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(17.08383F, 144.7917F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(84.79176F, 22.91666F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "ทะเบียนรถ";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrLabel10.Visible = false;
            // 
            // lbQuota
            // 
            this.lbQuota.BorderColor = System.Drawing.Color.Transparent;
            this.lbQuota.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lbQuota.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbQuota.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field6")});
            this.lbQuota.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbQuota.LocationFloat = new DevExpress.Utils.PointFloat(595.0002F, 111.4584F);
            this.lbQuota.Multiline = true;
            this.lbQuota.Name = "lbQuota";
            this.lbQuota.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbQuota.SizeF = new System.Drawing.SizeF(90.54181F, 22.91667F);
            this.lbQuota.StylePriority.UseBorderColor = false;
            this.lbQuota.StylePriority.UseBorderDashStyle = false;
            this.lbQuota.StylePriority.UseBorders = false;
            this.lbQuota.StylePriority.UseFont = false;
            this.lbQuota.StylePriority.UseTextAlignment = false;
            this.lbQuota.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(545.6252F, 111.4584F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(49.375F, 22.91666F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "โควต้า";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrLabel11.Visible = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(17.08383F, 111.4584F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(27.5001F, 22.91666F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "ชื่อ";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrLabel7.Visible = false;
            // 
            // lbName
            // 
            this.lbName.BorderColor = System.Drawing.Color.Transparent;
            this.lbName.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lbName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field5")});
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbName.LocationFloat = new DevExpress.Utils.PointFloat(44.58379F, 111.4584F);
            this.lbName.Multiline = true;
            this.lbName.Name = "lbName";
            this.lbName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbName.SizeF = new System.Drawing.SizeF(391.0418F, 22.91666F);
            this.lbName.StylePriority.UseBorderColor = false;
            this.lbName.StylePriority.UseBorderDashStyle = false;
            this.lbName.StylePriority.UseBorders = false;
            this.lbName.StylePriority.UseFont = false;
            this.lbName.StylePriority.UseTextAlignment = false;
            this.lbName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.lbName.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lbName_BeforePrint);
            // 
            // lbYear
            // 
            this.lbYear.BorderColor = System.Drawing.Color.Transparent;
            this.lbYear.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lbYear.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbYear.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field4")});
            this.lbYear.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbYear.LocationFloat = new DevExpress.Utils.PointFloat(656.4586F, 79.16666F);
            this.lbYear.Multiline = true;
            this.lbYear.Name = "lbYear";
            this.lbYear.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbYear.SizeF = new System.Drawing.SizeF(125.208F, 21.87498F);
            this.lbYear.StylePriority.UseBorderColor = false;
            this.lbYear.StylePriority.UseBorderDashStyle = false;
            this.lbYear.StylePriority.UseBorders = false;
            this.lbYear.StylePriority.UseFont = false;
            this.lbYear.StylePriority.UseTextAlignment = false;
            this.lbYear.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(610.7083F, 79.16666F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(43.95837F, 21.87498F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "พ.ศ.";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrLabel8.Visible = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(477.8744F, 79.16666F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(43.95844F, 21.875F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "เดือน";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            this.xrLabel5.Visible = false;
            // 
            // lbMonth
            // 
            this.lbMonth.BorderColor = System.Drawing.Color.Transparent;
            this.lbMonth.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.lbMonth.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbMonth.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field3")});
            this.lbMonth.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbMonth.LocationFloat = new DevExpress.Utils.PointFloat(521.8329F, 79.16666F);
            this.lbMonth.Multiline = true;
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbMonth.SizeF = new System.Drawing.SizeF(87.41693F, 21.875F);
            this.lbMonth.StylePriority.UseBorderColor = false;
            this.lbMonth.StylePriority.UseBorderDashStyle = false;
            this.lbMonth.StylePriority.UseBorders = false;
            this.lbMonth.StylePriority.UseFont = false;
            this.lbMonth.StylePriority.UseTextAlignment = false;
            this.lbMonth.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(323.9156F, 79.16666F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(43.9584F, 21.875F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "วันที่";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrLabel6.Visible = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Underline);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(142.7084F, 39.58333F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(401.3328F, 39.58335F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "ใบรับสินค้า (น้ำมัน)";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel4.Visible = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(612.5003F, 21.45834F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(43.9584F, 39.58333F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "เลขที่";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrLabel3.Visible = false;
            // 
            // lbDocNo
            // 
            this.lbDocNo.BorderColor = System.Drawing.Color.Transparent;
            this.lbDocNo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lbDocNo.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "SysTempOilBill.Field1")});
            this.lbDocNo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbDocNo.LocationFloat = new DevExpress.Utils.PointFloat(656.4586F, 21.45834F);
            this.lbDocNo.Multiline = true;
            this.lbDocNo.Name = "lbDocNo";
            this.lbDocNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDocNo.SizeF = new System.Drawing.SizeF(125.2078F, 39.58333F);
            this.lbDocNo.StylePriority.UseBorderColor = false;
            this.lbDocNo.StylePriority.UseBorders = false;
            this.lbDocNo.StylePriority.UseFont = false;
            this.lbDocNo.StylePriority.UseTextAlignment = false;
            this.lbDocNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(142.7084F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(401.3328F, 39.58333F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "บริษัท น้ำตาลพิษณุโลก ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel1.Visible = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 30F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 49F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.HeightF = 0F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "PS_DB.mdb";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "SysTempOilBill";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // rptBill
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "SysTempOilBill";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(40, 40, 30, 49);
            this.PageHeight = 550;
            this.PageWidth = 900;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Version = "17.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rptBill_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel lbDocNo;
        private DevExpress.XtraReports.UI.XRLabel lbYear;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel lbMonth;
        private DevExpress.XtraReports.UI.XRLabel lbDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel lbCaneNo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel lbFront;
        private DevExpress.XtraReports.UI.XRLabel lbCarNum;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel lbQuota;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel lbName;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
    }
}
