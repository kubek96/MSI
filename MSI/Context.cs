using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Controls;
using System.Windows.Documents;
using MahApps.Metro.Actions;
using RoughSet;

namespace MSI
{
    public class Context
    {
        private Frame _mainFrame;
        private Set _set;
        private ObservableCollection<Result> _results; 

        public Context()
        {
            _mainFrame = new Frame();
            _set = new Set();
            //_set.Universum.Add(new Item(false, false, (EnglishLevel)3, 0, false, true, true, 0, (Education)2, "Informatyka", false, true, true, false, false, false, false));
            _set.GenerateRandomSet(10000);
            _set.GenerateRules();
            _results = new ObservableCollection<Result>();
        }

        public void GenerateResults(int r)
        {
            _results.Clear();
            for (int i = 0; i < App.Context.Universum.Count; i++)
            {
                _results.Add(new Result(App.Context.Universum[i], _set.Rules[r]));
            }
        }

        public ObservableCollection<Result> Results
        {
            get { return _results; }
        }

        public List<Item> Universum
        {
            get { return _set.Universum; }
        }

        public List<Rule> Rules
        {
            get { return _set.Rules; }
        } 

        public Frame MainFrame
        {
            get { return _mainFrame; }
        }

        
    }
}