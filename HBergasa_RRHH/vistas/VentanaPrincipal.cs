using System.Windows.Forms;

namespace HBergasa_RRHH.vistas
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            labelNombre.Text=VentanaLogin.nombreCompleto.ToString();
            labelTimeSesion.Text=VentanaLogin.fecha.ToString();
            labelIP.Text = VentanaLogin.ipv4;

            int[] totales = conexion.Consultas.contarCandidatos();

            contadorAdmin.Text=totales[0].ToString();
            contadorAlmacen.Text=totales[1].ToString();

            tablaAdmin.DataSource=conexion.Consultas.obtenerCandidatosAdmin();
            tablaAlmacen.DataSource=conexion.Consultas.obtenerCandidatosAlmacen();
        }

        private void botonUno_Click(object sender, System.EventArgs e)
        {
            AltaAdministracion aa= new AltaAdministracion();
            aa.ShowDialog();
        }

        private void botonDos_Click(object sender, System.EventArgs e)
        {
            AltaAlmacen aal= new AltaAlmacen();
            aal.ShowDialog();
        }

        private void botonTres_Click(object sender, System.EventArgs e)
        {
            Listados l= new Listados();
            l.ShowDialog();
        }

        private void botonCuatro_Click(object sender, System.EventArgs e)
        {
            BuscarCandidato bc= new BuscarCandidato();
            bc.ShowDialog();
        }
    }
}
