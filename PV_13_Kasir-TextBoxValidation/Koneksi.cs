using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace PV_13_KasirTextBoxValidation
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = ANDREW-BENEDICT; initial catalog = Kasir; integrated security = true";
            return Conn;
        }
    }
}
