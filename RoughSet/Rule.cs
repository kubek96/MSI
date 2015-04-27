namespace RoughSet
{
    public class Rule
    {
        private bool _bd;
        private bool _ji;
        private EnglishLevel _ja;
        private bool _d;
        private uint _ll;
        private bool _c;
        private bool _s;
        private uint _o;
        private Education _w;
        private string _ks;
        private bool _st;
        private bool _net;
        private bool _asp;
        private bool _mvc;
        private bool _wpf;
        private bool _ef;
        private bool _hcj;

        public bool Recrutation(Item i)
        {
            bool r = true;

            if (i.BD != _bd) r = false;
            if (i.JI != _ji) r = false;
            if (i.JA != _ja) r = false;
            if (i.D != _d) r = false;
            if (i.LL != _ll) r = false;
            if (i.C != _c) r = false;
            if (i.S != _s) r = false;
            if (i.O != _o) r = false;
            if (i.W != _w) r = false;
            if (string.Compare(i.KS, _ks) != 0) r = false;
            if (i.ST != _st) r = false;
            if (i.NET != _net) r = false;
            if (i.ASP != _asp) r = false;
            if (i.MVC != _mvc) r = false;
            if (i.WPF != _wpf) r = false;
            if (i.EF != _ef) r = false;
            if (i.HCJ != _hcj) r = false;

            return r;
        }
    }
}