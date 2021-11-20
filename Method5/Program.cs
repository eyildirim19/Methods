using System;

namespace Method5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not : yapılar static olduğu içn metodun üzerine geldiğinde metot hakkında bilgi verir. eğer static olmasaydı kullanım esnasında da bilgi verecekti..
            Console.WriteLine("Method Overload");

            int sonuc = Topla(1, 1);

            int s = Topla(1, 2, 3, 4, 5, 6, 7, 8, sonuc, 100);

            Console.ReadKey();
        }

        /// <summary>
        /// girilen n adet sayıyı toplar...
        /// </summary>
        /// <param name="sayis">toplanacak sayı(s)</param>
        /// <returns></returns>
        private static int Topla(params int[] sayis) // params ile n tane parametre gönderilebilir...
        {
            int toplam = 0;

            foreach (var item in sayis)
                toplam += item;

            return toplam;
        }

        // 3 / (slash) ile metotlarınıza summary ekleyebilirsiniz. bu metotlarınızı kullanım esnasında açıklama ekleyecektir...
        /// <summary>
        /// 2 adet tam sayıyı toplar...
        /// </summary>
        /// <param name="sayi1">toplanacak 1. sayı</param>
        /// <param name="sayi2">toplanacak 2. sayı</param>
        /// <returns></returns>
        private static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        /// <summary>
        /// 3 ade tam sayıyı toplar
        /// </summary>
        /// <param name="sayi1">1. Sayı</param>
        /// <param name="sayi2">2. Sayı</param>
        /// <param name="sayi3">3. Sayı</param>
        /// <returns></returns>
        private static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        
    }
}
