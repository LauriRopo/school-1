using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace läksyt.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* T2 KT5
             * Lue käyttäjältä ympyrän säde liukulukuna. Kysy käyttäjältä myös nämä, Haluaako hän tehdä
             * kumpaa seuraavista ( eli käyttäjä syöttää numeron 1 tai 2)
             * 
             * 1 = Laskee ympyrän piirin
             * 2 = Laskee ympyrän pinta-alan
             */

            double dluku1;
            int iluku;
            double dPii = 3.14159, dhalk, dvastaus;
            

            Console.WriteLine("Kerro ympyrän säde liukulukuna");
            dluku1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Haluatko laskea piirin (1) vai pinta-alan (2)");
            iluku = int.Parse(Console.ReadLine());

            dhalk = 2 * dluku1;

            if (iluku == 1)
            {
                Console.WriteLine("Ympyrän piiri on : {0}", dvastaus = dPii * dhalk);

            }
            else if (iluku == 2)
            {
                Console.WriteLine("Ympyrän pinta-ala on : {0}", dvastaus = dPii * (dluku1 * dluku1));


            }

            













        }




    }
        
}
