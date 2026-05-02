using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataBase
{
    public class DataBaseConection
    {
        public SqlConnection sqlConnection;
        public DataBaseConection()
        {
            sqlConnection = new SqlConnection(@"server=DESKTOP-QSUN0UI ;database=Capital_One_Bank;integrated security=true;");
        }
        public void open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }

        }
        public void close()
        {
            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}
