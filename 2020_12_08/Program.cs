using System;
using System.Data.SqlClient;

namespace experSql123
{
    //添加
    class Add
    {
        public void add()
        {
            Console.Write("请输入学号：");
            string stuId = Console.ReadLine();
            Console.Write("请输入姓名：");
            string StuName = Console.ReadLine();
            Console.Write("请输入性别：");
            string StuSex = Console.ReadLine();
            Console.Write("请输入出生日期：");
            string StuBir = Console.ReadLine();
            Console.Write("请输入专业：");
            string StuMajor = Console.ReadLine();
            Console.Write("请输入总学分：");
            string StuCredit = Console.ReadLine();

            //1、创建数据库连接对象，并编写连接字符串，注意连接字符串不要写错
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);


            //2、创建数据库操作对象，创建过程是与刚创建的连接对象匹配起来
            SqlCommand cmd = conn.CreateCommand();

            //3、编写操作语句 TSQL语句
            cmd.CommandText = "insert into XSB(XH,XM,XB,CSRQ,ZY,ZXF) values('" + stuId + "','" + StuName + "','" + StuSex + "','" + StuBir + "','" + StuMajor + "','" + StuCredit + "')";



            //4、数据库连接打开，准备执行操作
            conn.Open();

            //5、执行操作，并记录受影响的行数
            int count = cmd.ExecuteNonQuery();

            //6、关闭数据库连接**********
            conn.Close();

            //7、提示操作是否成功
            if (count > 0)
                Console.WriteLine("添加成功！");
            else
                Console.WriteLine("添加失败！");


        }
    }

    //删除
    class Delete
    {
        public void delect()
        {
            Console.Write("请输入要删除的学生学号：");
            string StuID = Console.ReadLine();

            //1、创建数据库连接类
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);


            //2、创建数据库操作类
            SqlCommand cmd = conn.CreateCommand();
            //3输入要操作删除的信息
            cmd.CommandText = "delete from XSB where XH = '" + StuID + "'";
            //4打开数据库连接
            conn.Open();
            //5引进一个变量来记录受影响条数
            int i = cmd.ExecuteNonQuery();
            //6关闭数据库
            conn.Close();
            //7判断是否能够删除
            if (i > 0)
                Console.WriteLine("删除成功！");
            else
                Console.WriteLine("删除失败！");


        }
    }
    
    //修改
    class Change
    {
        public void change()
        {
            Console.Write("请输入要修改的学生姓名：");
            string StuOName = Console.ReadLine();
            Console.Write("请输入修改后的学生姓名：");
            string StuNName = Console.ReadLine();

            //1、创建数据库连接类
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);


            //2、创建数据库操作类
            SqlCommand cmd = conn.CreateCommand();
            //3输入要操作修改的信息
            cmd.CommandText = "update XSB set XM = '" + StuNName + "'  where XM = '" + StuOName + "'";
            //4打开数据库连接
            conn.Open();
            //5引进一个变量来记录受影响条数
            int i = cmd.ExecuteNonQuery();
            //6关闭数据库
            conn.Close();
            //7判断是否能够修改
            if (i > 0)
                Console.WriteLine("修改成功！");
            else
                Console.WriteLine("修改失败！");


        }
    }

    //查询
    class Search
    {
        public void search()
        {
            //1建立数据库连接对象并且建立变量，编写字符串
            string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=XSCJDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);

            //2建立数据库操作对象
            SqlCommand cmd = conn.CreateCommand();
            //3选择数据库表格
            cmd.CommandText = "select *from XSB";
            //4 打开数据库
            conn.Open();
            //5建立查询变量用一个新的类
            SqlDataReader dr = cmd.ExecuteReader();
            //6判断信息表格信息条数
            if (dr.HasRows)
            {//7挡在读取范围之内时读取出来每一行信息
                while (dr.Read())
                {//8输出
                    string result;
                    result = dr[0].ToString() + dr[1].ToString() + dr[2].ToString() + dr[3].ToString() + dr[4].ToString() + dr[5].ToString();
                    Console.WriteLine(result);
                }

            }
            conn.Close();

        }

    }

    //菜单
    class Menu                                                                            
    {
        public void menu()
        {
            Console.WriteLine("***** 1.Add *********** 2.Delete *****");
            Console.WriteLine("**** 3.Change ********* 4.Search *****");
            Console.WriteLine("************** 0.Exit ****************");
            Console.WriteLine("请输入你的选择#"); 
               
        }
    }
    class Mainclass
    {
        static void Main(string[] args)
        {
             // 实例化
            Add sel1 = new Add();           
            Delete sel2 = new Delete();
            Change sel3 = new Change();
            Search sel4 = new Search();
            Menu sel5 = new Menu();
            sel5.menu();
           
            while (true)     //永不主动退出
            {
                string temp = Console.ReadLine();
                int select = int.Parse(temp);

                if (select == 1)
                {
                    sel1.add();   
                }
                else if (select == 2)
                {
                    sel2.delect();
                }
                else if (select == 3)
                {
                    sel3.change();
                }
                else if (select == 4)
                {
                    sel4.search();
                }
                else if (select == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("输入错误，请重新输入！");
                }
                sel5.menu();    
            }
     
        }
    }    
}

