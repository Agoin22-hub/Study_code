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
    public partial class Student : Form
    {
        string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseManagementSystem;Integrated Security=True";

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            string Student_id = Login.ID;
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                string sql  = "select *from Student where Student_id='" +  Login.ID+"'" ;
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox1.Text +=  reader[0].ToString() + "    " + reader[1].ToString()
    + "    " + reader[2].ToString() + "    " + reader[3].ToString() + "    " + reader[4].ToString() + "\r\n";

                    }
                }
                reader.Close();
            }            
        }

        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                string sql = "select *from Student_Course where Student_id='" + Login.ID + "'";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox1.Text += "选课号： " + reader[0].ToString() + "    学号： "+ reader[1].ToString() + "    课程号"
    + reader[2].ToString()  + "\r\n";

                    }
                }
                reader.Close();
            }
        }

        private void 选课列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course f2 = new Course();
            f2.Show();
        }
    }
}

