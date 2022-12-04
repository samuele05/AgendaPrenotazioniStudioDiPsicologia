
namespace StudioPsicologia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAggiungiPaziente = new System.Windows.Forms.Button();
            this.btnAggiungiMedico = new System.Windows.Forms.Button();
            this.btnRimuoviMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAggiungiPaziente
            // 
            this.btnAggiungiPaziente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAggiungiPaziente.FlatAppearance.BorderSize = 0;
            this.btnAggiungiPaziente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiPaziente.Location = new System.Drawing.Point(12, 12);
            this.btnAggiungiPaziente.Name = "btnAggiungiPaziente";
            this.btnAggiungiPaziente.Size = new System.Drawing.Size(141, 50);
            this.btnAggiungiPaziente.TabIndex = 0;
            this.btnAggiungiPaziente.Text = "Aggiungi paziente";
            this.btnAggiungiPaziente.UseVisualStyleBackColor = false;
            this.btnAggiungiPaziente.Click += new System.EventHandler(this.btnAggiungiPaziente_Click);
            // 
            // btnAggiungiMedico
            // 
            this.btnAggiungiMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAggiungiMedico.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMedico.Location = new System.Drawing.Point(12, 78);
            this.btnAggiungiMedico.Name = "btnAggiungiMedico";
            this.btnAggiungiMedico.Size = new System.Drawing.Size(141, 50);
            this.btnAggiungiMedico.TabIndex = 1;
            this.btnAggiungiMedico.Text = "Aggiungi medico";
            this.btnAggiungiMedico.UseVisualStyleBackColor = false;
            this.btnAggiungiMedico.Click += new System.EventHandler(this.btnAggiungiMedico_Click);
            // 
            // btnRimuoviMedico
            // 
            this.btnRimuoviMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRimuoviMedico.FlatAppearance.BorderSize = 0;
            this.btnRimuoviMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviMedico.Location = new System.Drawing.Point(169, 78);
            this.btnRimuoviMedico.Name = "btnRimuoviMedico";
            this.btnRimuoviMedico.Size = new System.Drawing.Size(141, 50);
            this.btnRimuoviMedico.TabIndex = 2;
            this.btnRimuoviMedico.Text = "Rimuovi medico";
            this.btnRimuoviMedico.UseVisualStyleBackColor = false;
            this.btnRimuoviMedico.Click += new System.EventHandler(this.btnRimuoviMedico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 227);
            this.Controls.Add(this.btnRimuoviMedico);
            this.Controls.Add(this.btnAggiungiMedico);
            this.Controls.Add(this.btnAggiungiPaziente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiPaziente;
        private System.Windows.Forms.Button btnAggiungiMedico;
        private System.Windows.Forms.Button btnRimuoviMedico;
    }
}

