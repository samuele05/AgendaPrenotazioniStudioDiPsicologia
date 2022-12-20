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
            btnRimuoviAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviAppuntamento.Width, btnRimuoviAppuntamento.Height, 10, 10));
            btnRimuoviPaziente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRimuoviPaziente.Width, btnRimuoviPaziente.Height, 10, 10));
            btnModificaAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnModificaAppuntamento.Width, btnModificaAppuntamento.Height, 10, 10));
            btnSeleziona.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSeleziona.Width, btnSeleziona.Height, 10, 10));

            // pannelli
            plInformazioniAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plInformazioniAppuntamento.Width, plInformazioniAppuntamento.Height, 10, 10));
            plAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plAppuntamento.Width, plAppuntamento.Height, 10, 10));
            plArgomento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plArgomento.Width, plArgomento.Height, 10, 10));
            plSelezionaAppuntamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, plSelezionaAppuntamento.Width, plSelezionaAppuntamento.Height, 10, 10));


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

            // carica combobox appuntamenti
            caricaCbAppuntamenti();

            // svuota label info appuntamento
            svuotaLabelInfoAppuntamento();
        }


        // funzione orari liberi
        public void orariLiberi()
        {
            cbOrariLiberi.Items.Clear();
            List<int> lista = new List<int>();

            int inizioOrario = 0;
            int fineOrario = 0;
            if (cbMedici.Text != "")
            {
                inizioOrario = cercaMedico(cbMedici.Text.Split(' ')[2])._inizioOrario;
                fineOrario = cercaMedico(cbMedici.Text.Split(' ')[2])._fineOrario;
            }

            for (int i = 0; i < chiusura - apertura; i++)
                lista.Add(i + 8);

            for (int i = 0; i < studio._appuntamenti.Count; i++)
                if (studio._appuntamenti[i]._data == dtpDataAppuntamento.Text)
                    lista.Remove(studio._appuntamenti[i]._orario);

            for (int i = 0; i < lista.Count; i++)
                if (lista[i] >= inizioOrario && lista[i] < fineOrario)
                    cbOrariLiberi.Items.Add(lista[i]);
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
                app._concluso = leggi.ReadBoolean();

                fs.Seek(50 + 1, SeekOrigin.Current);
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
        private Paziente cercaPaziente(string codicePaziente)
        {
            Paziente paz = new Paziente();
            for (int i = 0; i < pazienti.Count; i++)
                if (pazienti[i].getCodice() == codicePaziente)
                    paz = pazienti[i];
            return paz;
        }


        // funzione carica medici da file
        public void caricaMedici()
        {
            medici.Clear();

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


        // funzione carica pazienti da file
        public void caricaPazienti()
        {
            pazienti.Clear();

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


        // funzione carica pazienti nella combobox
        public void caricaCbPazienti()
        {
            cbPazienti.Items.Clear();
            for (int i = 0; i < pazienti.Count; i++)
                cbPazienti.Items.Add($"{pazienti[i]._nome} {pazienti[i]._cognome} {pazienti[i].getCodice()}");
        }

        // funzione carica medici nella combobox
        public void caricaCbMedici()
        {
            cbMedici.Items.Clear();
            for (int i = 0; i < medici.Count; i++)
                if (medici[i]._inCarica)    // carica solo i medici in carica
                    cbMedici.Items.Add($"{medici[i]._nome} {medici[i]._cognome} {medici[i].getCodice()}");
        }

        // funzione carica appuntamenti nella combobox
        public void caricaCbAppuntamenti()
        {
            studio._appuntamenti.Sort();

            cbAppuntamenti.Items.Clear();
            for (int i = 0; i < studio._appuntamenti.Count; i++)
                if (studio._appuntamenti[i]._data == dtpAppuntamenti.Text)
                    if (!(studio._appuntamenti[i]._concluso))
                        cbAppuntamenti.Items.Add(/*$"medico: {studio._appuntamenti[i]._medico._cognome} |" +
                        $" paziente: {studio._appuntamenti[i]._paziente._cognome} {studio._appuntamenti[i]._paziente._nome} |" + */
                        $" ora: {studio._appuntamenti[i]._orario} |" +
                        $" codice: {studio._appuntamenti[i].codiceAppuntamento()}");
        }

        // funzione carica informazioni appuntamenti
        public void caricaInfoAppuntamento()
        {
            for (int i = 0; i < studio._appuntamenti.Count; i++)
            {
                if (cbAppuntamenti.Text != "")
                {
                    string codice = cbAppuntamenti.Text.Split(' ')[5];
                    if (codice == studio._appuntamenti[i].codiceAppuntamento())
                    {
                        lblMedicoAppuntamento.Text = studio._appuntamenti[i]._medico.ToString();
                        lblPazienteAppuntamento.Text = studio._appuntamenti[i]._paziente.ToString();
                        lblDataAppuntamento.Text = studio._appuntamenti[i]._data;
                        lblOrarioAppuntamento.Text = studio._appuntamenti[i]._orario.ToString();
                        tbArgomentoInfoAppuntamento.Text = studio._appuntamenti[i]._argomento;
                    }
                }
            }
        }

        // funzione libera label info appuntamento
        public void svuotaLabelInfoAppuntamento()
        {
            lblMedicoAppuntamento.Text = "";
            lblPazienteAppuntamento.Text = "";
            lblDataAppuntamento.Text = "";
            lblOrarioAppuntamento.Text = "";
            lblArgomentoAppuntamento.Text = "";
        }


        // bottone aggiungi appuntamento
        private void btnAggiungiAppuntamento_Click(object sender, EventArgs e)
        {
            if (cbPazienti.Text != "" && cbMedici.Text != "")
            {
                if (!appEsiste())
                {
                    if (controllaOrario())
                    {
                        if (aggiungiAppuntamento())
                        {
                            caricaCbAppuntamenti();
                            MessageBox.Show("Appuntamento aggiunto", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else 
                            MessageBox.Show("Questo medico non è disponibile", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("L'orario non esiste", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }      
                else
                    MessageBox.Show("L'orario è occupato", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Tutti i campi non sono stati inseriti", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // aggiorna gli appuntamenti una volta agiunti
            caricaCbAppuntamenti();
        }


        // bottone rimuovi appuntamento
        private void btnRimuoviAppuntamento_Click(object sender, EventArgs e)
        {
            if (cbAppuntamenti.Text != "")
            {
                string codice = cbAppuntamenti.Text.Split(' ')[5];
                if (rimuoviAppuntamento(codice))
                {
                    caricaCbAppuntamenti();
                    MessageBox.Show("Rimosso", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    svuotaLabelInfoAppuntamento();
                }
                else
                    MessageBox.Show("L'appuntamento non esiste", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Inserire tutti i campi", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        

        // funzione rimuovi appuntamento
        public bool rimuoviAppuntamento(string codiceAppuntameneto)
        {
            Appuntamento app = new Appuntamento();
            FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);
            BinaryReader leggi = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                fs.Seek(app.getByte() - app.lunghezzaCodice(), SeekOrigin.Current);
                string codiceLetto = leggi.ReadString();

                if (codiceLetto == codiceAppuntameneto)
                {
                    fs.Seek(-(app.getByte()), SeekOrigin.Current);

                    for (int i = 0; i < studio._appuntamenti.Count; i++)
                        if (studio._appuntamenti[i].codiceAppuntamento() == codiceAppuntameneto)
                        {
                            studio._appuntamenti[i]._concluso = true;
                            studio._appuntamenti[i].scriviApp(scrivi);
                        }

                    fs.Close();
                    return true;
                }
            }
            fs.Close();
            return false;
        }


        // funzione esiste appuntamento
        public bool appEsiste()
        {
            int orario = 0;
            if (cbOrariLiberi.Text != "") 
                orario = Convert.ToInt32(cbOrariLiberi.Text);

            for (int i = 0; i < studio._appuntamenti.Count; i++)
                if (studio._appuntamenti[i]._data == dtpDataAppuntamento.Text)
                    if (studio._appuntamenti[i]._orario == orario)
                        if (!(studio._appuntamenti[i]._concluso))
                            return true;
            return false;
        }


        // controlla orario
        public bool controllaOrario()
        {
            int orario = 0;
            if (cbOrariLiberi.Text != "")
                orario = Convert.ToInt32(cbOrariLiberi.Text);

            if (orario >= apertura && orario < chiusura)
                return true;
            return false;
        }


        // funzione inizializza e scrivi appuntamento
        private bool aggiungiAppuntamento()
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
            int orario = 0;
            if (cbOrariLiberi.Text != "")
                orario = Convert.ToInt32(cbOrariLiberi.Text);

            if (!(orario >= app._medico._inizioOrario && orario < app._medico._fineOrario))
                return false;

            app._orario = orario;

            // definisci argomento
            app._argomento = tbArgomentoAppuntamento.Text;

            // definisci stato appuntamento
            app._concluso = false;

            // aggiungi appuntamento
            studio.aggiungiAppuntamento(app);
            app.scriviAppuntemento();

            return true;
        }


        // bottone rimuovi paziente
        private void btnRimuoviPaziente_Click(object sender, EventArgs e)
        {
            RimuoviPaziente rimuoviPaziente = new RimuoviPaziente();
            rimuoviPaziente.ShowDialog();
        }

        // bottone rimuovi medico
        private void btnRimuoviMedico_Click(object sender, EventArgs e)
        {
            RimuoviMedico rimuoviMedico = new RimuoviMedico();
            rimuoviMedico.ShowDialog();
        }

        // bottone seleziona data
        private void btnSeleziona_Click(object sender, EventArgs e)
        {
            caricaCbAppuntamenti();
        }



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

        // appoggio per verificare se la data o il medico sono cambiati
        string dataTest = "";
        string medicoTest = "";

        // timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            caricaInfoAppuntamento();
            if (dtpDataAppuntamento.Text != dataTest || cbMedici.Text != medicoTest)
            {
                orariLiberi();
                dataTest = dtpDataAppuntamento.Text;
                medicoTest = cbMedici.Text;
            }
        }
    }
}
