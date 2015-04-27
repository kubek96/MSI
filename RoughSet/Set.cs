using System.Collections.Generic;
using System.Linq;

namespace RoughSet
{
    public class Set
    {
        private List<Rule> _rules;
        private List<Item> _universum;

        public Set()
        {
            _rules = new List<Rule>();
            _universum = new List<Item>();
        }

        public void GenerateRandomSet(int n)
        {
            _universum = Helper.GenerateRandomSet(n).ToList();
        }

        public void GenerateRules()
        {
            _rules = Helper.GenerateRules().ToList();
        }

        public List<Rule> Rules
        {
            get { return _rules; }
        }

        public List<Item> Universum
        {
            get { return _universum; }
        }
    }
}