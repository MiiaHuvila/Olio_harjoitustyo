using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_harjoitustyo
{
    class Program
    {
        static void Main(string[] args)
        {
            Talli talli1 = new Talli();
            talli1.laitaTalliTiedot("Tallinen", "Kangasala", "666");
            Console.WriteLine("Tallin nimi on " + talli1.vieTalliNimi() + " ja paikkakunta on " + talli1.viePaikkakunta() + ". Yhteyden talliin saat numerosta " + talli1.viePuh());

            Hevonen hevonen1 = new Hevonen();
            hevonen1.laitaHevonenNimi("Tukkajumala");
            hevonen1.laitaHevonenRotu("Suomenhevonen");
            Console.WriteLine("Hevosen nimi on " + hevonen1.vieHevonenNimi() + " ja hevosen rotu on " + hevonen1.vieHevonenRotu());
            
            Karsina karsina1 = new Karsina();
            karsina1.laitaKuivike("Hamppu");
            Console.WriteLine("Karsinan kuivikkeena on " + karsina1.vieKuivike());

            Omistaja omistaja1 = new Omistaja();
            omistaja1.laitaOmistajaTiedot("Matti Meikäläinen", "0449729028");
            Console.WriteLine("Omistajan nimi on " +omistaja1.vieOmistajaNimi()+ " ja hänet tavoittaa numerosta " +omistaja1.viePuhnum());
            Console.ReadLine();
        }
    }
}
