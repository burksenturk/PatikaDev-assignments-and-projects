using System;

namespace c__Ödev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. soru: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
           
            Console.WriteLine("lütfen dizinin eleman sayısını belirleyen bir tamsayı giriniz(n): ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] SayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
                SayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("*******************************girdiğiniz listedeki çift sayılar: ************************************");

            foreach (var sayi in SayıDizisi)
            {
              if (sayi%2 == 0)
              {
                  Console.WriteLine(sayi);
              }
              
            }

            // //2. soru: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.WriteLine("lütfen dizinin eleman sayısını belirleyen bir tamsayı giriniz(n): ");
            int diziboyutu = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen pozitif bir tamsayı giriniz(m): ");
            int Mdegeri = int.Parse(Console.ReadLine());

            int[] sayıdizisi = new int[diziboyutu];

            for (int i = 0; i < diziboyutu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz: ", i+1);
                sayıdizisi[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("******m değerine eşit veya tam bölnünen değerler******");

            foreach (var deger in sayıdizisi)
            {
                if (deger%2 ==0 || deger == Mdegeri)
                {
                    Console.WriteLine(deger);
                }
            }

            // //3. soru: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("lütfen dizinin eleman sayısını belirleyen bir tamsayı giriniz(n): ");

            int kelimedizisiuzunlugu = int.Parse(Console.ReadLine());
            string[] kelimeler = new string[kelimedizisiuzunlugu];

            Console.WriteLine("****Lütfen dizi içersinde yer almasını istediğiniz kelimeleri giriniz: ****");

            for (int i = 0; i < kelimedizisiuzunlugu ; i++)
            {
                Console.Write("lütfen {0}. kelimeyi giriniz: ", i+1);
                kelimeler[i] = Console.ReadLine();

            }

            Console.WriteLine("**kelimelerin sondan başa sıralanmış hali**");
            Array.Reverse(kelimeler);
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            //4. soru: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            
            string[] cumledizisi= cumle.Split(" ");
            Console.WriteLine("kelime sayısı: " + cumledizisi.Length);

            

            string.Join("",cumle);
            Console.WriteLine("harf sayısı: " + cumle.Length);
        }
    }
}
