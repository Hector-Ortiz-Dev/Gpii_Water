using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gpi_Water.Conexion
{
    class Conexion
    {
        static public SqlConnection con;
        static public IDbConnection db;

        static public void Connect()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
            if (db.State == ConnectionState.Closed)
                db.Open();
        }

        static public void Disconnect()
        {
            db.Close();
        }
    }
}
