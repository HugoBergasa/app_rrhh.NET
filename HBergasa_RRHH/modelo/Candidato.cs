using System;

namespace HBergasa_RRHH.modelo
{
    internal class Candidato
    {
        private string apellidos;
        private int cp;
        private string direccion, dni, email, estudiosFinalizados;
        private DateTime fechaAlta, fechaNacimiento;
        private byte[] foto;  
        private string localidad, nombre, observaciones;
        private int telefono;
        private string usuariosRegistrador;

        public Candidato(string apellidos, int cp, string direccion, string dni,
                        string email, string estudiosFinalizados, DateTime fechaAlta,
                        DateTime fechaNacimiento, byte[] foto, string localidad,
                        string nombre, string observaciones, int telefono,
                        string usuariosRegistrador)
        {
            this.Apellidos = apellidos;
            this.Cp = cp;
            this.Direccion = direccion;
            this.Dni = dni;
            this.Email = email;
            this.EstudiosFinalizados = estudiosFinalizados;
            this.FechaAlta = fechaAlta;
            this.FechaNacimiento = fechaNacimiento;
            this.Foto = foto;
            this.Localidad = localidad;
            this.Nombre = nombre;
            this.Observaciones = observaciones;
            this.Telefono = telefono;
            this.UsuariosRegistrador = usuariosRegistrador;
        }

        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Cp { get => cp; set => cp = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Email { get => email; set => email = value; }
        public string EstudiosFinalizados { get => estudiosFinalizados; set => estudiosFinalizados = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public byte[] Foto { get => foto; set => foto = value; } 
        public string Localidad { get => localidad; set => localidad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string UsuariosRegistrador { get => usuariosRegistrador; set => usuariosRegistrador = value; }
    }
}