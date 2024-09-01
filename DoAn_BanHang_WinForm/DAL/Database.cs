using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{

    public class Database
    {
        [STAThread] static void Main(string[] args) {  }

        private static string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLY_Pos;Integrated Security=True";
        
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strCon);
        }

    }
}
