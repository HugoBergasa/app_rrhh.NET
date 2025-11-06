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
    public partial class BuscarCandidato : Form
    {
        public BuscarCandidato()
        {
            InitializeComponent();
            comboTIpo.SelectedIndex = 0;
        }

        private void comboTIpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarDni();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            buscarDni();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarCandidato();
        }

        private void botonEnviarEmail_Click(object sender, EventArgs e)
        {
            EnviarMail();
        }
    }
}
