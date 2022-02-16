using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int kontrol = 0; // kontrol değişkeni 
            Console.Write("Sayı Girin : "); 
            int sayi = Convert.ToInt32(Console.ReadLine()); 

           if (sayi == 1 || sayi == 0) // sayı 0 veya 1 ise
            {
                Console.WriteLine("Asal sayı değildir");
                
            }
            else // diğer durumlar için
            {
                for(int i=2; i < sayi; i++) //2 den sayının kendisine kadar
                {
                    if (sayi % i == 0) // tam bölünürse
                    {
                        kontrol++; // kontrol değişkenini arttır
                        break; // döngüden çık
                    }
                    
                }
                if (kontrol == 0) // kontrol hala 0'a eşit ise 
                {
                    Console.WriteLine("Asal sayıdır"); 
                }
                else //değilse asal sayı değildir
                {
                    Console.WriteLine("Asal sayı değildir");
                }
            }
            


            Console.Read(); 
        }
    }
}
