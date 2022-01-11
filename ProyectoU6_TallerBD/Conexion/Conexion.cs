using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoU6_TallerBD.Conexion
{
    internal class Conexion
    {
        public static SqlConnection Conectar() { 
            SqlConnection con = new SqlConnection("SERVER=MEL;DATABASE=PROYECTOU6;Integrated Security=True");
            con.Open();
            return con;
        
        }

    }
}
