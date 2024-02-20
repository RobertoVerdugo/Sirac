using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;


namespace Test_Razor
{
    public class Conexion
    {
        public MySqlConnection conectar()
        {
            return new MySqlConnection("Database=siracdb;Data Server =localhost; User Id=root; Password=");
        }
    }
}
