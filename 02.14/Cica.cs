using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._14
{
    internal class Cica
    {
        Random rand = new Random();
        string nev;
        int kor;
        int suly;
        string fajta;
        string szin;
        int rendetlensegszint;
        int fogyasztas;
        bool ehes;
        string nem;

        public Cica(string nev, int kor, int suly, string fajta, string szin, int rendetlensegszint, int fogyasztas, string nem)
        {
            this.nev = nev;
            this.kor = kor;
            this.suly = suly;
            this.fajta = fajta;
            this.szin = szin;
            this.rendetlensegszint = rendetlensegszint;
            this.fogyasztas = fogyasztas;
            this.nem = nem;
            ehes = true;
        }

        public string Nev => nev;
        public int Kor => kor;
        public int Suly => suly;
        public string Fajta => fajta;
        public string Szin => szin;
        public int Rendetlensegszint => rendetlensegszint;
        public int Fogyasztas => fogyasztas;
        public bool Ehes => ehes;
        public string Nem => nem;

        public void Eves(double kajasuly)
        {
            int esely = rand.Next(101);
            ehes = false;

            if (esely <= 30)
            {
                szin = "zöld";
                suly -= (int)(suly * (esely / 100.0));
                rendetlensegszint /= 2;
                Console.WriteLine("Buta cica megmérgezte saját magát. :(");
            }
            else
            {
                suly += (int)Math.Ceiling(fogyasztas * kajasuly);
                rendetlensegszint -= 10;
            }
        }

        public void Alvas()
        {
            rendetlensegszint = 0;

            if (szin == "zöld")
            {
                szin = "Eredeti";
            }
        }

        public void Ebredes()
        {
            rendetlensegszint = 100;
            ehes = true;
        }

        public void Jatek()
        {
            List<string> tevekenysegek = new List<string> { "Gombolyaggal játszik", "Egeret kerget", "Fára mászik", "Megkarmolja a saját gazdáját" };
            if (rendetlensegszint > 50)
            {
                tevekenysegek.Add("Romlott ételt eszik");
            }

            int maxRendetlensegszint = 100 - kor * 2;
            if (szin == "Narancssárga")
            {
                maxRendetlensegszint += 20;
            }

            if (rendetlensegszint < 31)
            {
                Console.WriteLine("A cica nagyon fáradt, szóval nem játszik most.");
            }
            else
            {
                int tevekenysegIndex = rand.Next(tevekenysegek.Count);
                string tevekenyseg = tevekenysegek[tevekenysegIndex];
                Console.WriteLine($"A cica {tevekenyseg}");

                if (tevekenyseg == "Romlott ételt eszik")
                {
                    Eves(0.5);
                }
            }

            ehes = true;
        }
    }
}
