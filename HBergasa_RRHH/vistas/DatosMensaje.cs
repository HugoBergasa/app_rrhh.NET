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
    public partial class DatosMensaje : Form
    {
        public DatosMensaje()
        {
            InitializeComponent();
            ConfigurarVentana();
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {
            EnviarCorreo();
        }
    }
}
