using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DTO;
using System.Data;

namespace DAL
{
   
   


    
    public class SqlConnectionData
    {
        public static MySqlConnection Connect()
        {
            string strCon = "datasource=127.0.0.1;port=3306;username=root;password=;database=watchmanage;Convert Zero Datetime=true";
            MySqlConnection conn = new MySqlConnection(strCon);
            return conn;
        }

    }
    
    public class DatabaseAcess
    {
       
    }
}
