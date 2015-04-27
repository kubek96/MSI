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
using MahApps.Metro.Controls;
using MSI.View;
using MSI.ViewModel;

namespace MSI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();

            //MainGrid.Children.Add(App.Context.MainFrame);
            //App.Context.MainFrame.Style = Application.Current.Resources["MainFrameStyle"] as Style;
            //App.Context.MainFrame.Navigate(new UniversumView());
        }
    }
}
