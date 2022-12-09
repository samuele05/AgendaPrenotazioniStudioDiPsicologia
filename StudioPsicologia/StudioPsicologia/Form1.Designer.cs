
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
            this.plAppuntamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAggiungiPaziente
            // 
            this.btnAggiungiPaziente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAggiungiPaziente.FlatAppearance.BorderSize = 0;
            this.btnAggiungiPaziente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnAggiungiMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAggiungiMedico.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnRimuoviMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRimuoviMedico.FlatAppearance.BorderSize = 0;
            this.btnRimuoviMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnAggiungiAppuntamento.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAggiungiAppuntamento.FlatAppearance.BorderSize = 0;
            this.btnAggiungiAppuntamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiAppuntamento.Location = new System.Drawing.Point(29, 301);
            this.btnAggiungiAppuntamento.Name = "btnAggiungiAppuntamento";
            this.btnAggiungiAppuntamento.Size = new System.Drawing.Size(239, 50);
            this.btnAggiungiAppuntamento.TabIndex = 3;
            this.btnAggiungiAppuntamento.Text = "Aggiungi appuntamento";
            this.btnAggiungiAppuntamento.UseVisualStyleBackColor = false;
            this.btnAggiungiAppuntamento.Click += new System.EventHandler(this.btnAggiungiAppuntamento_Click);
            // 
            // plInformazioniAppuntamento
            // 
            this.plInformazioniAppuntamento.BackColor = System.Drawing.Color.White;
            this.plInformazioniAppuntamento.Location = new System.Drawing.Point(315, 244);
            this.plInformazioniAppuntamento.Name = "plInformazioniAppuntamento";
            this.plInformazioniAppuntamento.Size = new System.Drawing.Size(218, 258);
            this.plInformazioniAppuntamento.TabIndex = 12;
            // 
            // cbMedici
            // 
            this.cbMedici.FormattingEnabled = true;
            this.cbMedici.Location = new System.Drawing.Point(95, 93);
            this.cbMedici.Name = "cbMedici";
            this.cbMedici.Size = new System.Drawing.Size(173, 21);
            this.cbMedici.TabIndex = 13;
            // 
            // cbPazienti
            // 
            this.cbPazienti.FormattingEnabled = true;
            this.cbPazienti.Location = new System.Drawing.Point(95, 120);
            this.cbPazienti.Name = "cbPazienti";
            this.cbPazienti.Size = new System.Drawing.Size(173, 21);
            this.cbPazienti.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paziente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Appuntamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Argomento";
            // 
            // tbArgomentoAppuntamento
            // 
            this.tbArgomentoAppuntamento.Location = new System.Drawing.Point(95, 206);
            this.tbArgomentoAppuntamento.Multiline = true;
            this.tbArgomentoAppuntamento.Name = "tbArgomentoAppuntamento";
            this.tbArgomentoAppuntamento.Size = new System.Drawing.Size(173, 79);
            this.tbArgomentoAppuntamento.TabIndex = 19;
            // 
            // plAppuntamento
            // 
            this.plAppuntamento.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.plAppuntamento.Controls.Add(this.label5);
            this.plAppuntamento.Controls.Add(this.tbArgomentoAppuntamento);
            this.plAppuntamento.Controls.Add(this.btnAggiungiAppuntamento);
            this.plAppuntamento.Controls.Add(this.cbPazienti);
            this.plAppuntamento.Controls.Add(this.label3);
            this.plAppuntamento.Controls.Add(this.cbMedici);
            this.plAppuntamento.Controls.Add(this.label4);
            this.plAppuntamento.Controls.Add(this.label1);
            this.plAppuntamento.Controls.Add(this.label2);
            this.plAppuntamento.Location = new System.Drawing.Point(12, 151);
            this.plAppuntamento.Name = "plAppuntamento";
            this.plAppuntamento.Size = new System.Drawing.Size(545, 376);
            this.plAppuntamento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Orario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 546);
            this.Controls.Add(this.plInformazioniAppuntamento);
            this.Controls.Add(this.btnRimuoviMedico);
            this.Controls.Add(this.btnAggiungiMedico);
            this.Controls.Add(this.btnAggiungiPaziente);
            this.Controls.Add(this.plAppuntamento);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plAppuntamento.ResumeLayout(false);
            this.plAppuntamento.PerformLayout();
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
    }
}

