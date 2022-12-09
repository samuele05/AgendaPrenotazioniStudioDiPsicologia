
namespace StudioPsicologia
{
    partial class RimuoviMedico
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
            this.tbCodiceMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRimuoviMedico = new System.Windows.Forms.Button();
            this.plInformazioniMedico = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInCarica = new System.Windows.Forms.Label();
            this.lblSpecializzazioneMedico = new System.Windows.Forms.Label();
            this.lblCognomeMedico = new System.Windows.Forms.Label();
            this.lblNomeMedico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelezionaMedico = new System.Windows.Forms.Button();
            this.plInformazioniMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodiceMedico
            // 
            this.tbCodiceMedico.Location = new System.Drawing.Point(114, 18);
            this.tbCodiceMedico.Name = "tbCodiceMedico";
            this.tbCodiceMedico.Size = new System.Drawing.Size(100, 20);
            this.tbCodiceMedico.TabIndex = 9;
            this.tbCodiceMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodiceMedico_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codice medico";
            // 
            // btnRimuoviMedico
            // 
            this.btnRimuoviMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRimuoviMedico.FlatAppearance.BorderSize = 0;
            this.btnRimuoviMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviMedico.Location = new System.Drawing.Point(23, 254);
            this.btnRimuoviMedico.Name = "btnRimuoviMedico";
            this.btnRimuoviMedico.Size = new System.Drawing.Size(310, 50);
            this.btnRimuoviMedico.TabIndex = 10;
            this.btnRimuoviMedico.Text = "Rimuovi medico";
            this.btnRimuoviMedico.UseVisualStyleBackColor = false;
            this.btnRimuoviMedico.Click += new System.EventHandler(this.btnRimuoviMedico_Click);
            // 
            // plInformazioniMedico
            // 
            this.plInformazioniMedico.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.plInformazioniMedico.Controls.Add(this.label6);
            this.plInformazioniMedico.Controls.Add(this.label5);
            this.plInformazioniMedico.Controls.Add(this.label4);
            this.plInformazioniMedico.Controls.Add(this.label3);
            this.plInformazioniMedico.Controls.Add(this.lblInCarica);
            this.plInformazioniMedico.Controls.Add(this.lblSpecializzazioneMedico);
            this.plInformazioniMedico.Controls.Add(this.lblCognomeMedico);
            this.plInformazioniMedico.Controls.Add(this.lblNomeMedico);
            this.plInformazioniMedico.Location = new System.Drawing.Point(23, 87);
            this.plInformazioniMedico.Name = "plInformazioniMedico";
            this.plInformazioniMedico.Size = new System.Drawing.Size(310, 143);
            this.plInformazioniMedico.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "In carica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Specializzazione:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome:";
            // 
            // lblInCarica
            // 
            this.lblInCarica.AutoSize = true;
            this.lblInCarica.Location = new System.Drawing.Point(121, 115);
            this.lblInCarica.Name = "lblInCarica";
            this.lblInCarica.Size = new System.Drawing.Size(56, 13);
            this.lblInCarica.TabIndex = 16;
            this.lblInCarica.Text = "lblInCarica";
            // 
            // lblSpecializzazioneMedico
            // 
            this.lblSpecializzazioneMedico.AutoSize = true;
            this.lblSpecializzazioneMedico.Location = new System.Drawing.Point(121, 84);
            this.lblSpecializzazioneMedico.Name = "lblSpecializzazioneMedico";
            this.lblSpecializzazioneMedico.Size = new System.Drawing.Size(130, 13);
            this.lblSpecializzazioneMedico.TabIndex = 15;
            this.lblSpecializzazioneMedico.Text = "lblSpecializzazioneMedico";
            // 
            // lblCognomeMedico
            // 
            this.lblCognomeMedico.AutoSize = true;
            this.lblCognomeMedico.Location = new System.Drawing.Point(121, 52);
            this.lblCognomeMedico.Name = "lblCognomeMedico";
            this.lblCognomeMedico.Size = new System.Drawing.Size(97, 13);
            this.lblCognomeMedico.TabIndex = 14;
            this.lblCognomeMedico.Text = "lblCognomeMedico";
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.Location = new System.Drawing.Point(121, 19);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(80, 13);
            this.lblNomeMedico.TabIndex = 13;
            this.lblNomeMedico.Text = "lblNomeMedico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Informazioni medico";
            // 
            // btnSelezionaMedico
            // 
            this.btnSelezionaMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelezionaMedico.FlatAppearance.BorderSize = 0;
            this.btnSelezionaMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelezionaMedico.Location = new System.Drawing.Point(230, 18);
            this.btnSelezionaMedico.Name = "btnSelezionaMedico";
            this.btnSelezionaMedico.Size = new System.Drawing.Size(103, 44);
            this.btnSelezionaMedico.TabIndex = 13;
            this.btnSelezionaMedico.Text = "Seleziona";
            this.btnSelezionaMedico.UseVisualStyleBackColor = false;
            this.btnSelezionaMedico.Click += new System.EventHandler(this.btnSelezionaMedico_Click);
            // 
            // RimuoviMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 330);
            this.Controls.Add(this.btnSelezionaMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plInformazioniMedico);
            this.Controls.Add(this.btnRimuoviMedico);
            this.Controls.Add(this.tbCodiceMedico);
            this.Controls.Add(this.label1);
            this.Name = "RimuoviMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RimuoviMedico";
            this.Load += new System.EventHandler(this.RimuoviMedico_Load);
            this.plInformazioniMedico.ResumeLayout(false);
            this.plInformazioniMedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodiceMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRimuoviMedico;
        private System.Windows.Forms.Panel plInformazioniMedico;
        private System.Windows.Forms.Label lblInCarica;
        private System.Windows.Forms.Label lblSpecializzazioneMedico;
        private System.Windows.Forms.Label lblCognomeMedico;
        private System.Windows.Forms.Label lblNomeMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelezionaMedico;
    }
}