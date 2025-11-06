namespace HBergasa_RRHH.vistas
{
    partial class VentanaPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTimeSesion = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonCuatro = new System.Windows.Forms.Button();
            this.botonTres = new System.Windows.Forms.Button();
            this.botonDos = new System.Windows.Forms.Button();
            this.botonUno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contadorAdmin = new System.Windows.Forms.Label();
            this.contadorAlmacen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaAdmin = new System.Windows.Forms.DataGridView();
            this.tablaAlmacen = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.IndianRed;
            this.labelNombre.Location = new System.Drawing.Point(51, 26);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "label1";
            // 
            // labelTimeSesion
            // 
            this.labelTimeSesion.AutoSize = true;
            this.labelTimeSesion.ForeColor = System.Drawing.Color.IndianRed;
            this.labelTimeSesion.Location = new System.Drawing.Point(51, 59);
            this.labelTimeSesion.Name = "labelTimeSesion";
            this.labelTimeSesion.Size = new System.Drawing.Size(44, 16);
            this.labelTimeSesion.TabIndex = 2;
            this.labelTimeSesion.Text = "label2";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.ForeColor = System.Drawing.Color.IndianRed;
            this.labelIP.Location = new System.Drawing.Point(51, 93);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(44, 16);
            this.labelIP.TabIndex = 3;
            this.labelIP.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.botonCuatro);
            this.panel1.Controls.Add(this.botonTres);
            this.panel1.Controls.Add(this.botonDos);
            this.panel1.Controls.Add(this.botonUno);
            this.panel1.Location = new System.Drawing.Point(1, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 130);
            this.panel1.TabIndex = 4;
            // 
            // botonCuatro
            // 
            this.botonCuatro.BackColor = System.Drawing.Color.IndianRed;
            this.botonCuatro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonCuatro.Location = new System.Drawing.Point(863, 18);
            this.botonCuatro.Name = "botonCuatro";
            this.botonCuatro.Size = new System.Drawing.Size(188, 96);
            this.botonCuatro.TabIndex = 3;
            this.botonCuatro.Text = "Buscar candidatos";
            this.botonCuatro.UseVisualStyleBackColor = false;
            this.botonCuatro.Click += new System.EventHandler(this.botonCuatro_Click);
            // 
            // botonTres
            // 
            this.botonTres.BackColor = System.Drawing.Color.IndianRed;
            this.botonTres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonTres.Location = new System.Drawing.Point(611, 18);
            this.botonTres.Name = "botonTres";
            this.botonTres.Size = new System.Drawing.Size(188, 96);
            this.botonTres.TabIndex = 2;
            this.botonTres.Text = "Listado de candidatos";
            this.botonTres.UseVisualStyleBackColor = false;
            this.botonTres.Click += new System.EventHandler(this.botonTres_Click);
            // 
            // botonDos
            // 
            this.botonDos.BackColor = System.Drawing.Color.IndianRed;
            this.botonDos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonDos.Location = new System.Drawing.Point(356, 18);
            this.botonDos.Name = "botonDos";
            this.botonDos.Size = new System.Drawing.Size(188, 96);
            this.botonDos.TabIndex = 1;
            this.botonDos.Text = "Alta de candidatos para almacén";
            this.botonDos.UseVisualStyleBackColor = false;
            this.botonDos.Click += new System.EventHandler(this.botonDos_Click);
            // 
            // botonUno
            // 
            this.botonUno.BackColor = System.Drawing.Color.IndianRed;
            this.botonUno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonUno.Location = new System.Drawing.Point(104, 18);
            this.botonUno.Name = "botonUno";
            this.botonUno.Size = new System.Drawing.Size(188, 96);
            this.botonUno.TabIndex = 0;
            this.botonUno.Text = "Alta de candidatos para administración";
            this.botonUno.UseVisualStyleBackColor = false;
            this.botonUno.Click += new System.EventHandler(this.botonUno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Candidatos Administración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Candidatos Almacén";
            // 
            // contadorAdmin
            // 
            this.contadorAdmin.AutoSize = true;
            this.contadorAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contadorAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorAdmin.Location = new System.Drawing.Point(275, 350);
            this.contadorAdmin.Name = "contadorAdmin";
            this.contadorAdmin.Size = new System.Drawing.Size(65, 71);
            this.contadorAdmin.TabIndex = 7;
            this.contadorAdmin.Text = "0";
            this.contadorAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contadorAlmacen
            // 
            this.contadorAlmacen.AutoSize = true;
            this.contadorAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contadorAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorAlmacen.Location = new System.Drawing.Point(776, 350);
            this.contadorAlmacen.Name = "contadorAlmacen";
            this.contadorAlmacen.Size = new System.Drawing.Size(65, 71);
            this.contadorAlmacen.TabIndex = 8;
            this.contadorAlmacen.Text = "0";
            this.contadorAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Últimos candidatos registrados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(665, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Últimos candidatos registrados";
            // 
            // tablaAdmin
            // 
            this.tablaAdmin.AllowUserToAddRows = false;
            this.tablaAdmin.AllowUserToDeleteRows = false;
            this.tablaAdmin.AllowUserToResizeColumns = false;
            this.tablaAdmin.AllowUserToResizeRows = false;
            this.tablaAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tablaAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaAdmin.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaAdmin.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaAdmin.Location = new System.Drawing.Point(20, 516);
            this.tablaAdmin.Name = "tablaAdmin";
            this.tablaAdmin.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaAdmin.RowHeadersVisible = false;
            this.tablaAdmin.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.IndianRed;
            this.tablaAdmin.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaAdmin.RowTemplate.Height = 24;
            this.tablaAdmin.Size = new System.Drawing.Size(525, 117);
            this.tablaAdmin.TabIndex = 11;
            // 
            // tablaAlmacen
            // 
            this.tablaAlmacen.AllowUserToAddRows = false;
            this.tablaAlmacen.AllowUserToDeleteRows = false;
            this.tablaAlmacen.AllowUserToResizeColumns = false;
            this.tablaAlmacen.AllowUserToResizeRows = false;
            this.tablaAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaAlmacen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablaAlmacen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tablaAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaAlmacen.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaAlmacen.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaAlmacen.Location = new System.Drawing.Point(612, 516);
            this.tablaAlmacen.Name = "tablaAlmacen";
            this.tablaAlmacen.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaAlmacen.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaAlmacen.RowHeadersVisible = false;
            this.tablaAlmacen.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.IndianRed;
            this.tablaAlmacen.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaAlmacen.RowTemplate.Height = 24;
            this.tablaAlmacen.Size = new System.Drawing.Size(546, 117);
            this.tablaAlmacen.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HBergasa_RRHH.Properties.Resources.logotalento;
            this.pictureBox1.Location = new System.Drawing.Point(1008, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1182, 678);
            this.Controls.Add(this.tablaAlmacen);
            this.Controls.Add(this.tablaAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contadorAlmacen);
            this.Controls.Add(this.contadorAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelTimeSesion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 725);
            this.MinimumSize = new System.Drawing.Size(1200, 725);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RRHH";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTimeSesion;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonUno;
        private System.Windows.Forms.Button botonCuatro;
        private System.Windows.Forms.Button botonTres;
        private System.Windows.Forms.Button botonDos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label contadorAdmin;
        private System.Windows.Forms.Label contadorAlmacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaAdmin;
        private System.Windows.Forms.DataGridView tablaAlmacen;
    }
}