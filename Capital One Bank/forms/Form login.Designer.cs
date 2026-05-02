namespace Capital_One_Bank
{
    partial class Form_login
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_Btn = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.error_Lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(931, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 41);
            this.label5.TabIndex = 17;
            this.label5.Text = "Capital One Bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(741, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "⌀";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // login_Btn
            // 
            this.login_Btn.BackColor = System.Drawing.Color.White;
            this.login_Btn.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Btn.ForeColor = System.Drawing.Color.Black;
            this.login_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_Btn.Location = new System.Drawing.Point(469, 532);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(132, 57);
            this.login_Btn.TabIndex = 15;
            this.login_Btn.Text = "دخول";
            this.login_Btn.UseVisualStyleBackColor = false;
            this.login_Btn.BindingContextChanged += new System.EventHandler(this.login_Btn_BindingContextChanged);
            this.login_Btn.Click += new System.EventHandler(this.but_login_Click);
            // 
            // but_exit
            // 
            this.but_exit.BackColor = System.Drawing.Color.White;
            this.but_exit.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_exit.ForeColor = System.Drawing.Color.Black;
            this.but_exit.Location = new System.Drawing.Point(628, 532);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(141, 57);
            this.but_exit.TabIndex = 14;
            this.but_exit.Text = "خروج";
            this.but_exit.UseVisualStyleBackColor = false;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // error_Lbl
            // 
            this.error_Lbl.AutoSize = true;
            this.error_Lbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_Lbl.Location = new System.Drawing.Point(486, 407);
            this.error_Lbl.Name = "error_Lbl";
            this.error_Lbl.Size = new System.Drawing.Size(259, 28);
            this.error_Lbl.TabIndex = 13;
            this.error_Lbl.Text = "اسم المستخدم او كلمة المرور خاطئة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "كلمة المرور";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم المستخدم";
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Arial", 14F);
            this.text_password.Location = new System.Drawing.Point(469, 351);
            this.text_password.Multiline = true;
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '•';
            this.text_password.Size = new System.Drawing.Size(300, 35);
            this.text_password.TabIndex = 10;
            this.text_password.UseSystemPasswordChar = true;
            // 
            // text_username
            // 
            this.text_username.Font = new System.Drawing.Font("Arial", 14F);
            this.text_username.Location = new System.Drawing.Point(469, 246);
            this.text_username.Multiline = true;
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(300, 35);
            this.text_username.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(510, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 39);
            this.label6.TabIndex = 18;
            this.label6.Text = "تسجيل الدخول";
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1188, 730);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.login_Btn);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.error_Lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_username);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_login_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_Btn;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Label error_Lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Label label6;
    }
}