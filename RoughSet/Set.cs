using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RoughSet
{
    public class Set
    {
        private List<Rule> _rules;
        private ObservableCollection<Item> _universum;

        public Set()
        {
            _rules = new List<Rule>();
            _universum = new ObservableCollection<Item>();
        }

        public void GenerateRandomSet(int n)
        {
            Item.Count = 0;
            var t = Helper.GenerateRandomSet(n);
            _universum.Clear();
            for (int i = 0; i < t.Length; i++)
            {
                _universum.Add(t[i]);
            }
        }

        public void GenerateRules()
        {
            _rules = Helper.GenerateRules().ToList();
        }

        public List<Rule> Rules
        {
            get { return _rules; }
        }

        public ObservableCollection<Item> Universum
        {
            get { return _universum; }
        }
    }
}