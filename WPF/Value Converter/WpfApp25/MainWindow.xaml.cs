using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfApp25
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
  }

  public class YesNoToBooleanConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      switch (value.ToString().ToLower())
      {
        case "yes":
        case "oui":
          return true;

        case "no":
        case "non":
          return false;
      }

      return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is bool b )
      {
        if ( b == true)
        {
          return "yes";
        }
        else
        {
          return "no";
        }
      }
      return "no";
      }
  }
}
