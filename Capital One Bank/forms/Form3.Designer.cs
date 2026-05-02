namespace Capital_One_Bank
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label9 = new System.Windows.Forms.Label();
            this.comb_gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text_الجنسية = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_رقم_الهوية = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_رقم_الهاتف = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_search = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.but_Add = new System.Windows.Forms.Button();
            this.text_سنة = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comb_شهر = new System.Windows.Forms.ComboBox();
            this.comb_يوم = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.text_age = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lab_erorr = new System.Windows.Forms.Label();
            this.comb_نوع_الحساب = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.text_balance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 20F);
            this.label9.Location = new System.Drawing.Point(590, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 39);
            this.label9.TabIndex = 64;
            this.label9.Text = "العملاء";
            // 
            // comb_gender
            // 
            this.comb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_gender.FormattingEnabled = true;
            this.comb_gender.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.comb_gender.Location = new System.Drawing.Point(715, 192);
            this.comb_gender.Name = "comb_gender";
            this.comb_gender.Size = new System.Drawing.Size(321, 24);
            this.comb_gender.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(611, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 58;
            this.label8.Text = "العمر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(614, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "الجنس";
            // 
            // text_الجنسية
            // 
            this.text_الجنسية.Font = new System.Drawing.Font("Arial", 12F);
            this.text_الجنسية.Location = new System.Drawing.Point(714, 145);
            this.text_الجنسية.Multiline = true;
            this.text_الجنسية.Name = "text_الجنسية";
            this.text_الجنسية.Size = new System.Drawing.Size(321, 30);
            this.text_الجنسية.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(611, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "الجنسية";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(611, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 53;
            this.label5.Text = "تاريخ الميلاد ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress.Location = new System.Drawing.Point(217, 235);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(321, 30);
            this.txtAddress.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(120, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "العنوان ";
            // 
            // txt_رقم_الهوية
            // 
            this.txt_رقم_الهوية.Font = new System.Drawing.Font("Arial", 12F);
            this.txt_رقم_الهوية.Location = new System.Drawing.Point(214, 145);
            this.txt_رقم_الهوية.Multiline = true;
            this.txt_رقم_الهوية.Name = "txt_رقم_الهوية";
            this.txt_رقم_الهوية.Size = new System.Drawing.Size(324, 30);
            this.txt_رقم_الهوية.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(120, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "رقم الهوية ";
            // 
            // text_رقم_الهاتف
            // 
            this.text_رقم_الهاتف.Font = new System.Drawing.Font("Arial", 12F);
            this.text_رقم_الهاتف.Location = new System.Drawing.Point(217, 190);
            this.text_رقم_الهاتف.Multiline = true;
            this.text_رقم_الهاتف.Name = "text_رقم_الهاتف";
            this.text_رقم_الهاتف.Size = new System.Drawing.Size(321, 30);
            this.text_رقم_الهاتف.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(120, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "رقم الهاتف ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtName.Location = new System.Drawing.Point(217, 105);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(321, 31);
            this.txtName.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(120, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "الاسم ";
            // 
            // text_search
            // 
            this.text_search.Font = new System.Drawing.Font("Arial", 12F);
            this.text_search.Location = new System.Drawing.Point(217, 12);
            this.text_search.Multiline = true;
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(321, 31);
            this.text_search.TabIndex = 65;
            this.text_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.text_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.BackColor = System.Drawing.Color.Transparent;
            this.label_search.Font = new System.Drawing.Font("Arial", 12F);
            this.label_search.Location = new System.Drawing.Point(179, 12);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(32, 23);
            this.label_search.TabIndex = 67;
            this.label_search.Text = "🔍";
            this.label_search.Click += new System.EventHandler(this.label_search_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 23);
            this.label11.TabIndex = 69;
            this.label11.Text = "→";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // but_Add
            // 
            this.but_Add.AutoSize = true;
            this.but_Add.BackColor = System.Drawing.Color.White;
            this.but_Add.Font = new System.Drawing.Font("Arial", 12F);
            this.but_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_Add.Location = new System.Drawing.Point(1073, 105);
            this.but_Add.Margin = new System.Windows.Forms.Padding(50);
            this.but_Add.Name = "but_Add";
            this.but_Add.Padding = new System.Windows.Forms.Padding(10);
            this.but_Add.Size = new System.Drawing.Size(110, 56);
            this.but_Add.TabIndex = 72;
            this.but_Add.Text = "+  اضافة ";
            this.but_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_Add.UseVisualStyleBackColor = false;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            this.but_Add.Paint += new System.Windows.Forms.PaintEventHandler(this.but_Add_Paint);
            // 
            // text_سنة
            // 
            this.text_سنة.Font = new System.Drawing.Font("Arial", 12F);
            this.text_سنة.Location = new System.Drawing.Point(929, 105);
            this.text_سنة.Multiline = true;
            this.text_سنة.Name = "text_سنة";
            this.text_سنة.Size = new System.Drawing.Size(106, 30);
            this.text_سنة.TabIndex = 54;
            this.text_سنة.TextChanged += new System.EventHandler(this.text_سنة_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(957, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 23);
            this.label10.TabIndex = 73;
            this.label10.Text = "السنة";
            // 
            // comb_شهر
            // 
            this.comb_شهر.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_شهر.FormattingEnabled = true;
            this.comb_شهر.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comb_شهر.Location = new System.Drawing.Point(839, 107);
            this.comb_شهر.Name = "comb_شهر";
            this.comb_شهر.Size = new System.Drawing.Size(64, 24);
            this.comb_شهر.TabIndex = 74;
            this.comb_شهر.SelectedIndexChanged += new System.EventHandler(this.comb_شهر_SelectedIndexChanged);
            // 
            // comb_يوم
            // 
            this.comb_يوم.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_يوم.FormattingEnabled = true;
            this.comb_يوم.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comb_يوم.Location = new System.Drawing.Point(715, 105);
            this.comb_يوم.Name = "comb_يوم";
            this.comb_يوم.Size = new System.Drawing.Size(90, 24);
            this.comb_يوم.TabIndex = 75;
            this.comb_يوم.SelectedIndexChanged += new System.EventHandler(this.comb_يوم_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F);
            this.label12.Location = new System.Drawing.Point(746, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 23);
            this.label12.TabIndex = 76;
            this.label12.Text = "يوم";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 12F);
            this.label13.Location = new System.Drawing.Point(848, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 23);
            this.label13.TabIndex = 77;
            this.label13.Text = "شهر";
            // 
            // text_age
            // 
            this.text_age.Font = new System.Drawing.Font("Arial", 12F);
            this.text_age.Location = new System.Drawing.Point(714, 226);
            this.text_age.Multiline = true;
            this.text_age.Name = "text_age";
            this.text_age.ReadOnly = true;
            this.text_age.Size = new System.Drawing.Size(321, 30);
            this.text_age.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 406);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lab_erorr
            // 
            this.lab_erorr.AutoSize = true;
            this.lab_erorr.BackColor = System.Drawing.Color.Transparent;
            this.lab_erorr.Font = new System.Drawing.Font("Arial", 12F);
            this.lab_erorr.ForeColor = System.Drawing.Color.Red;
            this.lab_erorr.Location = new System.Drawing.Point(296, 46);
            this.lab_erorr.Name = "lab_erorr";
            this.lab_erorr.Size = new System.Drawing.Size(131, 23);
            this.lab_erorr.TabIndex = 87;
            this.lab_erorr.Text = "العميل غير موجود";
            // 
            // comb_نوع_الحساب
            // 
            this.comb_نوع_الحساب.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_نوع_الحساب.FormattingEnabled = true;
            this.comb_نوع_الحساب.Items.AddRange(new object[] {
            "جاري",
            "توفير"});
            this.comb_نوع_الحساب.Location = new System.Drawing.Point(715, 272);
            this.comb_نوع_الحساب.Name = "comb_نوع_الحساب";
            this.comb_نوع_الحساب.Size = new System.Drawing.Size(321, 24);
            this.comb_نوع_الحساب.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 12F);
            this.label14.Location = new System.Drawing.Point(611, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 23);
            this.label14.TabIndex = 88;
            this.label14.Text = "نوع الحساب";
            // 
            // text_balance
            // 
            this.text_balance.Font = new System.Drawing.Font("Arial", 12F);
            this.text_balance.Location = new System.Drawing.Point(214, 272);
            this.text_balance.Multiline = true;
            this.text_balance.Name = "text_balance";
            this.text_balance.Size = new System.Drawing.Size(324, 30);
            this.text_balance.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 12F);
            this.label15.Location = new System.Drawing.Point(95, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 23);
            this.label15.TabIndex = 90;
            this.label15.Text = "الرصيد الابتدائي";
            // 
            // but_delete
            // 
            this.but_delete.AutoSize = true;
            this.but_delete.BackColor = System.Drawing.Color.White;
            this.but_delete.Font = new System.Drawing.Font("Arial", 12F);
            this.but_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_delete.Image = global::Capital_One_Bank.Properties.Resources.icons8_trash_can_30__1_;
            this.but_delete.Location = new System.Drawing.Point(1073, 176);
            this.but_delete.Margin = new System.Windows.Forms.Padding(50);
            this.but_delete.Name = "but_delete";
            this.but_delete.Padding = new System.Windows.Forms.Padding(10);
            this.but_delete.Size = new System.Drawing.Size(110, 56);
            this.but_delete.TabIndex = 70;
            this.but_delete.Text = " حذف";
            this.but_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_delete.UseVisualStyleBackColor = false;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_update
            // 
            this.but_update.AutoSize = true;
            this.but_update.BackColor = System.Drawing.Color.White;
            this.but_update.Font = new System.Drawing.Font("Arial", 12F);
            this.but_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_update.Image = global::Capital_One_Bank.Properties.Resources.icons8_edit_pencil_24;
            this.but_update.Location = new System.Drawing.Point(1073, 245);
            this.but_update.Margin = new System.Windows.Forms.Padding(50);
            this.but_update.Name = "but_update";
            this.but_update.Padding = new System.Windows.Forms.Padding(10);
            this.but_update.Size = new System.Drawing.Size(110, 53);
            this.but_update.TabIndex = 71;
            this.but_update.Text = " تعديل";
            this.but_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_update.UseVisualStyleBackColor = false;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1264, 735);
            this.Controls.Add(this.text_balance);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comb_نوع_الحساب);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lab_erorr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_age);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comb_يوم);
            this.Controls.Add(this.comb_شهر);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_update);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comb_gender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_الجنسية);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_سنة);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_رقم_الهوية);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_رقم_الهاتف);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العملاء";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comb_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_الجنسية;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_رقم_الهوية;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_رقم_الهاتف;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.TextBox text_سنة;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comb_شهر;
        private System.Windows.Forms.ComboBox comb_يوم;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lab_erorr;
        private System.Windows.Forms.ComboBox comb_نوع_الحساب;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox text_balance;
        private System.Windows.Forms.Label label15;
    }
}