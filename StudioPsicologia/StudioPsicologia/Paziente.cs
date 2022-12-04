using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudioPsicologia
{
    class Paziente
    {
        string nome;
        string cognome;
        int giornoNascita;
        int meseNascita;
        int annoNascita;


        public string  _nome { get { return nome; } set { nome = value; } }
        public string _cognome { get { return cognome; } set { cognome = value; } }

        public int _giornoNascita { get { return giornoNascita; } set { giornoNascita = value; } }
        public int _meseNascita { get { return meseNascita; } set { meseNascita = value; } }
        public int _annoNascita { get { return annoNascita; } set { annoNascita = value; } }

        public Paziente(string nome, string cognome, int giornoNascita, int meseNascita, int annoNascita)
        {
            this.nome = nome;
            this.cognome = cognome;

            this.giornoNascita = giornoNascita;
            this.meseNascita = meseNascita;
            this.annoNascita = annoNascita;



        }
        public Paziente() : this( "Paziente", "Paziente", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year) { }


        // override ToString
        public override string ToString()
        {
            return base.ToString(); // sistemare
        }


        // restituisce la quantità di byte occupata dal paziente nel file binario
        public int getByte()
        {
            return 0;
        }


        // formatta la stringa
        private string formattaStringa(string stringa) // da testare
        {
            if (stringa.Length > 20)
                stringa.Substring(0, 20);
            else if (stringa.Length < 20)
                stringa.PadRight(20);
            return stringa;
        }


        // salva il paziente nel file pazienti
        public void scriviPaziente()
        {
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);
            BinaryReader leggi = new BinaryReader(fs);



            // faccio belle cose

        }
 

        // crea codice paziente
        private string cadicePaziente()
        {
            // restituisco un codice paziente da salvare nel file
            return "";
        }
        public string getCodice()
        {
            return cadicePaziente();
        }


    }
}
