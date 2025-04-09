using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Towar
    {
        public int Ilosc;
        public double Cena;

        public override string ToString()
        {
            return $"Ilość: {Ilosc}, Cena: {Cena:F2}";
        }

        public static Towar operator +(Towar t1, Towar t2)
        {
            Towar wynik = new Towar();
            wynik.Ilosc = t1.Ilosc + t2.Ilosc;
            wynik.Cena = (t1.Cena + t2.Cena) / 2.0;
            return wynik;
        }
    }
}
