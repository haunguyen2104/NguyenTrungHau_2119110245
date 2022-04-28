using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class DBConnection
    {
        public DBConnection() { }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source = DESKTOP-VSKS0JU\SQLEXPRESS; Initial Catalog=HR; User Id=sa;Password=sa";
            return conn;
        }
    }
}
