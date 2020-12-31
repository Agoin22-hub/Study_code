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
    public partial class Teacher : Form
    {
        string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseManagementSystem;Integrated Security=True";

        public Teacher()
        {
            InitializeComponent();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string n;
        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAllTea.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                string sql = "select *from Teacher where Teacher_id='" + Login.ID + "'";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtAllTea.Text += "教工号： " + reader[0].ToString() + "  姓名：" + reader[1].ToString()
    + "  电话：" + reader[2].ToString() + "  课程号：" + reader[3].ToString() + "\r\n";

                    }
                   // string n = reader[2].ToString();
                }
                reader.Close();
            }
        }

        private void 班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAllTea.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                string sql = "select *from Student ";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtAllTea.Text += "班级： " + reader[4].ToString() +  "\r\n";
                    }
                }
                reader.Close();
            }
        }

        private void 课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtAllTea.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                string sql = "select *from Teacher where Course_id='" + n + "'";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtAllTea.Text += "教工号： " + reader[0].ToString() + "  姓名：" + reader[1].ToString()
    + "  电话：" + reader[2].ToString() + "  课程号：" + reader[3].ToString() + "\r\n";

                    }
                }
                reader.Close();
            }
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
