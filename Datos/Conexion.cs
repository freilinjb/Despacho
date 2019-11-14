using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0GJ4POO\SQLEXPRESS;Initial Catalog=Despacho;Integrated Security=True");
    }
}
