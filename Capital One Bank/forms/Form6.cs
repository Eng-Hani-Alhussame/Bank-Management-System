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
    public partial class Form6 : Form
    {
        DataBaseConection con = new DataBaseConection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public void FillDataBase()
        {
            dt.Clear();
            cmd = new SqlCommand("SelectTransactions", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void FillDataemployee()
        {
            dt1.Clear();
            cmd = new SqlCommand("SelectEmployees", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }
        public void FillDatacustomer()
        {
            dt2.Clear();
            cmd = new SqlCommand("SelectCustomers", con.sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt2);
            dataGridView3.DataSource = dt2;

        }
        public Form6()
        {
            InitializeComponent();
           
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FillDataBase();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FillDataemployee();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillDatacustomer();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
