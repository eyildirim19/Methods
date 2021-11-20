using System;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metot Parametreleri!");
            //metotlar farklı scope'larda çalıştıkları için içerisine değer parametreler ile gönderilir...
            // parametre => bir scope'dan diğer scopa değer geçirmektir...
            // metot gövdesindeki komutlar sabit komutlardır. Değerleri dinamik kullanabilmek için parametre kullanılır...

            MesajVer(); // ekrana merhaba c# yazacaktır...
            // parametreye gönderilen değerlerler parametrenin argümanıdır...Ekrem,Serhat ve isim değişkenleri birer argümandır...
            MesajVerWithParameter("Ekrem");
            MesajVerWithParameter("Serhat");
            string isim = "Önder";
            MesajVerWithParameter(isim);

            int sonuc = Topla(1, 1); // argümanlar birden fazla is , ile gönderilir..

            int sayi1 = 5, sayi2 = 10;
            sonuc = Topla(sayi1, sayi2);
            sonuc = Topla(sayi1 + sayi2, 3);

            Console.ReadKey();
        }
        private static void MesajVer()
        {
            Console.WriteLine("Merhaba c#");
        }
        private static void MesajVerWithParameter(string msj) // msj metodun parametresidir...
        {
            Console.WriteLine($"Merhaba {msj}");
        }
        private static int Topla(int s1, int s2) // gönderilen 2 sayıyı toplayan metot
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
    }
}
