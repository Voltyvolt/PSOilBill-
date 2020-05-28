namespace PSOilBill
{
    partial class frmPassword
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
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtPswd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPswd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(130, 108);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(85, 35);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "ตกลง";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb1.Location = new System.Drawing.Point(117, 21);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(111, 25);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "ระบุรหัสผ่าน";
            // 
            // txtPswd
            // 
            this.txtPswd.Location = new System.Drawing.Point(73, 63);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPswd.Properties.Appearance.Options.UseFont = true;
            this.txtPswd.Properties.UseSystemPasswordChar = true;
            this.txtPswd.Size = new System.Drawing.Size(210, 30);
            this.txtPswd.TabIndex = 3;
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 163);
            this.Controls.Add(this.txtPswd);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnAccept);
            this.Name = "frmPassword";
            this.Text = "ยืนยันรหัสผ่าน";
            ((System.ComponentModel.ISupportInitialize)(this.txtPswd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private System.Windows.Forms.Label lb1;
        private DevExpress.XtraEditors.TextEdit txtPswd;
    }
}