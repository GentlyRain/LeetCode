using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 质数个数统计
    /// </summary>
    public class PrimeCount
    {
        /// <summary>
        /// 埃拉托色尼筛法
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Eratosthenes(int num)
        {
            bool[] flag = new bool[num];        // 合数：false；质数：true
            int count = 0;

            for (int i = 2; i <= num - 1; i++)
            {
                if (!flag[i])
                {
                    count++;
                    for (int j = 2 * i; j <= num - 1; j+=i)
                    {
                        flag[j] = true;
                    }
                }
            }

            return count;
        }
    }
}
