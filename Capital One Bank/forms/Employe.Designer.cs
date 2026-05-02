namespace Capital_One_Bank
{
    partial class Employee
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
            this.but_Add = new System.Windows.Forms.Button();
            this.text_الصلاحية = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_كلمة_المرور = new System.Windows.Forms.TextBox();
            this.password_Txt = new System.Windows.Forms.Label();
            this.name_Txt = new System.Windows.Forms.TextBox();
            this.name_Lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_رقم_الموظف = new System.Windows.Forms.TextBox();
            this.phone_Txt = new System.Windows.Forms.Label();
            this.lab_erorr = new System.Windows.Forms.Label();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Add
            // 
            this.but_Add.AutoSize = true;
            this.but_Add.BackColor = System.Drawing.Color.White;
            this.but_Add.Font = new System.Drawing.Font("Arial", 12F);
            this.but_Add.ForeColor = System.Drawing.Color.Black;
            this.but_Add.Location = new System.Drawing.Point(1003, 83);
            this.but_Add.Margin = new System.Windows.Forms.Padding(50);
            this.but_Add.Name = "but_Add";
            this.but_Add.Padding = new System.Windows.Forms.Padding(10);
            this.but_Add.Size = new System.Drawing.Size(53, 56);
            this.but_Add.TabIndex = 19;
            this.but_Add.Text = "+";
            this.but_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_Add.UseVisualStyleBackColor = false;
            this.but_Add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // text_الصلاحية
            // 
            this.text_الصلاحية.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_الصلاحية.Location = new System.Drawing.Point(656, 119);
            this.text_الصلاحية.Multiline = true;
            this.text_الصلاحية.Name = "text_الصلاحية";
            this.text_الصلاحية.Size = new System.Drawing.Size(321, 30);
            this.text_الصلاحية.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(562, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 77;
            this.label5.Text = "الصلاحية";
            // 
            // txt_كلمة_المرور
            // 
            this.txt_كلمة_المرور.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_كلمة_المرور.Location = new System.Drawing.Point(134, 122);
            this.txt_كلمة_المرور.Multiline = true;
            this.txt_كلمة_المرور.Name = "txt_كلمة_المرور";
            this.txt_كلمة_المرور.Size = new System.Drawing.Size(321, 30);
            this.txt_كلمة_المرور.TabIndex = 74;
            // 
            // password_Txt
            // 
            this.password_Txt.AutoSize = true;
            this.password_Txt.BackColor = System.Drawing.Color.Transparent;
            this.password_Txt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Txt.ForeColor = System.Drawing.Color.White;
            this.password_Txt.Location = new System.Drawing.Point(34, 125);
            this.password_Txt.Name = "password_Txt";
            this.password_Txt.Size = new System.Drawing.Size(94, 28);
            this.password_Txt.TabIndex = 73;
            this.password_Txt.Text = "Password";
            // 
            // name_Txt
            // 
            this.name_Txt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Txt.Location = new System.Drawing.Point(134, 86);
            this.name_Txt.Multiline = true;
            this.name_Txt.Name = "name_Txt";
            this.name_Txt.Size = new System.Drawing.Size(321, 31);
            this.name_Txt.TabIndex = 70;
            // 
            // name_Lbl
            // 
            this.name_Lbl.AutoSize = true;
            this.name_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.name_Lbl.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Lbl.ForeColor = System.Drawing.Color.White;
            this.name_Lbl.Location = new System.Drawing.Point(59, 89);
            this.name_Lbl.Name = "name_Lbl";
            this.name_Lbl.Size = new System.Drawing.Size(64, 28);
            this.name_Lbl.TabIndex = 69;
            this.name_Lbl.Text = "Name";
            this.name_Lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1076, 453);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(511, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 80;
            this.label6.Text = "الموظفين";
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.BackColor = System.Drawing.Color.Transparent;
            this.label_search.Font = new System.Drawing.Font("Arial", 12F);
            this.label_search.ForeColor = System.Drawing.Color.White;
            this.label_search.Location = new System.Drawing.Point(96, 9);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(32, 23);
            this.label_search.TabIndex = 82;
            this.label_search.Text = "🔍";
            this.label_search.Click += new System.EventHandler(this.label_search_Click);
            // 
            // text_search
            // 
            this.text_search.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_search.Location = new System.Drawing.Point(134, 9);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(321, 31);
            this.text_search.TabIndex = 81;
            this.text_search.TextChanged += new System.EventHandler(this.text_search_TextChanged);
            this.text_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_search_KeyDown);
            this.text_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_search_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 23);
            this.label7.TabIndex = 83;
            this.label7.Text = "→";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // text_رقم_الموظف
            // 
            this.text_رقم_الموظف.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_رقم_الموظف.Location = new System.Drawing.Point(656, 83);
            this.text_رقم_الموظف.Multiline = true;
            this.text_رقم_الموظف.Name = "text_رقم_الموظف";
            this.text_رقم_الموظف.Size = new System.Drawing.Size(321, 30);
            this.text_رقم_الموظف.TabIndex = 85;
            // 
            // phone_Txt
            // 
            this.phone_Txt.AutoSize = true;
            this.phone_Txt.BackColor = System.Drawing.Color.Transparent;
            this.phone_Txt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_Txt.ForeColor = System.Drawing.Color.White;
            this.phone_Txt.Location = new System.Drawing.Point(553, 83);
            this.phone_Txt.Name = "phone_Txt";
            this.phone_Txt.Size = new System.Drawing.Size(99, 28);
            this.phone_Txt.TabIndex = 84;
            this.phone_Txt.Text = "Phone No";
            // 
            // lab_erorr
            // 
            this.lab_erorr.AutoSize = true;
            this.lab_erorr.BackColor = System.Drawing.Color.Transparent;
            this.lab_erorr.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_erorr.ForeColor = System.Drawing.Color.Red;
            this.lab_erorr.Location = new System.Drawing.Point(222, 43);
            this.lab_erorr.Name = "lab_erorr";
            this.lab_erorr.Size = new System.Drawing.Size(150, 28);
            this.lab_erorr.TabIndex = 86;
            this.lab_erorr.Text = "الموظف غير موجود";
            // 
            // but_delete
            // 
            this.but_delete.AutoSize = true;
            this.but_delete.BackColor = System.Drawing.Color.White;
            this.but_delete.Font = new System.Drawing.Font("Arial", 12F);
            this.but_delete.ForeColor = System.Drawing.Color.Black;
            this.but_delete.Image = global::Capital_One_Bank.Properties.Resources.icons8_trash_can_30;
            this.but_delete.Location = new System.Drawing.Point(1115, 83);
            this.but_delete.Margin = new System.Windows.Forms.Padding(50);
            this.but_delete.Name = "but_delete";
            this.but_delete.Padding = new System.Windows.Forms.Padding(10);
            this.but_delete.Size = new System.Drawing.Size(56, 56);
            this.but_delete.TabIndex = 16;
            this.but_delete.Text = " ";
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_update
            // 
            this.but_update.AutoSize = true;
            this.but_update.BackColor = System.Drawing.Color.White;
            this.but_update.Font = new System.Drawing.Font("Arial", 10F);
            this.but_update.ForeColor = System.Drawing.Color.Black;
            this.but_update.Image = global::Capital_One_Bank.Properties.Resources.icons8_edit_pencil;
            this.but_update.Location = new System.Drawing.Point(1057, 83);
            this.but_update.Margin = new System.Windows.Forms.Padding(50);
            this.but_update.Name = "but_update";
            this.but_update.Padding = new System.Windows.Forms.Padding(10);
            this.but_update.Size = new System.Drawing.Size(58, 56);
            this.but_update.TabIndex = 17;
            this.but_update.Text = " ";
            this.but_update.UseVisualStyleBackColor = false;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1195, 695);
            this.Controls.Add(this.lab_erorr);
            this.Controls.Add(this.text_رقم_الموظف);
            this.Controls.Add(this.phone_Txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_الصلاحية);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_كلمة_المرور);
            this.Controls.Add(this.password_Txt);
            this.Controls.Add(this.name_Txt);
            this.Controls.Add(this.name_Lbl);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_update);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employe_FormClosing);
            this.Load += new System.EventHandler(this.Employe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.TextBox text_الصلاحية;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_كلمة_المرور;
        private System.Windows.Forms.Label password_Txt;
        private System.Windows.Forms.TextBox name_Txt;
        private System.Windows.Forms.Label name_Lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_رقم_الموظف;
        private System.Windows.Forms.Label phone_Txt;
        private System.Windows.Forms.Label lab_erorr;
    }
}