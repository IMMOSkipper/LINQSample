using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 28, 31, 17, 16, 42 };

            var numsQuery = from n in numbers
                           where n < 20
                           select n;

            var numsMethod = numbers.Where(N => N < 20);

            int numsCount = (from n in numbers
                             where n < 20
                             select n).Count();

            foreach(var x in numsQuery)
                Console.Write($"{ x }, ");
            Console.WriteLine();

            foreach (var x in numsMethod)
                Console.Write($"{ x }, ");
            Console.WriteLine();

            Console.WriteLine(numsCount);
        }
    }
}
