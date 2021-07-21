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

namespace WPF_Basic
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
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      Finish_ComboBox_SelectionChanged(this.FinishDropDown, null);
    }

    private void Apply_Btn_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show($"{this.Description_txt.Text}");
    }

    private void Reset_Btn_Click(object sender, RoutedEventArgs e)
    {
      this.Weld_ChkBox.IsChecked 
        = this.Assembly_ChkBox.IsChecked 
        = this.Plasma_ChkBox.IsChecked
        = this.Laser_ChkBox.IsChecked 
        = this.Lathe_ChkBox.IsChecked 
        = this.Purchase_ChkBox.IsChecked
        = this.Drill_ChkBox.IsChecked
        = this.Fold_ChkBox.IsChecked
        = this.Roll_ChkBox.IsChecked
        = this.Saw_ChkBox.IsChecked = false;
      Length_txt.Text = string.Empty;
    }

    private void ChkBox_Checked(object sender, RoutedEventArgs e)
    {
      Length_txt.Text += ((CheckBox)sender).Content + " ";
    }

    private void ChkBox_Unchecked(object sender, RoutedEventArgs e)
    {
      string ChkBox_txt = (string)((CheckBox)sender).Content + " ";
      Length_txt.Text = Length_txt.Text.Remove(Length_txt.Text.IndexOf(ChkBox_txt), ChkBox_txt.Length);
    }

    private void Finish_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      string ComboBox_txt = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
      if (Note_txt != null)
      {
        Note_txt.Text = ComboBox_txt;
      }
      
    }

    private void SupplierName_txt_TextChanged(object sender, TextChangedEventArgs e)
    {
      this.Mass_txt.Text = this.SupplierName_txt.Text;
    }
  }
}
