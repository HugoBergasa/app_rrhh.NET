using HBergasa_RRHH.conexion;
using HBergasa_RRHH.utilidades;
using Spire.Xls;
using System;
using System.Data;
using System.Windows.Forms;

namespace HBergasa_RRHH.vistas
{
    partial class Listados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTIpo = new System.Windows.Forms.ComboBox();
            this.filtroAdmin = new System.Windows.Forms.GroupBox();
            this.botonMostrarUno = new System.Windows.Forms.Button();
            this.comboEstudiosUno = new System.Windows.Forms.ComboBox();
            this.grupoUno = new System.Windows.Forms.GroupBox();
            this.radioTodosUno = new System.Windows.Forms.RadioButton();
            this.radioAvanzado1 = new System.Windows.Forms.RadioButton();
            this.radioMedio1 = new System.Windows.Forms.RadioButton();
            this.radioUsuario1 = new System.Windows.Forms.RadioButton();
            this.grupoDos = new System.Windows.Forms.GroupBox();
            this.radioTodosDos = new System.Windows.Forms.RadioButton();
            this.radioAvanzado2 = new System.Windows.Forms.RadioButton();
            this.radioMedio2 = new System.Windows.Forms.RadioButton();
            this.radioUsuario2 = new System.Windows.Forms.RadioButton();
            this.grupoTres = new System.Windows.Forms.GroupBox();
            this.radioTodosTres = new System.Windows.Forms.RadioButton();
            this.radioAvanzado3 = new System.Windows.Forms.RadioButton();
            this.radioMedio3 = new System.Windows.Forms.RadioButton();
            this.radioUsuario3 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.filtroAlm = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFiltrar = new System.Windows.Forms.RadioButton();
            this.radioTodosCuatro = new System.Windows.Forms.RadioButton();
            this.grupoCuatro = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.botonMostrarDos = new System.Windows.Forms.Button();
            this.comboEstudiosDos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.exportarExcel = new System.Windows.Forms.PictureBox();
            this.filtroAdmin.SuspendLayout();
            this.grupoUno.SuspendLayout();
            this.grupoDos.SuspendLayout();
            this.grupoTres.SuspendLayout();
            this.filtroAlm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grupoCuatro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportarExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 40);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 643);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 10);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de candidatos";
            // 
            // comboTIpo
            // 
            this.comboTIpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTIpo.FormattingEnabled = true;
            this.comboTIpo.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Almacén"});
            this.comboTIpo.Location = new System.Drawing.Point(148, 53);
            this.comboTIpo.Name = "comboTIpo";
            this.comboTIpo.Size = new System.Drawing.Size(178, 24);
            this.comboTIpo.TabIndex = 7;
            this.comboTIpo.Tag = "Tipo de candidatos";
            this.comboTIpo.SelectedIndexChanged += new System.EventHandler(this.comboTIpo_SelectedIndexChanged);
            // 
            // filtroAdmin
            // 
            this.filtroAdmin.Controls.Add(this.botonMostrarUno);
            this.filtroAdmin.Controls.Add(this.comboEstudiosUno);
            this.filtroAdmin.Controls.Add(this.grupoUno);
            this.filtroAdmin.Controls.Add(this.grupoDos);
            this.filtroAdmin.Controls.Add(this.grupoTres);
            this.filtroAdmin.Controls.Add(this.label11);
            this.filtroAdmin.Enabled = false;
            this.filtroAdmin.ForeColor = System.Drawing.Color.Black;
            this.filtroAdmin.Location = new System.Drawing.Point(20, 92);
            this.filtroAdmin.Name = "filtroAdmin";
            this.filtroAdmin.Size = new System.Drawing.Size(529, 289);
            this.filtroAdmin.TabIndex = 8;
            this.filtroAdmin.TabStop = false;
            this.filtroAdmin.Tag = "Filtros administración";
            this.filtroAdmin.Text = "Filtros";
            // 
            // botonMostrarUno
            // 
            this.botonMostrarUno.Location = new System.Drawing.Point(184, 248);
            this.botonMostrarUno.Name = "botonMostrarUno";
            this.botonMostrarUno.Size = new System.Drawing.Size(165, 23);
            this.botonMostrarUno.TabIndex = 7;
            this.botonMostrarUno.Text = "Mostrar Listado";
            this.botonMostrarUno.UseVisualStyleBackColor = true;
            this.botonMostrarUno.Click += new System.EventHandler(this.botonMostrarUno_Click);
            // 
            // comboEstudiosUno
            // 
            this.comboEstudiosUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstudiosUno.FormattingEnabled = true;
            this.comboEstudiosUno.Items.AddRange(new object[] {
            "Seleccione",
            "Eso",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
            this.comboEstudiosUno.Location = new System.Drawing.Point(184, 21);
            this.comboEstudiosUno.Name = "comboEstudiosUno";
            this.comboEstudiosUno.Size = new System.Drawing.Size(165, 24);
            this.comboEstudiosUno.TabIndex = 2;
            this.comboEstudiosUno.Tag = "Estudios finalizados";
            // 
            // grupoUno
            // 
            this.grupoUno.Controls.Add(this.radioTodosUno);
            this.grupoUno.Controls.Add(this.radioAvanzado1);
            this.grupoUno.Controls.Add(this.radioMedio1);
            this.grupoUno.Controls.Add(this.radioUsuario1);
            this.grupoUno.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoUno.Location = new System.Drawing.Point(35, 56);
            this.grupoUno.Name = "grupoUno";
            this.grupoUno.Size = new System.Drawing.Size(454, 52);
            this.grupoUno.TabIndex = 4;
            this.grupoUno.TabStop = false;
            this.grupoUno.Tag = "Tratamiento de textos";
            this.grupoUno.Text = "Tratamiento de textos";
            // 
            // radioTodosUno
            // 
            this.radioTodosUno.AutoSize = true;
            this.radioTodosUno.Location = new System.Drawing.Point(112, 21);
            this.radioTodosUno.Name = "radioTodosUno";
            this.radioTodosUno.Size = new System.Drawing.Size(68, 20);
            this.radioTodosUno.TabIndex = 3;
            this.radioTodosUno.TabStop = true;
            this.radioTodosUno.Tag = "Todos";
            this.radioTodosUno.Text = "Todos";
            this.radioTodosUno.UseVisualStyleBackColor = true;
            // 
            // radioAvanzado1
            // 
            this.radioAvanzado1.AutoSize = true;
            this.radioAvanzado1.Location = new System.Drawing.Point(357, 19);
            this.radioAvanzado1.Name = "radioAvanzado1";
            this.radioAvanzado1.Size = new System.Drawing.Size(89, 20);
            this.radioAvanzado1.TabIndex = 2;
            this.radioAvanzado1.TabStop = true;
            this.radioAvanzado1.Tag = "Avanzado";
            this.radioAvanzado1.Text = "Avanzado";
            this.radioAvanzado1.UseVisualStyleBackColor = true;
            // 
            // radioMedio1
            // 
            this.radioMedio1.AutoSize = true;
            this.radioMedio1.Location = new System.Drawing.Point(278, 20);
            this.radioMedio1.Name = "radioMedio1";
            this.radioMedio1.Size = new System.Drawing.Size(66, 20);
            this.radioMedio1.TabIndex = 1;
            this.radioMedio1.TabStop = true;
            this.radioMedio1.Tag = "Medio";
            this.radioMedio1.Text = "Medio";
            this.radioMedio1.UseVisualStyleBackColor = true;
            // 
            // radioUsuario1
            // 
            this.radioUsuario1.AutoSize = true;
            this.radioUsuario1.Location = new System.Drawing.Point(194, 20);
            this.radioUsuario1.Name = "radioUsuario1";
            this.radioUsuario1.Size = new System.Drawing.Size(75, 20);
            this.radioUsuario1.TabIndex = 0;
            this.radioUsuario1.TabStop = true;
            this.radioUsuario1.Tag = "Usuario";
            this.radioUsuario1.Text = "Usuario";
            this.radioUsuario1.UseVisualStyleBackColor = true;
            // 
            // grupoDos
            // 
            this.grupoDos.Controls.Add(this.radioTodosDos);
            this.grupoDos.Controls.Add(this.radioAvanzado2);
            this.grupoDos.Controls.Add(this.radioMedio2);
            this.grupoDos.Controls.Add(this.radioUsuario2);
            this.grupoDos.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoDos.Location = new System.Drawing.Point(35, 115);
            this.grupoDos.Name = "grupoDos";
            this.grupoDos.Size = new System.Drawing.Size(454, 53);
            this.grupoDos.TabIndex = 5;
            this.grupoDos.TabStop = false;
            this.grupoDos.Tag = "Hoja de cálculo";
            this.grupoDos.Text = "Hoja de cálculo";
            // 
            // radioTodosDos
            // 
            this.radioTodosDos.AutoSize = true;
            this.radioTodosDos.Location = new System.Drawing.Point(112, 21);
            this.radioTodosDos.Name = "radioTodosDos";
            this.radioTodosDos.Size = new System.Drawing.Size(68, 20);
            this.radioTodosDos.TabIndex = 4;
            this.radioTodosDos.TabStop = true;
            this.radioTodosDos.Tag = "Todos";
            this.radioTodosDos.Text = "Todos";
            this.radioTodosDos.UseVisualStyleBackColor = true;
            // 
            // radioAvanzado2
            // 
            this.radioAvanzado2.AutoSize = true;
            this.radioAvanzado2.Location = new System.Drawing.Point(357, 21);
            this.radioAvanzado2.Name = "radioAvanzado2";
            this.radioAvanzado2.Size = new System.Drawing.Size(89, 20);
            this.radioAvanzado2.TabIndex = 2;
            this.radioAvanzado2.TabStop = true;
            this.radioAvanzado2.Tag = "Avanzado";
            this.radioAvanzado2.Text = "Avanzado";
            this.radioAvanzado2.UseVisualStyleBackColor = true;
            // 
            // radioMedio2
            // 
            this.radioMedio2.AutoSize = true;
            this.radioMedio2.Location = new System.Drawing.Point(278, 21);
            this.radioMedio2.Name = "radioMedio2";
            this.radioMedio2.Size = new System.Drawing.Size(66, 20);
            this.radioMedio2.TabIndex = 1;
            this.radioMedio2.TabStop = true;
            this.radioMedio2.Tag = "Medio";
            this.radioMedio2.Text = "Medio";
            this.radioMedio2.UseVisualStyleBackColor = true;
            // 
            // radioUsuario2
            // 
            this.radioUsuario2.AutoSize = true;
            this.radioUsuario2.Location = new System.Drawing.Point(194, 21);
            this.radioUsuario2.Name = "radioUsuario2";
            this.radioUsuario2.Size = new System.Drawing.Size(75, 20);
            this.radioUsuario2.TabIndex = 0;
            this.radioUsuario2.TabStop = true;
            this.radioUsuario2.Tag = "Usuario";
            this.radioUsuario2.Text = "Usuario";
            this.radioUsuario2.UseVisualStyleBackColor = true;
            // 
            // grupoTres
            // 
            this.grupoTres.Controls.Add(this.radioTodosTres);
            this.grupoTres.Controls.Add(this.radioAvanzado3);
            this.grupoTres.Controls.Add(this.radioMedio3);
            this.grupoTres.Controls.Add(this.radioUsuario3);
            this.grupoTres.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoTres.Location = new System.Drawing.Point(35, 175);
            this.grupoTres.Name = "grupoTres";
            this.grupoTres.Size = new System.Drawing.Size(454, 59);
            this.grupoTres.TabIndex = 6;
            this.grupoTres.TabStop = false;
            this.grupoTres.Tag = "Internet";
            this.grupoTres.Text = "Internet";
            // 
            // radioTodosTres
            // 
            this.radioTodosTres.AutoSize = true;
            this.radioTodosTres.Location = new System.Drawing.Point(112, 22);
            this.radioTodosTres.Name = "radioTodosTres";
            this.radioTodosTres.Size = new System.Drawing.Size(68, 20);
            this.radioTodosTres.TabIndex = 5;
            this.radioTodosTres.TabStop = true;
            this.radioTodosTres.Tag = "Todos";
            this.radioTodosTres.Text = "Todos";
            this.radioTodosTres.UseVisualStyleBackColor = true;
            // 
            // radioAvanzado3
            // 
            this.radioAvanzado3.AutoSize = true;
            this.radioAvanzado3.Location = new System.Drawing.Point(357, 22);
            this.radioAvanzado3.Name = "radioAvanzado3";
            this.radioAvanzado3.Size = new System.Drawing.Size(89, 20);
            this.radioAvanzado3.TabIndex = 2;
            this.radioAvanzado3.TabStop = true;
            this.radioAvanzado3.Tag = "Avanzado";
            this.radioAvanzado3.Text = "Avanzado";
            this.radioAvanzado3.UseVisualStyleBackColor = true;
            // 
            // radioMedio3
            // 
            this.radioMedio3.AutoSize = true;
            this.radioMedio3.Location = new System.Drawing.Point(278, 23);
            this.radioMedio3.Name = "radioMedio3";
            this.radioMedio3.Size = new System.Drawing.Size(66, 20);
            this.radioMedio3.TabIndex = 1;
            this.radioMedio3.TabStop = true;
            this.radioMedio3.Tag = "Medio";
            this.radioMedio3.Text = "Medio";
            this.radioMedio3.UseVisualStyleBackColor = true;
            // 
            // radioUsuario3
            // 
            this.radioUsuario3.AutoSize = true;
            this.radioUsuario3.Location = new System.Drawing.Point(194, 23);
            this.radioUsuario3.Name = "radioUsuario3";
            this.radioUsuario3.Size = new System.Drawing.Size(75, 20);
            this.radioUsuario3.TabIndex = 0;
            this.radioUsuario3.TabStop = true;
            this.radioUsuario3.Tag = "Usuario";
            this.radioUsuario3.Text = "Usuario";
            this.radioUsuario3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Estudios finalizados";
            // 
            // filtroAlm
            // 
            this.filtroAlm.Controls.Add(this.groupBox1);
            this.filtroAlm.Controls.Add(this.grupoCuatro);
            this.filtroAlm.Controls.Add(this.botonMostrarDos);
            this.filtroAlm.Controls.Add(this.comboEstudiosDos);
            this.filtroAlm.Controls.Add(this.label3);
            this.filtroAlm.Enabled = false;
            this.filtroAlm.ForeColor = System.Drawing.Color.Black;
            this.filtroAlm.Location = new System.Drawing.Point(566, 92);
            this.filtroAlm.Name = "filtroAlm";
            this.filtroAlm.Size = new System.Drawing.Size(500, 289);
            this.filtroAlm.TabIndex = 9;
            this.filtroAlm.TabStop = false;
            this.filtroAlm.Tag = "Filtros almacén";
            this.filtroAlm.Text = "Filtros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFiltrar);
            this.groupBox1.Controls.Add(this.radioTodosCuatro);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioFiltrar
            // 
            this.radioFiltrar.AutoSize = true;
            this.radioFiltrar.Location = new System.Drawing.Point(136, 22);
            this.radioFiltrar.Name = "radioFiltrar";
            this.radioFiltrar.Size = new System.Drawing.Size(61, 20);
            this.radioFiltrar.TabIndex = 1;
            this.radioFiltrar.TabStop = true;
            this.radioFiltrar.Tag = "Filtrar";
            this.radioFiltrar.Text = "Filtrar";
            this.radioFiltrar.UseVisualStyleBackColor = true;
            this.radioFiltrar.CheckedChanged += new System.EventHandler(this.radioFiltrar_CheckedChanged);
            // 
            // radioTodosCuatro
            // 
            this.radioTodosCuatro.AutoSize = true;
            this.radioTodosCuatro.Location = new System.Drawing.Point(15, 22);
            this.radioTodosCuatro.Name = "radioTodosCuatro";
            this.radioTodosCuatro.Size = new System.Drawing.Size(68, 20);
            this.radioTodosCuatro.TabIndex = 0;
            this.radioTodosCuatro.TabStop = true;
            this.radioTodosCuatro.Tag = "Todos";
            this.radioTodosCuatro.Text = "Todos";
            this.radioTodosCuatro.UseVisualStyleBackColor = true;
            // 
            // grupoCuatro
            // 
            this.grupoCuatro.Controls.Add(this.checkBox1);
            this.grupoCuatro.Controls.Add(this.checkBox2);
            this.grupoCuatro.Controls.Add(this.checkBox3);
            this.grupoCuatro.Enabled = false;
            this.grupoCuatro.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoCuatro.Location = new System.Drawing.Point(22, 141);
            this.grupoCuatro.Name = "grupoCuatro";
            this.grupoCuatro.Size = new System.Drawing.Size(457, 68);
            this.grupoCuatro.TabIndex = 8;
            this.grupoCuatro.TabStop = false;
            this.grupoCuatro.Tag = "Carnets";
            this.grupoCuatro.Text = "CARNETS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(317, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Tag = "Carnet de camión";
            this.checkBox1.Text = "Carnet de camión";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(160, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Tag = "Carnet de carretilla";
            this.checkBox2.Text = "Carnet de carretilla";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 30);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(141, 20);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "Carnet de conducir";
            this.checkBox3.Text = "Carnet de conducir";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // botonMostrarDos
            // 
            this.botonMostrarDos.Location = new System.Drawing.Point(184, 248);
            this.botonMostrarDos.Name = "botonMostrarDos";
            this.botonMostrarDos.Size = new System.Drawing.Size(165, 23);
            this.botonMostrarDos.TabIndex = 7;
            this.botonMostrarDos.Text = "Mostrar Listado";
            this.botonMostrarDos.UseVisualStyleBackColor = true;
            this.botonMostrarDos.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboEstudiosDos
            // 
            this.comboEstudiosDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstudiosDos.FormattingEnabled = true;
            this.comboEstudiosDos.Items.AddRange(new object[] {
            "Seleccione",
            "Eso",
            "Grado Medio",
            "Bachillerato",
            "Grado Superior",
            "Universitarios"});
            this.comboEstudiosDos.Location = new System.Drawing.Point(184, 30);
            this.comboEstudiosDos.Name = "comboEstudiosDos";
            this.comboEstudiosDos.Size = new System.Drawing.Size(165, 24);
            this.comboEstudiosDos.TabIndex = 2;
            this.comboEstudiosDos.Tag = "Estudios finalizados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estudios finalizados";
            // 
            // tabla
            // 
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(20, 441);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            this.tabla.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla.RowTemplate.Height = 24;
            this.tabla.Size = new System.Drawing.Size(1046, 187);
            this.tabla.TabIndex = 10;
            // 
            // exportarExcel
            // 
            this.exportarExcel.Enabled = false;
            this.exportarExcel.Image = global::HBergasa_RRHH.Properties.Resources.icons8_microsoft_excel_2019_48;
            this.exportarExcel.Location = new System.Drawing.Point(1013, 393);
            this.exportarExcel.Name = "exportarExcel";
            this.exportarExcel.Size = new System.Drawing.Size(43, 37);
            this.exportarExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exportarExcel.TabIndex = 11;
            this.exportarExcel.TabStop = false;
            this.exportarExcel.Click += new System.EventHandler(this.exportarExcel_Click);
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.exportarExcel);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.filtroAlm);
            this.Controls.Add(this.filtroAdmin);
            this.Controls.Add(this.comboTIpo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Listados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados";
            this.filtroAdmin.ResumeLayout(false);
            this.filtroAdmin.PerformLayout();
            this.grupoUno.ResumeLayout(false);
            this.grupoUno.PerformLayout();
            this.grupoDos.ResumeLayout(false);
            this.grupoDos.PerformLayout();
            this.grupoTres.ResumeLayout(false);
            this.grupoTres.PerformLayout();
            this.filtroAlm.ResumeLayout(false);
            this.filtroAlm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupoCuatro.ResumeLayout(false);
            this.grupoCuatro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportarExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTIpo;
        private System.Windows.Forms.GroupBox filtroAdmin;
        private System.Windows.Forms.ComboBox comboEstudiosUno;
        private System.Windows.Forms.GroupBox grupoUno;
        private System.Windows.Forms.RadioButton radioAvanzado1;
        private System.Windows.Forms.RadioButton radioMedio1;
        private System.Windows.Forms.RadioButton radioUsuario1;
        private System.Windows.Forms.GroupBox grupoDos;
        private System.Windows.Forms.RadioButton radioAvanzado2;
        private System.Windows.Forms.RadioButton radioMedio2;
        private System.Windows.Forms.RadioButton radioUsuario2;
        private System.Windows.Forms.GroupBox grupoTres;
        private System.Windows.Forms.RadioButton radioAvanzado3;
        private System.Windows.Forms.RadioButton radioMedio3;
        private System.Windows.Forms.RadioButton radioUsuario3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button botonMostrarUno;
        private System.Windows.Forms.GroupBox filtroAlm;
        private System.Windows.Forms.GroupBox grupoCuatro;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button botonMostrarDos;
        private System.Windows.Forms.ComboBox comboEstudiosDos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioTodosUno;
        private System.Windows.Forms.RadioButton radioTodosDos;
        private System.Windows.Forms.RadioButton radioTodosTres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTodosCuatro;
        private System.Windows.Forms.RadioButton radioFiltrar;
        private System.Windows.Forms.DataGridView tabla;

        string condicion;

        public void muestraCandidatosAdmin()
        {
            condicion = "";

            if (comboEstudiosUno.SelectedIndex >= 1)
            {
                condicion += " AND nivelEstudios='" + comboEstudiosUno.Text + "'";
            }

            string valorTexto = Utilidades.RecuperarValorRadios(grupoUno);
            if (!string.IsNullOrEmpty(valorTexto) && valorTexto != "Todos")
            {
                condicion += " AND nivelInformaticaTexto='" + valorTexto + "'";
            }

            string valorCalculo = Utilidades.RecuperarValorRadios(grupoDos);
            if (!string.IsNullOrEmpty(valorCalculo) && valorCalculo != "Todos")
            {
                condicion += " AND nivelInformaticaHojaCalculo='" + valorCalculo + "'";
            }

            string valorInternet = Utilidades.RecuperarValorRadios(grupoTres);
            if (!string.IsNullOrEmpty(valorInternet) && valorInternet != "Todos")
            {
                condicion += " AND nivelInformaticaInternet='" + valorInternet + "'";
            }

            tabla.DataSource = Consultas.verCandidatosAdm(condicion);
            exportarExcel.Enabled= true;
        }
        public void muestraCandidatosAlmacen()
        {
            condicion = "";

            if (comboEstudiosDos.SelectedIndex >= 1)
            {
                condicion += " AND nivelEstudios='" + comboEstudiosDos.Text + "'";
            }

            if (radioFiltrar.Checked)
            {
                if (checkBox1.Checked)
                    condicion += " AND carnetConducir='SI'";
                else
                {
                    condicion += " AND carnetConducir='NO'";

                }
                if (checkBox2.Checked)
                    condicion += " AND carnetCarretilla='SI'";
                else
                {
                    condicion += " AND carnetCarretilla='NO'";

                }
                if (checkBox3.Checked)
                    condicion += " AND carnetCamion='SI'";
                else
                {
                    condicion += " AND carnetCamion='NO'";

                }
            }

            tabla.DataSource = Consultas.verCandidatosAlm(condicion);
            exportarExcel.Enabled = true;
        }

        public void exportar()
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel(*.xlsx)|*.xlsx";

            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Workbook workbook = new Workbook();
                Worksheet sheet = workbook.Worksheets[0];
                sheet.Range["B1"].Text = ("Informe de candidatos");
                sheet.Range["C2"].Text = DateTime.Now.ToString();                

                sheet.InsertDataTable((DataTable)this.tabla.DataSource, true, 3, 2, -1, -1);

                sheet.AllocatedRange.AutoFitColumns();
                sheet.AllocatedRange.AutoFitRows();

                workbook.SaveToFile(fichero.FileName, ExcelVersion.Version2016);
                System.Diagnostics.Process.Start(fichero.FileName);
            }
        }

        public void gestionCheckBox()
        {
            if (radioTodosCuatro.Checked)
            {
                grupoCuatro.Enabled = true;
                checkBox1.Enabled = false;
                checkBox1.Checked = true;
                checkBox2.Enabled = false;
                checkBox2.Checked = true;
                checkBox3.Enabled = false;
                checkBox3.Checked = true;
            }
            else if (radioFiltrar.Checked)
            {
                grupoCuatro.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        public void configurarCuestionario()
        {
            comboTIpo.SelectedIndex = 0;
            comboEstudiosUno.SelectedIndex = 0;
            comboEstudiosDos.SelectedIndex = 0;
            radioTodosUno.Checked = true;
            radioTodosDos.Checked = true;
            radioTodosTres.Checked = true;
            radioTodosCuatro.Checked = true;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            gestionCheckBox();

        }

        public void gestionComboTipo()
        {
            tabla.DataSource = null;
            if (comboTIpo.SelectedIndex == 1)
            {
                filtroAdmin.Enabled = true;
                filtroAlm.Enabled = false;
            }
            else if (comboTIpo.SelectedIndex == 2)
            {
                filtroAdmin.Enabled = false;
                filtroAlm.Enabled = true;
            }
            else
            {
                filtroAdmin.Enabled = false;
                filtroAlm.Enabled = false;
            }
        }

        private PictureBox exportarExcel;
    }
}