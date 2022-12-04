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
    public partial class AggiuntaMedico : Form
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

        public static AggiuntaMedico instance;
        public AggiuntaMedico()
        {
            instance = this;
            InitializeComponent();
        }










        // form load
        private void AggiuntaMedico_Load(object sender, EventArgs e)
        {
            // bottoni
            btnAggiungiMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiMedico.Width, btnAggiungiMedico.Height, 10, 10));
        }







        Medico medico = new Medico();

        // bottone aggiungi medico
        private void btnAggiungiMedico_Click(object sender, EventArgs e)
        {
            inizializzaMedico();

            if (scriviMedico())
                MessageBox.Show("Aggiunto", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Esiste già o non è stao inserito nulla", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        // inizializza medico
        public void inizializzaMedico()
        {
            medico._nome = tbNomeMedico.Text;
            medico._cognome = tbCognomeMedico.Text;
            medico._specializzazione = tbSpecializzazioneMedico.Text;
            medico._inCarica = true;
        }

        // scrivi medico
        public bool scriviMedico()
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);
            BinaryReader leggi = new BinaryReader(fs);


            string codiceLetto = "";

            // codice medico è = a "" perchè il metodo non è ancora stato definito

            if (tbNomeMedico.Text != "" &&
                tbCognomeMedico.Text != "" &&
                tbSpecializzazioneMedico.Text != "")
            {
                if (medico.getCodice() != codiceLetto)
                {
                    scrivi.Write(medico._nome);
                    scrivi.Write(medico._cognome);
                    scrivi.Write(medico._specializzazione);
                    scrivi.Write(medico._inCarica);
                }
                else return false;
            }
            return true;
        }










        // limitazioni textbox
        private void tbNomeMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void tbCognomeMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void tbSpecializzazioneMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
    }
}
