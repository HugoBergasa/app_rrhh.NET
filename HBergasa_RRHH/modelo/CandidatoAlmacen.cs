using System;

namespace HBergasa_RRHH.modelo
{
    internal class CandidatoAlmacen : Candidato
    {
        private string carnetConducir;
        private string carnetCarretilla;
        private string carnetCamion;

        public CandidatoAlmacen(
            string apellidos, int cp, string direccion, string dni,
            string email, string estudiosFinalizados, DateTime fechaAlta,
            DateTime fechaNacimiento, byte[] foto, string localidad,
            string nombre, string observaciones, int telefono,
            string usuariosRegistrador,
            string carnetConducir,
            string carnetCarretilla,
            string carnetCamion)
            : base(apellidos, cp, direccion, dni, email, estudiosFinalizados,
                   fechaAlta, fechaNacimiento, foto, localidad, nombre,
                   observaciones, telefono, usuariosRegistrador)
        {
            this.CarnetConducir = carnetConducir;
            this.CarnetCarretilla = carnetCarretilla;
            this.CarnetCamion = carnetCamion;
        }

        public string CarnetConducir { get => carnetConducir; set => carnetConducir = value; }
        public string CarnetCarretilla { get => carnetCarretilla; set => carnetCarretilla = value; }
        public string CarnetCamion { get => carnetCamion; set => carnetCamion = value; }
    }
}