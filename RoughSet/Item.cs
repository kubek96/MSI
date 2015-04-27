using System.Threading;

namespace RoughSet
{
    public class Item
    {
        public static uint Count = 0;

        public uint ID { get; set; }
        public bool BD { get; set; }
        public bool JI { get; set; }
        public EnglishLevel JA { get; set; }
        public bool D { get; set; }
        public uint LL { get; set; }
        public bool C { get; set; }
        public bool S { get; set; }
        public uint O { get; set; }
        public Education W { get; set; }
        public string KS { get; set; }
        public bool ST { get; set; }
        public bool NET { get; set; }
        public bool ASP { get; set; }
        public bool MVC { get; set; }
        public bool WPF { get; set; }
        public bool EF { get; set; }
        public bool HCJ { get; set; }
        //public bool R { get; set; }
        
        public Item(bool bd, bool ji, EnglishLevel ja, uint ll, bool d, bool c, bool s, uint o, Education w, string ks, bool st, bool net, bool asp, bool mvc, bool wpf, bool hcj, bool ef)
        {
            ID = ++Count;

            BD = bd;
            JI = ji;
            JA = ja;
            LL = ll;
            D = d;
            C = c;
            S = s;
            O = o;
            W = w;
            KS = ks;
            ST = st;
            NET = net;
            ASP = asp;
            MVC = mvc;
            WPF = wpf;
            HCJ = hcj;
            EF = ef;
        }

        public Item()
        {
            ID = ++Count;
        }

        public Item(Item i)
        {
            ID = i.ID;
            BD = i.BD;
            JI = i.JI;
            JA = i.JA;
            LL = i.LL;
            D = i.D;
            C = i.C;
            S = i.S;
            O = i.O;
            W = i.W;
            KS = i.KS;
            ST = i.ST;
            NET = i.NET;
            ASP = i.ASP;
            MVC = i.MVC;
            WPF = i.WPF;
            HCJ = i.HCJ;
            EF = i.EF;
        }
    }
}