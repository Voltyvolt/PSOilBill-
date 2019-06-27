namespace PSOilBill
{
    partial class frmPrintMulti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintMulti));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocE = new DevExpress.XtraEditors.TextEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(23, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 24);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "เลขที่ :";
            // 
            // txtDocS
            // 
            this.txtDocS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocS.Location = new System.Drawing.Point(87, 12);
            this.txtDocS.Name = "txtDocS";
            this.txtDocS.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDocS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDocS.Properties.Appearance.Options.UseBackColor = true;
            this.txtDocS.Properties.Appearance.Options.UseFont = true;
            this.txtDocS.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Bisque;
            this.txtDocS.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDocS.Size = new System.Drawing.Size(104, 30);
            this.txtDocS.TabIndex = 22;
            this.txtDocS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocS_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(197, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 24);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "ถึง :";
            // 
            // txtDocE
            // 
            this.txtDocE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocE.Location = new System.Drawing.Point(238, 12);
            this.txtDocE.Name = "txtDocE";
            this.txtDocE.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDocE.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDocE.Properties.Appearance.Options.UseBackColor = true;
            this.txtDocE.Properties.Appearance.Options.UseFont = true;
            this.txtDocE.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Bisque;
            this.txtDocE.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDocE.Size = new System.Drawing.Size(103, 30);
            this.txtDocE.TabIndex = 24;
            this.txtDocE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocE_KeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(347, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 30);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "พิมพ์";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPrintMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 55);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDocE);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDocS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrintMulti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "พิมพ์ต่อเนื่อง";
            this.Load += new System.EventHandler(this.frmPrintMulti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDocS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDocE;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}