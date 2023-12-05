using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotSayiBulucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiBulucu sayilar = new SayiBulucu();
            double bs = sayilar.BuyukSayiyiBul(4, 40);
            Console.WriteLine("Büyük sayı:"+bs);
        }
    }
    public class SayiBulucu
    {
        public double BuyukSayiyiBul(double sayi1,double sayi2)
        {
            double sonuc = 0;
            if(sayi1 >= sayi2) 
            {
                sonuc = sayi1;
            }
            else
            {
                sonuc =  sayi2;
            }
            return sonuc;
        }   
    }
}
