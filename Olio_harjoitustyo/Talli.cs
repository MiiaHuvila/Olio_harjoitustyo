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
        void laitaTalliTiedot(string tn, string pk, string ph)
        {
            talliNimi = tn;
            paikkakunta = pk;
            puh = ph;
        }
        void laitaTalliNimi(string tn)
        {
            talliNimi = tn;
        }
        void laitaPaikkakunta(string pk)
        {
            paikkakunta = pk;
        }
        void laitaPuh(string ph)
        {
            puh = ph;
        }
        //Tiedon vieminen oliosta
        string vieTalliNimi()
        {
            return talliNimi;
        }
        string viePaikkakunta()
        {
            return paikkakunta;
        }
        string viePuh()
        {
            return puh;
        }

    }
}
