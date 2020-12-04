using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SortCmp
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertionSorter Sorter1 = new InsertionSorter();
            BubbleSorter Sorter2 = new BubbleSorter();
            SelectionSorter Sorter3 = new SelectionSorter();
            //定义一个很大的数组（为了让结果更明显），用来存放随机生成的数字
            int iCount = 10000;
            Sorter1.list = new int[iCount];
            Sorter2.list = new int[iCount];
            Sorter3.list = new int[iCount];
            Random random = new Random();//生成随机数
            for (int i = 0; i < iCount; ++i)
            {
                Sorter1.list[i] = Sorter2.list[i] = Sorter3.list[i] = random.Next();
            }
            //单线程
            //插入排序
            Stopwatch stwatch1 = new Stopwatch();
            stwatch1.Start();
            Sorter1.Sort();
            stwatch1.Stop();
            Console.WriteLine(stwatch1.Elapsed.TotalMilliseconds);

            //冒泡排序
            Stopwatch stwatch2 = new Stopwatch();
            stwatch2.Start();
            Sorter2.Sort();
            stwatch2.Stop();
            Console.WriteLine(stwatch2.Elapsed.TotalMilliseconds);
            //选择排序
            Stopwatch stwatch3 = new Stopwatch();
            stwatch3.Start();
            Sorter3.Sort();
            stwatch3.Stop();
            Console.WriteLine(stwatch3.Elapsed.TotalMilliseconds);

            Console.ReadKey();

            //多线程

            Thread sortThread1 = new Thread(new ThreadStart(Sorter1.Sort));
            Thread sortThread2 = new Thread(new ThreadStart(Sorter2.Sort));
            Thread sortThread3 = new Thread(new ThreadStart(Sorter3.Sort));
            Stopwatch stwatch4 = new Stopwatch();
            stwatch4.Start();
            sortThread1.Start();
            sortThread2.Start();
            sortThread3.Start();

            while (true)
            {
                if (sortThread1.ThreadState == System.Threading.ThreadState.Stopped &&
                    sortThread2.ThreadState == System.Threading.ThreadState.Stopped &&
                    sortThread3.ThreadState == System.Threading.ThreadState.Stopped)
                {
                    stwatch4.Stop();
                    Console.WriteLine(stwatch4.Elapsed.TotalMilliseconds);
                    break;
                }
            }
            Console.ReadKey();
        }
    }

    //插入排序
    public class InsertionSorter
    {
        public int[] list;
        public void Sort()
        {
            for (int i = 1; i < list.Length; i++)   //要将第几位数进行插入
            {
                int t = list[i];
                int j = i;
                //如果要排序的数大于已排序元素的最大值，就不用比较了
                while ((j > 0) && (list[j - 1] > t))   //如不是就要不断比较找到合适的位置
                {
                    list[j] = list[j - 1];
                    --j;
                }
                list[j] = t;
            }
            Console.Write("Insertion done  ");
        }
    }

    //冒泡排序
    public class BubbleSorter
    {
        public int[] list;
        public void Sort()
        {
            int i, j, temp;
            bool done = false;
            j = 1;
            //利用双层循环进行依次比较
            //从第0位开始，比较前后两位数字大大小，当 list[i] > list[i+1] 时，数值互换。
            while ((j < list.Length) && (!done))
            {
                done = true;
                for (i = 0; i < list.Length - j; i++)  //for循环获得一个最大的数
                {
                    if (list[i] > list[i + 1])   //数值互换
                    {
                        done = false;
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
                j++;
            }
            Console.Write(" ");
            Console.Write("Bubble done  ");
        }
    }

    //选择排序
    //每次从后面找到最小或最大的数，进行位移排序
    public class SelectionSorter
    {
        public int[] list;
        public void Sort()
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                list[i] = i;
                for (int j = i + 1; j < list.Length; j++)   //从第i为开始找出最小的数
                {
                    if (list[j] < list[i])
                        list[j] = j;
                }
                int t = list[i];
                list[i] = list[i];
                list[i] = t;
            }
            Console.Write(" ");
            Console.Write("Selection done  ");
        }
    }
}
