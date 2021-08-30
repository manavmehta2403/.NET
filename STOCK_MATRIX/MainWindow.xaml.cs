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

namespace StockMatrix
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //array of the months
            string[] months =
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            //2D array to store the stock
            double[,] stocks = new double[12, 2]
            {
                {213.52, 192.32},
                {183.99, 150.08},
                {204.46, 160.93},
                {220.43, 123.28},
                {212.43, 150.46},
                {243.30, 100.08},
                {196.47, 140.40},
                {188.43, 160.88},
                {220.99, 190.08},
                {300.45, 291.89},
                {312.99, 290.99},
                {289.04, 200.43}
            };

            // work out average high stock
            double total_high = 0;
            for (int i = 0; i < 12; i++)
            {
                //total the stocks first column
                total_high += stocks[i, 0];
            }

            //calculating the average for high stocks
            double avg_high = total_high / 12;

            //setting the text associated desired text box
            TextBox1.Text = "$" + avg_high.ToString("0.00");

            // work out average low temperature
            double total_low = 0;

            for (int i = 0; i < 12; i++)
            {
                //total the stocks second column
                total_low += stocks[i, 1];
            }

            //calculating the average for low stocks
            double avg_low = total_low / 12;

            //setting the text associated desired text box
            TextBox2.Text = "$" + avg_low.ToString("0.00");

            // work out highest high temperature
            double highest = stocks[0, 0];
            string high_month = " ";
            for (int i = 1; i < 12; i++)
            {
                //checks the every element of the first column
                if (highest < stocks[i, 0])
                {
                    //finding the highest value of the stock
                    highest = stocks[i, 0];
                    //printing the corresponding month
                    high_month = months[i];
                }
            }

            //setting the text associated desired text box
            TextBox3.Text = "$" + highest.ToString("0.00") + " in " + high_month;

            // work out lowest low temperature
            double lowest = stocks[0, 1];
            string low_month = " ";
            for (int i = 1; i < 12; i++)
            {
                //checks the every element of the second column
                if (lowest > stocks[i, 1])
                {
                    //finding the lowest value of the stock
                    lowest = stocks[i, 1];
                    //printing the corresponding month
                    low_month = months[i];

                }
            };

            //setting the text associated desired text box
            TextBox4.Text = "$" + lowest.ToString("0.00") + " in " + low_month;
        }
    }
}
