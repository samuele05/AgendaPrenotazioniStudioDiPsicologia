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
    public partial class Form1 : Form
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

        public static Form1 instance;
        public Form1()
        {
            instance = this;
            InitializeComponent();
        }













        private void Form1_Load(object sender, EventArgs e)
        {
            // bottoni
            btnAggiungiPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiPaziente.Width, btnAggiungiPaziente.Height, 10, 10));
            btnAggiungiMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiMedico.Width, btnAggiungiMedico.Height, 10, 10));
            btnRimuoviMedico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviMedico.Width, btnRimuoviMedico.Height, 10, 10));
            btnAggiungiAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAggiungiAppuntamento.Width, btnAggiungiAppuntamento.Height, 10, 10));

            // pannelli
            plInformazioniAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plInformazioniAppuntamento.Width, plInformazioniAppuntamento.Height, 10, 10));
            plAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plAppuntamento.Width, plAppuntamento.Height, 10, 10));
            plArgomento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plArgomento.Width, plArgomento.Height, 10, 10));



            // carica pazienti
            caricaPazienti();
            caricaCbPazienti();




        }










        // liste
        List<Medico> medici = new List<Medico>();
        List<Paziente> pazienti = new List<Paziente>();
        List<Appuntamento> appuntamenti = new List<Appuntamento>();




        public void caricaMedici()
        {

        }


        // funzione carica pazienti leggendo da file
        public void caricaPazienti()   // creare un paziente prima di caricarli + fare in modo che legga tutti i pazienti
        {
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            Paziente paz = new Paziente();

            //paz._nome = leggi.ReadString();
            //paz._cognome = leggi.ReadString();

            //paz._giornoNascita = leggi.ReadInt32();
            //paz._meseNascita = leggi.ReadInt32();
            //paz._annoNascita = leggi.ReadInt32();

            //paz._IBAN = leggi.ReadString();

            //pazienti.Add(paz);

            fs.Close();
        }






        // funzione carica pazienti nelle combo box
        public void caricaCbPazienti()
        {
            for (int i = 0; i < pazienti.Count; i++)
                cbPazienti.Items.Add($"{pazienti[i]._nome} {pazienti[i]._cognome} {pazienti[i].getCodice()}");
        }

        // funzione carica medici nelle combo box
        public void caricaCbMedici()
        {
            for (int i = 0; i < medici.Count; i++)
                cbMedici.Items.Add($"{medici[i]._nome} {medici[i]._cognome} {medici[i].getCodice()}");
        }







        // bottone aggiungi appuntamento
        private void btnAggiungiAppuntamento_Click(object sender, EventArgs e) // verificare che l'appuntamento non esista già
        {
            Appuntamento app = new Appuntamento();

            // definisci appuntamento
            if (cbPazienti.Text != "" && cbMedici.Text != "")
            {
                string codicePaziente = cbPazienti.SelectedItem.ToString().Split(' ')[2];
                string codiceMedico = cbMedici.SelectedItem.ToString().Split(' ')[2];


                // definisci paziente
                for (int i = 0; i < pazienti.Count; i++)
                    if (pazienti[i].getCodice() == codicePaziente)
                        app._paziente = pazienti[i];

                // definisci medico
                for (int i = 0; i < medici.Count; i++)
                    if (medici[i].getCodice() == codiceMedico)
                        app._medico = medici[i];

                // definisci data
                // cose belle

                // definisci argomento
                app._argomento = tbArgomentoAppuntamento.Text;

            }
            else
                MessageBox.Show("Tutti i campi non sono stati inseriti", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }




        // COSE DA FARE
        // ricordati di ricaricare pazienti, medici e appuntamenti quando si chiude un form di aggiunta
        // trovare un modo per definire la data e ora dell'appuntamento
        // caricare nella lista appuntamenti gli appuntamenti una volta riaperto il programma
        // sistemare funzione carica pazienti e medici
        // vedere la questione degli orari di apertura dato che per ora i medici possono lavorare dalle 0 alle 23
        // aggiungere lettura file ed eventuali controlli di esistenza degli appuntamenti
        // lorario dell'appuntamento deve essere consono con quello dei medici e degli appuntamenti esistenti






        private void btnAggiungiPaziente_Click(object sender, EventArgs e)
        {
            AggiuntaPaziente aggiuntaPaziente = new AggiuntaPaziente();
            aggiuntaPaziente.ShowDialog();
        }

        private void btnAggiungiMedico_Click(object sender, EventArgs e)
        {
            AggiuntaMedico aggiuntaMedico = new AggiuntaMedico();
            aggiuntaMedico.ShowDialog();
        }

        private void btnRimuoviMedico_Click(object sender, EventArgs e)
        {
            RimuoviMedico rimuoviMedico = new RimuoviMedico();
            rimuoviMedico.ShowDialog(); 
        }
    }
}
