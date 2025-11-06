using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBergasa_RRHH.utilidades
{
    internal class Utilidades
    {
        // VALIDACIÓN PRINCIPAL DEL GROUPBOX

        public static bool ValidarForm(GroupBox grupo)
        {
            foreach (Control control in grupo.Controls)
            {
                if (control is TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.BackColor = Color.Red;
                        MessageBox.Show($"El campo '{control.Tag}' es obligatorio",
                                       "Campo vacío",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                        txt.Focus();
                        return false;
                    }
                }
                else if (control is ComboBox combo)
                {
                    if (combo.SelectedIndex == -1 || combo.SelectedIndex == 0)
                    {
                        combo.BackColor = Color.Red;
                        MessageBox.Show($"Debe seleccionar una opción en '{control.Tag}'",
                                       "Selección requerida",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Warning);
                        combo.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        //RESETEAR LOS FORMULARIOS
        public static void ResetearFormulario(GroupBox grupo)
        {
            foreach (Control control in grupo.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Clear();
                    txt.BackColor = Color.White;
                }
                else if (control is ComboBox combo)
                {
                    combo.SelectedIndex = 0;
                    combo.BackColor = Color.White;
                }
                else if (control is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now.AddYears(-18);
                }
                else if (control is RadioButton radio)
                {
                    radio.Checked = false;
                }
                else if (control is CheckBox chk)
                {
                    chk.Checked = false;
                }
                else if (control is PictureBox pic)
                {
                    pic.Image = null;
                }
            }
        }

        //VALIDACIÓNES DE LAS FOTOS
        public static bool ValidarFoto(string rutaArchivo)
        {
            string extension = System.IO.Path.GetExtension(rutaArchivo).ToLower();
            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
            {
                MessageBox.Show("Solo se permiten archivos .jpg o .png", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(rutaArchivo);
            if (fileInfo.Length > 2000000)
            {
                MessageBox.Show("El archivo no puede superar los 2MB", "Archivo muy grande", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static byte[] ConvertirImagenABytes(string rutaArchivo)
        {
            if (!System.IO.File.Exists(rutaArchivo))
                return null;

            return System.IO.File.ReadAllBytes(rutaArchivo);
        }


        // CONFIGURACIÓN DE EVENTOS DE FOCO

        public static void Foco(GroupBox grupo)
        {
            foreach (Control control in grupo.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.GotFocus += (s, e) => txt.BackColor = Color.White;
                }
                else if (control is ComboBox combo)
                {
                    combo.GotFocus += (s, e) => combo.BackColor = Color.White;
                }
            }
        }



        /// Validación de DNI
        public static bool ValidarDNI(TextBox txtDni)
        {
            string dni = txtDni.Text.Trim().ToUpper();

            if (dni.Length != 9)
            {
                txtDni.BackColor = Color.Red;
                MessageBox.Show("El DNI debe tener 9 caracteres (8 números + letra)",
                               "DNI inválido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }

            if (!int.TryParse(dni.Substring(0, 8), out int numero))
            {
                txtDni.BackColor = Color.Red;
                MessageBox.Show("Los primeros 8 caracteres del DNI deben ser números",
                               "DNI inválido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }

            char letraIngresada = dni[8];
            string letrasValidas = "TRWAGMYFPDXBNJZSQVHLCKE";
            char letraCorrecta = letrasValidas[numero % 23];

            if (letraIngresada != letraCorrecta)
            {
                txtDni.BackColor = Color.Red;
                MessageBox.Show($"La letra del DNI no es correcta.{Environment.NewLine}Letra correcta: {letraCorrecta}",
                               "DNI inválido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }

            return true;
        }

        /// Validación de teléfono
        public static bool ValidarTelefono(TextBox txtTelefono)
        {
            string expresion = @"^(\+34|0034)?[6-9]\d{8}$";

            if (!Regex.IsMatch(txtTelefono.Text.Trim(), expresion))
            {
                txtTelefono.BackColor = Color.Red;
                MessageBox.Show("El número de teléfono no tiene un formato válido.",
                               "Teléfono inválido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }

            return true;
        }

        /// Validación de email
        public static bool ValidarEmail(TextBox txtEmail)
        {
            string expresion = @"^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(txtEmail.Text.Trim(), expresion))
            {
                txtEmail.BackColor = Color.Red;
                MessageBox.Show("El correo electrónico no tiene un formato válido",
                               "Email inválido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        /// Validación de código postal
        public static bool ValidarCodigoPostal(TextBox txtCp)
        {
            string expresion = @"^\d{5}$";

            if (!Regex.IsMatch(txtCp.Text.Trim(), expresion))
            {
                txtCp.BackColor = Color.Red;
                MessageBox.Show("El código postal debe tener 5 dígitos",
                               "Código postal inválido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtCp.Focus();
                return false;
            }

            return true;
        }

        /// Validación de fecha de nacimiento para que tenga que ser mayor de edad.
        public static bool ValidarFechaNacimiento(DateTimePicker calendario, int edadMinima = 18)
        {
            DateTime fechaNacimiento = calendario.Value.Date;
            DateTime hoy = DateTime.Today;

            if (fechaNacimiento >= hoy)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser hoy o una fecha futura",
                               "Fecha inválida",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                calendario.Focus();
                return false;
            }

            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento > hoy.AddYears(-edad)) edad--;

            if (edad < edadMinima)
            {
                MessageBox.Show($"El candidato debe tener al menos {edadMinima} años",
                               "Edad insuficiente",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                calendario.Focus();
                return false;
            }

            return true;
        }

        //MÉTODOS PARA VALIDAR LOS RADIOBUTTONS
        public static bool ValidarRadioButtons(GroupBox grupo)
        {
            foreach (Control control in grupo.Controls)
            {
                if (control is RadioButton radio && radio.Checked)
                {
                    return true;
                }
            }

            MessageBox.Show($"Debe seleccionar una opción en '{grupo.Tag ?? grupo.Text}'",
                           "Selección requerida",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
            return false;
        }
        public static string RecuperarValorRadios(GroupBox grupo)
        {
            foreach (Control control in grupo.Controls)
            {
                if (control is RadioButton radio && radio.Checked)
                {
                    return radio.Tag?.ToString() ?? "";
                }
            }
            return "";
        }

        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Solo se permiten números",
                               "Entrada inválida",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }
        }

        //DEVOLUCIÓN DE CHECKBOX
        public static string CheckBoxATexto(CheckBox chk)
        {
            return chk.Checked ? "SI" : "NO";
        }
    }
}
