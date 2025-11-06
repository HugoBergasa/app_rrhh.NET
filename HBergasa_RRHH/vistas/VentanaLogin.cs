using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_RRHH
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void botonAcceder_Click(object sender, EventArgs e)
        {
            
            entrar();
        }

        private void campoUsuario_Enter(object sender, EventArgs e)
        {
            imagenUsu.Visible = true;
        }

        private void campoUsuario_Leave(object sender, EventArgs e)
        {
            imagenUsu.Visible=false;
        }

        private void campoPass_Enter(object sender, EventArgs e)
        {
            imagenPass.Visible = true;
        }

        private void campoPass_Leave(object sender, EventArgs e)
        {
            imagenPass.Visible=false;
        }
    }
}
