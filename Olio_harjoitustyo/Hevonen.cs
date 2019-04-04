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
        private Omistaja omaOmistaja;

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
        //omistajan lisääminen olioon
        public void laitaOmistaja(Omistaja o)
        {
            omaOmistaja = o;
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
        public string vieOmistajatiedot()
        {
            if (omaOmistaja != null)
            {
                string ot = "Omistajan nimi on " + omaOmistaja.vieOmistajaNimi() + " ja omistajan puhelinnumero on " + omaOmistaja.viePuhnum();
                return ot;
            }
            else
            {
                return "Kyseiseisen hevosen tietoihin ei ole liitetty omistajaa.";
            }
        }
    }
}
