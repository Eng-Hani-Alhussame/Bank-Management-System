namespace Capital_One_Bank
{
    partial class Form2
    {
     
        private System.ComponentModel.IContainer components = null;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.but_الموظفين = new System.Windows.Forms.Button();
            this.but_العملاء = new System.Windows.Forms.Button();
            this.but_معاملات = new System.Windows.Forms.Button();
            this.but_الحسابات = new System.Windows.Forms.Button();
            this.but_التقارير = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(378, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "مرحباً بك في نظام البنك  Capital One Bank";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1176, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(57, 62, 57, 62);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.button1.Size = new System.Drawing.Size(167, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = " تسجيل الخروج ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_الموظفين
            // 
            this.but_الموظفين.AutoSize = true;
            this.but_الموظفين.BackColor = System.Drawing.Color.GhostWhite;
            this.but_الموظفين.Font = new System.Drawing.Font("Ebrima", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_الموظفين.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_الموظفين.Image = global::Capital_One_Bank.Properties.Resources.icons8_user_groups_50;
            this.but_الموظفين.Location = new System.Drawing.Point(455, 298);
            this.but_الموظفين.Margin = new System.Windows.Forms.Padding(57, 62, 57, 62);
            this.but_الموظفين.Name = "but_الموظفين";
            this.but_الموظفين.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.but_الموظفين.Size = new System.Drawing.Size(235, 126);
            this.but_الموظفين.TabIndex = 19;
            this.but_الموظفين.Text = "إدارة الموظفين";
            this.but_الموظفين.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_الموظفين.UseVisualStyleBackColor = false;
            this.but_الموظفين.Click += new System.EventHandler(this.but_الموظفين_Click);
            // 
            // but_العملاء
            // 
            this.but_العملاء.AutoSize = true;
            this.but_العملاء.BackColor = System.Drawing.Color.GhostWhite;
            this.but_العملاء.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.but_العملاء.Font = new System.Drawing.Font("Ebrima", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_العملاء.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_العملاء.Image = global::Capital_One_Bank.Properties.Resources.icons8_clients_64;
            this.but_العملاء.Location = new System.Drawing.Point(810, 158);
            this.but_العملاء.Margin = new System.Windows.Forms.Padding(57, 62, 57, 62);
            this.but_العملاء.Name = "but_العملاء";
            this.but_العملاء.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.but_العملاء.Size = new System.Drawing.Size(218, 124);
            this.but_العملاء.TabIndex = 18;
            this.but_العملاء.Text = " إدارة العملاء";
            this.but_العملاء.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_العملاء.UseVisualStyleBackColor = false;
            this.but_العملاء.Click += new System.EventHandler(this.but_العملاء_Click);
            // 
            // but_معاملات
            // 
            this.but_معاملات.AutoSize = true;
            this.but_معاملات.BackColor = System.Drawing.Color.GhostWhite;
            this.but_معاملات.Font = new System.Drawing.Font("Ebrima", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_معاملات.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_معاملات.Image = global::Capital_One_Bank.Properties.Resources.icons8_transactions_32;
            this.but_معاملات.Location = new System.Drawing.Point(586, 156);
            this.but_معاملات.Margin = new System.Windows.Forms.Padding(57, 62, 57, 62);
            this.but_معاملات.Name = "but_معاملات";
            this.but_معاملات.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.but_معاملات.Size = new System.Drawing.Size(218, 126);
            this.but_معاملات.TabIndex = 16;
            this.but_معاملات.Text = " المعاملات المالية ";
            this.but_معاملات.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_معاملات.UseVisualStyleBackColor = false;
            this.but_معاملات.Click += new System.EventHandler(this.but_معاملات_Click);
            // 
            // but_الحسابات
            // 
            this.but_الحسابات.AutoSize = true;
            this.but_الحسابات.BackColor = System.Drawing.Color.GhostWhite;
            this.but_الحسابات.Font = new System.Drawing.Font("Ebrima", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_الحسابات.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_الحسابات.Image = global::Capital_One_Bank.Properties.Resources.icons8_accounts_64;
            this.but_الحسابات.Location = new System.Drawing.Point(344, 160);
            this.but_الحسابات.Margin = new System.Windows.Forms.Padding(57, 62, 57, 62);
            this.but_الحسابات.Name = "but_الحسابات";
            this.but_الحسابات.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.but_الحسابات.Size = new System.Drawing.Size(235, 124);
            this.but_الحسابات.TabIndex = 17;
            this.but_الحسابات.Text = " إدارة الحسابات";
            this.but_الحسابات.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_الحسابات.UseVisualStyleBackColor = false;
            this.but_الحسابات.Click += new System.EventHandler(this.but_الحسابات_Click);
            // 
            // but_التقارير
            // 
            this.but_التقارير.AutoSize = true;
            this.but_التقارير.BackColor = System.Drawing.Color.GhostWhite;
            this.but_التقارير.Font = new System.Drawing.Font("Ebrima", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_التقارير.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_التقارير.Image = global::Capital_One_Bank.Properties.Resources.icons8_graph_report_48;
            this.but_التقارير.Location = new System.Drawing.Point(702, 298);
            this.but_التقارير.Margin = new System.Windows.Forms.Padding(57, 62, 57, 62);
            this.but_التقارير.Name = "but_التقارير";
            this.but_التقارير.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.but_التقارير.Size = new System.Drawing.Size(218, 126);
            this.but_التقارير.TabIndex = 15;
            this.but_التقارير.Text = " التقارير ";
            this.but_التقارير.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_التقارير.UseVisualStyleBackColor = false;
            this.but_التقارير.Click += new System.EventHandler(this.but_التقارير_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::Capital_One_Bank.Properties.Resources._20160724_1469367933_744;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(37, 440);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 318);
            this.panel1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1346, 816);
            this.Controls.Add(this.but_الموظفين);
            this.Controls.Add(this.but_العملاء);
            this.Controls.Add(this.but_معاملات);
            this.Controls.Add(this.but_الحسابات);
            this.Controls.Add(this.but_التقارير);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الرئيسية";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_الموظفين;
        private System.Windows.Forms.Button but_العملاء;
        private System.Windows.Forms.Button but_معاملات;
        private System.Windows.Forms.Button but_الحسابات;
        private System.Windows.Forms.Button but_التقارير;
    }
}