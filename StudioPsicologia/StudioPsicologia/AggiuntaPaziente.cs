using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace StudioPsicologia
{
    public partial class AggiuntaPaziente : Form
    {
        // Angoli arrotondati
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        // Sposta Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public static AggiuntaPaziente instance;
        public AggiuntaPaziente()
        {
            InitializeComponent();
            instance = this;
        }











        private void AggiuntaPaziente_Load(object sender, EventArgs e)
        {
            // bottoni
            btnAggiungiPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiPaziente.Width, btnAggiungiPaziente.Height, 10, 10));
        }

        Paziente paziente = new Paziente();
        int giornoDiNascita;
        int meseDiNascita;
        int annoDiNascita;







        // bottone aggiungi paziente
        private void btnAggiungiPaziente_Click(object sender, EventArgs e)
        {
            // definisci paziente
            inizializzaPaziente();

            // scrivi paziente
            if (scriviPaziente())
            {
                MessageBox.Show("Aggiunto", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // chiudi aggiunta medico
                this.Close();
            }
            else
                MessageBox.Show("Esiste già o non è stao inserito nulla", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
        }
        




        // funzione inizializza medico
        public void inizializzaPaziente()
        {
            paziente._nome = tbNomePaziente.Text;
            paziente._cognome = tbCognomePaziente.Text;

            data();
            paziente._giornoNascita = giornoDiNascita;
            paziente._meseNascita = meseDiNascita;
            paziente._annoNascita = annoDiNascita;
        }

        // funzione scrivi medico
        public bool scriviPaziente()
        {
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);
            BinaryReader leggi = new BinaryReader(fs);





            // leggere e definire il codice letto
            string codiceLetto = "";

            // codice medico è = a "" perchè il metodo non è ancora stato definito

            if (tbNomePaziente.Text != "" && tbCognomePaziente.Text != "")
            {
                if (paziente.getCodice() != codiceLetto)
                {
                    scrivi.Write(paziente._nome);
                    scrivi.Write(paziente._cognome);
                    scrivi.Write(paziente._giornoNascita);
                    scrivi.Write(paziente._meseNascita);
                    scrivi.Write(paziente._annoNascita);
                }
                else
                {
                    fs.Close();
                    return false;
                }
            }





            fs.Close();
            return true;
        }



        // funzione data
        public void data()
        {
            DateTime data = dtpNascitaPaziente.Value;
            giornoDiNascita = data.Date.Day;
            meseDiNascita = data.Date.Month;
            annoDiNascita = data.Date.Year;
        }







        // limitazioni textbox
        private void tbNomePaziente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void tbCognomePaziente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
    }
}
