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
    public partial class Form3 : Form
    {
        DataBaseConection con = new DataBaseConection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt = new DataTable();
        public void FillDataBase()
        {
            dt.Clear();
            cmd = new SqlCommand("SelectCustomer", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void CalculateAge()
        {
            try
            {
                int day = int.Parse(comb_يوم.SelectedItem.ToString());
                int month = int.Parse(comb_شهر.SelectedItem.ToString());
                int year = int.Parse(text_سنة.Text);

                DateTime birthDate = new DateTime(year, month, day);
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;
                // إذا لم يصل تاريخ الميلاد بعد في هذه السنة، نقص العمر سنة واحدة
                if (birthDate > today.AddYears(-age))
                {
                    age--;
                }
                text_age.Text = age.ToString();
            }
            catch
            {
                // في حالة خطأ الإدخال
                text_age.Text = "";
            }
        }
        public Form3()
        {
            InitializeComponent();
          
            
        }


        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lab_erorr.Visible = false;
            text_رقم_الهاتف.Text = txtName.Text = text_الجنسية.Text = txt_رقم_الهوية.Text = text_age.Text = txtAddress.Text = text_سنة.Text=" ";
            comb_يوم.Text = comb_شهر.Text = comb_gender.Text = null;
            label_search.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FillDataBase();
            lab_erorr.Visible=false;
            StartPosition = FormStartPosition.CenterScreen;
           

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }


        //الاضافة
        private void but_Add_Click(object sender, EventArgs e)
        {

            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand("AddCustomer", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PhoneNumber", text_رقم_الهاتف.Text);
                cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                cmd.Parameters.AddWithValue("@NationalID", txt_رقم_الهوية.Text);
                cmd.Parameters.AddWithValue("@BirthDate", comb_يوم.Text+"-"+comb_شهر.Text+"-"+text_سنة.Text);
                cmd.Parameters.AddWithValue("@Nationality", text_الجنسية.Text);
                cmd.Parameters.AddWithValue("@Gender", comb_gender.Text);
                cmd.Parameters.AddWithValue("@Age", text_age.Text.ToString());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Balance", text_balance.Text);
                cmd.ExecuteNonQuery();
                FillDataBase();


                MessageBox.Show("تمت الإضافة بنجاح");
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

        //الحذف
        private void but_delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand("DeleteCustomer", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PhoneNumber", text_رقم_الهاتف.Text);
               
                cmd.ExecuteNonQuery();
                FillDataBase();

                MessageBox.Show("تمت عملية الحذف بنجاح");
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

        //التعديل
        private void but_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.open();
                SqlCommand cmd = new SqlCommand("UpdateCustomer", con.sqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PhoneNumber", text_رقم_الهاتف.Text);
                cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                cmd.Parameters.AddWithValue("@NationalID", txt_رقم_الهوية.Text);
                cmd.Parameters.AddWithValue("@BirthDate", comb_يوم.Text + "-" + comb_شهر.Text + "-" + text_سنة.Text);
                cmd.Parameters.AddWithValue("@Nationality", text_الجنسية.Text);
                cmd.Parameters.AddWithValue("@Gender", comb_gender.Text);
                cmd.Parameters.AddWithValue("@Age", text_age.Text.ToString());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Balance", Convert.ToDecimal(text_balance.Text));


                cmd.ExecuteNonQuery();
                FillDataBase();

                MessageBox.Show("تمت التعديل بنجاح");
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
        //البحث 
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    con.open();
                    cmd = new SqlCommand("SearchCustomer", con.sqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PhoneNumber", text_search.Text);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            text_رقم_الهاتف.Text = reader[1].ToString();
                            txtName.Text = reader[2].ToString();
                            txt_رقم_الهوية.Text = reader[3].ToString();
                            text_الجنسية.Text = reader[5].ToString();
                            comb_gender.Text = reader[6].ToString();
                            text_age.Text = reader[7].ToString();
                            txtAddress.Text = reader[8].ToString();
                            if (reader.Read())
                            {
                                DateTime BirthDate = Convert.ToDateTime(reader["BirthDate"]);
                                // اليوم
                                comb_يوم.SelectedItem = BirthDate.Day.ToString();
                                // الشهر
                                comb_شهر.SelectedItem = BirthDate.Month.ToString();
                                // السنة
                                text_سنة.Text = BirthDate.Year.ToString();
                            }
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

        private void but_Add_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comb_يوم_SelectedIndexChanged(object sender, EventArgs e)
        {
           // CalculateAge();

        }

        private void comb_شهر_SelectedIndexChanged(object sender, EventArgs e)
        {
           // CalculateAge();

        }

        private void text_سنة_TextChanged(object sender, EventArgs e)
        {
           // CalculateAge();

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void label_search_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
