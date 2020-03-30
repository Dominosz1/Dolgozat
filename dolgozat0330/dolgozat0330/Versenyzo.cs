using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat0330
{
    class Versenyzo
    {
        public string Nev { get; set; }
       public string Kategoria { get; set; }
        public string Egyesulet { get; set;}
         public int[] Pontok { get; set; }
        public int Osszpontszam => Feladat5(Pontok);
        public Versenyzo(string s)
        {
            var d = s.Split(';');
            this.Nev = d[0];
            this.Kategoria = d[1];
            this.Egyesulet = d[2];
            int[] tomb = new int[8];
            for (int i = 0; i < 8; i++)
            {
                tomb[i] = int.Parse(d[i + 3]);
            }
            Pontok = tomb;

        }
        private int Feladat5(int[] pontok)
        {
            Array.Sort(pontok);
            int osszpont = 0;
            for (int i = 0; i < pontok.Length; i++)
            {
                if (pontok[i] != 0 && i < 2) pontok[i] = 10;
                osszpont += pontok[i];
            }
            return osszpont;
        }

    }
}
