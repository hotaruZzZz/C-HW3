using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //第二題
            Console.Write("請輸入西元年份: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("閏年");
                    }
                    else
                    {
                        Console.WriteLine("平年");
                    }
                }
                else
                {
                    Console.WriteLine("閏年");
                }
            }
            else
            {
                Console.WriteLine("平年");
            }
            Console.Read();
        }
    }
}
