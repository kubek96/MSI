using System;

namespace RoughSet
{
    public class Rule
    {
        private static uint count = 0;
        private uint _id;

        private string _position;
        private bool _decision;
        
        private bool? _bd;
        private bool? _ji;
        private EnglishLevel? _ja;
        private bool? _d;
        private uint? _ll;
        private bool? _c;
        private bool? _s;
        private double? _o;
        private Education? _w;
        private string _ks;
        private bool? _st;
        private bool? _net;
        private bool? _asp;
        private bool? _mvc;
        private bool? _wpf;
        private bool? _ef;
        private bool? _hcj;

        public bool Decide(Item i)
        {
            bool r = _decision;

            if(_bd != null) if (i.BD != _bd) r = !_decision;
            if (_ji != null) if (i.JI != _ji) r = !_decision;
            if (_ja != null) if (i.JA < _ja) r = !_decision;
            if (_d != null) if (i.D != _d) r = !_decision;
            if (_ll != null) if (i.LL < _ll) r = !_decision;
            if (_c != null) if (i.C != _c) r = !_decision;
            if (_s != null) if (i.S != _s) r = !_decision;
            if (_o != null) if (i.O < _o) r = !_decision;
            if (_w != null) if (i.W < _w) r = !_decision;
            if (_ks != null) if (string.Compare(i.KS, _ks) != 0) r = !_decision;
            if (_st != null) if (i.ST != _st) r = !_decision;
            if (_net != null) if (i.NET != _net) r = !_decision;
            if (_asp != null) if (i.ASP != _asp) r = !_decision;
            if (_mvc != null) if (i.MVC != _mvc) r = !_decision;
            if (_wpf != null) if (i.WPF != _wpf) r = !_decision;
            if (_ef != null) if (i.EF != _ef) r = !_decision;
            if (_hcj != null) if (i.HCJ != _hcj) r = !_decision;

            return r;
        }

        public Rule(string position, bool? bd, bool? ji, EnglishLevel? ja, bool? d, uint ll, bool? c, bool? s, double? o, Education? w, string ks, bool? st, bool? net, bool? asp, bool? mvc, bool? wpf, bool? ef, bool? hcj, bool decision)
        {
            _id = ++count;

            _position = position;

            _bd = bd;
            _ji = ji;
            _ja = ja;
            _d = d;
            _ll = ll;
            _c = c;
            _s = s;
            _o = o;
            _w = w;
            _ks = ks;
            _st = st;
            _net = net;
            _asp = asp;
            _mvc = mvc;
            _wpf = wpf;
            _ef = ef;
            _hcj = hcj;

            _decision = decision;
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public bool? Decision
        {
            get { return _decision; }
            set { _decision = value.Value; }
        }

        public bool? Bd
        {
            get { return _bd; }
            set { _bd = value; }
        }

        public bool? Ji
        {
            get { return _ji; }
            set { _ji = value; }
        }

        public EnglishLevel? Ja
        {
            get { return _ja; }
            set { _ja = value; }
        }

        public bool? D
        {
            get { return _d; }
            set { _d = value; }
        }

        public uint? Ll
        {
            get { return _ll; }
            set { _ll = value; }
        }

        public bool? C
        {
            get { return _c; }
            set { _c = value; }
        }

        public bool? S
        {
            get { return _s; }
            set { _s = value; }
        }

        public double? O
        {
            get { return _o; }
            set { _o = value; }
        }

        public Education? W
        {
            get { return _w; }
            set { _w = value; }
        }

        public string Ks
        {
            get { return _ks; }
            set { _ks = value; }
        }

        public bool? St
        {
            get { return _st; }
            set { _st = value; }
        }

        public bool? Net
        {
            get { return _net; }
            set { _net = value; }
        }

        public bool? Asp
        {
            get { return _asp; }
            set { _asp = value; }
        }

        public bool? Mvc
        {
            get { return _mvc; }
            set { _mvc = value; }
        }

        public bool? Wpf
        {
            get { return _wpf; }
            set { _wpf = value; }
        }

        public bool? Ef
        {
            get { return _ef; }
            set { _ef = value; }
        }

        public bool? Hcj
        {
            get { return _hcj; }
            set { _hcj = value; }
        }

        public uint Id
        {
            get { return _id; }
        }
    }
}