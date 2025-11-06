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
    public partial class AltaAlmacen : Form
    {
        public AltaAlmacen()
        {
            InitializeComponent();
            configurarFormularios();
        }

        private void campoCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void campoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.SoloNumeros(e);
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void botonAnexar_Click_1(object sender, EventArgs e)
        {
            if (selector.ShowDialog() == DialogResult.OK)
            {
                campoFoto.Text = selector.FileName;
            }
        }
    }
}
