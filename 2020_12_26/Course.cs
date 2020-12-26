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
    public partial class Course : Form
    {
        string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseManagementSystem;Integrated Security=True";

        public Course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();

                string sql = "SELECT * FROM Course where Course_id='" + textBox2.Text + "'And Course_name='" + textBox3.Text + "'";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtAllStu.Text += reader[0].ToString() + "    " + reader[1].ToString()
    + "    " + reader[2].ToString() + "    " + reader[3].ToString() + "    " + reader[4].ToString() + "\r\n";
                    }
                }
                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                int i = 1;
                string Student_id = Login.ID;
                string Course_id = textBox2.Text;

                SqlCommand command = new SqlCommand();
                //command.CommandText = "INSERT INTO Student(Student_id，Student_name，Student_sex，Student_time，Student_class)VALUES('" + Student_id + "', '" + Student_name + "', '" + Student_sex + "', '" + Student_time + "', '" + Student_class + "')";
                command.CommandText = "INSERT INTO Student_Course(ID,Student_id，Course_id)VALUES('" + i++ + "','" + Student_id + "','" + Course_id + "')";
                command.CommandType = CommandType.Text;
                command.Connection = sqlcon;
                sqlcon.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("插入成功！", "消息", MessageBoxButtons.OK);
                    //btnSeach_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student f2 = new Student();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAllStu.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                string sql = "SELECT * FROM Student";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtAllStu.Text += reader[0].ToString() + "    " + reader[1].ToString()
    + "    " + reader[2].ToString() + "    " + reader[3].ToString() + "    " + reader[4].ToString() + "\r\n";
                    }
                }
                reader.Close();
            }
        }
    }
}
