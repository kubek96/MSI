using RoughSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSI
{
    public class MinRule : Rule
    {
        public bool _decision;

        public MinRule(Result i, Result j)
        {
            if (i.R == j.R)
                _decision = false;
            else
                Decide(i, j);
            
        }

        public MinRule(MinRule mr)
        {
            this.Asp = mr.Asp;
            this.Bd = mr.Bd;
            this.C = mr.C;
            this.D = mr.D;
            this.Decision = mr.Decision;
            this.Ef = mr.Ef;
            this.Hcj = mr.Hcj;
            this.Ja = mr.Ja;
            this.Ji = mr.Ji;
            this.Ks = mr.Ks;
            this.Ll = mr.Ll;
            this.Mvc = mr.Mvc;
            this.Net = mr.Net;
            this.O = mr.O;
            this.Position = mr.Position;
            this.S = mr.S;
            this.St = mr.St;
            this.W = mr.W;
            this.Wpf = mr.Wpf;
        }

        public void Decide(Result i, Result j)
        {
            if ((this.Asp = i.ASP) == j.ASP) this.Asp = null;
            if ((this.Bd = i.BD) == j.BD) this.Bd = null;
            if ((this.C = i.C) == j.C) this.C = null;
            if ((this.D = i.D) == j.D) this.D = null;
            if ((this.Ef = i.EF) == j.EF) this.Ef = null;
            if ((this.Hcj = i.HCJ) == j.HCJ) this.Hcj = null;
            if ((this.Ja = i.JA) == j.JA) this.Ja = null;
            if ((this.Ji = i.JI) == j.JI) this.Ji = null;
            if ((this.Ks = i.KS) == j.KS) this.Ks = null;
            if ((this.Ll = i.LL) == j.LL) this.Ll = null;
            if ((this.Mvc = i.MVC) == j.MVC) this.Mvc = null;
            if ((this.Net = i.NET) == j.NET) this.Net = null;
            if ((this.O = i.O) == j.O) this.O = null;
            if ((this.S = i.S) == j.S) this.S = null;
            if ((this.St = i.ST) == j.ST) this.St = null;
            if ((this.W = i.W) == j.W) this.W = null;
            if ((this.Wpf = i.WPF) == j.WPF) this.Wpf = null;
            this.Decision = i.R;
            _decision = true;
        }

        public void Add(MinRule i)
        {
            if (this.Asp == null) this.Asp = i.Asp;
            if (this.Bd == null) this.Bd = i.Bd;
            if (this.C == null) this.C = i.C;
            if (this.D == null) this.D = i.D;
            if (this.Ef == null) this.Ef = i.Ef;
            if (this.Hcj == null) this.Hcj = i.Hcj;
            if (this.Ja == null) this.Ja = i.Ja;
            if (this.Ji == null) this.Ji = i.Ji;
            if (this.Ks == null) this.Ks = i.Ks;
            if (this.Ll == null) this.Ll = i.Ll;
            if (this.Mvc == null) this.Mvc = i.Mvc;
            if (this.Net == null) this.Net = i.Net;
            if (this.O == null) this.O = i.O;
            if (this.S == null) this.S = i.S;
            if (this.St == null) this.St = i.St;
            if (this.W == null) this.W = i.W;
            if (this.Wpf == null) this.Wpf = i.Wpf;
        }

        public static List<MinRule> Add(MinRule i, MinRule j)
        {
            List<MinRule> minRule = new List<MinRule>();
            MinRule m;
            if (j.Asp != null)
            {
                m = new MinRule(i);
                m.Asp = j.Asp;
                AddToList(m, minRule);
            }
            if (j.Bd != null)
            {
                m = new MinRule(i);
                m.Bd = j.Bd;
                AddToList(m, minRule);
            }
            if (j.C != null)
            {
                m = new MinRule(i);
                m.C = j.C;
                AddToList(m, minRule);
            }
            if (j.D != null)
            {
                m = new MinRule(i);
                m.D = j.D;
                AddToList(m, minRule);
            }
            if (j.Ef != null)
            {
                m = new MinRule(i);
                m.Ef = j.Ef;
                AddToList(m, minRule);
            }
            if (j.Hcj != null)
            {
                m = new MinRule(i);
                m.Hcj = j.Hcj;
                AddToList(m, minRule);
            }
            if (j.Ja != null)
            {
                m = new MinRule(i);
                m.Ja = j.Ja;
                AddToList(m, minRule);
            }
            if (j.Ji != null)
            {
                m = new MinRule(i);
                m.Ji = j.Ji;
                AddToList(m, minRule);
            }
            if (j.Ks != null)
            {
                m = new MinRule(i);
                m.Ks = j.Ks;
                AddToList(m, minRule);
            }
            if (j.Ll != null)
            {
                m = new MinRule(i);
                m.Ll = j.Ll;
                AddToList(m, minRule);
            }
            if (j.Mvc != null)
            {
                m = new MinRule(i);
                m.Mvc = j.Mvc;
                AddToList(m, minRule);
            }
            if (j.Net != null)
            {
                m = new MinRule(i);
                m.Net = j.Net;
                AddToList(m, minRule);
            }
            if (j.O != null)
            {
                m = new MinRule(i);
                m.O = j.O;
                AddToList(m, minRule);
            }
            if (j.S != null)
            {
                m = new MinRule(i);
                m.S = j.S;
                AddToList(m, minRule);
            }
            if (j.St != null)
            {
                m = new MinRule(i);
                m.St = j.St;
                AddToList(m, minRule);
            }
            if (j.W != null)
            {
                m = new MinRule(i);
                m.W = j.W;
                AddToList(m, minRule);
            }
            if (j.Wpf != null)
            {
                m = new MinRule(i);
                m.Wpf = j.Wpf;
                AddToList(m, minRule);
            }

            return minRule;
        }

        public static bool AddToList(MinRule m, List<MinRule> minRule)
        {
            bool compare = false;

            for (int k = 0; k < minRule.Count; ++k)
                if ((compare = Compare(minRule[k], m)) == true)
                    break;
            if (!compare)
                minRule.Add(m);

            return compare;
        }

        public static bool Compare(MinRule i, MinRule j)
        {
            if (i.Asp != j.Asp) return false;
            if (i.Bd != j.Bd) return false;
            if (i.C != j.C) return false;
            if (i.D != j.D) return false;
            if (i.Ef != j.Ef) return false;
            if (i.Hcj != j.Hcj) return false;
            if (i.Ja != j.Ja) return false;
            if (i.Ji != j.Ji) return false;
            if (i.Ks != j.Ks) return false;
            if (i.Ll != j.Ll) return false;
            if (i.Mvc != j.Mvc) return false;
            if (i.Net != j.Net) return false;
            if (i.O != j.O) return false;
            if (i.S != j.S) return false;
            if (i.St != j.St) return false;
            if (i.W != j.W) return false;
            if (i.Wpf != j.Wpf) return false;

            return true;
        }

        public bool Contains(MinRule mr)
        {
            if (this.Decision != null) if (this.Decision != mr.Decision) return false;
            if (this.Asp != null) if (this.Asp != mr.Asp) return false;
            if (this.Bd != null) if (this.Bd != mr.Bd) return false;
            if (this.C != null) if (this.C != mr.C) return false;
            if (this.D != null) if (this.D != mr.D) return false;
            if (this.Ef != null) if (this.Ef != mr.Ef) return false;
            if (this.Hcj != null) if (this.Hcj != mr.Hcj) return false;
            if (this.Ja != null) if (this.Ja != mr.Ja) return false;
            if (this.Ji != null) if (this.Ji != mr.Ji) return false;
            if (this.Ks != null) if (this.Ks != mr.Ks) return false;
            if (this.Ll != null) if (this.Ll != mr.Ll) return false;
            if (this.Mvc != null) if (this.Mvc != mr.Mvc) return false;
            if (this.Net != null) if (this.Net != mr.Net) return false;
            if (this.O != null) if (this.O != mr.O) return false;
            if (this.S != null) if (this.S != mr.S) return false;
            if (this.St != null) if (this.St != mr.St) return false;
            if (this.W != null) if (this.W != mr.W) return false;
            if (this.Wpf != null) if (this.Wpf != mr.Wpf) return false;

            return true;
        }
    }
}
