using System;
using System.Collections.Generic;
using System.Linq;


namespace Telefon_Rehberi_Uygulaması
{

    public class TelefonRehberi
    {
        //1)
        public static void NumaraKaydetmek(List<Kisiler> KisiListesi)
        {

            System.Console.WriteLine("Lütfen isim giriniz : ");
            string Isim = Console.ReadLine();
            System.Console.WriteLine("Lütfen soyisim giriniz : ");
            string Soyisim = Console.ReadLine();
            System.Console.WriteLine("Lütfen telefon numarası giriniz : ");
            string TelefonNo = Console.ReadLine();
            KisiListesi.Add(new Kisiler() { Isim = Isim, Soyisim = Soyisim, TelefonNo = TelefonNo });


        }


        //2)
        public static void NumaraSilmek(List<Kisiler> KisiListesi)
        {
            System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string girdi = Console.ReadLine();
            bool KisiKontrol = false;

            foreach (var item in KisiListesi.ToList())
            {
                KisiKontrol = true;
                if (item.Isim == girdi || item.Soyisim == girdi)
                {
                    System.Console.WriteLine("{} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item);
                    string YesNo = Console.ReadLine().ToLower();
                    if (YesNo == "y")
                        KisiListesi.Remove(item);
                    else if (YesNo == "n")
                    {
                        System.Console.WriteLine("silme işlemi iptal edildi..");
                        break;
                    }
                    break;

                }
            }
                if(!KisiKontrol)
            {
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için      : (2)");

                int giren = int.Parse(Console.ReadLine());
                if (giren == 2)
                {
                    NumaraSilmek(KisiListesi);
                }
                if (giren == 1)
                {
                    System.Console.WriteLine("silme işlemi sonlandırılıyor..");
                    
                }

            }

            TestDisplay(KisiListesi);

        }


        //3)
        public static void NumaraGüncelleme(List<Kisiler> KisiListesi)
        {
            System.Console.WriteLine("Lütfen numarasını değiştirmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string girdi = Console.ReadLine();
            bool Kisivarmı = false;
            foreach (var item in KisiListesi.ToList())
            {
                if (item.Isim == girdi || item.Soyisim == girdi)
                {
                    Kisivarmı = true;
                    System.Console.WriteLine("{0} isimli kişinin numarası güncellenmek üzere, onaylıyor musunuz ?(y/n)", item.Isim);
                    string YesNo = Console.ReadLine().ToLower();
                    if (YesNo == "y")
                    {
                        System.Console.WriteLine("yeni numarayı giriniz:");
                        string YeniNumara = Console.ReadLine();
                        item.TelefonNo = YeniNumara;
                    }
                    else if (YesNo == "n")
                    {
                        System.Console.WriteLine("güncelleme işlemi iptal edildi..");
                        break;
                    }
                    break;
                }
            }
            if (!Kisivarmı)
            {
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* güncellemeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için      : (2)");

                string input = Console.ReadLine();
                if (input == "2")
                {
                    NumaraGüncelleme(KisiListesi);
                }
                if (input == "1")
                {
                    System.Console.WriteLine("Güncelleme işlemi sonlandırılıyor..");

                }
            }

            TestDisplay(KisiListesi);

        }


        //4)
        public static void RehberListeleme(List<Kisiler> KisiListesi)
        {
            System.Console.WriteLine("Telefon Rehberi");
            System.Console.WriteLine("**********************************************");

            foreach (var item in KisiListesi)
            {
                Console.WriteLine(" isim= {0} \n soyisim = {1} \n telefon no = {2} \n     - ", item.Isim, item.Soyisim, item.TelefonNo);
            }
            System.Console.WriteLine(".\n.");




        }
        //5)
        public static void RehberdeArama(List<Kisiler> KisiListesi)
        {

            System.Console.WriteLine("arama yapmak istediğiniz tipi seçiniz");
            System.Console.WriteLine("**********************************************");
            System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2) ");

            int Secsayı = int.Parse(Console.ReadLine());
            if (Secsayı == 1)
            {
                System.Console.WriteLine("Lütfen Aramak istediğiniz kişiye ait isim veya soyisim giriniz");
                string girilen = Console.ReadLine();
                foreach (var item in KisiListesi)
                {
                    if (item.Isim.ToLower() == girilen.ToLower() || item.Soyisim.ToLower() == girilen.ToLower())
                    {
                        System.Console.WriteLine("isim: {0}", item.Isim);
                        System.Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        System.Console.WriteLine("Telefon Numarası: {0}", item.TelefonNo);
                        System.Console.WriteLine("    -    ");
                    }

                }

            }
            else if (Secsayı == 2)
            {
                System.Console.WriteLine("Lütfen Aramak istediğiniz kişiye ait telefon numarası giriniz ");
                string girilenNo = Console.ReadLine();
                foreach (var item in KisiListesi)
                {
                    if (girilenNo == item.TelefonNo)
                    {
                        System.Console.WriteLine("isim: {0}", item.Isim);
                        System.Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        System.Console.WriteLine("Telefon Numarası: {0}", item.TelefonNo);
                        System.Console.WriteLine("    -    ");
                        System.Console.WriteLine(".\n.");

                    }
                }
            }
            else
            {
                System.Console.WriteLine("hatalı seçim..");
            }


        }

        public static void TestDisplay(List<Kisiler> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine(" isim= {0} \n soyisim = {1} \n telefon numarası = {2}", item.Isim, item.Soyisim, item.TelefonNo);
            }
        }

    }
}