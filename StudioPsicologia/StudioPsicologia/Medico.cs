using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudioPsicologia
{
    class Medico
    {
        string nome;
        string cognome;
        string specializzazione;
        bool inCarica;


        public string _nome { get { return nome; } set { nome = value; } }
        public string _cognome { get { return cognome; } set { cognome = value; } }

        public string _specializzazione { get { return specializzazione; } set { specializzazione = value; } }
        public bool _inCarica { get { return inCarica; } set { inCarica = value; } }

        public Medico(string nome, string cognome, string specializzazione, bool inCarica)
        {
            this.nome = nome;
            this.cognome = cognome;

            this.specializzazione = specializzazione;
            this.inCarica = inCarica;


        }
        public Medico() : this("Medico", "Medico", "//", false) { }


        // override ToString
        public override string ToString()
        {
            return base.ToString(); // sistemare
        }


        // restituisce la quantità di byte occupata dal Medico nel file binario
        public int getByte()
        {
            return 0;
        }


        // formatta stringa
        private string formattaStringa(string stringa) // da testare
        {
            if (stringa.Length > 20)
                stringa.Substring(0, 20);
            else if (stringa.Length < 20)
                stringa.PadRight(20);
            return stringa;
        }


        // salva il medici nel file pazienti
        public void scriviMedico()
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);
            //BinaryReader leggi = new BinaryReader(fs);

            // faccio belle cose
        }


        // crea codice medico
        private string codiceMedico()
        {
            // restituisco un codice medico da salvare nel file
            return "";
        }
        public string getCodice()
        {
            return codiceMedico();
        }







    }
}
