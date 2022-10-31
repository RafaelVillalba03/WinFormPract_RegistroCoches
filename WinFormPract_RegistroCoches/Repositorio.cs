using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;

namespace WinFormPract_RegistroCoches
{
    internal class Repositorio
    {
        /// <summary>
        /// Método par obtener la lista de los coches del concesionario en un DataSet ds.
        /// </summary>
        /// <returns></returns>

        public static DataSet ObtenerCoches()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.CommandText = "SELECT * FROM COCHESCONCESIONARIO";
                comando.Connection = conexion.cnx;
                adaptador.SelectCommand = comando;
                conexion.cnx.Open();
                adaptador.Fill(ds);
                conexion.cnx.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }

        /// <summary>
        /// Método para crear un coche
        /// </summary>
        /// <returns></returns>

        public static bool CrearCoche(Coche c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; INSERT INTO COCHESCONCESIONARIO VALUES " +
                    "('" + c.marca + "', '" + c.fechaFabricacion + "', '" + c.coste +"')";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para eliminar un coche
        /// </summary>
        /// <returns></returns>

        public static bool EliminarCoche(Coche c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "DELETE FROM COCHESCONCESIONARIO WHERE ID = '" + c.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        /// <summary>
        /// Método para modificar un coche
        /// </summary>
        /// <returns></returns>

        public static bool ModificarCoche(Coche c)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; UPDATE COCHESCONCESIONARIO SET MARCA = '" + c.marca + "', FABRICACION= '" + c.fechaFabricacion + "', " +
                    "COSTE = '" + c.coste + "'WHERE ID = '" + c.Id + "'"; ;

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }


    }
}
