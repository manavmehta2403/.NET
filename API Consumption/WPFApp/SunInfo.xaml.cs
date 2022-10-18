using DemoLibrary;
using System;
using System.Windows;

namespace WPFApp
{
  /// <summary>
  /// Interaction logic for SunInfo.xaml
  /// </summary>
  public partial class SunInfo : Window
  {

    public SunInfo()
    {
      InitializeComponent();
    }

    private async void LoadSunInfo_ClickAsync(object sender, RoutedEventArgs e)
    {
      var sunInfo = await SunProcessor.LoadSunInformation();
      sunriseText.Text = $"Sunrise at {sunInfo.Sunrise.ToLocalTime().ToLocalTime()}";
      sunsetText.Text = $"Sun set at {sunInfo.Sunset.ToLocalTime().ToLocalTime()}";
    }
  }
}
