using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me how long I must count?");
            int N = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= N) 
            {
                Console.Write(i);
                Console.Write(' ');
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}
