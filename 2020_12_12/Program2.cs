using System;

namespace work_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[30];
            Console.Write("请输入一个字符串：");
            string str = Console.ReadLine();
            //abc2345 345fdf678 jdhfg945\0
            int start = 0;
            int index = 0;
            while (start < str.Length - 1)//表示start从下标0开始依次向后找，直到"\0"为止
            {
                string s = "";
                while (start < str.Length && str[start] >= 'a' && str[start] <= 'z')
                {
                    start++;
                }
                while (start < str.Length && str[start] >= '0' && str[start] <= '9')
                {
                    s += str[start];//将数字存入新的字符串
                    start++;
                }
                a[index] = Convert.ToInt32(s);//由于string无法隐式转换为int
                index++;
            }
            for (int i = 0; i < index; i++)
            {
                Console.Write("a[{0}]:{1} ", i, a[i]);
            }
            Console.Read();

        }
    }
}
