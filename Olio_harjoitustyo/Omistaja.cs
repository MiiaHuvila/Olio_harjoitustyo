using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_harjoitustyo
{
    class Omistaja
    {
        //Omistaja-luokan ominaisuudet
        private String omistajaNimi;
        private String puhnum;

        /*  Omistaja-luokan metodit */
        //Tiedon tuominen olioon
        public void laitaOmistajaTiedot(string on, string ph)
        {
            omistajaNimi = on;
            puhnum = ph;
        }
        public void laitaOmistajaNimi(string on)
        {
            omistajaNimi = on;
        }
        public void laitaPuhnum(string ph)
        {
            puhnum = ph;
        }
        //Tiedon vieminen oliosta
        public string vieOmistajaNimi()
        {
            return omistajaNimi;
        }
        public string viePuhnum()
        {
            return puhnum;
        }
    }
}
