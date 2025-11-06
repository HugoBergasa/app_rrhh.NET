using System;

namespace HBergasa_RRHH.modelo
{
    internal class CandidatoAdministracion : Candidato
    {
        private string nivelInformaticaCalculo;
        private string nivelInformaticaTexto;
        private string nivelInformaticaInternet;

        public CandidatoAdministracion(
            string apellidos, int cp, string direccion, string dni,
            string email, string estudiosFinalizados, DateTime fechaAlta,
            DateTime fechaNacimiento, byte[] foto, string localidad,
            string nombre, string observaciones, int telefono,
            string usuariosRegistrador,
            string nivelInformaticaCalculo,
            string nivelInformaticaTexto,
            string nivelInformaticaInternet)
            : base(apellidos, cp, direccion, dni, email, estudiosFinalizados,
                   fechaAlta, fechaNacimiento, foto, localidad, nombre,
                   observaciones, telefono, usuariosRegistrador)
        {
            this.NivelInformaticaCalculo = nivelInformaticaCalculo;
            this.NivelInformaticaTexto = nivelInformaticaTexto;
            this.NivelInformaticaInternet = nivelInformaticaInternet;
        }

        public string NivelInformaticaCalculo { get => nivelInformaticaCalculo; set => nivelInformaticaCalculo = value; }
        public string NivelInformaticaTexto { get => nivelInformaticaTexto; set => nivelInformaticaTexto = value; }
        public string NivelInformaticaInternet { get => nivelInformaticaInternet; set => nivelInformaticaInternet = value; }
    }
}