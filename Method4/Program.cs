using System;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Overload!");

            int a = 3;
            //  int a = 2; a değişkeni daha önce tanımlandığı için tekrar tanımlanamaz...

            // Metot overload (metot aşırıyüklemesi) =>metotlar aynı isimlerde tanımlanabilir. değilkenler gibi veya dğer varklılar gibi isimleri unique(benzersiz) olmak zorunda değildir...aynı ismi tekrar kullanmanın tek yolu metot parametresini değiştirmektir. (tip veya sayıları olabilir)

            string s = "1";
            byte bt = 20;
            a = Convert.ToInt32(s);
            a = Convert.ToInt32(bt);


            Mesaj("Yazılımcı gençlik...");

            // Niye metot overload vardır...
            Mesaj();

            Mesaj("Selam", "Gençlik");

            Mesaj("Merhaba", "Arkadaşlar");

            Mesaj(1);
            Mesaj("2");

            Console.ReadKey();
        }
        private static void Mesaj()
        {
            Console.WriteLine("Merhaba C#");
        }

        private static void Mesaj(string isim)
        {
            Console.WriteLine($"Merhaba {isim}");
        }
        private static void Mesaj(string mesaj, string isim)
        {
            Console.WriteLine($"{mesaj} {isim}");
        }
        private static void Mesaj(int sayi)
        {
            Console.WriteLine($"girilen sayı = {sayi}");
        }
    }
}