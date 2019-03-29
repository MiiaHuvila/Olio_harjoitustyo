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

        /*  Karsina-luokan metodit  */
        //Tiedon tuominen olioon
        public void laitaKuivike(string k)
        {
            kuivike = k;
        }
        //Tiedon vieminen oliosta
        public string vieKuivike()
        {
            return kuivike;
        }
    }
}
