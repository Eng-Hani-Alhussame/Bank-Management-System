namespace Capital_One_Bank
{
    partial class Form5
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
            this.label_المستلم = new System.Windows.Forms.Label();
            this.text_رقم_المستلم = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_رقم_الهاتف = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_المبلغ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 20F);
            this.label5.Location = new System.Drawing.Point(550, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 39);
            this.label5.TabIndex = 25;
            this.label5.Text = "المعاملات ";
            // 
            // label_المستلم
            // 
            this.label_المستلم.AutoSize = true;
            this.label_المستلم.BackColor = System.Drawing.Color.Transparent;
            this.label_المستلم.Font = new System.Drawing.Font("Arial", 12F);
            this.label_المستلم.Location = new System.Drawing.Point(597, 167);
            this.label_المستلم.Name = "label_المستلم";
            this.label_المستلم.Size = new System.Drawing.Size(81, 23);
            this.label_المستلم.TabIndex = 24;
            this.label_المستلم.Text = "اسم المستلم";
            // 
            // text_رقم_المستلم
            // 
            this.text_رقم_المستلم.Font = new System.Drawing.Font("Arial", 12F);
            this.text_رقم_المستلم.Location = new System.Drawing.Point(693, 166);
            this.text_رقم_المستلم.Name = "text_رقم_المستلم";
            this.text_رقم_المستلم.Size = new System.Drawing.Size(239, 30);
            this.text_رقم_المستلم.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(610, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 44);
            this.button2.TabIndex = 20;
            this.button2.Text = "عرض العمليات ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(219, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "رقم الهاتف ";
            // 
            // text_رقم_الهاتف
            // 
            this.text_رقم_الهاتف.Font = new System.Drawing.Font("Arial", 12F);
            this.text_رقم_الهاتف.Location = new System.Drawing.Point(315, 170);
            this.text_رقم_الهاتف.Name = "text_رقم_الهاتف";
            this.text_رقم_الهاتف.Size = new System.Drawing.Size(239, 30);
            this.text_رقم_الهاتف.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(597, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "المبلغ ";
            // 
            // text_المبلغ
            // 
            this.text_المبلغ.Font = new System.Drawing.Font("Arial", 12F);
            this.text_المبلغ.Location = new System.Drawing.Point(693, 105);
            this.text_المبلغ.Name = "text_المبلغ";
            this.text_المبلغ.Size = new System.Drawing.Size(239, 30);
            this.text_المبلغ.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(221, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "نوع العملية ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "سحب",
            "ايداع",
            "تحويل"});
            this.comboBox1.Location = new System.Drawing.Point(315, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 31);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "→";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 393);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(513, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "تاكيد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1204, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_المستلم);
            this.Controls.Add(this.text_رقم_المستلم);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_رقم_الهاتف);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_المبلغ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_المستلم;
        private System.Windows.Forms.TextBox text_رقم_المستلم;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_رقم_الهاتف;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_المبلغ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}