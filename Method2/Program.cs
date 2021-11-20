using System;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            // metotlar => tanımlı alt programlardır.. parentez ile çağrılan bütün komutlar metottur..bu alt programlar c# yapısı gereği sınıflar içeriisnde tanımlanır. WriteLine,ReadLine,ReadKey metotları COnsole sınıfı içerisinde tanımlıyken, ToInt32 metodu Convert sınıfında, Sort metodu Array sınıfında tanımlıdır...

            // bizlerde kendi sınıflarımızda metotlar tanımlayıp bunları aynı sınıf veya farklı sınıflarda kullanbiliriz...

            // metotlar farklı alt programlar olduğu için ana scope dışında tanımlanır. ana scope'ta çağırılır. ve bağımsız çalıştıkları için dönüş tipi önemlidir. dönüş tipi metodun yaptığı iş hakkında rapor vermek gibi düşünebilibir. Örneğin birisine bir iş veriyorsunuz, sonucunda iş verilen kişi işi bitirip bitirmediğini size söylüyor...metot dönüş tipi işin yapılıp yapılmadığını belirtir..


            // dönüş tipleri 2'ye ayrılır. bunlar void ve diğerleri;
            // void metot geriye boş döner
            // diğerleri geriye dolu döner...

            // metot dönüş tipi yapılan işe göre belirlenir...

            Console.WriteLine("Metot dönüş tipleri"); // bir komutu üzerinde f12 tuşuna bastığınızda sizi meta dosyayasına yönlendirir..veya sağ tık yapıp go to defination seçenği ile aynı yere gidebilirsiniz...

            int sayi = Convert.ToInt32("3");

            int[] sayilar = { 3, 1, 2 };
            Array.Sort(sayilar);

            Console.WriteLine("adınız????");
            string isim = Console.ReadLine();


            // metotları çalıştıralım..
             Mesaj1();
            string gelenMesaj = Mesaj2();
            Console.ReadKey();
        }

        // geriye boş dönen metot
        private static void Mesaj1()
        {
            string msj = "metotlar geriye değer dönerler";
            // return; not :void metotlarda dönüş değeri beklenmediği için return ifadesi kullanılmaz.. alt scope gelindiğinde program terkedilecektir...
        }

        // geriye değer dönen metot. eğer metot geriye dolu dönüyorsa return ifadesi kullanılmalıdır. return ifadesi ile dönülecek değer belirtilir. bu sayede metot çalışması sonlanmış olur...
        private static string Mesaj2()
        {
            string msj = "metotlar geriye değer dönerler";
            return msj;
        }
    }
}
