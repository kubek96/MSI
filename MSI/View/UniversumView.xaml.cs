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
    /// Interaction logic for UniversumView.xaml
    /// </summary>
    public partial class UniversumView : Page
    {
        public UniversumView()
        {
            InitializeComponent();
            this.DataContext = new UniversumViewModel();
        }
    }
}
