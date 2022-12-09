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

        int inizioOrario;
        int fineOrario;


        public string _nome { get { return nome; } set { nome = value; } }
        public string _cognome { get { return cognome; } set { cognome = value; } }

        public string _specializzazione { get { return specializzazione; } set { specializzazione = value; } }
        public bool _inCarica { get { return inCarica; } set { inCarica = value; } }

        public int _inizioOrario { get { return inizioOrario; } set { inizioOrario = value; } }
        public int _fineOrario { get { return fineOrario; } set { fineOrario = value; } }


        public Medico(string nome, string cognome, string specializzazione, bool inCarica, int inizioOrario, int fineOrario)
        {
            this.nome = nome;
            this.cognome = cognome;

            this.specializzazione = specializzazione;
            this.inCarica = inCarica;

            this.inizioOrario = inizioOrario;
            this.fineOrario = fineOrario;
        }
        public Medico() : this("Medico", "Medico", "//", false, 0, 0) { }


        //// restituisce la quantità di byte occupata dal Medico nel file binario
        //public int getByte()
        //{
        //    return 0;
        //}


        // formatta stringa
        private string formattaStringa(string stringa) // da testare
        {
            if (stringa.Length > 20)
                stringa.Substring(0, 20);
            else if (stringa.Length < 20)
                stringa.PadRight(20);
            return stringa;
        }

        // formatta numero
        private string formattaNumero(int numero)
        {
            if (numero < 10)
                return $"{0}{numero}";
            return numero.ToString();
        }


        // salva il medici nel file pazienti
        public void scriviMedico()
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);

            fs.Seek(0, SeekOrigin.End);       // chiedere se va bene

            scrivi.Write(formattaStringa(nome));
            scrivi.Write(formattaStringa(cognome));
            scrivi.Write(formattaStringa(specializzazione));
            scrivi.Write(inCarica);
            scrivi.Write(inizioOrario);
            scrivi.Write(fineOrario);

            scrivi.Write(getCodice());

            fs.Close();
        }


        // crea codice medico
        private string codiceMedico()  // da controllare
        {
            string codiceMedico =
                $"{nome.Substring(0, 1).ToUpper()}" +
                $"{cognome.Substring(0, 1).ToUpper()}" +
                $"{specializzazione.Substring(0, 3).ToUpper()}" +
                $"{inCarica.ToString().Substring(0, 1).ToUpper()}" +
                $"{formattaNumero(inizioOrario)}" +
                $"{formattaNumero(fineOrario)}";
            return codiceMedico;
        }
        public string getCodice()
        {
            return codiceMedico();
        }
    }
}
