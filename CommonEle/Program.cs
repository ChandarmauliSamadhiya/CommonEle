using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            Console.WriteLine("Common elements:");
            foreach (int num1 in array1)
            {
                foreach (int num2 in array2)
                {
                    if (num1 == num2)
                    {
                        Console.Write(num1 + " ");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
