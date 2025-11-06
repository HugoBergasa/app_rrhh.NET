using HBergasa_RRHH.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;

namespace HBergasa_RRHH.conexion
{
    internal class Consultas
    {
        public static string rescatarNombreCompleto(string usuario)
        {
            string consulta = "SELECT CONCAT(nombre, ' ', apellidos) as nombreCompleto FROM usuarios WHERE usuario=@usuario";

            using (MySqlConnection conn = new MySqlConnection(Conexion.url))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(consulta, conn))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        object resultado = command.ExecuteScalar();
                        return resultado?.ToString();
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al rescatar el nombre completo");
                    return null;
                }
            }
        }

        public static int[] contarCandidatos()
        {
            int[] resultados = new int[2];

            string consulta = @"SELECT 
                            (SELECT COUNT(*) FROM candidatoadministracion) as totalAdministracion,
                            (SELECT COUNT(*) FROM candidatoalmacen) as totalAlmacen";

            using (MySqlConnection conn = new MySqlConnection(Conexion.url))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(consulta, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                resultados[0] = reader.GetInt32("totalAdministracion");
                                resultados[1] = reader.GetInt32("totalAlmacen");
                            }
                        }
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al contar candidatos");
                }
            }
            return resultados;
        }

        public static DataTable obtenerCandidatosAdmin()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT nombre AS NOMBRE,apellidos AS APELLIDOS,dni AS DNI,telefono AS TELEFONO FROM candidatoadministracion ORDER BY fechaAlta DESC LIMIT 3";

            using (MySqlConnection conn = new MySqlConnection(Conexion.url))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(consulta, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al cargar candidatos administración");
                }
            }

            return dt;
        }

        public static DataTable obtenerCandidatosAlmacen()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT nombre AS NOMBRE,apellidos AS APELLIDOS,dni AS DNI,telefono AS TELEFONO FROM candidatoalmacen ORDER BY fechaAlta DESC LIMIT 3";

            using (MySqlConnection conn = new MySqlConnection(Conexion.url))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(consulta, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al cargar candidatos almacén");
                }
            }

            return dt;
        }

        public static bool ComprobarDNIExiste(string dni, string tabla)
        {
            string consulta = "SELECT COUNT(*) FROM candidatoadministracion WHERE dni = @dni";

            using (MySqlConnection conn = new MySqlConnection(Conexion.url))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(consulta, conn))
                    {
                        command.Parameters.AddWithValue("@dni", dni);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static bool RegistrarCandidatoAdministracion(CandidatoAdministracion candidato)
        {
            string consulta = @"INSERT INTO candidatoadministracion 
                       (nombre, apellidos, dni, fechaNacimiento, direccion, cp, localidad, 
                        telefono, email, foto, nivelEstudios, nivelInformaticaTexto, 
                        nivelInformaticaHojaCalculo, nivelInformaticaInternet, 
                        observaciones, fechaAlta, registrador) 
                       VALUES 
                       (@nombre, @apellidos, @dni, @fechaNacimiento, @direccion, @cp, @localidad, 
                        @telefono, @email, @foto, @nivelEstudios, @nivelInformaticaTexto, 
                        @nivelInformaticaHojaCalculo, @nivelInformaticaInternet, 
                        @observaciones, @fechaAlta, @registrador)";

            using (MySqlConnection conn = new MySqlConnection(Conexion.url))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(consulta, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", candidato.Nombre);
                        command.Parameters.AddWithValue("@apellidos", candidato.Apellidos);
                        command.Parameters.AddWithValue("@dni", candidato.Dni);
                        command.Parameters.AddWithValue("@fechaNacimiento", candidato.FechaNacimiento);
                        command.Parameters.AddWithValue("@direccion", candidato.Direccion);
                        command.Parameters.AddWithValue("@cp", candidato.Cp);
                        command.Parameters.AddWithValue("@localidad", candidato.Localidad);
                        command.Parameters.AddWithValue("@telefono", candidato.Telefono);
                        command.Parameters.AddWithValue("@email", candidato.Email);
                        command.Parameters.AddWithValue("@foto", candidato.Foto);
                        command.Parameters.AddWithValue("@nivelEstudios", candidato.EstudiosFinalizados);
                        command.Parameters.AddWithValue("@observaciones", candidato.Observaciones);
                        command.Parameters.AddWithValue("@fechaAlta", candidato.FechaAlta);
                        command.Parameters.AddWithValue("@registrador", candidato.UsuariosRegistrador);
                        command.Parameters.AddWithValue("@nivelInformaticaTexto", candidato.NivelInformaticaTexto);
                        command.Parameters.AddWithValue("@nivelInformaticaHojaCalculo", candidato.NivelInformaticaCalculo);
                        command.Parameters.AddWithValue("@nivelInformaticaInternet", candidato.NivelInformaticaInternet);

                        int filasAfectadas = command.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al registrar candidato: " + e.Message,
                                  "Error BD",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static bool RegistrarCandidatoAlmacen(CandidatoAlmacen candidato)
        {
            string consulta = @"INSERT INTO candidatoalmacen 
                       (nombre, apellidos, dni, fechaNacimiento, direccion, cp, localidad, 
                        telefono, email, foto, nivelEstudios, carnetConducir, 
                        carnetCarretilla, carnetCamion, observaciones, fechaAlta, registrador) 
                       VALUES 
                       (@nombre, @apellidos, @dni, @fechaNacimiento, @direccion, @cp, @localidad, 
                        @telefono, @email, @foto, @nivelEstudios, @carnetConducir, 
                        @carnetCarretilla, @carnetCamion, @observaciones, @fechaAlta, @registrador)";

            using (MySqlConnection conn = new MySqlConnection(Conexion.url))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(consulta, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", candidato.Nombre);
                        command.Parameters.AddWithValue("@apellidos", candidato.Apellidos);
                        command.Parameters.AddWithValue("@dni", candidato.Dni);
                        command.Parameters.AddWithValue("@fechaNacimiento", candidato.FechaNacimiento);
                        command.Parameters.AddWithValue("@direccion", candidato.Direccion);
                        command.Parameters.AddWithValue("@cp", candidato.Cp);
                        command.Parameters.AddWithValue("@localidad", candidato.Localidad);
                        command.Parameters.AddWithValue("@telefono", candidato.Telefono);
                        command.Parameters.AddWithValue("@email", candidato.Email);
                        command.Parameters.AddWithValue("@foto", candidato.Foto);
                        command.Parameters.AddWithValue("@nivelEstudios", candidato.EstudiosFinalizados);
                        command.Parameters.AddWithValue("@observaciones", candidato.Observaciones);
                        command.Parameters.AddWithValue("@fechaAlta", candidato.FechaAlta);
                        command.Parameters.AddWithValue("@registrador", candidato.UsuariosRegistrador);
                        command.Parameters.AddWithValue("@carnetConducir", candidato.CarnetConducir);
                        command.Parameters.AddWithValue("@carnetCarretilla", candidato.CarnetCarretilla);
                        command.Parameters.AddWithValue("@carnetCamion", candidato.CarnetCamion);

                        int filasAfectadas = command.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error al registrar candidato: " + e.Message,
                                  "Error BD",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    return false;
                }
            }
        }

    }
}
