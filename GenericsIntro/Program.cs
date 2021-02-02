using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Halef");
            Console.WriteLine(isimler.Length);
            isimler.Add("uludağ");
            Console.WriteLine(isimler.Length);
            foreach (var isim in isimler.Items   )
            {
                Console.WriteLine(isim);
            }
        }
    }
}
