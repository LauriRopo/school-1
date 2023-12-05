using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        /* T5 KT3
        Tee ohjelma, joka laskee mäkihyppääjän yhden kierroksen suorituspisteet.
        Ohjelma kysyy hypyn pituuden (liukuluku 0.5 metrin välein) sekä viiden arvostelutuomarin tyylipisteet (0-20 välillä 0.5 välein eli esim.
        16.5 tai 17.0 tai 18.5). Hyppääjän pisteet muodostuvat kaavasta.

        pisteet = (hypyn pituus - kriittinen piste) * 1.8 + kolmen keskimmäisen tuomarin tyylipisteet + 60. 
        Tyylipisteissä siis parhain ja huonoin pistemäärä tipahtaa pois.

        Ohjelman hyppyrimäen kriittinen piste on 90 metrin kohdalla
        Laita kriittinen piste vakioon KR_PISTE.
        Tulosta lopuksi hypyn pituus ja hypyn pisteet.
        Käytä ohjelmassa funktioita (funktiot eivät saa palauttaa mitään):

        KysyHypynPituus
        KysyTuomareidenPisteet
        LaskeHypynPisteet
        Tulosta


      */

        static void KysyHypynPituus(out double dPituus)
        {
            
            Console.Write("Ilmoita hypyn pituus : ");
            dPituus = double.Parse(Console.ReadLine());


        }
        static void KysyTuomareidenPisteet(out double dTpisteet)
        {

            double i;
            

                Console.Write("Kerro {0}. tuomarin pisteet : ");
                dTpisteet = double.Parse(Console.ReadLine());
                
              
        }
        static void LaskeHypynPisteet(double dPituus,double dTpisteet, int Kpiste)
        {
            Console.Clear();
            double Pisteet;
            Console.Write("Pistemäärä on : {0}  ",Pisteet = (dPituus + Kpiste) * 1.8 + dTpisteet + 60);
            Console.WriteLine();
        }
        

    
         static void Main()
        {
            int Kpiste = 90;
            double dPituus, dTpisteet;
            KysyHypynPituus(out dPituus);
            KysyTuomareidenPisteet(out dTpisteet);
            LaskeHypynPisteet(dPituus, dTpisteet, Kpiste);
            


        }
            
    }       
}
