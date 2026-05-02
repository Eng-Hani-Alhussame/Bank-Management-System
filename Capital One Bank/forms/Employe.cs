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
    public partial class Employee : Form
    {
        DataBaseConection con = new DataBaseConection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader ;
        DataTable dt = new DataTable();
        public void FillDataBase()
        {
            dt.Clear();
            cmd = new SqlCommand("SelectEmployee", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public Employee()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void but_add_Click(object sender, EventArgs e)
        {


            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand("AddUser", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", name_Txt.Text);
                cmd.Parameters.AddWithValue("@Password", txt_كلمة_المرور.Text);
                cmd.Parameters.AddWithValue("@Role", text_الصلاحية.Text);

                cmd.ExecuteNonQuery();
                FillDataBase();
                text_الصلاحية.Text = txt_كلمة_المرور.Text = name_Txt.Text = text_رقم_الموظف.Text = " ";

                MessageBox.Show("تمت إضافة الموظف بنجاح");
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

        private void Employe_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            FillDataBase();
            lab_erorr.Visible=false;

        }


        private void but_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand("UpdateUser", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", text_رقم_الموظف.Text);
                cmd.Parameters.AddWithValue("@Username", name_Txt.Text);
                cmd.Parameters.AddWithValue("@Password", txt_كلمة_المرور.Text);
                cmd.Parameters.AddWithValue("@Role", text_الصلاحية.Text);

                cmd.ExecuteNonQuery();
                FillDataBase();
                text_الصلاحية.Text = txt_كلمة_المرور.Text = name_Txt.Text = text_رقم_الموظف.Text = " ";

                MessageBox.Show("تمت تعديل بيانات الموظف بنجاح");
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

        private void but_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand("DeleteUser", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", text_رقم_الموظف.Text);
               

                cmd.ExecuteNonQuery();
                FillDataBase();
                text_الصلاحية.Text = txt_كلمة_المرور.Text = name_Txt.Text = text_رقم_الموظف.Text = " ";
                MessageBox.Show("تمت حذف الموظف بنجاح");
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

        
            

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            lab_erorr.Visible = false;

        }

        private void label_search_Click(object sender, EventArgs e)
        {

        }

        private void text_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void text_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    con.open();
                    cmd = new SqlCommand("SearchUserByID", con.sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", text_search.Text);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            text_رقم_الموظف.Text = reader[0].ToString();
                            name_Txt.Text = reader[1].ToString();
                            txt_كلمة_المرور.Text = reader[2].ToString();
                            text_الصلاحية.Text = reader[3].ToString();
                        }
                    }
                    else
                    {
                        lab_erorr.Visible = true;

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

        private void Employe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
