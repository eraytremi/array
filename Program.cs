using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi= {15,85,96,45,76,25,63};
            foreach (var sayi in sayiDizisi)
            {
                System.Console.Write($"{sayi,5}");
            }

            // sort sıralama işlemi yapar
            System.Console.WriteLine();
            System.Console.Write("sıralama işlemi:  ");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine($"{sayi,5}");
            }

            //clear temizleme 
            System.Console.WriteLine();
            System.Console.WriteLine("2. elemandan sonra iki elemanı silince: ");
            Array.Clear(sayiDizisi,2,2);
             foreach (var sayi in sayiDizisi)
            {
                System.Console.Write($"{sayi,5}");
            }

            //reverse işlemi : listeyi tersine çevirir

            System.Console.WriteLine();
            System.Console.WriteLine("reverse işlemi:  ");
            Array.Reverse(sayiDizisi);
             foreach (var sayi in sayiDizisi)
            {
                System.Console.Write($"{sayi,5}");
            }

            // indexof verilen değerin indexini döner 
            System.Console.WriteLine();
            System.Console.WriteLine("76 elemanı kaçıncı indexte? :  ");
            System.Console.WriteLine(Array.IndexOf(sayiDizisi,76)); 

            // Resize / yeniden boyutlandırma yapar.
            System.Console.WriteLine();
            System.Console.WriteLine("dizinin boyutunu 9 yap!");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[4]=90;
            
            foreach (var sayi in sayiDizisi)
            {
                System.Console.Write($"{sayi,5}");
            }
            
               
            


           

        
            
        }
    }
}