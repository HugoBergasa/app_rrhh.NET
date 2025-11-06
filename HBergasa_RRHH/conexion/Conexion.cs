using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_RRHH.conexion
{
    internal class Conexion
    {

        public static readonly string url = Environment.GetEnvironmentVariable("DB_CONNECTION_RRHH");

        //Sustituir DB_CONNECTION_RRHH por:

       /* public static readonly string url = "Server=1; " +
       "Database=; " +
       "User=; " +
       "port=; " +
       "password=; " +
       "Convert Zero Datetime=True";*/

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(url);
        }

        public static bool acceder(string user, string pass)
        {
            string consulta = "SELECT usuario, contrasenya FROM usuarios WHERE usuario=?user AND contrasenya=?pass ";

            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(consulta, conn);

                command.Parameters.AddWithValue("?user", user);
                command.Parameters.AddWithValue("?pass", pass);

                MySqlDataReader resultados = command.ExecuteReader();

                if (resultados.Read())
                {
                    return true;
                }
                resultados.Close();
                conn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);

            }
            return false;

        }
    }
}
