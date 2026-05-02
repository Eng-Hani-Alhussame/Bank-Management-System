using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;

namespace Capital_One_Bank
{
    public partial class Form4 : Form
    {
        DataBaseConection con = new DataBaseConection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        public void FillDataBase()
        {
            dt.Clear();
            cmd = new SqlCommand("SelectTransactions", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void FillDataBase0()
        {
            dt3.Clear();
            cmd = new SqlCommand("GetWithdrawalsByPhone", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt3);
            dataGridView1.DataSource = dt3;

        }
        public void FillDataBase1()
        {
            dt1.Clear();
            cmd = new SqlCommand("SearchCustomer", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }
        public void FillDataBase2()
        {
            dt2.Clear();
            cmd = new SqlCommand("SearchCustomer", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }
        public Form4()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form_Paint);


            void Form_Paint(object sender, PaintEventArgs e)
            {
                Rectangle rect = this.ClientRectangle;

                // اللون العلوي (واضح) واللون السفلي (خافت)
                Color topColor = Color.LightBlue;   // يمكنك تغييره للون أوضح
                Color bottomColor = Color.WhiteSmoke;  // لون خافت في الأسفل

                using (LinearGradientBrush brush = new LinearGradientBrush(
                    rect,
                    topColor,
                    bottomColor,
                    LinearGradientMode.Vertical)) // من أعلى إلى أسفل
                {
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    con.open();
                    cmd = new SqlCommand("GetAccountInfo", con.sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PhoneNumber", textBox1.Text);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboBox1.Text = reader[0].ToString();
                            textBox2.Text = reader[1].ToString();
                          
                        }
                    }
                   
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message, "erorr", MessageBoxButtons.OK);

                }
                finally
                {
                    con.close();
                }

                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dt3.Clear();
                con.open();
                cmd = new SqlCommand("GetTransfersByPhone", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhoneNumber", textBox1.Text);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt3);
                dataGridView1.DataSource = dt3;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "erorr", MessageBoxButtons.OK);
            }
            finally
            {
                con.close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dt3.Clear();
                con.open();
                cmd = new SqlCommand("GetDepositsByPhone", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhoneNumber", textBox1.Text);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt3);
                dataGridView1.DataSource = dt3;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "erorr", MessageBoxButtons.OK);
            }
            finally
            {
                con.close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt3.Clear();
                con.open();
                cmd = new SqlCommand("GetWithdrawalsByPhone", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhoneNumber", textBox1.Text);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt3);
                dataGridView1.DataSource = dt3;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "erorr", MessageBoxButtons.OK);
            }
            finally
            {
                con.close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
