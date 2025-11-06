using HBergasa_RRHH.conexion;
using HBergasa_RRHH.modelo;
using HBergasa_RRHH.utilidades;
using System;
using System.Windows.Forms;

namespace HBergasa_RRHH.vistas
{
    partial class AltaAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAdministracion));
            this.panelDatosUno = new System.Windows.Forms.GroupBox();
            this.labelTelefono = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDatosDos = new System.Windows.Forms.GroupBox();
            this.comboEstudios = new System.Windows.Forms.ComboBox();
            this.grupoUno = new System.Windows.Forms.GroupBox();
            this.radioAvanzado1 = new System.Windows.Forms.RadioButton();
            this.radioMedio1 = new System.Windows.Forms.RadioButton();
            this.radioUsuario1 = new System.Windows.Forms.RadioButton();
            this.grupoDos = new System.Windows.Forms.GroupBox();
            this.radioAvanzado2 = new System.Windows.Forms.RadioButton();
            this.radioMedio2 = new System.Windows.Forms.RadioButton();
            this.radioUsuario2 = new System.Windows.Forms.RadioButton();
            this.grupoTres = new System.Windows.Forms.GroupBox();
            this.radioAvanzado3 = new System.Windows.Forms.RadioButton();
            this.radioMedio3 = new System.Windows.Forms.RadioButton();
            this.radioUsuario3 = new System.Windows.Forms.RadioButton();
            this.campoObservaciones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selector = new System.Windows.Forms.OpenFileDialog();
            this.panelDatosUno.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDatosDos.SuspendLayout();
            this.grupoUno.SuspendLayout();
            this.grupoDos.SuspendLayout();
            this.grupoTres.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDatosUno
            // 
            this.panelDatosUno.Controls.Add(this.labelTelefono);
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
            this.panelDatosUno.Location = new System.Drawing.Point(22, 80);
            this.panelDatosUno.Name = "panelDatosUno";
            this.panelDatosUno.Size = new System.Drawing.Size(496, 476);
            this.panelDatosUno.TabIndex = 0;
            this.panelDatosUno.TabStop = false;
            this.panelDatosUno.Tag = "datos personales";
            this.panelDatosUno.Text = "DATOS PERSONALES";
            this.panelDatosUno.Enter += new System.EventHandler(this.panelDatosUno_Enter);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(14, 358);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(61, 16);
            this.labelTelefono.TabIndex = 21;
            this.labelTelefono.Text = "Teléfono";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(125, 33);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(212, 22);
            this.campoNombre.TabIndex = 9;
            this.campoNombre.Tag = "nombre";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(125, 74);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(350, 22);
            this.campoApellidos.TabIndex = 10;
            this.campoApellidos.Tag = "apellidos";
            // 
            // campoDni
            // 
            this.campoDni.Location = new System.Drawing.Point(125, 122);
            this.campoDni.Name = "campoDni";
            this.campoDni.Size = new System.Drawing.Size(212, 22);
            this.campoDni.TabIndex = 11;
            this.campoDni.Tag = "DNI";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(125, 172);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(267, 22);
            this.calendario.TabIndex = 16;
            this.calendario.Tag = "fecha de nacimiento";
            // 
            // campoDireccion
            // 
            this.campoDireccion.Location = new System.Drawing.Point(125, 219);
            this.campoDireccion.Name = "campoDireccion";
            this.campoDireccion.Size = new System.Drawing.Size(350, 22);
            this.campoDireccion.TabIndex = 12;
            this.campoDireccion.Tag = "dirección";
            // 
            // campoCp
            // 
            this.campoCp.Location = new System.Drawing.Point(125, 269);
            this.campoCp.Name = "campoCp";
            this.campoCp.Size = new System.Drawing.Size(134, 22);
            this.campoCp.TabIndex = 13;
            this.campoCp.Tag = "CP";
            this.campoCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoCp_KeyPress);
            // 
            // comboLocalidad
            // 
            this.comboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocalidad.FormattingEnabled = true;
            this.comboLocalidad.Items.AddRange(new object[] {
            "Seleccione",
            "Madrid",
            "Cuenca",
            "Albacete",
            "Segovia",
            "Zaragoza"});
            this.comboLocalidad.Location = new System.Drawing.Point(125, 311);
            this.comboLocalidad.Name = "comboLocalidad";
            this.comboLocalidad.Size = new System.Drawing.Size(220, 24);
            this.comboLocalidad.TabIndex = 17;
            this.comboLocalidad.Tag = "localidad";
            // 
            // campoTelefono
            // 
            this.campoTelefono.Location = new System.Drawing.Point(125, 352);
            this.campoTelefono.Name = "campoTelefono";
            this.campoTelefono.Size = new System.Drawing.Size(166, 22);
            this.campoTelefono.TabIndex = 20;
            this.campoTelefono.Tag = "teléfono";
            this.campoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoTelefono_KeyPress);
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(125, 388);
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
            this.campoFoto.ReadOnly = true;
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
            this.botonAnexar.Click += new System.EventHandler(this.botonAnexar_Click);
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
            this.label9.Location = new System.Drawing.Point(14, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "F. de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "Telefono";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de candidatos para puestos de administración";
            // 
            // panelDatosDos
            // 
            this.panelDatosDos.Controls.Add(this.comboEstudios);
            this.panelDatosDos.Controls.Add(this.grupoUno);
            this.panelDatosDos.Controls.Add(this.grupoDos);
            this.panelDatosDos.Controls.Add(this.grupoTres);
            this.panelDatosDos.Controls.Add(this.campoObservaciones);
            this.panelDatosDos.Controls.Add(this.label13);
            this.panelDatosDos.Controls.Add(this.label12);
            this.panelDatosDos.Controls.Add(this.label11);
            this.panelDatosDos.ForeColor = System.Drawing.Color.IndianRed;
            this.panelDatosDos.Location = new System.Drawing.Point(530, 80);
            this.panelDatosDos.Name = "panelDatosDos";
            this.panelDatosDos.Size = new System.Drawing.Size(529, 476);
            this.panelDatosDos.TabIndex = 2;
            this.panelDatosDos.TabStop = false;
            this.panelDatosDos.Tag = "datos complementarios";
            this.panelDatosDos.Text = "DATOS COMPLEMENTARIOS";
            // 
            // comboEstudios
            // 
            this.comboEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstudios.FormattingEnabled = true;
            this.comboEstudios.Items.AddRange(new object[] {
            "Seleccione",
            "Eso",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
            this.comboEstudios.Location = new System.Drawing.Point(184, 44);
            this.comboEstudios.Name = "comboEstudios";
            this.comboEstudios.Size = new System.Drawing.Size(165, 24);
            this.comboEstudios.TabIndex = 2;
            this.comboEstudios.Tag = "estudios finalizados";
            // 
            // grupoUno
            // 
            this.grupoUno.Controls.Add(this.radioAvanzado1);
            this.grupoUno.Controls.Add(this.radioMedio1);
            this.grupoUno.Controls.Add(this.radioUsuario1);
            this.grupoUno.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoUno.Location = new System.Drawing.Point(52, 128);
            this.grupoUno.Name = "grupoUno";
            this.grupoUno.Size = new System.Drawing.Size(425, 67);
            this.grupoUno.TabIndex = 4;
            this.grupoUno.TabStop = false;
            this.grupoUno.Tag = "tratamiento de textos";
            this.grupoUno.Text = "Tratamiento de textos";
            // 
            // radioAvanzado1
            // 
            this.radioAvanzado1.AutoSize = true;
            this.radioAvanzado1.Location = new System.Drawing.Point(321, 30);
            this.radioAvanzado1.Name = "radioAvanzado1";
            this.radioAvanzado1.Size = new System.Drawing.Size(89, 20);
            this.radioAvanzado1.TabIndex = 2;
            this.radioAvanzado1.TabStop = true;
            this.radioAvanzado1.Tag = "avanzado";
            this.radioAvanzado1.Text = "Avanzado";
            this.radioAvanzado1.UseVisualStyleBackColor = true;
            // 
            // radioMedio1
            // 
            this.radioMedio1.AutoSize = true;
            this.radioMedio1.Location = new System.Drawing.Point(179, 31);
            this.radioMedio1.Name = "radioMedio1";
            this.radioMedio1.Size = new System.Drawing.Size(66, 20);
            this.radioMedio1.TabIndex = 1;
            this.radioMedio1.TabStop = true;
            this.radioMedio1.Tag = "medio";
            this.radioMedio1.Text = "Medio";
            this.radioMedio1.UseVisualStyleBackColor = true;
            // 
            // radioUsuario1
            // 
            this.radioUsuario1.AutoSize = true;
            this.radioUsuario1.Location = new System.Drawing.Point(28, 31);
            this.radioUsuario1.Name = "radioUsuario1";
            this.radioUsuario1.Size = new System.Drawing.Size(75, 20);
            this.radioUsuario1.TabIndex = 0;
            this.radioUsuario1.TabStop = true;
            this.radioUsuario1.Tag = "usuario";
            this.radioUsuario1.Text = "Usuario";
            this.radioUsuario1.UseVisualStyleBackColor = true;
            // 
            // grupoDos
            // 
            this.grupoDos.Controls.Add(this.radioAvanzado2);
            this.grupoDos.Controls.Add(this.radioMedio2);
            this.grupoDos.Controls.Add(this.radioUsuario2);
            this.grupoDos.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoDos.Location = new System.Drawing.Point(52, 201);
            this.grupoDos.Name = "grupoDos";
            this.grupoDos.Size = new System.Drawing.Size(425, 67);
            this.grupoDos.TabIndex = 5;
            this.grupoDos.TabStop = false;
            this.grupoDos.Tag = "hoja de cálculo";
            this.grupoDos.Text = "Hoja de cálculo";
            // 
            // radioAvanzado2
            // 
            this.radioAvanzado2.AutoSize = true;
            this.radioAvanzado2.Location = new System.Drawing.Point(321, 31);
            this.radioAvanzado2.Name = "radioAvanzado2";
            this.radioAvanzado2.Size = new System.Drawing.Size(89, 20);
            this.radioAvanzado2.TabIndex = 2;
            this.radioAvanzado2.TabStop = true;
            this.radioAvanzado2.Tag = "avanzado";
            this.radioAvanzado2.Text = "Avanzado";
            this.radioAvanzado2.UseVisualStyleBackColor = true;
            // 
            // radioMedio2
            // 
            this.radioMedio2.AutoSize = true;
            this.radioMedio2.Location = new System.Drawing.Point(179, 31);
            this.radioMedio2.Name = "radioMedio2";
            this.radioMedio2.Size = new System.Drawing.Size(66, 20);
            this.radioMedio2.TabIndex = 1;
            this.radioMedio2.TabStop = true;
            this.radioMedio2.Tag = "medio";
            this.radioMedio2.Text = "Medio";
            this.radioMedio2.UseVisualStyleBackColor = true;
            // 
            // radioUsuario2
            // 
            this.radioUsuario2.AutoSize = true;
            this.radioUsuario2.Location = new System.Drawing.Point(28, 31);
            this.radioUsuario2.Name = "radioUsuario2";
            this.radioUsuario2.Size = new System.Drawing.Size(75, 20);
            this.radioUsuario2.TabIndex = 0;
            this.radioUsuario2.TabStop = true;
            this.radioUsuario2.Tag = "usuario";
            this.radioUsuario2.Text = "Usuario";
            this.radioUsuario2.UseVisualStyleBackColor = true;
            // 
            // grupoTres
            // 
            this.grupoTres.Controls.Add(this.radioAvanzado3);
            this.grupoTres.Controls.Add(this.radioMedio3);
            this.grupoTres.Controls.Add(this.radioUsuario3);
            this.grupoTres.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoTres.Location = new System.Drawing.Point(52, 274);
            this.grupoTres.Name = "grupoTres";
            this.grupoTres.Size = new System.Drawing.Size(425, 67);
            this.grupoTres.TabIndex = 6;
            this.grupoTres.TabStop = false;
            this.grupoTres.Tag = "internet";
            this.grupoTres.Text = "Internet";
            // 
            // radioAvanzado3
            // 
            this.radioAvanzado3.AutoSize = true;
            this.radioAvanzado3.Location = new System.Drawing.Point(321, 30);
            this.radioAvanzado3.Name = "radioAvanzado3";
            this.radioAvanzado3.Size = new System.Drawing.Size(89, 20);
            this.radioAvanzado3.TabIndex = 2;
            this.radioAvanzado3.TabStop = true;
            this.radioAvanzado3.Tag = "avanzado";
            this.radioAvanzado3.Text = "Avanzado";
            this.radioAvanzado3.UseVisualStyleBackColor = true;
            // 
            // radioMedio3
            // 
            this.radioMedio3.AutoSize = true;
            this.radioMedio3.Location = new System.Drawing.Point(179, 31);
            this.radioMedio3.Name = "radioMedio3";
            this.radioMedio3.Size = new System.Drawing.Size(66, 20);
            this.radioMedio3.TabIndex = 1;
            this.radioMedio3.TabStop = true;
            this.radioMedio3.Tag = "medio";
            this.radioMedio3.Text = "Medio";
            this.radioMedio3.UseVisualStyleBackColor = true;
            // 
            // radioUsuario3
            // 
            this.radioUsuario3.AutoSize = true;
            this.radioUsuario3.Location = new System.Drawing.Point(28, 31);
            this.radioUsuario3.Name = "radioUsuario3";
            this.radioUsuario3.Size = new System.Drawing.Size(75, 20);
            this.radioUsuario3.TabIndex = 0;
            this.radioUsuario3.TabStop = true;
            this.radioUsuario3.Tag = "usuario";
            this.radioUsuario3.Text = "Usuario";
            this.radioUsuario3.UseVisualStyleBackColor = true;
            // 
            // campoObservaciones
            // 
            this.campoObservaciones.Location = new System.Drawing.Point(52, 385);
            this.campoObservaciones.Multiline = true;
            this.campoObservaciones.Name = "campoObservaciones";
            this.campoObservaciones.Size = new System.Drawing.Size(425, 73);
            this.campoObservaciones.TabIndex = 8;
            this.campoObservaciones.Tag = "observaciones";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 7;
            this.label13.Tag = "observaciones";
            this.label13.Text = "Observaciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Nivel Informática";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Estudios finalizados";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(428, 566);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(192, 38);
            this.botonRegistrar.TabIndex = 3;
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
            this.panel2.TabIndex = 4;
            // 
            // selector
            // 
            this.selector.FileName = "FileName";
            // 
            // AltaAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.panelDatosDos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDatosUno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 670);
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "AltaAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevos candidatos para puestos de Administración";
            this.panelDatosUno.ResumeLayout(false);
            this.panelDatosUno.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDatosDos.ResumeLayout(false);
            this.panelDatosDos.PerformLayout();
            this.grupoUno.ResumeLayout(false);
            this.grupoUno.PerformLayout();
            this.grupoDos.ResumeLayout(false);
            this.grupoDos.PerformLayout();
            this.grupoTres.ResumeLayout(false);
            this.grupoTres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panelDatosUno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.GroupBox panelDatosDos;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grupoUno;
        private System.Windows.Forms.RadioButton radioAvanzado1;
        private System.Windows.Forms.RadioButton radioMedio1;
        private System.Windows.Forms.RadioButton radioUsuario1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEstudios;
        private System.Windows.Forms.GroupBox grupoDos;
        private System.Windows.Forms.RadioButton radioAvanzado2;
        private System.Windows.Forms.RadioButton radioMedio2;
        private System.Windows.Forms.RadioButton radioUsuario2;
        private System.Windows.Forms.GroupBox grupoTres;
        private System.Windows.Forms.RadioButton radioAvanzado3;
        private System.Windows.Forms.RadioButton radioMedio3;
        private System.Windows.Forms.RadioButton radioUsuario3;
        private System.Windows.Forms.TextBox campoObservaciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog selector;
        private TextBox campoTelefono;
        private Label label14;


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

            string dni = campoDni.Text.Trim().ToUpper();

            if (Consultas.ComprobarDNIExiste(dni, "candidatoadministracion"))
            {
                MessageBox.Show("Ya existe un candidato de administración con este DNI",
                              "DNI duplicado",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                campoDni.Focus();
                campoDni.Text = "";
                return;
            }

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

            if (!Utilidades.ValidarRadioButtons(grupoUno))
                return;

            if (!Utilidades.ValidarRadioButtons(grupoDos))
                return;

            if (!Utilidades.ValidarRadioButtons(grupoTres))
                return;

            try
            {
                string nivelTexto = Utilidades.RecuperarValorRadios(grupoUno);
                string nivelCalculo = Utilidades.RecuperarValorRadios(grupoDos);
                string nivelInternet = Utilidades.RecuperarValorRadios(grupoTres);

                byte[] fotoBytes = Utilidades.ConvertirImagenABytes(campoFoto.Text);

                CandidatoAdministracion candidato = new CandidatoAdministracion(
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
                    nivelInformaticaCalculo: nivelCalculo,
                    nivelInformaticaTexto: nivelTexto,
                    nivelInformaticaInternet: nivelInternet
                );

                
                bool registro = Consultas.RegistrarCandidatoAdministracion(candidato);

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
                MessageBox.Show(ex.Message);
            }
        }

        private Label labelTelefono;
    }
}