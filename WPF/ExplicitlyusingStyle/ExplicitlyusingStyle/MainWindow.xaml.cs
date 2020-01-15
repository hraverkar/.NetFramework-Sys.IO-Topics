using System.Windows;
using System.Windows.Controls;

namespace ExplicitlyusingStyle
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
      var btn = (Button) e.Source;
      var value = btn.Content.ToString();
      MessageBox.Show(value);
    }
  }
}
