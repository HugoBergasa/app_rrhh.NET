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
    public partial class Listados : Form
    {
        public Listados()
        {
            InitializeComponent();
            configurarCuestionario();

        }

        private void comboTIpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestionComboTipo();

        }

        private void botonMostrarUno_Click(object sender, EventArgs e)
        {
            muestraCandidatosAdmin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            muestraCandidatosAlmacen();
        }

        private void radioFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            gestionCheckBox();
        }

        private void exportarExcel_Click(object sender, EventArgs e)
        {
            exportar();
        }
    }
}
