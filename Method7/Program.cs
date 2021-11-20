using System;

namespace Method7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doviz kur programı");

            Console.WriteLine("Doviz tipini giriniz...($ / €)");
            char doviz = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"₺ karşılığı = {Fiyat(doviz)}");

            Console.ReadKey();
        }

        private static decimal Fiyat(char d)
        {
            decimal retVal = 0;
            if (d == '$')
            {
                retVal = 11.30m;
            }
            else if (d == '€')
            {
                retVal = 12.50m;
            }

            return retVal; // Not:dönüş değeri ile dönüş tipi eşit olmak zorundur..
        }
    }
}
