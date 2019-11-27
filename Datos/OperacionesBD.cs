using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Librerías necesarias para poder trabajar con la BD
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class OperacionesBD
    {
        // Definiendo los elementos necesarios para establecer una conexión con la BD
        SqlConnection sqlConexion;
        SqlCommand sqlConsulta;
        IDataReader lectorDatos;
        DataTable tablaDatos;

        string nombreBD = "SisAlumnia", nombreServidor = "VYRIL\\SQL_2014", usuario = "", contrasenia = "";
        string cadenaConexion;

        public OperacionesBD()
        {
            cadenaConexion = "Server=" + nombreServidor + "; Database=" + nombreBD + "; Integrated Security=True;";
        }

        ~OperacionesBD() { }

        // Las conexiones a la BD se harán mediante usings, que hace más fácil desechar el objeto usado
        // cuando finalice su tarea.
        public DataTable CargarDatosBD(string procedimientoAlmacenado)
        {

            using (sqlConexion = new SqlConnection(cadenaConexion))
            {
                // Preparando la consulta que leerá los datos de la BD
                sqlConsulta = new SqlCommand()
                {
                    Connection = sqlConexion,
                    CommandText = procedimientoAlmacenado,
                    CommandType = CommandType.StoredProcedure,
                };

                using (sqlConsulta)
                {
                    // Ahora, abrimos la conexión a la BD y recuperamos los datos,
                    // que luego serán guardados en un DataTable y devueltos al programa.
                    sqlConexion.Open();

                    lectorDatos = sqlConsulta.ExecuteReader();

                    tablaDatos = new DataTable();
                    tablaDatos.Load(lectorDatos);
                }
            }
            return tablaDatos;

        }

        public int EscribirEnBd(string procedimientoAlmacenado, string[] valoresParametros, params string[] parametros)
        {
            using (sqlConexion = new SqlConnection(cadenaConexion))
            {
                // Nos aseguramos que la cantidad de parámetros y los valores de los mismos coincidan.
                if (valoresParametros.Length == parametros.Length)
                {
                    sqlConsulta = new SqlCommand()
                    {
                        Connection = sqlConexion,
                        CommandText = procedimientoAlmacenado,
                        CommandType = CommandType.StoredProcedure,
                    };
                    using (sqlConsulta)
                    {
                        for (int i = 0; i < parametros.Length; i++)
                        {
                            sqlConsulta.Parameters.AddWithValue(valoresParametros[i], parametros[i]);
                        }

                        // Devolvemos el número de filas afectadas por el procedimiento almacenado
                        return sqlConsulta.ExecuteNonQuery();
                        

                    }

                }
                else
                {
                    // No se pudo ejecutar la consulta porque los parámetros y sus valores no coinciden, 
                    // por lo que se devuelve un código de ERROR: -1
                    return -1;
                }

            }
        }
    }
}
