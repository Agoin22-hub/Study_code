using System;

namespace work_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 1;//存放表达式的结果
            double i;//循环控制条件
                     //i是整数，但是它将会作为除数和被除数，除后结果要求返回double型

            int n = 1000;

            for (i = 1; i <= n; i++)
            {

                res *= (2 * i / (2 * i - 1)) * (2 * i / (2 * i + 1));
            }

            double pi = 2 * res;
            Console.WriteLine("{0}", pi);
            Console.Read();
        }
    }
}
