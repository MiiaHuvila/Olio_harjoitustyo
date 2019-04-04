using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_harjoitustyo
{
    class Karsina
    {
        //Karsina-luokan ominaisuudet
        private String kuivike;
        private Talli omaTalli;
        private Hevonen asukas;

        /*  Karsina-luokan metodit  */
        //Tiedon tuominen olioon
        public void laitaKuivike(string k)
        {
            kuivike = k;
        }
        //Tallin lisääminen olioon
        public void laitaTalli(Talli t)
        {
            omaTalli = t;
        }
        //Asukkaan lisääminen olioon
        public void laitaAsukas(Hevonen h)
        {
            asukas = h;
        }
        //Tiedon vieminen oliosta
        public string vieKuivike()
        {
            return kuivike;
        }
        public string vieTalliTiedot()
        {
            if (omaTalli != null)
            {
                string ot = "Karsina sijaitsee tallissa nimeltä " + omaTalli.vieTalliNimi() + ", se sijaitsee paikkakunnalla " + omaTalli.viePaikkakunta() + " ja talliin saa yhteyden numerosta " + omaTalli.viePuh();
                return ot;
            }
            else
            {
                return "Karsinan tietoihin ei ole merkitty tallia";
            }
        }
    }
}
