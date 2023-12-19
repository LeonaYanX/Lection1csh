using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value");
            int firstV = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            int secV = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third value");
            int thirdV = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth value");
            int fourthV = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth value");
            int fiveV = int.Parse(Console.ReadLine());
            int max = firstV;
            if (secV>max) 
            {
            max = secV;
            }
            if (thirdV > max)
            {
                max = thirdV;
            }
            if (fourthV > max)
            {
                max = fourthV;
            }
            if (fiveV > max)
            {
                max = fiveV;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
