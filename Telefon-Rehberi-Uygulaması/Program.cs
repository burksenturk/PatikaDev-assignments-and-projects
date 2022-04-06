using System;
using System.Collections.Generic;

namespace Telefon_Rehberi_Uygulaması
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Kisi> KisiListesi = new List<Kisi>()
            {
                new Kisi(){Isim="burak",Soyisim="şentürk",TelefonNo="5356214553"},
                new Kisi(){Isim="selen",Soyisim="yüntem",TelefonNo="5401234567"},
                new Kisi(){Isim="bilal",Soyisim="yılmaz",TelefonNo="5381233885"},
                new Kisi(){Isim="yavuz",Soyisim="yılmaz",TelefonNo="712345678"},
                new Kisi(){Isim="çağla",Soyisim="şentürk",TelefonNo="987654332"},
                
            };

            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
            System.Console.WriteLine("**************************************** ");

            System.Console.WriteLine("(1) Yeni Numara Kaydetmek ");
            System.Console.WriteLine("(2) Varolan Numarayı Silmek");
            System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            System.Console.WriteLine("(4) Rehberi Listelemek");
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");

            
            Console.Write("işlem yapacağınız sıra:"); int deger = int.Parse(Console.ReadLine());
            switch (deger)
            {

                case 1:
                    TelefonRehberi.NumaraKaydetmek(KisiListesi);
                    break;

                case 2:
                    TelefonRehberi.NumaraSilmek(KisiListesi);
                    break;

                case 3:
                    TelefonRehberi.NumaraGüncelleme(KisiListesi);
                    break;

                case 4:
                    TelefonRehberi.RehberListeleme(KisiListesi);
                    break;

                case 5:
                    TelefonRehberi.RehberdeArama(KisiListesi);
                    break;


            }

            System.Console.WriteLine("Gerçekleştirdiğiniz işlem başarıyla tamamlanmıştır..");




        }

    }
}
