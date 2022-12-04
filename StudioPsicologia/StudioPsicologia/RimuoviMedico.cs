using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioPsicologia
{
    public partial class RimuoviMedico : Form
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

        public static RimuoviMedico instance;
        public RimuoviMedico()
        {
            instance = this;
            InitializeComponent();
        }








        // form load
        private void RimuoviMedico_Load(object sender, EventArgs e)
        {
            // bottoni
            btnRimuoviMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviMedico.Width, btnRimuoviMedico.Height, 10, 10));
            btnSelezionaMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSelezionaMedico.Width, btnSelezionaMedico.Height, 10, 10));

            // pannelli
            plInformazioniMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plInformazioniMedico.Width, plInformazioniMedico.Height, 10, 10));
        }















        string codiceMedico = "";
        Medico medico = new Medico();

        // bottone seleziona medico
        private void btnSelezionaMedico_Click(object sender, EventArgs e)
        {
            codiceMedico = tbCodiceMedico.Text;
            if (cercaMedico(codiceMedico))
            {
                // aggiorna label con medico trovato
                lblNomeMedico.Text = medico._nome;
                lblCognomeMedico.Text = medico._cognome;
                lblSpecializzazioneMedico.Text = medico._specializzazione;
                if (medico._inCarica)
                    lblInCarica.Text = "Si";
                else
                    lblInCarica.Text = "No";
            }
        }

        // bottone rimuovi medico
        private void btnRimuoviMedico_Click(object sender, EventArgs e)
        {
            rimuoviMedicoDallaCarica();
        }










        // funzione cerca medico
        private bool cercaMedico(string codice)     // da fare
        {
            // se esiste setta il medico e ritorna true 
            // altrimenti false

            Medico medicoTrovato = new Medico();

            if (true)
            {
                medico = medicoTrovato;
                return true;
            }
            return false;
        }

        // funzione riscrivi medico
        private void rimuoviMedicoDallaCarica()
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);
            BinaryReader leggi = new BinaryReader(fs);








            string codiceMedicoLetto = "";
            if (medico.getCodice() == codiceMedicoLetto)
            {
                // vai dove si trova il true nel file e cambialo con false
            }
        }









        // limitazioni textbox
        private void tbCodiceMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
    }
}
