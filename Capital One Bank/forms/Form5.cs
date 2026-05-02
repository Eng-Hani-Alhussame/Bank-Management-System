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
    public partial class Form5 : Form
    {
        DataBaseConection con = new DataBaseConection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt = new DataTable();
        public void FillDataBase()
        {
            dt.Clear();
            cmd = new SqlCommand("selecttransaction", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
           dataGridView1.DataSource = dt;

        }
        public Form5()
        {
            InitializeComponent();


            
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            text_رقم_المستلم.Visible =label_المستلم.Visible=dataGridView1.Visible= false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem=="تحويل")
            {
                text_رقم_المستلم.Visible = label_المستلم.Visible =  true;
                text_رقم_المستلم.Text = text_رقم_الهاتف.Text = text_المبلغ.Text = "";


                label3.Text = "رقم المرسل";
                label_المستلم.Text = "رقم المستلم ";
            }
            else if(comboBox1.SelectedItem=="ايداع"||comboBox1.SelectedItem=="سحب")
            {

                text_رقم_المستلم.Visible = label_المستلم.Visible = false;
                label3.Text = "رقم الهاتف";
                text_رقم_المستلم.Text=text_رقم_الهاتف.Text=text_المبلغ.Text = "";


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand("selecttransaction", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                FillDataBase();
;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = comboBox1.SelectedItem?.ToString();
            if (x == "ايداع")
            {
                try
                {
                    con.open();
                    SqlCommand cmd = new SqlCommand("DepositAmount", con.sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PhoneNumber", text_رقم_الهاتف.Text);
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(text_المبلغ.Text)); // تحويل صحيح
                    cmd.ExecuteNonQuery();
                    FillDataBase();

                    MessageBox.Show("تمت الايداع بنجاح");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("خطأ SQL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ عام: " + ex.Message);
                }
                finally
                {
                    con.close();
                }
            }
            else if (x == "سحب")
            {
                try
                {
                    con.open();
                    SqlCommand cmd = new SqlCommand("WithdrawAmount", con.sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PhoneNumber", text_رقم_الهاتف.Text);
                    cmd.Parameters.AddWithValue("@Amount", text_المبلغ.Text);
                    cmd.ExecuteNonQuery();
                    FillDataBase();

                    MessageBox.Show("تمت السحب بنجاح");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.close();
                }
            }
            else if (x == "تحويل")
            {            
                text_رقم_المستلم.Visible = label_المستلم.Visible = dataGridView1.Visible = true;

                label3.Text = "رقم المرسل";
                label_المستلم.Text = "رقم المستلم ";


                try
                {
                    con.open();
                    SqlCommand cmd = new SqlCommand("TransferAmount", con.sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SenderPhone", text_رقم_الهاتف.Text);
                    cmd.Parameters.AddWithValue("@ReceiverPhone", text_رقم_المستلم.Text); 
                    cmd.Parameters.AddWithValue("@Amount",Convert.ToDecimal(text_المبلغ.Text));
                    cmd.ExecuteNonQuery();
                    FillDataBase();

                    MessageBox.Show("تمت التحويل بنجاح");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.close();
                }
            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
