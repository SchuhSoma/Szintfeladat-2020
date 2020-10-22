using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szintfeladat_2020
{
    class Program
    {
        static Random rnd = new Random();
        static int[] SzamTMB = new int[50];
        static void Main(string[] args)
        {
            Feladat1(); Console.WriteLine("\n----------------------------------------------\n");
            Feladat2(); Console.WriteLine("\n----------------------------------------------\n");
            Feladat3(); Console.WriteLine("\n----------------------------------------------\n");
            Feladat4(); Console.WriteLine("\n----------------------------------------------\n");
            Feladat5(); Console.WriteLine("\n----------------------------------------------\n");
            Feladat6(); Console.WriteLine("\n----------------------------------------------\n");
            Feladat7(); Console.WriteLine("\n----------------------------------------------\n");
            Feladat8(); Console.WriteLine("\n----------------------------------------------\n");
            Console.ReadKey();

        }

        private static void Feladat8()
        {
            Console.WriteLine("Feladat 8: Rendezze csökkenő illetve növekvő sorrendbe a tömb elemeit és irassa ki a konzolra");
            Array.Sort(SzamTMB);//Ezzel a paranccsal növekvő sorrendbe raktam a tömb elemeit
            for (int i = 0; i < SzamTMB.Length; i++)
            {
                Console.Write("\t{0} , ", SzamTMB[i]);
                if ((i + 1) % 5 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("\n\t----------------------------------------------\n");
            Array.Reverse(SzamTMB);//Csökkenő sorrendbe rakja a tömb elemeit
            for (int j = 0; j < SzamTMB.Length; j++)
            {
                Console.Write("\t{0} , ", SzamTMB[j]);
                if ((j + 1) % 5 == 0)
                {
                    Console.Write("\n");
                }
            }
        }

        private static void Feladat7()
        {
            Console.WriteLine("Feladat 7: írja ki a tömb elemeinke átlagát");
            double Ossze = 0;
            double Atlag = 0;
            for (int i = 0; i < SzamTMB.Length; i++)
            {
                Ossze += (double)SzamTMB[i];
            }
            Atlag = Ossze / SzamTMB.Length;
            Console.WriteLine("\tA tömb elemeinek átlaga: {0:0.00}", Atlag);
        }

        private static void Feladat6()
        {
            Console.WriteLine("Feladat 6: 3-mal osztható számok száma");//Leszámlálási tétel
            int db = 0;
            for (int i = 0; i < SzamTMB.Length; i++)
            {
                if(SzamTMB[i]%3==0)
                {
                    db++;
                }
            }
            Console.WriteLine("\tEnnyi esetben találtunk 3-al osztható számot: {0}", db);
        }

        private static void Feladat5()
        {
            Console.WriteLine("Feladat 5: a legnagyobb elem és annak helye");//Maximum kiválasztás tétele
            int Max = int.MinValue;
            int MaxHely = 0;
            for (int i = 0; i < SzamTMB.Length; i++)
            {
                if(Max<SzamTMB[i])
                {
                    Max = SzamTMB[i];
                    MaxHely = i + 1;
                }
            }
            Console.WriteLine("\tA legnagyobb elem : {0}\n\tA legnagyobb elem helye: {1}", Max, MaxHely);
        }

        private static void Feladat4()
        {
            Console.WriteLine("Feladat 4:  legkisebb elem helye");//Minimum kiválasztás tétele
            int Min = int.MaxValue;
            int MinHely = 0;
            for (int i = 0; i < SzamTMB.Length; i++)
            {
                if(SzamTMB[i]<Min)
                {
                    Min = SzamTMB[i];
                    MinHely = i+1;
                }
            }
            Console.WriteLine("\tA tömb legkisebb elem: {0}\n\tMinimum ezen a helyen volt: {1}", Min, MinHely);
        }

        private static void Feladat3()
        {
            Console.WriteLine("Feladat 3: ha szerepel köztük a 1337, vagy ennek többszöröse, akkor azt kiíráskor piros színnel");
            for (int i = 0; i < SzamTMB.Length; i++)
            {
                Console.Write("\t{0}, ",SzamTMB[i]);
                if(SzamTMB[i]%1337==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (SzamTMB[i] % 1337 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if ((i + 1 )% 5 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.ResetColor();
        }

        private static void Feladat2()
        {
            Console.WriteLine("Feladat 2: a generált számok kiiratása úgy, hogy egy sorba 5 elem menjen vesszővel elválasztva");
            for (int i = 0; i < SzamTMB.Length; i++)
            {
                Console.Write("\t{0} , ", SzamTMB[i]);
                if ((i+1)%5==0)
                {
                    Console.Write("\n");
                }
            }
        }

        private static void Feladat1()
        {
            Console.WriteLine("Feladat 1: 50 elemű tömb feltöltése random számokkal amik 7 oszthatók és 4 jegyű számok");
            int Szam;
            for (int i = 0; i < SzamTMB.Length; i++)
            {
                Szam = rnd.Next(0, 1285);
                SzamTMB[i]= 1001 + 7 * Szam;
            }
           
        }
    }
}
