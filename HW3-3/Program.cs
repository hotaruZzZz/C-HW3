using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //第三題
            Console.Write("請輸入用電度數: ");
            double m = double.Parse(Console.ReadLine());
            double price = m;
            if (m <= 120)
            {
                price *= 1.63;
                Console.WriteLine($"電費為{price}元");
            }
            else if (m > 120 && m <= 330)
            {
                price *= 2.38;
                Console.WriteLine($"電費為{price}元");
            }
            else if (m > 330 && m <= 500)
            {
                price *= 3.52;
                Console.WriteLine($"電費為{price}元");
            }
            else if (m > 500 && m <= 700)
            {
                price *= 4.80;
                Console.WriteLine($"電費為{price}元");
            }
            else if (m > 700 && m <= 1000)
            {
                price *= 5.66;
                Console.WriteLine($"電費為{price}元");
            }
            else
            {
                price *= 6.41;
                Console.WriteLine($"電費為{price}元");
            }
            Console.Read();
        }
    }
}
