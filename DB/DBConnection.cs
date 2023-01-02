using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOF_ATMS.DB
{
    public abstract class DBConnection
    {
        private readonly string connectionString;

        public DBConnection()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\dbMATMS.mdf;Integrated Security=True;Connect Timeout=30";

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
