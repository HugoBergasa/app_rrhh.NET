using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HBergasa_RRHH
{
    partial class VentanaLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.imagenPass = new System.Windows.Forms.PictureBox();
            this.imagenUsu = new System.Windows.Forms.PictureBox();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonAcceder);
            this.groupBox1.Controls.Add(this.imagenPass);
            this.groupBox1.Controls.Add(this.imagenUsu);
            this.groupBox1.Controls.Add(this.campoPass);
            this.groupBox1.Controls.Add(this.campoUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(451, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCEDER";
            // 
            // botonAcceder
            // 
            this.botonAcceder.BackColor = System.Drawing.Color.IndianRed;
            this.botonAcceder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonAcceder.Location = new System.Drawing.Point(136, 173);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(163, 38);
            this.botonAcceder.TabIndex = 6;
            this.botonAcceder.Text = "ENTRAR";
            this.botonAcceder.UseVisualStyleBackColor = false;
            this.botonAcceder.Click += new System.EventHandler(this.botonAcceder_Click);
            // 
            // imagenPass
            // 
            this.imagenPass.Image = global::HBergasa_RRHH.Properties.Resources.pass;
            this.imagenPass.Location = new System.Drawing.Point(316, 99);
            this.imagenPass.Name = "imagenPass";
            this.imagenPass.Size = new System.Drawing.Size(48, 50);
            this.imagenPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenPass.TabIndex = 5;
            this.imagenPass.TabStop = false;
            this.imagenPass.Visible = false;
            // 
            // imagenUsu
            // 
            this.imagenUsu.Image = global::HBergasa_RRHH.Properties.Resources.user;
            this.imagenUsu.Location = new System.Drawing.Point(316, 33);
            this.imagenUsu.Name = "imagenUsu";
            this.imagenUsu.Size = new System.Drawing.Size(48, 50);
            this.imagenUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenUsu.TabIndex = 4;
            this.imagenUsu.TabStop = false;
            this.imagenUsu.Visible = false;
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(136, 112);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(163, 22);
            this.campoPass.TabIndex = 3;
            this.campoPass.UseSystemPasswordChar = true;
            this.campoPass.Enter += new System.EventHandler(this.campoPass_Enter);
            this.campoPass.Leave += new System.EventHandler(this.campoPass_Leave);
            // 
            // campoUsuario
            // 
            this.campoUsuario.Location = new System.Drawing.Point(136, 47);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(163, 22);
            this.campoUsuario.TabIndex = 2;
            this.campoUsuario.Enter += new System.EventHandler(this.campoUsuario_Enter);
            this.campoUsuario.Leave += new System.EventHandler(this.campoUsuario_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HBergasa_RRHH.Properties.Resources.logotalento;
            this.pictureBox2.Location = new System.Drawing.Point(574, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HBergasa_RRHH.Properties.Resources.imglogin;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 430);
            this.MinimumSize = new System.Drawing.Size(880, 430);
            this.Name = "VentanaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imagenUsu;
        private System.Windows.Forms.PictureBox imagenPass;
        private System.Windows.Forms.Button botonAcceder;

        public static string nombreCompleto, fecha, ipv4, registrador;

        public void entrar()
        {
            if (conexion.Conexion.acceder(campoUsuario.Text, campoPass.Text))
            {
                registrador = campoUsuario.Text;
                nombreCompleto = conexion.Consultas.rescatarNombreCompleto(campoUsuario.Text);

                fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                ipv4 = ObtenerIPv4();

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error de identificación. Inténtelo de nuevo.", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoUsuario.Text = "";
                campoPass.Text = "";
            }
        }

        public static string ObtenerIPv4()
        {
            string ip = "";
            string patronIpv4 = @"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$";
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIPs)
            {
                if (Regex.IsMatch(address.ToString(), patronIpv4))
                {
                    ip = address.ToString();
                    break;
                }
            }
            return ip;
        }
    }
}

