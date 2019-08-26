using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using ClassLibrary1;

namespace ConsoleApp
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] Arr = new int[10];


            Arr = LogicLayer.AddArr();

            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.WriteLine($"Sum:{LogicLayer.SumAll(Arr)}");
            Console.WriteLine($"Sum negative:{LogicLayer.SumNeg(Arr)}");


            Console.ReadKey();
        }
    }
}
