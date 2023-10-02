using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            int toplam, fark, carpim, bolum;

            Console.WriteLine("Sayı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;

            Console.WriteLine("Toplam = " + toplam);
            Console.WriteLine("Fark = " + fark);
            Console.WriteLine("Çarpım = " +  carpim);
;           Console.WriteLine("Bölüm = " + bolum);

            Console.ReadLine();
        }
    }
}
