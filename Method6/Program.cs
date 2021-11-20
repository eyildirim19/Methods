using System;

namespace Method6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Params!");

            int a = Topla(1, 2);
            int b = Topla(1, 2, 3, 4, 5, 6, 7, 8);

            string isim = "suna";
            string isim1 = "ali";
            Deneme(isim, isim1, "ekrem");

            Console.ReadKey();
        }
        // params keywordü metoda değer olarak n adet veri göndermek için kullanılır. Dizi parametre göndermek ile karıştırılabilir. fark diziyi bir değer olarak gönderirken params ile n adet değer gönderirsiniz. yani dizi parametresine göre kullaım kolaylığı vardır...
        private static int Topla(params int[] s1)
        {
            return s1.Length;
        }
        private static string[] Deneme(params string[] isimler)
        {
            return isimler;
        }
    }
}
