using System;

namespace Method10
{
    class Program
    {
        // out parameter =>  metot gövdesinden dışarıya değer çıkarmak için kullanılır. özellikle metodun birden fazla değer dönmesi gereken durumlarda bu işlem yapılır...

        static void Main(string[] args)
        {
            Console.WriteLine("Ref ve Out!");
            int sonuc1;
            int sonuc = islem(1, 2, out sonuc1);

            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc1);

            string str = "a";
            int sayi;
            bool durum = int.TryParse(str, out sayi); // eğer başarılı dönüşüm olursa true, olmazsa false döner. out ilede başarılı durumda dönüşen sayıyı, başarısız durumda 0 döner..
            durum = int.TryParse("5", out sayi);



            Console.WriteLine("Lütfen bir sayı giriniz");

            int i;
            if (int.TryParse(Console.ReadLine(),out i))
            {
                Console.WriteLine($"Gİrilen sayının 5 fazlası {i + 5}");
            }
            else
            {
                Console.WriteLine("Sayı girin demiştik.....");
            }

            int a = 1;
            int r = Demo(ref a);

            Console.WriteLine(a);

            Console.ReadKey();
        }

        private static int islem(int s1, int s2, out int c) // parametre eğer out ise metot gövesinde değer vermek zorunludur
        {
            c = s1 * s2;// out parametera değer ata...
            return s1 + s2;
        }

        private static int Demo(ref int s1)
        {
            s1 = 10;
            return 0;
        }

    }
}