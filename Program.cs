using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*** 链表倒置 ***/
                NodeList node5 = new NodeList(5, null);
                NodeList node4 = new NodeList(4, node5);
                NodeList node3 = new NodeList(3, node4);
                NodeList node2 = new NodeList(2, node3);
                NodeList node1 = new NodeList(1, node2);

                // 递归 
                NodeList newNodeList1 = NodeList.Recursion(node1);
                Console.WriteLine($"{newNodeList1}");

                // 迭代
                NodeList newNodeList2 = NodeList.Iteration(node5);
                Console.WriteLine($"{newNodeList2}");
                /*** 链表倒置 ***/


                Console.WriteLine();


                /*** 质数个数统计 ***/
                // 埃拉托色尼筛法
                int range1 = 100;
                int count1 = PrimeCount.Eratosthenes(range1);
                Console.WriteLine($"0-{range1}内的质数个数: {count1}");

                // 暴力搜索法
                int range2 = 10;
                int count2 = PrimeCount.Bs(range2);
                Console.WriteLine($"0-{range2}内的质数个数：{count2}");
                /*** 质数个数统计 ***/


                Console.WriteLine();


                /*** 斐波那契数列 ***/
                // 暴力递归
                Console.WriteLine($"斐波那契数列第10项：{Fib.Recursion(10)}");

                // 去重递归
                Console.WriteLine($"斐波那契数列第10项：{Fib.ReviewRecursion(10)}");

                // 双指针算法
                Console.WriteLine($"斐波那契数列第10项：{Fib.TwoPointMethod(10)}");
                /*** 斐波那契数列 ***/


                Console.WriteLine();


                /*** 硬币排列 ***/
                Console.WriteLine($"11个硬币最多排列：{ArrangeCoin.ArrangeCoins1(11)}行");
                Console.WriteLine($"11个硬币最多排列：{ArrangeCoin.ArrangeCoins2(11)}行");
                /*** 硬币排列 ***/


                Console.WriteLine();


                /*** 一维线性规划问题 ***/
                Console.WriteLine($"{DynamicProgramming.GoUpstairs(10)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
