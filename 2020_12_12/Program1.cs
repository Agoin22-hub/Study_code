using System;

namespace work_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = 0;//下标
            int max = 0;
            max = a[0];
            for (int i = 1; i < a.Length; i++)//遍历数组，将最大值存入max中
            {
                if (max < a[i])
                {
                    max = a[i];
                    index = i;
                }
            }
            Console.Write("最大值{0},下标为:{1}", a[index], index);
            Console.Read();

        }
    }
}
