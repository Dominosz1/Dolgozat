using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat0330
{
    class Program
    {
        private static List<Versenyzo> versenyzok = new List<Versenyzo>();
        static void Main(string[] args)
        {
            Beolvas();
            Feladat3();
            Feladat4();
            Feladat6();
            Console.ReadKey();
        }

        private static void Feladat6()
        {
            var v = versenyzok.Where(x => x.Kategoria.Contains("Noi")).OrderByDescending(x => x.Osszpontszam).First();
            Console.WriteLine($"6. feladat: \n\tNév: {v.Nev}\n\tEgyesület: {v.Egyesulet}\n\tÖsszpont: {v.Osszpontszam}");
        }

        private static void Feladat4()
        {
            var nok = versenyzok.Count(n => n.Kategoria.Contains("Noi"));
            var szazalek = (nok*100) / versenyzok.Count;
            Console.WriteLine("Feladat 4: {0:0.00}%" , szazalek);
        }

        private static void Feladat3()
        {
            Console.WriteLine($"Feladat 3: {versenyzok.Count}");
        }

        private static void Beolvas()
        {
            var sr = new StreamReader(@"..\..\Res\fob2016.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                versenyzok.Add(new Versenyzo(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
