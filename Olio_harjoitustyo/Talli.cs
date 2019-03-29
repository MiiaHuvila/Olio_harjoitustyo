using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_harjoitustyo
{
    class Talli
    {
        //Talli-luokan ominaisuudet
        private String talliNimi;
        private String paikkakunta;
        private String puh;

        /*  Talli-luokan metodit    */
        //Tiedon tuominen olioon
        public void laitaTalliTiedot(string tn, string pk, string ph)
        {
            talliNimi = tn;
            paikkakunta = pk;
            puh = ph;
        }
        public void laitaTalliNimi(string tn)
        {
            talliNimi = tn;
        }
        public void laitaPaikkakunta(string pk)
        {
            paikkakunta = pk;
        }
        public void laitaPuh(string ph)
        {
            puh = ph;
        }
        //Tiedon vieminen oliosta
        public string vieTalliNimi()
        {
            return talliNimi;
        }
        public string viePaikkakunta()
        {
            return paikkakunta;
        }
        public string viePuh()
        {
            return puh;
        }

    }
}
