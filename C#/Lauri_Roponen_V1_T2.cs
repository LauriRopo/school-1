using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmoiti2Läksy
{
    internal class Program
    {
        /*Esittele 10 alkioinen taulukko, jossa henkilötietoja. Yksittäisestä henkilöstä on tietoina

                - etunimi

                - sukunimi

                - pituus 

                - paino
         *  
         *  Käytä tietuetyyppiä! Tee static-tyyppinen eli ei siis tietueen sisäinen funktio LaskePainoindeksi, 
         *  joka saa parametrinaan henkilötaulukon ja tulostaa henkilöiden keskimääräisen painoindeksin.
         *  bmi = paino (kg) / pituus (m) 2
         * 
         */

        struct Henkilo
        {
            public string Enimi;
            public string Snimi;
            public double Pituus;
            public double Paino;

        }
        static void BMI(Henkilo[] henkilo)
        {
            double BmiKa = 0;
            
            foreach (Henkilo h in henkilo)
            {
                BmiKa += h.Paino;
            }
            Console.WriteLine("Henkilöiden keskimääräinen BMI on : {0}", (h.Paino / Math.Pow(h.Pituus, 2) / henkilo.Length));
        }





        static void Main(string[] args)
        {
            Henkilo[] henkilo = new Henkilo[1];
            Henkilo h;
            

            for(int i = 0; i < henkilo.Length; i++)
            {
                Console.WriteLine("Kerro nimi");
                h.Enimi = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Kerro sukunimesi");
                h.Snimi = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Kerro pituutesi");
                h.Pituus = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Kerro painosi");
                h.Paino = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            BMI(henkilo);
            
        }
    }
}
