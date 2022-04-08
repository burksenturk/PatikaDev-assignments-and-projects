using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDo_Uygulaması
{
    class Program
    {
        static List<Kart> ToDo = new List<Kart>()           //3 tane kart tanımlasak?
        {
            new Kart(){Baslık="koleksiyonlar",Icerik="dictionary",Buyukluk=Buyukluk.S,AtananCalısan=1},
            new Kart(){Baslık="koleksiyonlar1",Icerik="dictionary",Buyukluk=Buyukluk.XL,AtananCalısan=2}
        };
        static List<Kart> InProgress = new List<Kart>()
        {
            new Kart(){Baslık="koleksiyonlar2",Icerik="dictionary",Buyukluk=Buyukluk.XS,AtananCalısan=3}

        };
        static List<Kart> Done = new List<Kart>();
        static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz..");
            System.Console.WriteLine("*******************************************");
            System.Console.WriteLine("(1) Board Listelemek");
            System.Console.WriteLine("(2) Board'a Kart Eklemek");
            System.Console.WriteLine("(3) Board'dan Kart Silmek");
            System.Console.WriteLine("(4) Kart Taşımak");

            switch (int.Parse(Console.ReadLine()))
            {

                case 1:
                    BoardListeleme(ToDo, InProgress, Done);
                    break;
                case 2:
                    KartEkleme(ToDo);
                    break;
                case 3:
                    KartSilmek(ToDo, InProgress, Done);
                    break;
                case 4:
                    KartTasımak(ToDo, InProgress, Done);
                    break;
            }
        }

        static List<Calisan> CalisanListesi()
        {
            List<Calisan> CalisanListesi = new List<Calisan>()
            {
                new Calisan(){Name="burak",Surname="şentürk",Id=1},
                new Calisan(){Name="bilal",Surname="yılmaz",Id=2},
                new Calisan(){Name="selen",Surname="yüntem",Id=3},


            };
            return CalisanListesi;
        }


        static bool CalisanKontrol(int CalisanId)
        {
            List<Calisan> Liste = CalisanListesi();
            bool kisiVarMi = false;
            foreach (var item in Liste.ToList())
            {
                if (item.Id == CalisanId)
                {
                    kisiVarMi = true;
                }

            }

            return kisiVarMi;
        }
        static void KartEkleme(List<Kart> List)
        {
            System.Console.WriteLine(" Başlık Giriniz:");
            string baslık = Console.ReadLine();
            System.Console.WriteLine(" İçerik Giriniz :");
            string Icerik = Console.ReadLine();
            System.Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5):");
            string buyukluk = Console.ReadLine();
            System.Console.WriteLine("  Kişi Seçiniz:");
            string CalısanId = Console.ReadLine();
            bool CalisanVarmi = CalisanKontrol(int.Parse(CalısanId));
            if (!CalisanVarmi)
            {
                Console.WriteLine("Personel Bulunamadı");
            }
            else
            {
                Kart kart = new Kart();
                kart.Baslık = baslık;  //telefon rehberindeki gibi yapamaz  mıyım eklemeyi
                kart.AtananCalısan = int.Parse(CalısanId);
                kart.Icerik = Icerik;
                kart.Buyukluk = (Buyukluk)int.Parse(buyukluk);

                List.Add(kart);

                BoardListeleme(ToDo, InProgress, Done);

            }

        }
        static void BoardListeleme(List<Kart> todo, List<Kart> inprogress, List<Kart> done)
        {
            Console.WriteLine("Todo");
            Console.WriteLine("**********************");

            foreach (var item in todo.ToList())
            {
                string calisanName = CalisanIsımGetir(item.AtananCalısan);  //atanancalısan neden int id si int olsa?
                Console.WriteLine("Baslik : {0}", item.Baslık);             //inprogress done aynı şekilde mi listelemesi?
                Console.WriteLine("Icerik : {0}", item.Icerik);
                Console.WriteLine("Atanan Kisi : {0}", calisanName);
                Console.WriteLine("Buyukluk : {0}", item.Buyukluk.ToString());
                Console.WriteLine("-");

            }

            Console.WriteLine("InProgress");
            Console.WriteLine("**********************");

            foreach (var item in inprogress.ToList())
            {
                string calisanName = CalisanIsımGetir(item.AtananCalısan);  //atanancalısan neden int id si int olsa?
                Console.WriteLine("Baslik : {0}", item.Baslık);             //inprogress done aynı şekilde mi listelemesi?
                Console.WriteLine("Icerik : {0}", item.Icerik);
                Console.WriteLine("Atanan Kisi : {0}", calisanName);
                Console.WriteLine("Buyukluk : {0}", item.Buyukluk.ToString());
                Console.WriteLine("-");

            }

            Console.WriteLine("Done");
            Console.WriteLine("**********************");
            if (done.Count == 0)
            {
                Console.WriteLine("Boş");

            }
            else
            {
                foreach (var item in done.ToList())
                {
                    string calisanName = CalisanIsımGetir(item.AtananCalısan);  //atanancalısan neden int id si int olsa?
                    Console.WriteLine("Baslik : {0}", item.Baslık);             //inprogress done aynı şekilde mi listelemesi?
                    Console.WriteLine("Icerik : {0}", item.Icerik);
                    Console.WriteLine("Atanan Kisi : {0}", calisanName);
                    Console.WriteLine("Buyukluk : {0}", item.Buyukluk.ToString());
                    Console.WriteLine("-");

                }
            }



        }

        static void KartSilmek(List<Kart> todo, List<Kart> inprogress, List<Kart> done)
        {
            System.Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            System.Console.WriteLine("Lütfen kart başlığını yazınız:");
            string KartBaslıgı = Console.ReadLine();
            bool KartKontrol = false;
            foreach (var item in todo.ToList())
            {
                if (item.Baslık == KartBaslıgı)
                {
                    KartKontrol = true;
                    todo.Remove(item);
                }
            }
            foreach (var item in inprogress.ToList())
            {
                if (item.Baslık == KartBaslıgı)
                {
                    KartKontrol = true;
                    todo.Remove(item);
                }
            }
            foreach (var item in done.ToList())
            {
                if (item.Baslık == KartBaslıgı)
                {
                    KartKontrol = true;
                    todo.Remove(item);
                }
            }

            if (!KartKontrol)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                Console.WriteLine(" *Yeniden denemek için : (2)");
                var secilen = Console.ReadLine();
                if (secilen == "1")
                {
                    Console.WriteLine("İşlem İptal Ediliyor");
                }
                else
                {
                    KartSilmek(todo, inprogress, done);
                }
            }

            BoardListeleme(todo, inprogress, done);

        }
        static void KartTasımak(List<Kart> todo, List<Kart> inprogress, List<Kart> done)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string KartBaslıgı = Console.ReadLine();
            bool KartKontrol = false;
            string kartinBulunduguLine = "";
            Kart bulunanKart = new Kart();
            foreach (var item in todo.ToList())
            {
                if (item.Baslık == KartBaslıgı)
                {
                    KartKontrol = true;
                    bulunanKart = item;
                    kartinBulunduguLine = "ToDo";
                }
            }
            foreach (var item in inprogress.ToList())
            {
                if (item.Baslık == KartBaslıgı)
                {
                    KartKontrol = true;
                    bulunanKart = item;
                    kartinBulunduguLine = "InProgress";

                }
            }
            foreach (var item in done.ToList())
            {
                if (item.Baslık == KartBaslıgı)
                {
                    KartKontrol = true;
                    bulunanKart = item;
                    kartinBulunduguLine = "Done";

                }
            }
            if (!KartKontrol)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                Console.WriteLine(" *Yeniden denemek için : (2)");
                var secilen = Console.ReadLine();
                if (secilen == "1")
                {
                    Console.WriteLine("İşlem İptal Ediliyor");
                }
                else
                {
                    KartTasımak(todo, inprogress, done);
                }
            }

            if (KartKontrol)
            {
                string calisanName = CalisanIsımGetir(bulunanKart.AtananCalısan);  //atanancalısan neden int id si int olsa?
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**********************");

                Console.WriteLine("Baslik : {0}", bulunanKart.Baslık);             //inprogress done aynı şekilde mi listelemesi?
                Console.WriteLine("Icerik : {0}", bulunanKart.Icerik);
                Console.WriteLine("Atanan Kisi : {0}", calisanName);
                Console.WriteLine("Buyukluk : {0}", bulunanKart.Buyukluk.ToString());
                Console.WriteLine("Line : {0}", kartinBulunduguLine);

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                string tasınacakLine = Console.ReadLine();
                ListelerdenSil(bulunanKart, todo, inprogress, done);
                if (tasınacakLine == "1")
                {
                    todo.Add(bulunanKart);
                }
                else if (tasınacakLine == "2")
                {
                    inprogress.Add(bulunanKart);

                }
                else if (tasınacakLine == "3")
                {
                    done.Add(bulunanKart);

                }

              BoardListeleme(todo, inprogress, done);
              

            }

            static void ListelerdenSil(Kart kart, List<Kart> todo, List<Kart> inprogress, List<Kart> done)
            {
                todo.Remove(kart);
                inprogress.Remove(kart);
                done.Remove(kart);
            }
        }
        static string CalisanIsımGetir(int CalisanId)
        {
            List<Calisan> Liste = CalisanListesi();
            string isim = "";
            foreach (var item in Liste.ToList())
            {
                if (item.Id == CalisanId)
                {
                    isim = item.Name + " " + item.Surname;
                }

            }

            return isim;
        }
    }
}
