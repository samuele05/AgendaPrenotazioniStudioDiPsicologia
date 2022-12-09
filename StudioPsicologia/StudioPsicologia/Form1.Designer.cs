
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
            this.btnAggiungiAppuntamento = new System.Windows.Forms.Button();
            this.plInformazioniAppuntamento = new System.Windows.Forms.Panel();
            this.cbMedici = new System.Windows.Forms.ComboBox();
            this.cbPazienti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArgomentoAppuntamento = new System.Windows.Forms.TextBox();
            this.plAppuntamento = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.plArgomento = new System.Windows.Forms.Panel();
            this.plAppuntamento.SuspendLayout();
            this.plArgomento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAggiungiPaziente
            // 
            this.btnAggiungiPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnAggiungiPaziente.FlatAppearance.BorderSize = 0;
            this.btnAggiungiPaziente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiPaziente.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnAggiungiPaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAggiungiPaziente.Location = new System.Drawing.Point(12, 75);
            this.btnAggiungiPaziente.Name = "btnAggiungiPaziente";
            this.btnAggiungiPaziente.Size = new System.Drawing.Size(141, 50);
            this.btnAggiungiPaziente.TabIndex = 0;
            this.btnAggiungiPaziente.Text = "Aggiungi paziente";
            this.btnAggiungiPaziente.UseVisualStyleBackColor = false;
            this.btnAggiungiPaziente.Click += new System.EventHandler(this.btnAggiungiPaziente_Click);
            // 
            // btnAggiungiMedico
            // 
            this.btnAggiungiMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnAggiungiMedico.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnAggiungiMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAggiungiMedico.Location = new System.Drawing.Point(12, 12);
            this.btnAggiungiMedico.Name = "btnAggiungiMedico";
            this.btnAggiungiMedico.Size = new System.Drawing.Size(141, 50);
            this.btnAggiungiMedico.TabIndex = 1;
            this.btnAggiungiMedico.Text = "Aggiungi medico";
            this.btnAggiungiMedico.UseVisualStyleBackColor = false;
            this.btnAggiungiMedico.Click += new System.EventHandler(this.btnAggiungiMedico_Click);
            // 
            // btnRimuoviMedico
            // 
            this.btnRimuoviMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnRimuoviMedico.FlatAppearance.BorderSize = 0;
            this.btnRimuoviMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnRimuoviMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRimuoviMedico.Location = new System.Drawing.Point(169, 12);
            this.btnRimuoviMedico.Name = "btnRimuoviMedico";
            this.btnRimuoviMedico.Size = new System.Drawing.Size(141, 50);
            this.btnRimuoviMedico.TabIndex = 2;
            this.btnRimuoviMedico.Text = "Rimuovi medico";
            this.btnRimuoviMedico.UseVisualStyleBackColor = false;
            this.btnRimuoviMedico.Click += new System.EventHandler(this.btnRimuoviMedico_Click);
            // 
            // btnAggiungiAppuntamento
            // 
            this.btnAggiungiAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnAggiungiAppuntamento.FlatAppearance.BorderSize = 0;
            this.btnAggiungiAppuntamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnAggiungiAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAggiungiAppuntamento.Location = new System.Drawing.Point(29, 321);
            this.btnAggiungiAppuntamento.Name = "btnAggiungiAppuntamento";
            this.btnAggiungiAppuntamento.Size = new System.Drawing.Size(279, 59);
            this.btnAggiungiAppuntamento.TabIndex = 3;
            this.btnAggiungiAppuntamento.Text = "Aggiungi appuntamento";
            this.btnAggiungiAppuntamento.UseVisualStyleBackColor = false;
            this.btnAggiungiAppuntamento.Click += new System.EventHandler(this.btnAggiungiAppuntamento_Click);
            // 
            // plInformazioniAppuntamento
            // 
            this.plInformazioniAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.plInformazioniAppuntamento.Location = new System.Drawing.Point(345, 172);
            this.plInformazioniAppuntamento.Name = "plInformazioniAppuntamento";
            this.plInformazioniAppuntamento.Size = new System.Drawing.Size(264, 350);
            this.plInformazioniAppuntamento.TabIndex = 12;
            // 
            // cbMedici
            // 
            this.cbMedici.BackColor = System.Drawing.SystemColors.Window;
            this.cbMedici.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbMedici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbMedici.FormattingEnabled = true;
            this.cbMedici.Location = new System.Drawing.Point(109, 93);
            this.cbMedici.Name = "cbMedici";
            this.cbMedici.Size = new System.Drawing.Size(199, 21);
            this.cbMedici.TabIndex = 13;
            // 
            // cbPazienti
            // 
            this.cbPazienti.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbPazienti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbPazienti.FormattingEnabled = true;
            this.cbPazienti.Location = new System.Drawing.Point(109, 120);
            this.cbPazienti.Name = "cbPazienti";
            this.cbPazienti.Size = new System.Drawing.Size(199, 21);
            this.cbPazienti.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paziente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Appuntamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(26, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Argomento";
            // 
            // tbArgomentoAppuntamento
            // 
            this.tbArgomentoAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbArgomentoAppuntamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArgomentoAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbArgomentoAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.tbArgomentoAppuntamento.Location = new System.Drawing.Point(6, 17);
            this.tbArgomentoAppuntamento.Multiline = true;
            this.tbArgomentoAppuntamento.Name = "tbArgomentoAppuntamento";
            this.tbArgomentoAppuntamento.Size = new System.Drawing.Size(171, 70);
            this.tbArgomentoAppuntamento.TabIndex = 19;
            // 
            // plAppuntamento
            // 
            this.plAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plAppuntamento.Controls.Add(this.cbMedici);
            this.plAppuntamento.Controls.Add(this.plArgomento);
            this.plAppuntamento.Controls.Add(this.label5);
            this.plAppuntamento.Controls.Add(this.btnAggiungiAppuntamento);
            this.plAppuntamento.Controls.Add(this.cbPazienti);
            this.plAppuntamento.Controls.Add(this.label3);
            this.plAppuntamento.Controls.Add(this.label4);
            this.plAppuntamento.Controls.Add(this.label1);
            this.plAppuntamento.Controls.Add(this.label2);
            this.plAppuntamento.Location = new System.Drawing.Point(12, 142);
            this.plAppuntamento.Name = "plAppuntamento";
            this.plAppuntamento.Size = new System.Drawing.Size(621, 408);
            this.plAppuntamento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(26, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Orario";
            // 
            // plArgomento
            // 
            this.plArgomento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.plArgomento.Controls.Add(this.tbArgomentoAppuntamento);
            this.plArgomento.Location = new System.Drawing.Point(109, 195);
            this.plArgomento.Name = "plArgomento";
            this.plArgomento.Size = new System.Drawing.Size(199, 100);
            this.plArgomento.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(649, 566);
            this.Controls.Add(this.plInformazioniAppuntamento);
            this.Controls.Add(this.btnRimuoviMedico);
            this.Controls.Add(this.btnAggiungiMedico);
            this.Controls.Add(this.btnAggiungiPaziente);
            this.Controls.Add(this.plAppuntamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studio di psicologia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plAppuntamento.ResumeLayout(false);
            this.plAppuntamento.PerformLayout();
            this.plArgomento.ResumeLayout(false);
            this.plArgomento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiPaziente;
        private System.Windows.Forms.Button btnAggiungiMedico;
        private System.Windows.Forms.Button btnRimuoviMedico;
        private System.Windows.Forms.Button btnAggiungiAppuntamento;
        private System.Windows.Forms.Panel plInformazioniAppuntamento;
        private System.Windows.Forms.ComboBox cbMedici;
        private System.Windows.Forms.ComboBox cbPazienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArgomentoAppuntamento;
        private System.Windows.Forms.Panel plAppuntamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel plArgomento;
    }
}

