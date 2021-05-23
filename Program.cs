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



                /*** 质数个数统计 ***/
                // 埃拉托色尼筛法
                int range = 100;
                int count = PrimeCount.Eratosthenes(100);
                Console.WriteLine($"0-{range}内的质数个数: {count}");
                /*** 质数个数统计 ***/
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
