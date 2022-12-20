
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
            this.components = new System.ComponentModel.Container();
            this.btnAggiungiPaziente = new System.Windows.Forms.Button();
            this.btnAggiungiMedico = new System.Windows.Forms.Button();
            this.btnRimuoviMedico = new System.Windows.Forms.Button();
            this.btnAggiungiAppuntamento = new System.Windows.Forms.Button();
            this.cbMedici = new System.Windows.Forms.ComboBox();
            this.cbPazienti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArgomentoAppuntamento = new System.Windows.Forms.TextBox();
            this.plAppuntamento = new System.Windows.Forms.Panel();
            this.dtpDataAppuntamento = new System.Windows.Forms.DateTimePicker();
            this.nudOrario = new System.Windows.Forms.NumericUpDown();
            this.plArgomento = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAppuntamenti = new System.Windows.Forms.DateTimePicker();
            this.cbAppuntamenti = new System.Windows.Forms.ComboBox();
            this.btnRimuoviAppuntamento = new System.Windows.Forms.Button();
            this.plSelezionaAppuntamento = new System.Windows.Forms.Panel();
            this.btnModificaAppuntamento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.plInformazioniAppuntamento = new System.Windows.Forms.Panel();
            this.tbArgomentoInfoAppuntamento = new System.Windows.Forms.TextBox();
            this.lblArgomentoAppuntamento = new System.Windows.Forms.Label();
            this.lblOrarioAppuntamento = new System.Windows.Forms.Label();
            this.lblDataAppuntamento = new System.Windows.Forms.Label();
            this.lblPazienteAppuntamento = new System.Windows.Forms.Label();
            this.lblMedicoAppuntamento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRimuoviPaziente = new System.Windows.Forms.Button();
            this.plAppuntamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrario)).BeginInit();
            this.plArgomento.SuspendLayout();
            this.plSelezionaAppuntamento.SuspendLayout();
            this.plInformazioniAppuntamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAggiungiPaziente
            // 
            this.btnAggiungiPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnAggiungiPaziente.FlatAppearance.BorderSize = 0;
            this.btnAggiungiPaziente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiPaziente.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnAggiungiPaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAggiungiPaziente.Location = new System.Drawing.Point(445, 81);
            this.btnAggiungiPaziente.Name = "btnAggiungiPaziente";
            this.btnAggiungiPaziente.Size = new System.Drawing.Size(110, 50);
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
            this.btnAggiungiMedico.Location = new System.Drawing.Point(445, 23);
            this.btnAggiungiMedico.Name = "btnAggiungiMedico";
            this.btnAggiungiMedico.Size = new System.Drawing.Size(110, 50);
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
            this.btnRimuoviMedico.Location = new System.Drawing.Point(561, 23);
            this.btnRimuoviMedico.Name = "btnRimuoviMedico";
            this.btnRimuoviMedico.Size = new System.Drawing.Size(110, 50);
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
            this.btnAggiungiAppuntamento.Location = new System.Drawing.Point(29, 273);
            this.btnAggiungiAppuntamento.Name = "btnAggiungiAppuntamento";
            this.btnAggiungiAppuntamento.Size = new System.Drawing.Size(350, 59);
            this.btnAggiungiAppuntamento.TabIndex = 3;
            this.btnAggiungiAppuntamento.Text = "Salva appuntamento";
            this.btnAggiungiAppuntamento.UseVisualStyleBackColor = false;
            this.btnAggiungiAppuntamento.Click += new System.EventHandler(this.btnAggiungiAppuntamento_Click);
            // 
            // cbMedici
            // 
            this.cbMedici.BackColor = System.Drawing.SystemColors.Window;
            this.cbMedici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedici.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbMedici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbMedici.FormattingEnabled = true;
            this.cbMedici.Location = new System.Drawing.Point(99, 65);
            this.cbMedici.Name = "cbMedici";
            this.cbMedici.Size = new System.Drawing.Size(277, 21);
            this.cbMedici.TabIndex = 13;
            // 
            // cbPazienti
            // 
            this.cbPazienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPazienti.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbPazienti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbPazienti.FormattingEnabled = true;
            this.cbPazienti.Location = new System.Drawing.Point(99, 92);
            this.cbPazienti.Name = "cbPazienti";
            this.cbPazienti.Size = new System.Drawing.Size(277, 21);
            this.cbPazienti.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(26, 68);
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
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paziente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(23, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Appuntamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(26, 164);
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
            this.tbArgomentoAppuntamento.Location = new System.Drawing.Point(5, 17);
            this.tbArgomentoAppuntamento.Multiline = true;
            this.tbArgomentoAppuntamento.Name = "tbArgomentoAppuntamento";
            this.tbArgomentoAppuntamento.Size = new System.Drawing.Size(272, 70);
            this.tbArgomentoAppuntamento.TabIndex = 19;
            // 
            // plAppuntamento
            // 
            this.plAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plAppuntamento.Controls.Add(this.dtpDataAppuntamento);
            this.plAppuntamento.Controls.Add(this.nudOrario);
            this.plAppuntamento.Controls.Add(this.cbMedici);
            this.plAppuntamento.Controls.Add(this.plArgomento);
            this.plAppuntamento.Controls.Add(this.label5);
            this.plAppuntamento.Controls.Add(this.btnAggiungiAppuntamento);
            this.plAppuntamento.Controls.Add(this.cbPazienti);
            this.plAppuntamento.Controls.Add(this.label3);
            this.plAppuntamento.Controls.Add(this.label4);
            this.plAppuntamento.Controls.Add(this.label1);
            this.plAppuntamento.Controls.Add(this.label2);
            this.plAppuntamento.Location = new System.Drawing.Point(21, 23);
            this.plAppuntamento.Name = "plAppuntamento";
            this.plAppuntamento.Size = new System.Drawing.Size(407, 357);
            this.plAppuntamento.TabIndex = 13;
            // 
            // dtpDataAppuntamento
            // 
            this.dtpDataAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.dtpDataAppuntamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAppuntamento.Location = new System.Drawing.Point(185, 119);
            this.dtpDataAppuntamento.Name = "dtpDataAppuntamento";
            this.dtpDataAppuntamento.Size = new System.Drawing.Size(191, 22);
            this.dtpDataAppuntamento.TabIndex = 22;
            // 
            // nudOrario
            // 
            this.nudOrario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudOrario.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.nudOrario.Location = new System.Drawing.Point(99, 119);
            this.nudOrario.Name = "nudOrario";
            this.nudOrario.Size = new System.Drawing.Size(80, 22);
            this.nudOrario.TabIndex = 21;
            // 
            // plArgomento
            // 
            this.plArgomento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.plArgomento.Controls.Add(this.tbArgomentoAppuntamento);
            this.plArgomento.Location = new System.Drawing.Point(99, 147);
            this.plArgomento.Name = "plArgomento";
            this.plArgomento.Size = new System.Drawing.Size(278, 100);
            this.plArgomento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(26, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Orario";
            // 
            // dtpAppuntamenti
            // 
            this.dtpAppuntamenti.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.dtpAppuntamenti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppuntamenti.Location = new System.Drawing.Point(14, 51);
            this.dtpAppuntamenti.Name = "dtpAppuntamenti";
            this.dtpAppuntamenti.Size = new System.Drawing.Size(116, 22);
            this.dtpAppuntamenti.TabIndex = 23;
            // 
            // cbAppuntamenti
            // 
            this.cbAppuntamenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppuntamenti.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbAppuntamenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbAppuntamenti.FormattingEnabled = true;
            this.cbAppuntamenti.Location = new System.Drawing.Point(14, 79);
            this.cbAppuntamenti.Name = "cbAppuntamenti";
            this.cbAppuntamenti.Size = new System.Drawing.Size(431, 21);
            this.cbAppuntamenti.TabIndex = 23;
            // 
            // btnRimuoviAppuntamento
            // 
            this.btnRimuoviAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnRimuoviAppuntamento.FlatAppearance.BorderSize = 0;
            this.btnRimuoviAppuntamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnRimuoviAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRimuoviAppuntamento.Location = new System.Drawing.Point(462, 14);
            this.btnRimuoviAppuntamento.Name = "btnRimuoviAppuntamento";
            this.btnRimuoviAppuntamento.Size = new System.Drawing.Size(172, 38);
            this.btnRimuoviAppuntamento.TabIndex = 23;
            this.btnRimuoviAppuntamento.Text = "Rimuovi appuntamento";
            this.btnRimuoviAppuntamento.UseVisualStyleBackColor = false;
            this.btnRimuoviAppuntamento.Click += new System.EventHandler(this.btnRimuoviAppuntamento_Click);
            // 
            // plSelezionaAppuntamento
            // 
            this.plSelezionaAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plSelezionaAppuntamento.Controls.Add(this.btnModificaAppuntamento);
            this.plSelezionaAppuntamento.Controls.Add(this.btnRimuoviAppuntamento);
            this.plSelezionaAppuntamento.Controls.Add(this.label6);
            this.plSelezionaAppuntamento.Controls.Add(this.dtpAppuntamenti);
            this.plSelezionaAppuntamento.Controls.Add(this.cbAppuntamenti);
            this.plSelezionaAppuntamento.Location = new System.Drawing.Point(21, 393);
            this.plSelezionaAppuntamento.Name = "plSelezionaAppuntamento";
            this.plSelezionaAppuntamento.Size = new System.Drawing.Size(650, 114);
            this.plSelezionaAppuntamento.TabIndex = 24;
            // 
            // btnModificaAppuntamento
            // 
            this.btnModificaAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnModificaAppuntamento.FlatAppearance.BorderSize = 0;
            this.btnModificaAppuntamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnModificaAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnModificaAppuntamento.Location = new System.Drawing.Point(462, 62);
            this.btnModificaAppuntamento.Name = "btnModificaAppuntamento";
            this.btnModificaAppuntamento.Size = new System.Drawing.Size(172, 38);
            this.btnModificaAppuntamento.TabIndex = 24;
            this.btnModificaAppuntamento.Text = "Modifica appuntamento";
            this.btnModificaAppuntamento.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Seleziona appuntamento";
            // 
            // plInformazioniAppuntamento
            // 
            this.plInformazioniAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plInformazioniAppuntamento.Controls.Add(this.tbArgomentoInfoAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblArgomentoAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblOrarioAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblDataAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblPazienteAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblMedicoAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.label7);
            this.plInformazioniAppuntamento.Location = new System.Drawing.Point(445, 142);
            this.plInformazioniAppuntamento.Name = "plInformazioniAppuntamento";
            this.plInformazioniAppuntamento.Size = new System.Drawing.Size(226, 238);
            this.plInformazioniAppuntamento.TabIndex = 12;
            // 
            // tbArgomentoInfoAppuntamento
            // 
            this.tbArgomentoInfoAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbArgomentoInfoAppuntamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArgomentoInfoAppuntamento.Enabled = false;
            this.tbArgomentoInfoAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbArgomentoInfoAppuntamento.ForeColor = System.Drawing.Color.White;
            this.tbArgomentoInfoAppuntamento.Location = new System.Drawing.Point(21, 163);
            this.tbArgomentoInfoAppuntamento.Multiline = true;
            this.tbArgomentoInfoAppuntamento.Name = "tbArgomentoInfoAppuntamento";
            this.tbArgomentoInfoAppuntamento.Size = new System.Drawing.Size(189, 61);
            this.tbArgomentoInfoAppuntamento.TabIndex = 20;
            // 
            // lblArgomentoAppuntamento
            // 
            this.lblArgomentoAppuntamento.AutoSize = true;
            this.lblArgomentoAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblArgomentoAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblArgomentoAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblArgomentoAppuntamento.Location = new System.Drawing.Point(18, 163);
            this.lblArgomentoAppuntamento.Name = "lblArgomentoAppuntamento";
            this.lblArgomentoAppuntamento.Size = new System.Drawing.Size(0, 13);
            this.lblArgomentoAppuntamento.TabIndex = 28;
            // 
            // lblOrarioAppuntamento
            // 
            this.lblOrarioAppuntamento.AutoSize = true;
            this.lblOrarioAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblOrarioAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblOrarioAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblOrarioAppuntamento.Location = new System.Drawing.Point(18, 138);
            this.lblOrarioAppuntamento.Name = "lblOrarioAppuntamento";
            this.lblOrarioAppuntamento.Size = new System.Drawing.Size(114, 13);
            this.lblOrarioAppuntamento.TabIndex = 27;
            this.lblOrarioAppuntamento.Text = "lblOrarioAppuntamento";
            // 
            // lblDataAppuntamento
            // 
            this.lblDataAppuntamento.AutoSize = true;
            this.lblDataAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDataAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblDataAppuntamento.Location = new System.Drawing.Point(18, 110);
            this.lblDataAppuntamento.Name = "lblDataAppuntamento";
            this.lblDataAppuntamento.Size = new System.Drawing.Size(109, 13);
            this.lblDataAppuntamento.TabIndex = 26;
            this.lblDataAppuntamento.Text = "lblDataAppuntamento";
            // 
            // lblPazienteAppuntamento
            // 
            this.lblPazienteAppuntamento.AutoSize = true;
            this.lblPazienteAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblPazienteAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPazienteAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblPazienteAppuntamento.Location = new System.Drawing.Point(18, 82);
            this.lblPazienteAppuntamento.Name = "lblPazienteAppuntamento";
            this.lblPazienteAppuntamento.Size = new System.Drawing.Size(127, 13);
            this.lblPazienteAppuntamento.TabIndex = 25;
            this.lblPazienteAppuntamento.Text = "lblPazienteAppuntamento";
            // 
            // lblMedicoAppuntamento
            // 
            this.lblMedicoAppuntamento.AutoSize = true;
            this.lblMedicoAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicoAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMedicoAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblMedicoAppuntamento.Location = new System.Drawing.Point(18, 55);
            this.lblMedicoAppuntamento.Name = "lblMedicoAppuntamento";
            this.lblMedicoAppuntamento.Size = new System.Drawing.Size(121, 13);
            this.lblMedicoAppuntamento.TabIndex = 24;
            this.lblMedicoAppuntamento.Text = "lblMedicoAppuntamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(17, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Info appuntamento";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRimuoviPaziente
            // 
            this.btnRimuoviPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnRimuoviPaziente.FlatAppearance.BorderSize = 0;
            this.btnRimuoviPaziente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviPaziente.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnRimuoviPaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRimuoviPaziente.Location = new System.Drawing.Point(561, 81);
            this.btnRimuoviPaziente.Name = "btnRimuoviPaziente";
            this.btnRimuoviPaziente.Size = new System.Drawing.Size(110, 50);
            this.btnRimuoviPaziente.TabIndex = 25;
            this.btnRimuoviPaziente.Text = "Rimuovi paziente";
            this.btnRimuoviPaziente.UseVisualStyleBackColor = false;
            this.btnRimuoviPaziente.Click += new System.EventHandler(this.btnRimuoviPaziente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(691, 527);
            this.Controls.Add(this.btnRimuoviPaziente);
            this.Controls.Add(this.btnAggiungiPaziente);
            this.Controls.Add(this.plInformazioniAppuntamento);
            this.Controls.Add(this.btnRimuoviMedico);
            this.Controls.Add(this.btnAggiungiMedico);
            this.Controls.Add(this.plAppuntamento);
            this.Controls.Add(this.plSelezionaAppuntamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studio di psicologia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plAppuntamento.ResumeLayout(false);
            this.plAppuntamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrario)).EndInit();
            this.plArgomento.ResumeLayout(false);
            this.plArgomento.PerformLayout();
            this.plSelezionaAppuntamento.ResumeLayout(false);
            this.plSelezionaAppuntamento.PerformLayout();
            this.plInformazioniAppuntamento.ResumeLayout(false);
            this.plInformazioniAppuntamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiPaziente;
        private System.Windows.Forms.Button btnAggiungiMedico;
        private System.Windows.Forms.Button btnRimuoviMedico;
        private System.Windows.Forms.Button btnAggiungiAppuntamento;
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
        private System.Windows.Forms.NumericUpDown nudOrario;
        private System.Windows.Forms.DateTimePicker dtpDataAppuntamento;
        private System.Windows.Forms.DateTimePicker dtpAppuntamenti;
        private System.Windows.Forms.ComboBox cbAppuntamenti;
        private System.Windows.Forms.Button btnRimuoviAppuntamento;
        private System.Windows.Forms.Panel plSelezionaAppuntamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel plInformazioniAppuntamento;
        private System.Windows.Forms.Label lblMedicoAppuntamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblArgomentoAppuntamento;
        private System.Windows.Forms.Label lblOrarioAppuntamento;
        private System.Windows.Forms.Label lblDataAppuntamento;
        private System.Windows.Forms.Label lblPazienteAppuntamento;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRimuoviPaziente;
        private System.Windows.Forms.Button btnModificaAppuntamento;
        private System.Windows.Forms.TextBox tbArgomentoInfoAppuntamento;
    }
}

