//增
using System;
using System.Data.SqlClient;

namespace insert
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}

//删
using System;
using System.Data.SqlClient;


namespace adonet1
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}
//改
using System;
using System.Data.SqlClient;


namespace adonet1
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadKey();
        }
    }
}
//查
using System;
using System.Data.SqlClient;


namespace SQLSelect
{
    class Program
    {
        static void Main(string[] args)
        {//1建立数据库连接对象并且建立变量，编写字符串
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
            Console.ReadKey();
        }
    }
}
//MySQL
using System;
using MySql.Data.MySqlClient;
using MySqlConnector;

namespace insert
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("请输入学号：");
            string stuId = Console.ReadLine();
            Console.Write("请输入姓名：");
            string StuName = Console.ReadLine();


            //1、创建数据库连接对象，并编写连接字符串，注意连接字符串与SQLServer不同
            string strcon = "data source=localhost;database=xscjdb;user id=root;password=123456;pooling=false;charset=utf8";
            MySqlConnection conn = new MySqlConnection(strcon);
            //mySqlConnection conn = new SqlConnection(strcon);

            //2、创建数据库操作对象，创建过程是与刚创建的连接对象匹配起来
            MySqlCommand cmd = conn.CreateCommand();

            //3、编写操作语句 TSQL语句
            cmd.CommandText = "insert into XSB values('" + stuId + "','" + StuName + "' )";

            //string sql = "insert into xsb values('" + stuId + "','" + StuName + "' )";
            //MySqlCommand cmd = new MySqlCommand(sql, conn);

            //4、数据库连接打开，准备执行操作
            try { conn.Open(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            //5、执行操作，并记录受影响的行数
            int count = cmd.ExecuteNonQuery();

            //6、关闭数据库连接**********
            conn.Close();

            //7、提示操作是否成功
            if (count > 0)
                Console.WriteLine("添加成功！");
            else
                Console.WriteLine("添加失败！");

            Console.ReadKey();
        }
    }
}

