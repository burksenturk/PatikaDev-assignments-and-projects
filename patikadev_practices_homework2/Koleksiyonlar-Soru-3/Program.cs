using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("**lütfen bir cümle giriniz**");
            string cumle = Console.ReadLine().ToLower();
            cumle.ToCharArray();
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            ArrayList harflistesi = new ArrayList();

            foreach (var harf1 in cumle)
            {
                foreach (var harf2 in sesliler)
                 {
                  if(harf1==harf2)
                  harflistesi.Add(harf1);
                 }

            }
            Console.WriteLine("***cümlede bulunan sesli harfler: ***");

            foreach (var item in harflistesi)
            {
                Console.Write(item);
            }
          

            
            
        }
    }
}
