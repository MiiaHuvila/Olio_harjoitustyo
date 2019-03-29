using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_harjoitustyo
{
    class Hevonen
    {
        /*  Hevonen-luokan ominaisuudet */
        private String hevonenNimi;
        private String rotu;

        /*  Hevonen-luokan metodit  */
        //tiedon tuominen olioon
        void laitaHevonenNimi(string hn)
        {
            hevonenNimi = hn;
        }
        void laitaHevonenRotu(string r)
        {
            rotu = r;
        }
        //tiedon vieminen oliosta
        string vieHevonenNimi()
        {
            return hevonenNimi;
        }
        string vieHevonenRotu()
        {
            return rotu;
        }
    }
}
