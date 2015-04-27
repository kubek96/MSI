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

            int prop = 10;
            int ks = 0;

            while (--n >= 0)
            {
                t[n] = new Item();

                t[n].BD = rnd.Next(100) > prop;
                t[n].JI = rnd.Next(100) > prop;
                t[n].JA = (EnglishLevel)rnd.Next(0, 4);
                t[n].D = rnd.Next(100) > prop;
                t[n].LL = (uint)rnd.Next(0,11);
                t[n].C = rnd.Next(100) > prop;
                t[n].S = rnd.Next(100) > prop;
                t[n].O = (uint)rnd.Next(3, 6);
                t[n].W = (Education)rnd.Next(0, 4);

                ks = rnd.Next(100);
                t[n].KS =  ks > 30 ? "Informatyka" : ks > 20 ? "Matematyka" : ks > 5 ? "Elektronika" : "Filozofia";

                t[n].ST = rnd.Next(100) > 90;
                t[n].NET = rnd.Next(100) > prop;
                t[n].ASP = rnd.Next(100) > prop;
                t[n].MVC = rnd.Next(100) > prop;
                t[n].WPF = rnd.Next(100) > prop;
                t[n].EF = rnd.Next(100) > prop;
                t[n].HCJ = rnd.Next(100) > prop;
            }

            return t;
        }

        public static Rule[] GenerateRules()
        {
            Rule[] t = new Rule[2];

            t[0] = new Rule("Junior developer", false, false, (EnglishLevel) 3, false, 0, true, true, 0, (Education)2,
                "Informatyka", false, true, true, false, false, false, false, true);

            t[1] = new Rule("Senior developer", null, null, (EnglishLevel)3, true, 2, true, true, 3.5, (Education) 2, null, false,
                true, true, true, null, true, null, true);
            return t;
        }
    }
}