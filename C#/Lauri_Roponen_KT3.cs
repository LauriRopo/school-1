using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuntihommia.cs
{
    internal class Program
    {
        static void Main()
        {

            /*
             KT3
            Esittele kaksi kokonaislukumuuttujaa ja lue niihin käyttäjältä arvot.
            Tulosta näiden muuttujien summa, erotus ja tulo alla olevalla tavalla
            
            */

            int iluku1;
            int iluku2;
            int iSumma, ierotus, iTulo;

            Console.WriteLine("Anna numero");
            iluku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna toinen luku");
            iluku2 = int.Parse(Console.ReadLine());

            iSumma = iluku1 + iluku2;
            ierotus = iluku1 - iluku2;
            iTulo = iluku1 * iluku2;

            Console.WriteLine("Summa : {0} + {1} = {2} ",iluku1,iluku2, iSumma);
            Console.WriteLine("Erotus : {0} - {1} = {2} ", iluku1, iluku2, ierotus);
            Console.WriteLine("Tulo : {0} * {1} = {2} ", iluku1, iluku2, iTulo);



























        }
    }
}
