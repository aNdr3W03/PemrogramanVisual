using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PV_14_KoneksiMsAccess
{
    internal class Koneksi
    {
        public OleDbConnection GetConn()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|/DBBarang.mdb";
            return conn;
        }
    }
}
