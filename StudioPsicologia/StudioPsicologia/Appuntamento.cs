using System;
using System.Collections.Generic;
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

        public Medico _medico { get { return medico; } set { medico = value; } }
        public Paziente _paziente { get { return paziente; } set { paziente = value; } }
        public string _data { get { return data; } set { data = value; } }
        public string _argomento { get { return argomento; } set { argomento = value; } }


        public Appuntamento(Medico medico, Paziente paziente, string data, string argomento)
        {
            this.medico = medico;
            this.paziente = paziente;
            this.data = data;
            this.argomento = argomento;
        }

        //public Appuntamento() : this()
        //{
        //}






    }
}
