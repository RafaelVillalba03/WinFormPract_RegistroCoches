using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormPract_RegistroCoches
{
    public class Conexion
    {
        public SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=WINAPFVFWIJWPFD\\SQLEXPRESS;Initial Catalog=Concesionario;Integrated Security=True");
                Console.WriteLine("Éxito al conectar.");

            }

            catch(Exception ex)
            {
                Console.WriteLine("Error al conectar. " + ex.Message);
            }
        }
    }
}
