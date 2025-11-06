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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelDatosDos = new System.Windows.Forms.GroupBox();
            this.comboEstudiosUno = new System.Windows.Forms.ComboBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.botonMostrarUno = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboEstudiosDos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioTodosCuatro = new System.Windows.Forms.RadioButton();
            this.radioFiltrar = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDatosDos.SuspendLayout();
            this.grupoUno.SuspendLayout();
            this.grupoDos.SuspendLayout();
            this.grupoTres.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seleccione",
            "Administración",
            "Almacén"});
            this.comboBox1.Location = new System.Drawing.Point(148, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // panelDatosDos
            // 
            this.panelDatosDos.Controls.Add(this.botonMostrarUno);
            this.panelDatosDos.Controls.Add(this.comboEstudiosUno);
            this.panelDatosDos.Controls.Add(this.grupoUno);
            this.panelDatosDos.Controls.Add(this.grupoDos);
            this.panelDatosDos.Controls.Add(this.grupoTres);
            this.panelDatosDos.Controls.Add(this.label11);
            this.panelDatosDos.ForeColor = System.Drawing.Color.Black;
            this.panelDatosDos.Location = new System.Drawing.Point(20, 92);
            this.panelDatosDos.Name = "panelDatosDos";
            this.panelDatosDos.Size = new System.Drawing.Size(529, 289);
            this.panelDatosDos.TabIndex = 8;
            this.panelDatosDos.TabStop = false;
            this.panelDatosDos.Tag = "datos complementarios";
            this.panelDatosDos.Text = "Filtros";
            // 
            // comboEstudiosUno
            // 
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
            this.comboEstudiosUno.Tag = "estudios finalizados";
            // 
            // grupoUno
            // 
            this.grupoUno.Controls.Add(this.radioButton1);
            this.grupoUno.Controls.Add(this.radioAvanzado1);
            this.grupoUno.Controls.Add(this.radioMedio1);
            this.grupoUno.Controls.Add(this.radioUsuario1);
            this.grupoUno.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoUno.Location = new System.Drawing.Point(35, 56);
            this.grupoUno.Name = "grupoUno";
            this.grupoUno.Size = new System.Drawing.Size(454, 52);
            this.grupoUno.TabIndex = 4;
            this.grupoUno.TabStop = false;
            this.grupoUno.Tag = "tratamiento de textos";
            this.grupoUno.Text = "Tratamiento de textos";
            // 
            // radioAvanzado1
            // 
            this.radioAvanzado1.AutoSize = true;
            this.radioAvanzado1.Location = new System.Drawing.Point(357, 19);
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
            this.radioMedio1.Location = new System.Drawing.Point(278, 20);
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
            this.radioUsuario1.Location = new System.Drawing.Point(194, 20);
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
            this.grupoDos.Controls.Add(this.radioButton2);
            this.grupoDos.Controls.Add(this.radioAvanzado2);
            this.grupoDos.Controls.Add(this.radioMedio2);
            this.grupoDos.Controls.Add(this.radioUsuario2);
            this.grupoDos.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoDos.Location = new System.Drawing.Point(35, 115);
            this.grupoDos.Name = "grupoDos";
            this.grupoDos.Size = new System.Drawing.Size(454, 53);
            this.grupoDos.TabIndex = 5;
            this.grupoDos.TabStop = false;
            this.grupoDos.Tag = "hoja de cálculo";
            this.grupoDos.Text = "Hoja de cálculo";
            // 
            // radioAvanzado2
            // 
            this.radioAvanzado2.AutoSize = true;
            this.radioAvanzado2.Location = new System.Drawing.Point(357, 21);
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
            this.radioMedio2.Location = new System.Drawing.Point(278, 21);
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
            this.radioUsuario2.Location = new System.Drawing.Point(194, 21);
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
            this.grupoTres.Controls.Add(this.radioButton3);
            this.grupoTres.Controls.Add(this.radioAvanzado3);
            this.grupoTres.Controls.Add(this.radioMedio3);
            this.grupoTres.Controls.Add(this.radioUsuario3);
            this.grupoTres.ForeColor = System.Drawing.Color.IndianRed;
            this.grupoTres.Location = new System.Drawing.Point(35, 175);
            this.grupoTres.Name = "grupoTres";
            this.grupoTres.Size = new System.Drawing.Size(454, 59);
            this.grupoTres.TabIndex = 6;
            this.grupoTres.TabStop = false;
            this.grupoTres.Tag = "internet";
            this.grupoTres.Text = "Internet";
            // 
            // radioAvanzado3
            // 
            this.radioAvanzado3.AutoSize = true;
            this.radioAvanzado3.Location = new System.Drawing.Point(357, 22);
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
            this.radioMedio3.Location = new System.Drawing.Point(278, 23);
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
            this.radioUsuario3.Location = new System.Drawing.Point(194, 23);
            this.radioUsuario3.Name = "radioUsuario3";
            this.radioUsuario3.Size = new System.Drawing.Size(75, 20);
            this.radioUsuario3.TabIndex = 0;
            this.radioUsuario3.TabStop = true;
            this.radioUsuario3.Tag = "usuario";
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
            // botonMostrarUno
            // 
            this.botonMostrarUno.Location = new System.Drawing.Point(184, 248);
            this.botonMostrarUno.Name = "botonMostrarUno";
            this.botonMostrarUno.Size = new System.Drawing.Size(165, 23);
            this.botonMostrarUno.TabIndex = 7;
            this.botonMostrarUno.Text = "Mostrar Listado";
            this.botonMostrarUno.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboEstudiosDos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(566, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 289);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "datos complementarios";
            this.groupBox3.Text = "Filtros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mostrar Listado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboEstudiosDos
            // 
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
            this.comboEstudiosDos.Tag = "estudios finalizados";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Enabled = false;
            this.groupBox4.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox4.Location = new System.Drawing.Point(22, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 68);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CARNETS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(317, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Tag = "carnet de camión";
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
            this.checkBox2.Tag = "carnet de carretilla";
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
            this.checkBox3.Tag = "carnet de conducir";
            this.checkBox3.Text = "Carnet de conducir";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(112, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "todos";
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(112, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "todos";
            this.radioButton2.Text = "Todos";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(112, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "todos";
            this.radioButton3.Text = "Todos";
            this.radioButton3.UseVisualStyleBackColor = true;
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
            // radioTodosCuatro
            // 
            this.radioTodosCuatro.AutoSize = true;
            this.radioTodosCuatro.Location = new System.Drawing.Point(15, 22);
            this.radioTodosCuatro.Name = "radioTodosCuatro";
            this.radioTodosCuatro.Size = new System.Drawing.Size(68, 20);
            this.radioTodosCuatro.TabIndex = 0;
            this.radioTodosCuatro.TabStop = true;
            this.radioTodosCuatro.Tag = "todos";
            this.radioTodosCuatro.Text = "Todos";
            this.radioTodosCuatro.UseVisualStyleBackColor = true;
            // 
            // radioFiltrar
            // 
            this.radioFiltrar.AutoSize = true;
            this.radioFiltrar.Location = new System.Drawing.Point(136, 22);
            this.radioFiltrar.Name = "radioFiltrar";
            this.radioFiltrar.Size = new System.Drawing.Size(61, 20);
            this.radioFiltrar.TabIndex = 1;
            this.radioFiltrar.TabStop = true;
            this.radioFiltrar.Tag = "filtrar";
            this.radioFiltrar.Text = "Filtrar";
            this.radioFiltrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 187);
            this.dataGridView1.TabIndex = 10;
            // 
            // Listados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelDatosDos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Listados";
            this.Text = "Listados";
            this.panelDatosDos.ResumeLayout(false);
            this.panelDatosDos.PerformLayout();
            this.grupoUno.ResumeLayout(false);
            this.grupoUno.PerformLayout();
            this.grupoDos.ResumeLayout(false);
            this.grupoDos.PerformLayout();
            this.grupoTres.ResumeLayout(false);
            this.grupoTres.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox panelDatosDos;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboEstudiosDos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTodosCuatro;
        private System.Windows.Forms.RadioButton radioFiltrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}