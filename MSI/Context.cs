using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Context()
        {
            _mainFrame = new Frame();
            _set = new Set();
            _set.GenerateRandomSet(50000);
            _set.GenerateRules();
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