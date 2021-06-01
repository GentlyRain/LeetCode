using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ArrangeCoin
    {
        public static int ArrangeCoins1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                n = n - i;
                if (n < i + 1)
                {
                    return i;
                }
            }

            return 0;
        }


        /// <summary>
        /// 双指针算法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ArrangeCoins2(int n)
        {
            int low = 0, high = n;
            int cost = 0, mid = 0;
            while (low < high)
            {
                mid = (high - low) / 2 + low;
                cost = (1 + mid) * mid / 2;     // 求和
                if (cost < n)
                {
                    low = mid + 1;
                }
                else if (cost > n)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return low < high ? low : high;
        }
    }
}
