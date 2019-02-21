namespace QLKhoHang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(105, 35);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(143, 20);
            this.ten.TabIndex = 2;
            this.ten.TextChanged += new System.EventHandler(this.ten_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(105, 83);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(143, 20);
            this.pass.TabIndex = 3;
            this.pass.UseSystemPasswordChar = true;
            // 
            // dangnhap
            // 
            this.dangnhap.Location = new System.Drawing.Point(47, 131);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(76, 31);
            this.dangnhap.TabIndex = 4;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // thoat
            // 
            this.thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.thoat.Location = new System.Drawing.Point(161, 131);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(87, 31);
            this.thoat.TabIndex = 5;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.thoat;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(296, 174);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button thoat;
        public System.Windows.Forms.TextBox ten;
    }
}

