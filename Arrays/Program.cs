using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testcase; i++)
            {
                int j = Convert.ToInt32(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                Array.Sort(arr);
                Console.WriteLine(arr[0] + " " + arr[arr.Length - 1]);

            }
        }
    }
}
