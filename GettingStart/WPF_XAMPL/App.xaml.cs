using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Threading;
using System.Globalization;

namespace WPF_XAMPL
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

			MainWindow wnd = new MainWindow();
			if (e.Args.Length == 1)
			{
				MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
			}
			wnd.Show();
			
		}
		
	}
}
