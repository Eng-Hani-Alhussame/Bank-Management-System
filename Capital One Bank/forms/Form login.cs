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
    
    
    public partial class Form_login : Form
    {
        DataBaseConection con = new DataBaseConection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt = new DataTable();

        public Form_login()
        {
            InitializeComponent();


           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            error_Lbl.Visible = false;
            text_password.UseSystemPasswordChar = false;

        }

        private void but_login_Click(object sender, EventArgs e)
        {
           

            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand("CheckUserLogin", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", text_username.Text);
                cmd.Parameters.AddWithValue("@Password", text_password.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();

                    if (role == "Admin")
                    {
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else if (role == "Employee")
                    {
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is not valid, try again");
                }
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

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "○";
            text_password.UseSystemPasswordChar = true;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "⌀";
            text_password.UseSystemPasswordChar = false;

        }

        private void but_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void login_Btn_BindingContextChanged(object sender, EventArgs e)
        {

        }
    }
}
