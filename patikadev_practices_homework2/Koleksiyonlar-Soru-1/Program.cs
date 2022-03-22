using System;
using System.Collections;


namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)

           // *Negatif ve numeric olmayan girişleri engelleyin.
           // *Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
           // *Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın
            Islemler islem = new Islemler();

            ArrayList liste = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList not_asal = new ArrayList();

            Console.WriteLine("Lütfen 20 adet sayı giriniz :");
            try
            {
                for (int i = 1; i < 21; i++)
                {
                    Console.WriteLine("{0}.sayıyı giriniz :", i);
                    int n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                        break;
                    }
                    liste.Add(n);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Lüften pozitif bir sayı giriniz");

            }

            Console.WriteLine("***************************");


            foreach (int item in liste)
            {
                if (item == 1)
                {
                    not_asal.Add(item);
                }
                else if (item == 2)
                {
                    asal.Add(item);
                }
                else
                {
                    int asalsayi = 0;
                    for (int i = 2; i < item; i++)
                    {
                        if (item % i == 0)
                        {
                            asalsayi++;

                        }
                    }

                    if (asalsayi == 0)
                    {
                        asal.Add(item);
                    }
                    else
                    {
                        not_asal.Add(item);
                    }
                }





            }
            Console.WriteLine("Asal olan sayıların toplam sayısı : " + asal.Count);
            Console.WriteLine("Asal olan sayıların büyükten küçüğe sıralanışı :");
            islem.Asal_Islemleri(asal);
            islem.Ortalama(asal);
            Console.WriteLine("Asal olmayan sayıların toplam sayısı : " + not_asal.Count);
            Console.WriteLine("Asal olmayan sayıların büyükten küçüğe sıralanışı : ");
            islem.Asal_Islemleri(not_asal);
            islem.Ortalama(not_asal);
        }

        public class Islemler
        {
            public ArrayList Asal_Islemleri(ArrayList arr)
            {
                arr.Sort();
                arr.Reverse();
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("şeklinde sıralanmıştır.");
                return arr;
            }
            public ArrayList Ortalama(ArrayList arr)
            {
                int toplam = 0;
                foreach (int item in arr)
                {
                    toplam += item;
                }
                decimal ort = toplam/arr.Count;
                Console.WriteLine("Sayıların ortalaması : " + ort);
                  return arr;
         }
     }
  }

}

