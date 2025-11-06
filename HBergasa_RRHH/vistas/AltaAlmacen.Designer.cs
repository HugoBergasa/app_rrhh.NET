using HBergasa_RRHH.conexion;
using HBergasa_RRHH.modelo;
using HBergasa_RRHH.utilidades;
using System;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace HBergasa_RRHH.vistas
{
    partial class AltaAlmacen
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDatosUno = new System.Windows.Forms.GroupBox();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoDni = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.campoDireccion = new System.Windows.Forms.TextBox();
            this.campoCp = new System.Windows.Forms.TextBox();
            this.comboLocalidad = new System.Windows.Forms.ComboBox();
            this.campoTelefono = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoFoto = new System.Windows.Forms.TextBox();
            this.botonAnexar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDatosDos = new System.Windows.Forms.GroupBox();
            this.comboEstudios = new System.Windows.Forms.ComboBox();
            this.grupoUno = new System.Windows.Forms.GroupBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.checkUno = new System.Windows.Forms.CheckBox();
            this.campoObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selector = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panelDatosUno.SuspendLayout();
            this.panelDatosDos.SuspendLayout();
            this.grupoUno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de candidatos para puestos de almacén";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 61);
            this.panel1.TabIndex = 2;
            // 
            // panelDatosUno
            // 
            this.panelDatosUno.Controls.Add(this.campoNombre);
            this.panelDatosUno.Controls.Add(this.campoApellidos);
            this.panelDatosUno.Controls.Add(this.campoDni);
            this.panelDatosUno.Controls.Add(this.calendario);
            this.panelDatosUno.Controls.Add(this.campoDireccion);
            this.panelDatosUno.Controls.Add(this.campoCp);
            this.panelDatosUno.Controls.Add(this.comboLocalidad);
            this.panelDatosUno.Controls.Add(this.campoTelefono);
            this.panelDatosUno.Controls.Add(this.campoEmail);
            this.panelDatosUno.Controls.Add(this.campoFoto);
            this.panelDatosUno.Controls.Add(this.botonAnexar);
            this.panelDatosUno.Controls.Add(this.label13);
            this.panelDatosUno.Controls.Add(this.label10);
            this.panelDatosUno.Controls.Add(this.label9);
            this.panelDatosUno.Controls.Add(this.label8);
            this.panelDatosUno.Controls.Add(this.label7);
            this.panelDatosUno.Controls.Add(this.label6);
            this.panelDatosUno.Controls.Add(this.label5);
            this.panelDatosUno.Controls.Add(this.label4);
            this.panelDatosUno.Controls.Add(this.label3);
            this.panelDatosUno.Controls.Add(this.label2);
            this.panelDatosUno.ForeColor = System.Drawing.Color.IndianRed;
            this.panelDatosUno.Location = new System.Drawing.Point(21, 78);
            this.panelDatosUno.Name = "panelDatosUno";
            this.panelDatosUno.Size = new System.Drawing.Size(496, 476);
            this.panelDatosUno.TabIndex = 3;
            this.panelDatosUno.TabStop = false;
            this.panelDatosUno.Text = "DATOS PERSONALES";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(125, 21);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(212, 22);
            this.campoNombre.TabIndex = 9;
            this.campoNombre.Tag = "nombre";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(125, 70);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(350, 22);
            this.campoApellidos.TabIndex = 10;
            this.campoApellidos.Tag = "apellidos";
            // 
            // campoDni
            // 
            this.campoDni.Location = new System.Drawing.Point(125, 120);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(212, 22);
            this.campoDni.TabIndex = 11;
            this.campoDni.Tag = "DNI";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(125, 170);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(267, 22);
            this.calendario.TabIndex = 16;
            this.calendario.Tag = "fecha de nacimiento";
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(125, 217);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(350, 22);
            this.campoDireccion.TabIndex = 12;
            this.campoDireccion.Tag = "dirección";
            // 
            // campoCp
            // 
            this.campoCp.Location = new System.Drawing.Point(125, 267);
            this.campoCp.Name = "campoCp";
            this.campoCp.Size = new System.Drawing.Size(134, 22);
            this.campoCp.TabIndex = 13;
            this.campoCp.Tag = "CP";
            this.campoCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoCp_KeyPress);
            // 
            // comboLocalidad
            // 
            this.comboLocalidad.FormattingEnabled = true;
            this.comboLocalidad.Items.AddRange(new object[] {
            "Seleccione",
            "Madrid",
            "Cuenca",
            "Albacete",
            "Segovia",
            "Zaragoza"});
            this.comboLocalidad.Location = new System.Drawing.Point(125, 314);
            this.comboLocalidad.Name = "comboLocalidad";
            this.comboLocalidad.Size = new System.Drawing.Size(220, 24);
            this.comboLocalidad.TabIndex = 17;
            this.comboLocalidad.Tag = "localidad";
            // 
            // campoTelefono
            // 
            this.campoTelefono.Location = new System.Drawing.Point(125, 355);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(153, 22);
            this.campoTelefono.TabIndex = 20;
            this.campoTelefono.Tag = "teléfono";
            this.campoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoTelefono_KeyPress);
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(125, 393);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(220, 22);
            this.campoEmail.TabIndex = 14;
            this.campoEmail.Tag = "email";
            // 
            // campoFoto
            // 
            this.campoFoto.Enabled = false;
            this.campoFoto.Location = new System.Drawing.Point(221, 432);
            this.campoFoto.Name = "campoFoto";
            this.campoFoto.Size = new System.Drawing.Size(236, 22);
            this.campoFoto.TabIndex = 15;
            this.campoFoto.Tag = "foto";
            // 
            // botonAnexar
            // 
            this.botonAnexar.Location = new System.Drawing.Point(107, 428);
            this.botonAnexar.Name = "botonAnexar";
            this.botonAnexar.Size = new System.Drawing.Size(100, 30);
            this.botonAnexar.TabIndex = 18;
            this.botonAnexar.Text = "Anexar foto";
            this.botonAnexar.UseVisualStyleBackColor = true;
            this.botonAnexar.Click += new System.EventHandler(this.botonAnexar_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Teléfono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Foto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "F. de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // panelDatosDos
            // 
            this.panelDatosDos.Controls.Add(this.comboEstudios);
            this.panelDatosDos.Controls.Add(this.grupoUno);
            this.panelDatosDos.Controls.Add(this.campoObservaciones);
            this.panelDatosDos.Controls.Add(this.label12);
            this.panelDatosDos.Controls.Add(this.label11);
            this.panelDatosDos.Controls.Add(this.label14);
            this.panelDatosDos.ForeColor = System.Drawing.Color.IndianRed;
            this.panelDatosDos.Location = new System.Drawing.Point(531, 78);
            this.panelDatosDos.Name = "panelDatosDos";
            this.panelDatosDos.Size = new System.Drawing.Size(529, 476);
            this.panelDatosDos.TabIndex = 4;
            this.panelDatosDos.TabStop = false;
            this.panelDatosDos.Text = "DATOS COMPLEMENTARIOS";
            // 
            // comboEstudios
            // 
            this.comboEstudios.FormattingEnabled = true;
            this.comboEstudios.Items.AddRange(new object[] {
            "Seleccione",
            "Eso",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
            this.comboEstudios.Location = new System.Drawing.Point(171, 34);
            this.comboEstudios.Name = "comboEstudios";
            this.comboEstudios.Size = new System.Drawing.Size(181, 24);
            this.comboEstudios.TabIndex = 2;
            this.comboEstudios.Tag = "estudios finalizados";
            // 
            // grupoUno
            // 
            this.grupoUno.Controls.Add(this.check3);
            this.grupoUno.Controls.Add(this.check2);
            this.grupoUno.Controls.Add(this.checkUno);
            this.grupoUno.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoUno.Location = new System.Drawing.Point(45, 123);
            this.grupoUno.Name = "grupoUno";
            this.grupoUno.Size = new System.Drawing.Size(422, 156);
            this.grupoUno.TabIndex = 3;
            this.grupoUno.TabStop = false;
            this.grupoUno.Text = "CARNETS";
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(138, 115);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(134, 20);
            this.check3.TabIndex = 2;
            this.check3.Tag = "carnet de camión";
            this.check3.Text = "Carnet de camión";
            this.check3.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(138, 70);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(141, 20);
            this.check2.TabIndex = 1;
            this.check2.Tag = "carnet de carretilla";
            this.check2.Text = "Carnet de carretilla";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // checkUno
            // 
            this.checkUno.AutoSize = true;
            this.checkUno.Location = new System.Drawing.Point(138, 27);
            this.checkUno.Name = "checkUno";
            this.checkUno.Size = new System.Drawing.Size(141, 20);
            this.checkUno.TabIndex = 0;
            this.checkUno.Tag = "carnet de conducir";
            this.checkUno.Text = "Carnet de conducir";
            this.checkUno.UseVisualStyleBackColor = true;
            // 
            // campoObservaciones
            // 
            this.campoObservaciones.Location = new System.Drawing.Point(42, 353);
            this.campoObservaciones.Multiline = true;
            this.campoObservaciones.Name = "campoObservaciones";
            this.campoObservaciones.Size = new System.Drawing.Size(425, 73);
            this.campoObservaciones.TabIndex = 10;
            this.campoObservaciones.Tag = "observaciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Estudios finalizados";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Observaciones";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(427, 567);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(192, 38);
            this.botonRegistrar.TabIndex = 5;
            this.botonRegistrar.Text = "REGISTRAR";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 10);
            this.panel2.TabIndex = 6;
            // 
            // selector
            // 
            this.selector.FileName = "FileName";
            // 
            // AltaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.panelDatosDos);
            this.Controls.Add(this.panelDatosUno);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 670);
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "AltaAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevos candidatos para puestos de Almacén";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatosUno.ResumeLayout(false);
            this.panelDatosUno.PerformLayout();
            this.panelDatosDos.ResumeLayout(false);
            this.panelDatosDos.PerformLayout();
            this.grupoUno.ResumeLayout(false);
            this.grupoUno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox panelDatosUno;
        private System.Windows.Forms.Button botonAnexar;
        private System.Windows.Forms.ComboBox comboLocalidad;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.TextBox campoFoto;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoCp;
        private System.Windows.Forms.TextBox campoDireccion;
        private System.Windows.Forms.TextBox campoDni;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox panelDatosDos;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboEstudios;
        private System.Windows.Forms.TextBox campoTelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grupoUno;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox checkUno;
        private System.Windows.Forms.TextBox campoObservaciones;
        private System.Windows.Forms.Label label14;


        private void configurarFormularios()
        {
            comboLocalidad.SelectedIndex = 0;
            comboEstudios.SelectedIndex = 0;
            Utilidades.Foco(panelDatosUno);
            Utilidades.Foco(panelDatosDos);
            calendario.Value = DateTime.Now.AddYears(-18);

        }

        private void registrar()
        {
            if (!Utilidades.ValidarForm(panelDatosUno))
                return;

            if (!Utilidades.ValidarForm(panelDatosDos))
                return;

            if (!Utilidades.ValidarDNI(campoDni))
                return;

            if (!Utilidades.ValidarCodigoPostal(campoCp))
                return;

            if (!Utilidades.ValidarTelefono(campoTelefono))
                return;

            if (!Utilidades.ValidarEmail(campoEmail))
                return;

            if (!Utilidades.ValidarFechaNacimiento(calendario, 18))
                return;

            if (string.IsNullOrEmpty(campoFoto.Text))
            {
                MessageBox.Show("Debe seleccionar una foto",
                              "Campo obligatorio",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                botonAnexar.Focus();
                return;
            }

            try
            {
                string carnetConducir = Utilidades.CheckBoxATexto(checkUno);
                string carnetCarretilla = Utilidades.CheckBoxATexto(check2);
                string carnetCamion = Utilidades.CheckBoxATexto(check3);

                byte[] fotoBytes = Utilidades.ConvertirImagenABytes(campoFoto.Text);

                CandidatoAlmacen candidato = new CandidatoAlmacen(
                    apellidos: campoApellidos.Text,
                    cp: int.Parse(campoCp.Text),
                    direccion: campoDireccion.Text,
                    dni: campoDni.Text.Trim().ToUpper(),
                    email: campoEmail.Text.Trim(),
                    estudiosFinalizados: comboEstudios.SelectedItem.ToString(),
                    fechaAlta: DateTime.Now,
                    fechaNacimiento: calendario.Value,
                    foto: fotoBytes,
                    localidad: comboLocalidad.SelectedItem.ToString(),
                    nombre: campoNombre.Text,
                    observaciones: campoObservaciones.Text,
                    telefono: int.Parse(campoTelefono.Text.Trim()),
                    usuariosRegistrador: VentanaLogin.registrador,
                    carnetConducir: carnetConducir,
                    carnetCarretilla: carnetCarretilla,
                    carnetCamion: carnetCamion
                );

                if (!Consultas.ComprobarDNIExiste(candidato.Dni, "candidatoalmacen"))
                {
                    MessageBox.Show("Ya existe un candidato de almacén con este DNI",
                                  "DNI duplicado",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    campoDni.Focus();
                    return;
                }

                bool registro = Consultas.RegistrarCandidatoAlmacen(candidato);

                if (registro)
                {
                    MessageBox.Show("Candidato registrado correctamente",
                                  "Registro exitoso",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    Utilidades.ResetearFormulario(panelDatosUno);
                    Utilidades.ResetearFormulario(panelDatosDos);
                }
                else
                {
                    MessageBox.Show("Error al registrar el candidato",
                                  "Error de registro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);

                    Utilidades.ResetearFormulario(panelDatosUno);
                    Utilidades.ResetearFormulario(panelDatosDos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private OpenFileDialog selector;
    }
}
    
