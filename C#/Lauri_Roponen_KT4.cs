using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            KT4
           Esittele nimi, pituus ja paino muuttujat. Esittele lisäksi bmi muuttuja.
           Kysy käyttäjältä nimi, pituus metreinä ja paino kilon tarkkuudella.
           Laske painoindeksi bmi muuttujaan seuraavasti: bmi = paino / pituus ^ 2
           Tulosta lopuksi:
           Sami Lahti, pituutesi on 1,81 m ja painosi 104 kg
           Painoindeksisi on siten 31,75

           */

            String Nimi;
            double Pituus;
            int Paino;
            double bmi;


            Console.WriteLine("Nimesi : ");
            Nimi = Console.ReadLine();

            Console.WriteLine("Pituus metreinä");
            Pituus = double.Parse(Console.ReadLine());

            Console.WriteLine("Paino kiloina");
            Paino = int.Parse(Console.ReadLine());

            bmi = Paino / ((Pituus / 100) * (Pituus / 100));




            Console.WriteLine(Nimi + " , pituutesi on " + Pituus + "m ja painosi on " + Paino + "Kg");
            Console.WriteLine("Painoindeksis on siten {0:f2} " , bmi);


        }
    }
}
