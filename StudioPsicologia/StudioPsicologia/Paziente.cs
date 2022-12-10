﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudioPsicologia
{
    class Paziente
    {
        string nome;           // 20 + 1 byte
        string cognome;        // 20 + 1 byte
        int giornoNascita;     // 4 byte
        int meseNascita;       // 4 byte
        int annoNascita;       // 4 byte
        string IBAN;           // 27 + 1 byte

        // 21 + 21 + 4 + 4 + 4 = 54 + 28 = 82

        public string  _nome { get { return nome; } set { nome = value; } }
        public string _cognome { get { return cognome; } set { cognome = value; } }

        public int _giornoNascita { get { return giornoNascita; } set { giornoNascita = value; } }
        public int _meseNascita { get { return meseNascita; } set { meseNascita = value; } }
        public int _annoNascita { get { return annoNascita; } set { annoNascita = value; } }

        public string _IBAN { get { return IBAN; } set { IBAN = value; } }


        public Paziente(string nome, string cognome, int giornoNascita, int meseNascita, int annoNascita, string IBAN)
        {
            this.nome = nome;
            this.cognome = cognome;

            this.giornoNascita = giornoNascita;
            this.meseNascita = meseNascita;
            this.annoNascita = annoNascita;

            this.IBAN = IBAN;
        }
        public Paziente() : this( "Paziente", "Paziente", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, "IBAN") { }


        // formatta la stringa
        private string formattaStringa(string stringa)
        {
            if (stringa.Length > 20)
                stringa = stringa.Substring(0, 20);
            else if (stringa.Length < 20)
                stringa = stringa.PadRight(20);
            return stringa;
        }


        // salva il paziente nel file pazienti
        public void scriviPaziente()
        {
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);

            fs.Seek(0, SeekOrigin.End);       // chiedere se va bene

            scrivi.Write(formattaStringa(nome));
            scrivi.Write(formattaStringa(cognome));
            scrivi.Write(giornoNascita);
            scrivi.Write(meseNascita);
            scrivi.Write(annoNascita);

            scrivi.Write(IBAN);

            fs.Close();
        }
 

        // crea codice paziente
        //private string cadicePaziente()    // aggiungere identificatore paziente
        //{
        //    string codicePaziente = 
        //        $"{nome.Substring(0, 1).ToUpper()}" +
        //        $"{cognome.Substring(0, 1).ToUpper()}" +
        //        $"{formattaNumero(giornoNascita)}" +
        //        $"{formattaNumero(meseNascita)}" +
        //        $"{annoNascita}";

        //    return codicePaziente;
        //}


        private string formattaNumero(int numero)
        {
            if (numero < 10)
                return $"{0}{numero}";
            return numero.ToString();
        }

        public string getCodice()
        {
            //return cadicePaziente();
            return IBAN;
        }

        // mi restituisce la lunghezza del paziente nel file binario
        public int getByte()
        {
            return 54 + 28;
        }

        // lunghezza IBAN
        public int lunghezzaCodice()
        {
            return 28;
        }
    }
}
