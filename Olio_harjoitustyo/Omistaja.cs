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
        void laitaOmistajaTiedot(string on, string ph)
        {
            omistajaNimi = on;
            puhnum = ph;
        }
        void laitaOmistajaNimi(string on)
        {
            omistajaNimi = on;
        }
        void laitaPuhnum(string ph)
        {
            puhnum = ph;
        }
        //Tiedon vieminen oliosta
        string vieOmistajaNimi()
        {
            return omistajaNimi;
        }
        string viePuhnum()
        {
            return puhnum;
        }
    }
}
