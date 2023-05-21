using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alıştırmalar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı_1, sayı_2, toplam = 0;
            Console.Write("sayı_1 değeri:");
            sayı_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sayı_2 değeri:");
            sayı_2 = Convert.ToInt32(Console.ReadLine());
            toplam = sayı_1 + sayı_2;
            Console.Write("toplam=" + toplam);
            Console.ReadLine();
        }// BU CONSOLE PROGRAMI TOPLAMA İŞLEMİ İÇİN YAZILMIŞTIR. ÖĞRENME AŞAMASINDAYIM :)
    }
}
