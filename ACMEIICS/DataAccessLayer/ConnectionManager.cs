using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ACMEIICS.DataAccessLayer
{   
        public class ConnectionManager
        {
            //Create Connection to data base.
            public static SqlConnection DatabaseConnection()
            {
                string connection = "Data Source=jakethedog\\SQLEXPRESS;Initial Catalog=Acme;User ID=sa;Password=sqlexpress";//Database adress and connection info.
                SqlConnection conn = new SqlConnection(connection);
                return conn;
            }

        }

    
}
