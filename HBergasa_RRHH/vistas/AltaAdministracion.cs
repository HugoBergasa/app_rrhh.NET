using HBergasa_RRHH.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_RRHH.vistas
{
    public partial class AltaAdministracion : Form
    {
        public AltaAdministracion()
        {
            InitializeComponent();
            configurarFormularios();
        }

        private void botonAnexar_Click(object sender, EventArgs e)
        {
            if (selector.ShowDialog() == DialogResult.OK)
            {
                campoFoto.Text = selector.FileName;
            }
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void campoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void campoCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);

        }

        private void panelDatosUno_Enter(object sender, EventArgs e)
        {

        }
    }
}
