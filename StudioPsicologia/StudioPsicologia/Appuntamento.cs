using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioPsicologia
{
    class Appuntamento
    {
        Medico medico;
        Paziente paziente;
        string data;
        string argomento;
        int orario;

        public Medico _medico { get { return medico; } set { medico = value; } }
        public Paziente _paziente { get { return paziente; } set { paziente = value; } }
        public string _data { get { return data; } set { data = value; } }
        public string _argomento { get { return argomento; } set { argomento = value; } }
        public int _orario { get { return orario; } set { orario = value; } }


        public Appuntamento(Medico medico, Paziente paziente, string data, string argomento, int orario)
        {
            this.medico = medico;
            this.paziente = paziente;
            this.data = data;
            this.argomento = argomento;
            this.orario = orario;
        }

        public Appuntamento() : this(new Medico(), new Paziente(), "", "", 0) { }



        public void scriviAppuntemento()
        {
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryWriter scrivi = new BinaryWriter(fs);

            fs.Seek(0, SeekOrigin.End);       // chiedere se va bene

            scrivi.Write(medico.getCodice());
            scrivi.Write(paziente.getCodice());

            scrivi.Write(formattaStringa(data));
            scrivi.Write(formattaStringa(argomento));

            scrivi.Write(formattaNumero(orario));

            fs.Close();
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

        // formatta numero
        private string formattaNumero(int numero)
        {
            if (numero < 10)
                return $"{0}{numero}";
            return numero.ToString();
        }
    }
}
