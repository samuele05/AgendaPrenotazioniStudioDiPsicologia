
namespace StudioPsicologia
{
    partial class AggiuntaPaziente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomePaziente = new System.Windows.Forms.TextBox();
            this.tbCognomePaziente = new System.Windows.Forms.TextBox();
            this.dtpNascitaPaziente = new System.Windows.Forms.DateTimePicker();
            this.btnAggiungiPaziente = new System.Windows.Forms.Button();
            this.tbIAggiungiIBAN = new System.Windows.Forms.TextBox();
            this.IBAN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data di nascita";
            // 
            // tbNomePaziente
            // 
            this.tbNomePaziente.Location = new System.Drawing.Point(128, 28);
            this.tbNomePaziente.Name = "tbNomePaziente";
            this.tbNomePaziente.Size = new System.Drawing.Size(162, 20);
            this.tbNomePaziente.TabIndex = 3;
            this.tbNomePaziente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomePaziente_KeyPress);
            // 
            // tbCognomePaziente
            // 
            this.tbCognomePaziente.Location = new System.Drawing.Point(128, 63);
            this.tbCognomePaziente.Name = "tbCognomePaziente";
            this.tbCognomePaziente.Size = new System.Drawing.Size(162, 20);
            this.tbCognomePaziente.TabIndex = 4;
            this.tbCognomePaziente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCognomePaziente_KeyPress);
            // 
            // dtpNascitaPaziente
            // 
            this.dtpNascitaPaziente.Location = new System.Drawing.Point(128, 99);
            this.dtpNascitaPaziente.Name = "dtpNascitaPaziente";
            this.dtpNascitaPaziente.Size = new System.Drawing.Size(162, 20);
            this.dtpNascitaPaziente.TabIndex = 5;
            // 
            // btnAggiungiPaziente
            // 
            this.btnAggiungiPaziente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAggiungiPaziente.FlatAppearance.BorderSize = 0;
            this.btnAggiungiPaziente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiPaziente.Location = new System.Drawing.Point(32, 197);
            this.btnAggiungiPaziente.Name = "btnAggiungiPaziente";
            this.btnAggiungiPaziente.Size = new System.Drawing.Size(258, 50);
            this.btnAggiungiPaziente.TabIndex = 12;
            this.btnAggiungiPaziente.Text = "Aggiungi paziente";
            this.btnAggiungiPaziente.UseVisualStyleBackColor = false;
            this.btnAggiungiPaziente.Click += new System.EventHandler(this.btnAggiungiPaziente_Click);
            // 
            // tbIAggiungiIBAN
            // 
            this.tbIAggiungiIBAN.Location = new System.Drawing.Point(128, 146);
            this.tbIAggiungiIBAN.Name = "tbIAggiungiIBAN";
            this.tbIAggiungiIBAN.Size = new System.Drawing.Size(162, 20);
            this.tbIAggiungiIBAN.TabIndex = 14;
            this.tbIAggiungiIBAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIAggiungiIBAN_KeyPress);
            // 
            // IBAN
            // 
            this.IBAN.AutoSize = true;
            this.IBAN.Location = new System.Drawing.Point(29, 149);
            this.IBAN.Name = "IBAN";
            this.IBAN.Size = new System.Drawing.Size(32, 13);
            this.IBAN.TabIndex = 13;
            this.IBAN.Text = "IBAN";
            // 
            // AggiuntaPaziente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 279);
            this.Controls.Add(this.tbIAggiungiIBAN);
            this.Controls.Add(this.IBAN);
            this.Controls.Add(this.btnAggiungiPaziente);
            this.Controls.Add(this.dtpNascitaPaziente);
            this.Controls.Add(this.tbCognomePaziente);
            this.Controls.Add(this.tbNomePaziente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AggiuntaPaziente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AggiuntaPaziente";
            this.Load += new System.EventHandler(this.AggiuntaPaziente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNomePaziente;
        private System.Windows.Forms.TextBox tbCognomePaziente;
        private System.Windows.Forms.DateTimePicker dtpNascitaPaziente;
        private System.Windows.Forms.Button btnAggiungiPaziente;
        private System.Windows.Forms.TextBox tbIAggiungiIBAN;
        private System.Windows.Forms.Label IBAN;
    }
}