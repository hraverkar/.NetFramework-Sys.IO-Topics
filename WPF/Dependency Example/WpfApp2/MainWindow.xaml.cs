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
    }

    private void MyButton_Click(object sender, RoutedEventArgs e)
    {
      CarDependencyProperty cdr = TryFindResource("CarDependency") as CarDependencyProperty;
      MessageBox.Show(cdr.MyCar);
    }
  }

  public class CarDependencyProperty : DependencyObject
  {
    public static readonly DependencyProperty CarDependency = DependencyProperty.Register("MyCar", typeof(string), typeof(CarDependencyProperty));

    public string MyCar
    {
      get { return (string)GetValue(CarDependency); }
      set { SetValue(CarDependency , value); }
    }
  }
}
