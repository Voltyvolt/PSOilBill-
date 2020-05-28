namespace PSOilBill
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ขอมลบลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.พมพใบทะเบยนรถToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เพมทะเบยนรถToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานสรปToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ลอคควToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลบลToolStripMenuItem,
            this.รายงานToolStripMenuItem,
            this.ตToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // ขอมลบลToolStripMenuItem
            // 
            this.ขอมลบลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.บลToolStripMenuItem,
            this.เพมทะเบยนรถToolStripMenuItem,
            this.พมพใบทะเบยนรถToolStripMenuItem});
            this.ขอมลบลToolStripMenuItem.Name = "ขอมลบลToolStripMenuItem";
            this.ขอมลบลToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ขอมลบลToolStripMenuItem.Text = "ข้อมูล";
            // 
            // บลToolStripMenuItem
            // 
            this.บลToolStripMenuItem.Name = "บลToolStripMenuItem";
            this.บลToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.บลToolStripMenuItem.Text = "ใบเสร็จ";
            this.บลToolStripMenuItem.Click += new System.EventHandler(this.บลToolStripMenuItem_Click);
            // 
            // พมพใบทะเบยนรถToolStripMenuItem
            // 
            this.พมพใบทะเบยนรถToolStripMenuItem.Name = "พมพใบทะเบยนรถToolStripMenuItem";
            this.พมพใบทะเบยนรถToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.พมพใบทะเบยนรถToolStripMenuItem.Text = "พิมพ์ใบทะเบียนรถ";
            this.พมพใบทะเบยนรถToolStripMenuItem.Click += new System.EventHandler(this.พมพใบทะเบยนรถToolStripMenuItem_Click);
            // 
            // เพมทะเบยนรถToolStripMenuItem
            // 
            this.เพมทะเบยนรถToolStripMenuItem.Name = "เพมทะเบยนรถToolStripMenuItem";
            this.เพมทะเบยนรถToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.เพมทะเบยนรถToolStripMenuItem.Text = "จัดการทะเบียนรถ";
            this.เพมทะเบยนรถToolStripMenuItem.Click += new System.EventHandler(this.เพมทะเบยนรถToolStripMenuItem_Click);
            // 
            // รายงานToolStripMenuItem
            // 
            this.รายงานToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายงานสรปToolStripMenuItem});
            this.รายงานToolStripMenuItem.Name = "รายงานToolStripMenuItem";
            this.รายงานToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.รายงานToolStripMenuItem.Text = "รายงาน";
            // 
            // รายงานสรปToolStripMenuItem
            // 
            this.รายงานสรปToolStripMenuItem.Name = "รายงานสรปToolStripMenuItem";
            this.รายงานสรปToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.รายงานสรปToolStripMenuItem.Text = "รายงานสรุป";
            this.รายงานสรปToolStripMenuItem.Click += new System.EventHandler(this.รายงานสรปToolStripMenuItem_Click);
            // 
            // ตToolStripMenuItem
            // 
            this.ตToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ลอคควToolStripMenuItem});
            this.ตToolStripMenuItem.Name = "ตToolStripMenuItem";
            this.ตToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ตToolStripMenuItem.Text = "ตั้งค่า";
            // 
            // ลอคควToolStripMenuItem
            // 
            this.ลอคควToolStripMenuItem.Name = "ลอคควToolStripMenuItem";
            this.ลอคควToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ลอคควToolStripMenuItem.Text = "ล็อคคิว";
            this.ลอคควToolStripMenuItem.Click += new System.EventHandler(this.ลอคควToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 963);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมพิมพ์ใบเสร็จ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ขอมลบลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem บลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายงานสรปToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ลอคควToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem พมพใบทะเบยนรถToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เพมทะเบยนรถToolStripMenuItem;
    }
}



