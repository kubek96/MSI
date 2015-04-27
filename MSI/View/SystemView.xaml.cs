using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MSI.ViewModel;

namespace MSI.View
{
    /// <summary>
    /// Interaction logic for SystemView.xaml
    /// </summary>
    public partial class SystemView : Page
    {
        public SystemView()
        {
            InitializeComponent();
            this.DataContext = new SystemViewModel();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int r = Convert.ToInt32(b.Tag);
            App.Context.GenerateResults(r-1);
        }
    }
}