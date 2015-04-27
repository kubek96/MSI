namespace RoughSet
{
    public enum EnglishLevel
    {
        Zero,
        Basic,
        Intermediate,
        Advanced
    }

    public enum Education
    {
        Primary,
        Secondary,
        IncompleteHigher,
        Higher
    }

    public class Item
    {
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
    }
}