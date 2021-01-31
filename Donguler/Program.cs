using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Giriş Kursu";
            string kurs3 = "java";
            string kurs4 = "python";
            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya Giriş Kursu" ,"java", "python"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");
        }
    }
}
