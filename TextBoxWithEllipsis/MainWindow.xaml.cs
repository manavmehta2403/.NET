using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MarkLTX;

namespace TextBoxWithEllipsis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            chkReadOnly.IsChecked = txtEllipsis.IsReadOnly;
            chkEnabled.IsChecked = txtEllipsis.IsEllipsisEnabled;
            chkToolTip.IsChecked = txtEllipsis.UseLongTextForToolTip;
            lblTextChangeCount.Content = null;

            radRight.IsChecked = txtEllipsis.EllipsisPlacement == EllipsisPlacement.Right;
            radLeft.IsChecked = txtEllipsis.EllipsisPlacement == EllipsisPlacement.Left;
            radCenter.IsChecked = txtEllipsis.EllipsisPlacement == EllipsisPlacement.Center;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            txtEllipsis.Text = textBox1.Text;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //DialogResult = false;
            Close();
        }

        private void chkReadOnly_Checked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.IsReadOnly = true;
        }

        private void chkReadOnly_Unchecked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.IsReadOnly = false;
        }

        private void chkEnabled_Checked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.IsEllipsisEnabled = true;
        }

        private void chkEnabled_Unchecked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.IsEllipsisEnabled = false;
        }

        private void chkToolTip_Checked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.UseLongTextForToolTip = true;
        }

        private void chkToolTip_Unchecked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.UseLongTextForToolTip = false;
        }

        int _textChangedCount;

        private void txtEllipsis_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lblTextChangeCount != null)
            {
                lblTextChangeCount.Content = ++_textChangedCount;
            }
        }

        private void radLeft_Checked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.EllipsisPlacement = EllipsisPlacement.Left;
        }

        private void radCenter_Checked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.EllipsisPlacement = EllipsisPlacement.Center;
        }

        private void radRight_Checked(object sender, RoutedEventArgs e)
        {
            txtEllipsis.EllipsisPlacement = EllipsisPlacement.Right;
        }
    }
}
