
namespace StudioPsicologia
{
    partial class AggiuntaMedico
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
            this.tbCognomeMedico = new System.Windows.Forms.TextBox();
            this.tbNomeMedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpecializzazioneMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungiMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCognomeMedico
            // 
            this.tbCognomeMedico.Location = new System.Drawing.Point(127, 60);
            this.tbCognomeMedico.Name = "tbCognomeMedico";
            this.tbCognomeMedico.Size = new System.Drawing.Size(126, 20);
            this.tbCognomeMedico.TabIndex = 8;
            this.tbCognomeMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCognomeMedico_KeyPress);
            // 
            // tbNomeMedico
            // 
            this.tbNomeMedico.Location = new System.Drawing.Point(127, 25);
            this.tbNomeMedico.Name = "tbNomeMedico";
            this.tbNomeMedico.Size = new System.Drawing.Size(126, 20);
            this.tbNomeMedico.TabIndex = 7;
            this.tbNomeMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomeMedico_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // tbSpecializzazioneMedico
            // 
            this.tbSpecializzazioneMedico.Location = new System.Drawing.Point(127, 95);
            this.tbSpecializzazioneMedico.Name = "tbSpecializzazioneMedico";
            this.tbSpecializzazioneMedico.Size = new System.Drawing.Size(126, 20);
            this.tbSpecializzazioneMedico.TabIndex = 10;
            this.tbSpecializzazioneMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpecializzazioneMedico_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Specializzazione";
            // 
            // btnAggiungiMedico
            // 
            this.btnAggiungiMedico.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAggiungiMedico.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMedico.Location = new System.Drawing.Point(26, 142);
            this.btnAggiungiMedico.Name = "btnAggiungiMedico";
            this.btnAggiungiMedico.Size = new System.Drawing.Size(227, 50);
            this.btnAggiungiMedico.TabIndex = 11;
            this.btnAggiungiMedico.Text = "Aggiungi medico";
            this.btnAggiungiMedico.UseVisualStyleBackColor = false;
            this.btnAggiungiMedico.Click += new System.EventHandler(this.btnAggiungiMedico_Click);
            // 
            // AggiuntaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 221);
            this.Controls.Add(this.btnAggiungiMedico);
            this.Controls.Add(this.tbSpecializzazioneMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCognomeMedico);
            this.Controls.Add(this.tbNomeMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AggiuntaMedico";
            this.Text = "AggiuntaMedico";
            this.Load += new System.EventHandler(this.AggiuntaMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCognomeMedico;
        private System.Windows.Forms.TextBox tbNomeMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSpecializzazioneMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungiMedico;
    }
}