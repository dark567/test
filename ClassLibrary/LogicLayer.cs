using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class LogicLayer
    {
        /// <summary>
        /// какое то описание
        /// </summary>
        /// <returns></returns>
        public static int[] AddArr()
        {
            Random rnd = new Random();
            int[] arrT = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrT[i] = rnd.Next(-100, 100);
            }
            return arrT;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ArrT"></param>
        /// <returns></returns>
        public static int SumAll(int[] ArrT)
        {
            int sum = 0;
            foreach (var item in ArrT)
            {
                sum += item;
            }
            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ArrT"></param>
        /// <returns></returns>
        public static int SumNeg(int[] ArrT)
        {
            int sum = 0;
            foreach (var item in ArrT)
            {
                if (item < 0) sum += item;
            }
            return sum;
        }
    }
}
