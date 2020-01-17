using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp2
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      cbbox.ItemsSource = typeof(Colors).GetProperties();
    }

    private void cbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      Color selectedColor = (Color)(cbbox.SelectedItem as PropertyInfo).GetValue(null, null);
      this.Background = new SolidColorBrush(selectedColor);
    }

    private void BtnPrevious_Click(object sender, RoutedEventArgs e)
    {
      if (cbbox.SelectedIndex > 0)
        cbbox.SelectedIndex = cbbox.SelectedIndex - 1;
    }

    private void btnNext_Click(object sender, RoutedEventArgs e)
    {
      if (cbbox.SelectedIndex < cbbox.Items.Count - 1)
        cbbox.SelectedIndex = cbbox.SelectedIndex + 1;
    }

    private void btnBlue_Click(object sender, RoutedEventArgs e)
    {
      cbbox.SelectedItem = typeof(Colors).GetProperty("Blue");
    }
  }
}
