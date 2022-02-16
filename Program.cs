using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayi){
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama= " + toplam/sayi);

            //foreach
            string[] arabalar = {"hyundai", "toyota", "suzuki", "nissan"};

            foreach(var araba in arabalar){
                Console.WriteLine(araba);
            }
        }
    }
}
