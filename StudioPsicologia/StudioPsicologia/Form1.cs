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



        // ----------------------------------------------------------------------------------------------------



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


            // funzione start
            start();
        }










        // liste
        List<Medico> medici = new List<Medico>();
        List<Paziente> pazienti = new List<Paziente>();

        public int apertura = 8;
        public int chiusura = 18;

        Studio studio = new Studio();

        // def orari 
        public void definisciOrariStudio()
        {
            studio._orarioApertura = apertura;
            studio._orarioChiusura = chiusura;
        }


        // funzione start
        public void start()
        {
            // carica pazienti
            caricaPazienti();
            caricaCbPazienti();

            // carica medici
            caricaMedici();
            caricaCbMedici();

            // studio
            definisciOrariStudio();
            caricaAppuntamenti();
        }


        // funzione carica medici leggendo da file
        public void caricaAppuntamenti()
        {
            FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Appuntamento app = new Appuntamento();

                app._medico = cercaMedico(leggi.ReadString());
                app._paziente = cercaPaziente(leggi.ReadString());
                app._data = leggi.ReadString();
                app._argomento = leggi.ReadString();
                app._orario = leggi.ReadInt32();

                studio.aggiungiAppuntamento(app);
            }
            fs.Close();
        }


        // funzione cerca medico
        private Medico cercaMedico(string codiceMedico)
        {
            Medico med = new Medico();
            for (int i = 0; i < medici.Count; i++)
                if (medici[i].getCodice() == codiceMedico)
                    med = medici[i];
            return med;
        }


        // funzione cerca paziente
        private Paziente cercaPaziente(string codiceMedico)
        {
            Paziente paz = new Paziente();
            for (int i = 0; i < pazienti.Count; i++)
                if (pazienti[i].getCodice() == codiceMedico)
                    paz = pazienti[i];
            return paz;
        }









        // funzione carica medici leggendo da file
        public void caricaMedici()
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Medico med = new Medico();

                med._nome = leggi.ReadString().Trim(' ');
                med._cognome = leggi.ReadString().Trim(' ');
                med._specializzazione = leggi.ReadString().Trim(' ');
                med._inCarica = leggi.ReadBoolean();
                med._inizioOrario = leggi.ReadInt32();
                med._fineOrario = leggi.ReadInt32();

                fs.Seek(11, SeekOrigin.Current);

                medici.Add(med);
            }
            fs.Close();
        }


        // funzione carica pazienti leggendo da file
        public void caricaPazienti()
        {
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Paziente paz = new Paziente();

                paz._nome = leggi.ReadString().Trim(' ');
                paz._cognome = leggi.ReadString().Trim(' ');
                paz._giornoNascita = leggi.ReadInt32();
                paz._meseNascita = leggi.ReadInt32();
                paz._annoNascita = leggi.ReadInt32();
                paz._IBAN = leggi.ReadString();

                pazienti.Add(paz);
            }
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
        private void btnAggiungiAppuntamento_Click(object sender, EventArgs e)
        {
            // definisci appuntamento
            if (cbPazienti.Text != "" && cbMedici.Text != "")
            {
                Appuntamento app = new Appuntamento();
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
                app._data = dtpDataAppuntamento.Text;
                app._orario = Convert.ToInt32(nudOrario.Value);

                // definisci argomento
                app._argomento = tbArgomentoAppuntamento.Text;

                // aggiungi appuntamento
                studio.aggiungiAppuntamento(app);
                app.scriviAppuntemento();
            }
            else
                MessageBox.Show("Tutti i campi non sono stati inseriti", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }



        // COSE DA FARE

        // ricordati di ricaricare pazienti, medici e appuntamenti quando si chiude un form di aggiunta

        // aggiungere lettura file ed eventuali controlli di esistenza degli appuntamenti

        // lorario dell'appuntamento deve essere consono con quello dei medici e degli appuntamenti esistenti

        // fare in modo di visualizzare gli appuntamenti e modificarli



        // ----------------------------------------------------------------------------------------------------



        // limitazioni textbox
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
