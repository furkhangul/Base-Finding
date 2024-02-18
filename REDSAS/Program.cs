using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDSAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int taban, us,sonuc=1;

            Console.Write("Sayı tabanını giriniz: ");
            taban = int.Parse(Console.ReadLine());

            Console.Write("Üs değerini giriniz: ");
            us = int.Parse(Console.ReadLine());
            for(int i = 0; i < us; i++)
            {   
                sonuc = sonuc * taban;
            }
            Console.WriteLine("Girdiğiniz tabanın üssü : {0}", sonuc);
            Console.ReadLine();
        }
    }
}
