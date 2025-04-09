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

namespace WpfApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        double[] liczby = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };

        Window1 okno = new Window1();
        okno.Liczby = liczby; // właściwość tylko do zapisu
        okno.Show();
    }

}