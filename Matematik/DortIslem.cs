using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç :" + toplam);
        }
        public void Eksi(int x, int y)
        {
            int eksi = x - y;
            Console.WriteLine("Sonuç:" + eksi);
        }
    }
}
