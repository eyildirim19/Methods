using System;

namespace Method9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimler = { "ata", "ütü", "kavak", "gün", "sınav" };

            foreach (var item in kelimler)
            {
                if (IsPalindrome(item))  // düzü tersi ile karşılaştır..geriye değer dönen metotlar çağırıldıkları yere değer dönerler...
                    Console.WriteLine("palindromeeee");
            }
            Console.ReadKey();
        }

        private static string Palindrome(string kelime)
        {
            char[] temp = kelime.ToCharArray();// değeri diziye çevir...
            Array.Reverse(temp); // diziyi ters çevir...
            //string retVal = new string(temp); // temp dizisinden string oluştur...
            //return retVal;
            return new string(temp);
        }
        private static bool IsPalindrome(string kelime)
        {
            // ternary if => kosul ? if : else
           // return Palindrome(kelime) == kelime ? true : false;
            bool durum = Palindrome(kelime) == kelime ? true : false; // ternary if => iki koşulun olduğu durumlarda kullanılabilir..
            return durum;
            //if (kelime == Palindrome(kelime))
            //    return true;
            //else
            //    return false;
        }
    }
}
