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
        
        public void laitaHevonenNimi(string hn)
        {
            hevonenNimi = hn;
        }
        public void laitaHevonenRotu(string r)
        {
            rotu = r;
        }
        //tiedon vieminen oliosta
        public string vieHevonenNimi()
        {
            return hevonenNimi;
        }
        public string vieHevonenRotu()
        {
            return rotu;
        }
    }
}
