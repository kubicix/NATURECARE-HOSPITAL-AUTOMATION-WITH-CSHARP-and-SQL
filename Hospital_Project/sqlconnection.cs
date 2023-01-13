using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Project
{
    internal class sqlconnection
    {
        //Data Source=DESKTOP-BDSUH1M\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-BDSUH1M\\SQLEXPRESS;Initial Catalog=HospitalProject;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
