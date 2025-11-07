using HBergasa_RRHH.conexion;
using HBergasa_RRHH.modelo;
using HBergasa_RRHH.utilidades;
using Spire.Xls;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HBergasa_RRHH.vistas
{
    partial class BuscarCandidato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarCandidato));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTIpo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.panelDatosUno = new System.Windows.Forms.GroupBox();
            this.campoFecha = new System.Windows.Forms.TextBox();
            this.campoLocalidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.fotoCandidato = new System.Windows.Forms.PictureBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoCp = new System.Windows.Forms.TextBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoFechaAlta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonEnviarEmail = new System.Windows.Forms.Button();
            this.botonPdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDatosUno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda de Candidatos";
            // 
            // comboTIpo
            // 
            this.comboTIpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTIpo.FormattingEnabled = true;
            this.comboTIpo.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Almacén"});
            this.comboTIpo.Location = new System.Drawing.Point(152, 65);
            this.comboTIpo.Name = "comboTIpo";
            this.comboTIpo.Size = new System.Drawing.Size(178, 24);
            this.comboTIpo.TabIndex = 9;
            this.comboTIpo.Tag = "Tipo de candidatos";
            this.comboTIpo.SelectedIndexChanged += new System.EventHandler(this.comboTIpo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de candidatos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(109, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "DNI";
            // 
            // campoDni
            // 
            this.campoDni.Enabled = false;
            this.campoDni.Location = new System.Drawing.Point(152, 99);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(178, 22);
            this.campoDni.TabIndex = 11;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Enabled = false;
            this.botonBuscar.Location = new System.Drawing.Point(362, 98);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(99, 32);
            this.botonBuscar.TabIndex = 12;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // panelDatosUno
            // 
            this.panelDatosUno.Controls.Add(this.campoFecha);
            this.panelDatosUno.Controls.Add(this.campoLocalidad);
            this.panelDatosUno.Controls.Add(this.label13);
            this.panelDatosUno.Controls.Add(this.fotoCandidato);
            this.panelDatosUno.Controls.Add(this.labelTelefono);
            this.panelDatosUno.Controls.Add(this.campoNombre);
            this.panelDatosUno.Controls.Add(this.campoApellidos);
            this.panelDatosUno.Controls.Add(this.campoDireccion);
            this.panelDatosUno.Controls.Add(this.campoCp);
            this.panelDatosUno.Controls.Add(this.campoTelefono);
            this.panelDatosUno.Controls.Add(this.campoEmail);
            this.panelDatosUno.Controls.Add(this.campoFechaAlta);
            this.panelDatosUno.Controls.Add(this.label10);
            this.panelDatosUno.Controls.Add(this.label9);
            this.panelDatosUno.Controls.Add(this.label8);
            this.panelDatosUno.Controls.Add(this.label7);
            this.panelDatosUno.Controls.Add(this.label6);
            this.panelDatosUno.Controls.Add(this.label5);
            this.panelDatosUno.Controls.Add(this.label11);
            this.panelDatosUno.Controls.Add(this.label12);
            this.panelDatosUno.ForeColor = System.Drawing.Color.IndianRed;
            this.panelDatosUno.Location = new System.Drawing.Point(98, 141);
            this.panelDatosUno.Name = "panelDatosUno";
            this.panelDatosUno.Size = new System.Drawing.Size(924, 412);
            this.panelDatosUno.TabIndex = 13;
            this.panelDatosUno.TabStop = false;
            this.panelDatosUno.Tag = "datos personales";
            this.panelDatosUno.Text = "DATOS PERSONALES";
            // 
            // campoFecha
            // 
            this.campoFecha.Location = new System.Drawing.Point(125, 103);
            this.campoFecha.Name = "campoFecha";
            this.campoFecha.ReadOnly = true;
            this.campoFecha.Size = new System.Drawing.Size(265, 22);
            this.campoFecha.TabIndex = 25;
            this.campoFecha.Tag = "DNI";
            // 
            // campoLocalidad
            // 
            this.campoLocalidad.Location = new System.Drawing.Point(125, 221);
            this.campoLocalidad.Name = "campoLocalidad";
            this.campoLocalidad.ReadOnly = true;
            this.campoLocalidad.Size = new System.Drawing.Size(166, 22);
            this.campoLocalidad.TabIndex = 24;
            this.campoLocalidad.Tag = "teléfono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(666, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Foto";
            // 
            // fotoCandidato
            // 
            this.fotoCandidato.Location = new System.Drawing.Point(669, 94);
            this.fotoCandidato.Name = "fotoCandidato";
            this.fotoCandidato.Size = new System.Drawing.Size(191, 224);
            this.fotoCandidato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoCandidato.TabIndex = 22;
            this.fotoCandidato.TabStop = false;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(14, 264);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(61, 16);
            this.labelTelefono.TabIndex = 21;
            this.labelTelefono.Text = "Teléfono";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(125, 30);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.ReadOnly = true;
            this.campoNombre.Size = new System.Drawing.Size(212, 22);
            this.campoNombre.TabIndex = 9;
            this.campoNombre.Tag = "nombre";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(125, 66);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.ReadOnly = true;
            this.campoApellidos.Size = new System.Drawing.Size(350, 22);
            this.campoApellidos.TabIndex = 10;
            this.campoApellidos.Tag = "apellidos";
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(125, 142);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.ReadOnly = true;
            this.campoDireccion.Size = new System.Drawing.Size(350, 22);
            this.campoDireccion.TabIndex = 12;
            this.campoDireccion.Tag = "dirección";
            // 
            // campoCp
            // 
            this.campoCp.Location = new System.Drawing.Point(125, 184);
            this.campoCp.Name = "campoCp";
            this.campoCp.ReadOnly = true;
            this.campoCp.Size = new System.Drawing.Size(134, 22);
            this.campoCp.TabIndex = 13;
            this.campoCp.Tag = "CP";
            // 
            // campoTelefono
            // 
            this.campoTelefono.Location = new System.Drawing.Point(125, 258);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.ReadOnly = true;
            this.campoTelefono.Size = new System.Drawing.Size(166, 22);
            this.campoTelefono.TabIndex = 20;
            this.campoTelefono.Tag = "teléfono";
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(125, 292);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.ReadOnly = true;
            this.campoEmail.Size = new System.Drawing.Size(220, 22);
            this.campoEmail.TabIndex = 14;
            this.campoEmail.Tag = "email";
            // 
            // campoFechaAlta
            // 
            this.campoFechaAlta.Location = new System.Drawing.Point(125, 332);
            this.campoFechaAlta.Name = "campoFechaAlta";
            this.campoFechaAlta.ReadOnly = true;
            this.campoFechaAlta.Size = new System.Drawing.Size(332, 22);
            this.campoFechaAlta.TabIndex = 15;
            this.campoFechaAlta.Tag = "fecha de alta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Fecha de alta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "F. de nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Apellidos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nombre";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Enabled = false;
            this.botonEliminar.Location = new System.Drawing.Point(206, 575);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(99, 32);
            this.botonEliminar.TabIndex = 14;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonEnviarEmail
            // 
            this.botonEnviarEmail.Enabled = false;
            this.botonEnviarEmail.Location = new System.Drawing.Point(491, 575);
            this.botonEnviarEmail.Name = "botonEnviarEmail";
            this.botonEnviarEmail.Size = new System.Drawing.Size(141, 32);
            this.botonEnviarEmail.TabIndex = 15;
            this.botonEnviarEmail.Text = "Enviar Email";
            this.botonEnviarEmail.UseVisualStyleBackColor = true;
            this.botonEnviarEmail.Click += new System.EventHandler(this.botonEnviarEmail_Click);
            // 
            // botonPdf
            // 
            this.botonPdf.Enabled = false;
            this.botonPdf.Location = new System.Drawing.Point(757, 575);
            this.botonPdf.Name = "botonPdf";
            this.botonPdf.Size = new System.Drawing.Size(146, 32);
            this.botonPdf.TabIndex = 16;
            this.botonPdf.Text = "Ficha PDF";
            this.botonPdf.UseVisualStyleBackColor = true;
            this.botonPdf.Click += new System.EventHandler(this.botonPdf_Click);
            // 
            // BuscarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 623);
            this.Controls.Add(this.botonPdf);
            this.Controls.Add(this.botonEnviarEmail);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.panelDatosUno);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.campoDni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboTIpo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 670);
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "BuscarCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Candidatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatosUno.ResumeLayout(false);
            this.panelDatosUno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTIpo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoDni;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.GroupBox panelDatosUno;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.TextBox campoCp;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox campoLocalidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox fotoCandidato;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonEnviarEmail;
        private System.Windows.Forms.Button botonPdf;
        private System.Windows.Forms.TextBox campoFecha;

        private CandidatoAdministracion candidatoAdmin;
        private CandidatoAlmacen candidatoAlmacen;
        private string tipoCandidatoActual;

        public static string emailCandidato;



        private void buscarDni()
        {
            string dni = campoDni.Text.Trim().ToUpper();

            LimpiarFormulario();
            candidatoAdmin = null;
            candidatoAlmacen = null;

            if (tipoCandidatoActual == "Administración")
            {
                BuscarCandidatoAdministracion(dni,candidatoAdmin);
            }
            else if (tipoCandidatoActual == "Almacén")
            {
                BuscarCandidatoAlmacen(dni,candidatoAlmacen);
            }
        }

        private void BuscarCandidatoAdministracion(string dni, CandidatoAdministracion candidato)
        {
            candidatoAdmin = Consultas.BuscarCandidatoAdmin(dni);

            if (candidatoAdmin != null)
            {
                campoNombre.Text = candidatoAdmin.Nombre ?? "";
                campoApellidos.Text = candidatoAdmin.Apellidos ?? "";
                campoFecha.Text = candidatoAdmin.FechaNacimiento.ToString("dd/MM/yyyy");
                campoDireccion.Text = candidatoAdmin.Direccion ?? "";
                campoCp.Text = candidatoAdmin.Cp.ToString();
                campoLocalidad.Text = candidatoAdmin.Localidad ?? "";
                campoTelefono.Text = candidatoAdmin.Telefono.ToString();
                campoEmail.Text = candidatoAdmin.Email ?? "";
                campoFechaAlta.Text = candidatoAdmin.FechaAlta.ToString("dd/MM/yyyy");

                if (candidatoAdmin.Foto != null && candidatoAdmin.Foto.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(candidatoAdmin.Foto))
                    {
                        fotoCandidato.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                ActivarBotonesAccion();
            }
            else
            {
                MessageBox.Show("No se encontró ningún candidato de Administración con ese DNI",
                    "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarCandidatoAlmacen(string dni, CandidatoAlmacen candidato)
        {
            candidatoAlmacen = Consultas.BuscarCandidatoAlmacen(dni);

            if (candidatoAlmacen != null)
            {
                campoNombre.Text = candidatoAlmacen.Nombre ?? "";
                campoApellidos.Text = candidatoAlmacen.Apellidos ?? "";
                campoFecha.Text = candidatoAlmacen.FechaNacimiento.ToString("dd/MM/yyyy");
                campoDireccion.Text = candidatoAlmacen.Direccion ?? "";
                campoCp.Text = candidatoAlmacen.Cp.ToString();
                campoLocalidad.Text = candidatoAlmacen.Localidad ?? "";
                campoTelefono.Text = candidatoAlmacen.Telefono.ToString();
                campoEmail.Text = candidatoAlmacen.Email ?? "";
                campoFechaAlta.Text = candidatoAlmacen.FechaAlta.ToString("dd/MM/yyyy");

                if (candidatoAlmacen.Foto != null && candidatoAlmacen.Foto.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(candidatoAlmacen.Foto))
                        fotoCandidato.Image = System.Drawing.Image.FromStream(ms);
                }
                ActivarBotonesAccion();
            }
            else
            {
                MessageBox.Show("No se encontró ningún candidato de Almacén con ese DNI",
                    "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EliminarCandidato()
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el candidato de la base de datos?", "Eliminación de candidatos",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string tabla = tipoCandidatoActual == "Administración" ?
                    "candidatoadministracion" : "candidatoalmacen";

                string dni = campoDni.Text.Trim();

                bool eliminado = Consultas.EliminarCandidato(dni, tabla);

                if (eliminado)
                {
                    MessageBox.Show("Candidato eliminado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    campoDni.Text="";
                    candidatoAdmin = null;
                    candidatoAlmacen = null;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el candidato", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EnviarMail()
        {
            BuscarCandidato.emailCandidato = campoEmail.Text.Trim();
            DatosMensaje dm = new DatosMensaje();
            dm.ShowDialog();
        }

        private void ActivarDni()
        {
            if (comboTIpo.SelectedIndex > 0)
            {
                campoDni.Enabled = true;
                botonBuscar.Enabled = true;
                tipoCandidatoActual = comboTIpo.SelectedItem.ToString();
                LimpiarFormulario();
            }
            else
            {
                campoDni.Enabled = false;
                botonBuscar.Enabled = false;
                LimpiarFormulario();
            }
        }
        private void ActivarBotonesAccion()
        {
            botonEliminar.Enabled = true;
            botonEnviarEmail.Enabled = true;
            botonPdf.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            campoNombre.Clear();
            campoApellidos.Clear();
            campoFecha.Clear();
            campoDireccion.Clear();
            campoCp.Clear();
            campoLocalidad.Clear();
            campoTelefono.Clear();
            campoEmail.Clear();
            campoFechaAlta.Clear();
            fotoCandidato.Image = null;

            botonEliminar.Enabled = false;
            botonEnviarEmail.Enabled = false;
            botonPdf.Enabled = false;
        }

        private TextBox campoFechaAlta;
        private Label label10;
    }
}