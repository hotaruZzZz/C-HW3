using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10802013_陳家甄
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //第一題
            Console.Write("請輸入一個整數: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "偶數" : "奇數");
            Console.Read();
        }
    }
}
