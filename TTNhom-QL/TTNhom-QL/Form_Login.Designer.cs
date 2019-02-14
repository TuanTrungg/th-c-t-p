namespace TTNhom_QL
{
    partial class Form_Login
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
            this.thoat = new System.Windows.Forms.Button();
            this.dangnhap = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(171, 163);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(87, 31);
            this.thoat.TabIndex = 11;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            // 
            // dangnhap
            // 
            this.dangnhap.Location = new System.Drawing.Point(30, 163);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(76, 31);
            this.dangnhap.TabIndex = 10;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(104, 115);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(143, 20);
            this.pass.TabIndex = 9;
            this.pass.UseSystemPasswordChar = true;
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(104, 67);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(143, 20);
            this.ten.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài khoản :";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 266);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Login";
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.TextBox pass;
        public System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}