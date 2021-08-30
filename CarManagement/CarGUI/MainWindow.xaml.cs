using CarClass;
using ClassesLib;
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

namespace CarGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Store myStore = new Store();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void btn_makeCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                bool check = theft(Convert.ToInt32(txt_vin.Text));

                if (check)
                {
                    MessageBox.Show("I detect the robbed car.");
                }

                else
                {
                    Car c = new Car(txt_model.Text, txt_maker.Text, Convert.ToInt32(txt_vin.Text), DateTime.ParseExact(txt_year.Text, "yyyy", null), Convert.ToDecimal(txt_price.Text));

                    myStore.Inventory.Add(c);

                    warehouse.Items.Clear();
                    warehouse.Items.Add(String.Format("{0,-10} {1,-10} {2,10} {3,10} {4,10}", "Model", "Manufacture", "VIN", "Year", "Price"));
                    foreach (var car in myStore.Inventory)
                    {
                        warehouse.Items.Add(car.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            txt_model.Clear();
            txt_maker.Clear();
            txt_price.Clear();
            txt_vin.Clear();
            txt_year.Clear();
        }

        private void btn_addToCart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, RoutedEventArgs e)
        {

        }

        public static bool theft(int num)
        {
            foreach (var c in myStore.Inventory)
            {
                if (num == c.VIN)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
