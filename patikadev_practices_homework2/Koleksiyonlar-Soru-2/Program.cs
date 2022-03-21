using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.        (Array sınıfını kullanarak yazınız.)

            Console.WriteLine("** 20 adet sayı giriniz: **");
            ArrayList SayıListesi = new ArrayList();
            int[] sayıdizisi = new int[20];
            

            for (int i = 0; i<20; i++)
            {
                Console.WriteLine("lütfen {0}. sayıyı giriniz: ",i+1);
                sayıdizisi[i] = int.Parse(Console.ReadLine());
            }
            
            ArrayList KucuklerListesi = new ArrayList();
            ArrayList BuyuklerListesi = new ArrayList();
            
            Array.Sort(sayıdizisi);
            for (int i = 0; i < 3; i++)
                 KucuklerListesi.Add(sayıdizisi[i]);
            
            Console.WriteLine("***en küçük 3 sayı***");
            int toplam = 0;
            
            foreach (var item in KucuklerListesi)
                {
                    Console.WriteLine(item);
                    toplam+= Convert.ToInt32(item);
                }
                
            Console.WriteLine("en küçük 3 sayının ortalaması: "+toplam/3 );
                    
            
            Console.WriteLine("***en büyük 3 sayı***");
            Array.Reverse(sayıdizisi);
            
            for (int i = 0; i < 3; i++)
                BuyuklerListesi.Add(sayıdizisi[i]);
    
            int Toplam =0;
            foreach (var item in BuyuklerListesi)
                {
                    Console.WriteLine(item);
                    Toplam+=Convert.ToInt32(item);
                }
            Console.WriteLine("en büyük 3 sayının ortalaması: "+Toplam/3 );
            
            int OrtToplamları = Toplam/3 + toplam/3;
            Console.WriteLine("ortalamaların toplamı: "+ OrtToplamları );
            
            

            
            

        

           




        }
    }
}


 //SayıListesi.Add(sayıdizisi);
            //SayıListesi.Sort();