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

namespace WPF_RS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOther_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Red);
        }

        private void btnOther_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynamicColor"] = new SolidColorBrush(Colors.Orange);
        }

    }
}
