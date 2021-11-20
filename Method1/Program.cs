using System;

namespace Method1
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Method!");

            #region metot tanım....


            /*
            method (metot) =>  belirli işleri yapmak üzere kodların yazıldığı alt programlardır...
            Örnek olarak  Reverse metodu => diziyi ters çeviren ön tanımlı (c# içerisinde) kodları barından alt programdır... 

            metotlar;

            1 ) kodları blok haline getirip ayrı görevler vermek için
            2 ) yazılan kodları tekrar kullanabilmek için

            kullanılan yapılardır...yani birkere yaz sürekli kullan mantığı vardır..

            2 adımdan oluşur
            1. ) tanımlama
            // örnek metot tanımı....
            <erisimSeviyesi> <metotDonusTipi> <metotAdi>()
            {
                <metotGovdesi>
            }

            metotlar sadece çağrıldığnda çalışan yapılardır..

            2.çalıştırma
            <metotAdi>();

             */
            #endregion
            string[] kisiler = { "ali", "veli" };
            int[] sayilar = { 1, 2, 3 };

            Array.Reverse(kisiler);
            Array.Reverse(sayilar);

            MyMethod(); // metodu çalıştırıyoruz.....
            MyMethod();
            MyMethod();


            Console.ReadKey();
        }
        // şiimdilik static komutunu kullanıyoruz. (static varlıklaara geçildiğinde konuşulackatır..)
        // private => metot erişim seviyesidir
        // void => metot dönüş tipidir
        // MyMethod => metot adıdıdır..scope içerisindeki komutlar metodun gövdesidir...

        private static void MyMethod()
        {
            Console.WriteLine("Merhaba C# Yazılımcıları");
        }

    }

    
}
