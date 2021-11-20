using System;

namespace Method8
{
    class Program
    {
        // Main programının görevi kullanıcında veri almak, bilgiye dönüştürüp çıktı sağlamaktır...
        static void Main(string[] args)
        {
            Console.WriteLine("4 işlem örnepi!");

            int sayi1, sayi2, sonuc;
            Console.WriteLine("1. Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            char islem = Convert.ToChar(Console.ReadLine());

            float islemSonucu = Islem(islem, sayi1, sayi2);

            Console.Write($"İşlem Sonucunuz = {islemSonucu}");

            Console.ReadKey();
        }

        // todo : bu işlemi n adet sayı için yapan metodu yazınız.. Perşembe gününe kadar gönderiniz...

        // todo:  ascii table nedir. Neden 255 karakter vardır.. araştırınız...Ve Bu programdaki gibi txt dosyasına açıklamasını yazınız...
        private static float Islem(char islem, int sayi1, int sayi2)
        {
            float sonuc = 0;
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    break;
            }
            return sonuc;
        }
    }
}
