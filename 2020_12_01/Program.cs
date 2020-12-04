//题目：根据公式计算π的值，并计算圆的面积
//时间：2020_12_01
//π/6 = 1/2 +(1/2)*(1/3)*(1/2)^3+((1/2)*(3/4)) *(1/5) *(1/2)^5 +……
//公式编程计算π的值，直到所加项小于1e-10为止

using System;

namespace pi_exa03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入圆的半径r：");

            double r = Convert.ToDouble(Console.ReadLine());//将指定的对象的值强制转换为double类型
            double sum = 0.5, t, t1, t2, t3, p = 0.5 * 0.5, S;
            int odd = 1, even = 2;
            t = t1 = t2 = 1.0; t3 = 0.5;
            while (t > 1e-10)
            {
                t1 = t1 * odd / even;
                odd += 2; even += 2;
                t2 = 1.0 / odd;
                t3 = t3 * p;
                t = t1 * t2 * t3;
                sum += t;

            }
            S = sum * 6 * r * r;
            Console.WriteLine("\nPI={0,10:f8}", sum * 6);
            Console.WriteLine("S is" + S);
            Console.Read();

        }
    }
}


