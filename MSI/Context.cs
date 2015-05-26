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
        private ObservableCollection<MinRule> _minRules;
        private List<StringValue> _legend;

        public Context()
        {
            _mainFrame = new Frame();
            _set = new Set();
            _legend = new List<StringValue>();
            //_set.Universum.Add(new Item(false, false, (EnglishLevel)3, 0, false, true, true, 0, (Education)2, "Informatyka", false, true, true, false, false, false, false));
            _set.GenerateRandomSet(10000);
            _set.GenerateRules();
            GenerateLegend();
            _results = new ObservableCollection<Result>();
            _minRules = new ObservableCollection<MinRule>();
        }

        public void GenerateLegend()
        {
            _legend.Clear();
            _legend.Add(new StringValue("R", "Rezultat naboru - Przyjety/Nieprzyjety"));
            _legend.Add(new StringValue("ID", "Id aplikanta"));
            _legend.Add(new StringValue("BD", "Umiejetnosc pisania efektywnych zapytac do bazy danych - T/N"));
            _legend.Add(new StringValue("JI", "Znajomosc innych jezykow - T/N"));
            _legend.Add(new StringValue("JA", "Znajomosc jezyka angielskiego\n    0 - brak\n    1 - podstawowy\n    2 - srednio-zaawansowany\n    3 - zaawansowany"));
            _legend.Add(new StringValue("D", "Doswiadczenia na aplikowane stanowisko - T/N"));
            _legend.Add(new StringValue("LL", "Liczba przepracowanych lat w branzy IT - liczba lat"));
            _legend.Add(new StringValue("C", "Umiejetnosc programowania w jezyku C# - T/N"));
            _legend.Add(new StringValue("S", "Znajomosc podstaw - jezyki strukturalne - T/N"));
            _legend.Add(new StringValue("O", "Ocena z dyplomy"));
            _legend.Add(new StringValue("W", "Wyksztalcenie\n    0 - podstawowe\n    1 - srednie\n    2 - wyzsze niepelne\n    3 - wyzsze"));
            _legend.Add(new StringValue("KS", "Kierunek studiow"));
            _legend.Add(new StringValue("ST", "Czy osoba aplikuje na staz - T/N"));
            _legend.Add(new StringValue("NET" ,"Znajomosc platformy .Net - T/N"));
            _legend.Add(new StringValue("ASP", "Umiejetnosc prowadzenia projektow w ASP.NET - T/N"));
            _legend.Add(new StringValue("MVC", "Znajomosc MVC - T/N"));
            _legend.Add(new StringValue("WPF", "Umiejetnosc tworzenia aplikacji w WPF - T/N"));
            _legend.Add(new StringValue("EF" ,"Znajomosc EntityFramework - T/N"));
            _legend.Add(new StringValue("HCJ", "Znajomosc HTML, CSS, JavaScript - T/N"));
        }

        public void GenerateNewUniversum(int n)
        {
            _set.GenerateRandomSet(n);
        }

        public void GenerateResults(int r)
        {
            _results.Clear();
            for (int i = 0; i < App.Context.Universum.Count; i++)
            {
                _results.Add(new Result(App.Context.Universum[i], _set.Rules[r]));
            }
        }

        public void GenerateMinRules()
        {
            _minRules.Clear();
            List<List<MinRule>> matrix = new List<List<MinRule>>();
            for (int i = 0; i < _results.Count; ++i)
            {
                List<MinRule> tmp = new List<MinRule>();
                for (int j = 0; j < _results.Count; ++j)
                {
                    if (_results[i].R == _results[j].R) continue;
                    tmp.Add(new MinRule(_results[i], _results[j]));
                }
                matrix.Add(tmp);
            }

            List<MinRule> minRules = new List<MinRule>();
            foreach (var l in matrix)
            {
                if (l.Count < 2)
                    continue;
                List<MinRule> tmp = new List<MinRule>();
                List<MinRule> tmp2 = new List<MinRule>();
                tmp.Add(l[0]);

                for (int i = 1; i < l.Count; ++i)
                {
                    for (int j = 0; j < tmp.Count; ++j)
                        tmp2.AddRange(MinRule.Add(tmp[j], l[i]));

                    tmp.Clear();
                    tmp.AddRange(tmp2);
                    tmp2.Clear();
                }
                minRules.AddRange(tmp);
            }

            for (int i = 0; i < minRules.Count; ++i)
            {
                for (int j = 0; j < minRules.Count; ++j)
                {
                    if (i == j) continue;
                    if (minRules[i] == null || minRules[j] == null) continue;
                    if (minRules[i].Contains(minRules[j]))
                        minRules[j] = null;
                }
            }

            for (int i = 0; i < minRules.Count; ++i)
                if (minRules[i] != null)
                    _minRules.Add(minRules[i]);

        }

        public ObservableCollection<Result> Results
        {
            get { return _results; }
        }

        public ObservableCollection<Item> Universum
        {
            get { return _set.Universum; }
        }

        public List<Rule> Rules
        {
            get { return _set.Rules; }
        }

        public ObservableCollection<MinRule> MinRules
        {
            get { return _minRules; }
        }

        public List<StringValue> Legend
        {
            get { return _legend; }
        }

        public Frame MainFrame
        {
            get { return _mainFrame; }
        }

        
    }
}