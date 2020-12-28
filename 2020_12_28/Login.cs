using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace V_1
{
    //public class classshared
    //{
    //    //数组“userInfo”记录登录用户的用户名
    //    public static string[] userInfo = new string[2];
    //}
   
    public partial class Login : Form
    {
        public static string ID ;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //设置连接字符串
            String Connstr = @"Persist Security Info=False;Integrated Security=SSPI;Initial Catalog=CourseManagementSystem;Data Source=(localdb)\MSSQLLocalDB";
            SqlConnection conn = new SqlConnection(Connstr);
            conn.Open();
            ID = textBox1.Text;
            try
            {
                if (this.textBox1.Text == "") //验证是否输入了用户姓名
                {
                    MessageBox.Show("用户名不能为空");
                    textBox1.Focus();
                    return;
                }
                if (this.textBox2.Text == "")//验证是否输入了密码
                {
                    MessageBox.Show("请输入密码");
                    textBox2.Focus();
                    return;
                }
                if (radioButton1.Checked == true)
                {
                    string sql = string.Format("select count(*)from Users where User_id='{0}'and User_password='{1}'and User_power='{2}'", this.textBox1.Text, this.textBox2.Text, 1);
                    SqlCommand comm = new SqlCommand(sql, conn); //创建comm对象
                    int count = (int)comm.ExecuteScalar();//执行查询并返回查询
                    if (count == 1)//判断是否存在这样一列
                    {
                        this.Hide();
                        Student f2 = new Student();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("不存在此用户");
                    }
                }
                if (radioButton2.Checked == true)
                {
                    string sql = string.Format("select count(*)from Users where User_id='{0}'and User_password='{1}'and User_power='{2}'", this.textBox1.Text, this.textBox2.Text, 2);
                    SqlCommand comm = new SqlCommand(sql, conn); //创建comm对象
                    int count = (int)comm.ExecuteScalar();//执行查询并返回查询
                    if (count == 1)//判断是否存在这样一列
                    {
                        this.Hide();
                        Teacher f2 = new Teacher();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("不存在此用户");
                    }
                }
                if (radioButton3.Checked == true)
                {
                    string sql = string.Format("select count(*)from Users where User_id='{0}'and User_password='{1}'and User_power='{2}'", this.textBox1.Text, this.textBox2.Text, 3);
                    SqlCommand comm = new SqlCommand(sql, conn); //创建comm对象
                    int count = (int)comm.ExecuteScalar();//执行查询并返回查询
                    if (count == 1)//判断是否存在这样一列
                    {
                        this.Hide();
                        Administrator f2 = new Administrator();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("输入有误，请重新输入");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("产生异常！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }
    }
}
