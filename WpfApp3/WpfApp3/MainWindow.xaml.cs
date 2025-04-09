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

namespace WpfApp3;

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
        Towar t1 = new Towar();
        t1.Ilosc = 10;
        t1.Cena = 5.0;

        Towar t2 = new Towar();
        t2.Ilosc = 20;
        t2.Cena = 7.0;

        Towar t3 = t1 + t2;

        MessageBox.Show($"Towar 1: {t1}\nTowar 2: {t2}\n\nPo dodaniu: {t3}");
    }
}