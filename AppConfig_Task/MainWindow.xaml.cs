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
using System.Configuration;

namespace Learning_Task
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

    private void Save_Btn_Click(object sender, RoutedEventArgs e)
    {
      Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      config.AppSettings.Settings["FilePath"].Value = File_TxtBx.Text;
      ConfigurationManager.RefreshSection("appSettings");
      config.Save(ConfigurationSaveMode.Modified);
    }

    private void Write_Btn_Click(object sender, RoutedEventArgs e)
    {
      Write("Written");
    }

    public string Write(string STR) 
    {
      File_TxtBx.Text = ConfigurationManager.AppSettings.Get("FilePath");
      return STR;
    }
  }
}
