using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace TruyumDAL
{
    public class ConnectionHandler
    {
        public static SqlConnection GetConnection() {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["truyum"].ConnectionString);
        }
    }
}
