namespace QLKhoHang
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qLHANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghvvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHIEUNHAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHIEUXUATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLHANGToolStripMenuItem,
            this.nCCToolStripMenuItem,
            this.pHIEUNHAPToolStripMenuItem,
            this.pHIEUXUATToolStripMenuItem,
            this.đăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // qLHANGToolStripMenuItem
            // 
            this.qLHANGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ghvvToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.qLHANGToolStripMenuItem.Enabled = false;
            this.qLHANGToolStripMenuItem.Name = "qLHANGToolStripMenuItem";
            this.qLHANGToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.qLHANGToolStripMenuItem.Text = "Quản lý";
            this.qLHANGToolStripMenuItem.Click += new System.EventHandler(this.qLHANGToolStripMenuItem_Click);
            // 
            // ghvvToolStripMenuItem
            // 
            this.ghvvToolStripMenuItem.Name = "ghvvToolStripMenuItem";
            this.ghvvToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ghvvToolStripMenuItem.Text = "Hàng tồn";
            this.ghvvToolStripMenuItem.Click += new System.EventHandler(this.ghvvToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // nCCToolStripMenuItem
            // 
            this.nCCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHàngToolStripMenuItem,
            this.xuấtHàngToolStripMenuItem});
            this.nCCToolStripMenuItem.Enabled = false;
            this.nCCToolStripMenuItem.Name = "nCCToolStripMenuItem";
            this.nCCToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.nCCToolStripMenuItem.Text = "Hoạt động";
            this.nCCToolStripMenuItem.Click += new System.EventHandler(this.nCCToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            this.nhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // xuấtHàngToolStripMenuItem
            // 
            this.xuấtHàngToolStripMenuItem.Name = "xuấtHàngToolStripMenuItem";
            this.xuấtHàngToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.xuấtHàngToolStripMenuItem.Text = "Xuất hàng";
            this.xuấtHàngToolStripMenuItem.Click += new System.EventHandler(this.xuấtHàngToolStripMenuItem_Click);
            // 
            // pHIEUNHAPToolStripMenuItem
            // 
            this.pHIEUNHAPToolStripMenuItem.Enabled = false;
            this.pHIEUNHAPToolStripMenuItem.Name = "pHIEUNHAPToolStripMenuItem";
            this.pHIEUNHAPToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pHIEUNHAPToolStripMenuItem.Text = "Chi tiết";
            this.pHIEUNHAPToolStripMenuItem.Click += new System.EventHandler(this.pHIEUNHAPToolStripMenuItem_Click);
            // 
            // pHIEUXUATToolStripMenuItem
            // 
            this.pHIEUXUATToolStripMenuItem.Enabled = false;
            this.pHIEUXUATToolStripMenuItem.Name = "pHIEUXUATToolStripMenuItem";
            this.pHIEUXUATToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pHIEUXUATToolStripMenuItem.Text = "Cập nhật";
            this.pHIEUXUATToolStripMenuItem.Click += new System.EventHandler(this.pHIEUXUATToolStripMenuItem_Click);
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click_1);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Enabled = false;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(583, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem qLHANGToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nCCToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pHIEUNHAPToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pHIEUXUATToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ghvvToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem xuấtHàngToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}