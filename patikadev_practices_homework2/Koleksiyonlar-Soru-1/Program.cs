using System;
using System.Collections;


namespace Koleksiyonlar_Soru_1
{
 
    public class Program
    {
        static void Main(string[] args)
        {

            bool ContolMetod(int key, ArrayList liste)
            {
                Console.WriteLine("{0}.sayıyı giriniz :", key);
                string n = Console.ReadLine();
                int value;
                if (!n.isNumeric())
                {
                    Console.WriteLine("Sayı giriniz");
                    return false;
                }
                else
                {
                    value = int.Parse(n);
                }
                
                if (value.isNegative())
                {
                    Console.WriteLine("Pozitif Sayı giriniz");
                    return false;
                }

                liste.Add(value);
                return true;


            }
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

                
                    while(true){
                        bool result=ContolMetod(i,liste);
                        if(result) break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Lüften pozitif bir sayı giriniz" + e.Message);

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
                decimal ort = toplam / arr.Count;
                Console.WriteLine("Sayıların ortalaması : " + ort);
                return arr;
            }
        }
    }

}




// class Program
//     {
//         static void Main(string[] args)
//         {
//             ArrayList numbers = new ArrayList();
//             ArrayList asal = new ArrayList();
//             Console.WriteLine("20 adet sayı girin.");

//             try
//             {

//                 int i = 0;
//                 while (i < 20)
//                 {
//                     int n = Convert.ToInt32(Console.ReadLine());

//                     if (n >= 0)
//                     {

//                         if (n == 1 || n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 7 == 0)
//                         {
//                             numbers.Add(n);
//                             if (n == 2 || n == 3 || n == 5 || n == 7)
//                             {
//                                 numbers.Remove(n);
//                                 asal.Add(n);
//                             }


//                         }
//                         else
//                         {
//                             asal.Add(n);
//                         }

//                     }
//                     else
//                     {
//                         Console.WriteLine("Lütfen 0'dan büyük bir sayı girin.");
//                         i--;
//                     }

//                     i++;

//                 }

//                 Console.WriteLine("******* [{0}] tane Asal Sayı vardır **********", asal.Count);

//                 asal.Sort();
//                 int asalToplam = 0;
//                 int toplam = 0;



//                 foreach (int item in asal)
//                 {
//                     asalToplam += item;
//                     Console.WriteLine(item);

//                 }

//                 Console.WriteLine("Asal sayıların ortalaması: " + asalToplam / asal.Count);
//                 Console.WriteLine("******* [{0}] tane Asal Olmayan Sayı vardır. **********", numbers.Count);

//                 numbers.Sort();

//                 foreach (int item in numbers)
//                 {
//                     toplam += item;
//                     Console.WriteLine(item);
//                 }
//                 Console.WriteLine("Asal olmayan sayıların ortalaması: " + toplam / numbers.Count);
//             }

//             catch (Exception ex)
//             {
//                 Console.WriteLine("Hata: Lütfen bir sayı girin. ", ex.Message );

//             }





//         }
//     }
// }