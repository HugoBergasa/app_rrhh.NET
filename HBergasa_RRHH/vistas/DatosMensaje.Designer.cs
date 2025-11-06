using HBergasa_RRHH.modelo;
using System;
using System.Windows.Forms;

namespace HBergasa_RRHH.vistas
{
    partial class DatosMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosMensaje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha y hora de convocatoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especifique fecha y hora para la entrevista de trabajo.";
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(140, 107);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(268, 22);
            this.calendario.TabIndex = 4;
            // 
            // comboHora
            // 
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Items.AddRange(new object[] {
            "Seleccione",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.comboHora.Location = new System.Drawing.Point(140, 159);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(148, 24);
            this.comboHora.TabIndex = 5;
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(217, 237);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(114, 30);
            this.botonEnviar.TabIndex = 6;
            this.botonEnviar.Text = "Enviar Correo";
            this.botonEnviar.UseVisualStyleBackColor = true;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // DatosMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.comboHora);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "DatosMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convocatoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.Button botonEnviar;

        private string emailDestinatario;

        private void ConfigurarVentana()
        {
            calendario.MinDate = DateTime.Now.AddDays(1);
            calendario.Value = DateTime.Now.AddDays(1);
            comboHora.SelectedIndex = 0;

        }

        private void EnviarCorreo()
        {
            if (comboHora.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar una hora", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string emailDestinatario = BuscarCandidato.emailCandidato;
                string fecha = calendario.Value.ToString("dd/MM/yyyy");
                string hora = comboHora.SelectedItem.ToString();

                 Email email = new Email(
                    asunto: "Convocatoria para entrevista de trabajo",
                    destinatario: emailDestinatario,
                    fecha: fecha,
                    hora: hora
                );

                email.EnviarCorreo();

                MessageBox.Show("Correo enviado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}