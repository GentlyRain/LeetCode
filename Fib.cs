using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Fib
    {
        /// <summary>
        /// 暴力递归
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Recursion(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }

            return Recursion(num - 1) + Recursion(num - 2);
        }


        public static int ReviewRecursion(int num)
        {
            int[] fibArray = new int[num + 1];
            
            return SaveNum(fibArray, num);
        }

        public static int SaveNum(int[] fibArray, int num)
        {
            if (num == 0)
            {
                return 0;
            }

            if (num == 1)
            {
                return 1;
            }

            if (fibArray[num] != 0)
            {
                return fibArray[num];
            }

            fibArray[num] = SaveNum(fibArray, num - 1) + SaveNum(fibArray, num - 2);

            return fibArray[num];
        }


        /// <summary>
        /// 双指针算法
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int TwoPointMethod(int num)
        {
            int low = 0, high = 1;
            int sum = 0;
            for (int i = 2; i <= num; i++)
            {
                sum = low + high;
                low = high;
                high = sum;
            }

            return sum;
        }
    }
}
