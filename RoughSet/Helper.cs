using System;
using System.Collections.Generic;

namespace RoughSet
{
    public static class Helper
    {
        public static Item[] GenerateRandomSet(int n)
        {
            Item[] t = new Item[n];
            Random rnd = new Random();

            int ks = 0;

            while (--n >= 0)
            {
                t[n] = new Item();

                t[n].BD = rnd.Next(100) > 50;
                t[n].JI = rnd.Next(100) > 50;
                t[n].JA = (EnglishLevel)rnd.Next(0, 3);
                t[n].D = rnd.Next(100) > 50;
                t[n].LL = (uint)rnd.Next(0,10);
                t[n].C = rnd.Next(100) > 50;
                t[n].S = rnd.Next(100) > 50;
                t[n].O = (uint)rnd.Next(3, 5);
                t[n].W = (Education)rnd.Next(0, 3);

                ks = rnd.Next(100);
                t[n].KS =  ks > 60 ? "Informatyka" : ks > 40 ? "Matematyka" : ks > 20 ? "Elektronika" : "Filozofia";

                t[n].ST = rnd.Next(100) > 50;
                t[n].NET = rnd.Next(100) > 50;
                t[n].ASP = rnd.Next(100) > 50;
                t[n].MVC = rnd.Next(100) > 50;
                t[n].WPF = rnd.Next(100) > 50;
                t[n].EF = rnd.Next(100) > 50;
                t[n].HCJ = rnd.Next(100) > 50;
            }

            return t;
        }

        public static Rule[] GenerateRules()
        {
            Rule[] t = new Rule[1];

            t[0] = new Rule("Junior developer", false, false, (EnglishLevel) 3, false, 0, true, true, 0, (Education)2,
                "Informatyka", false, true, true, false, false, false, false, true);

            return t;
        }
    }
}