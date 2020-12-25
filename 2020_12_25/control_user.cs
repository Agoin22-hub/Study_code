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
    public partial class control_user : Form
    {
        string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseManagementSystem;Integrated Security=True";

        public control_user()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void control_user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                string Student_id = textBox1.Text.Trim();
                string Student_name = textBox2.Text.Trim();
                string Student_sex;
                if (RbtnMale.Checked)
                {
                    Student_sex = "male";
                }
                else
                {
                    Student_sex = "fmale";
                }
                string Student_time = dateTimePicker1.Value.ToShortDateString().Split(' ')[0];
                string Student_class = textBox3.Text.Trim();
                //string stuCredit = txtCredit.Text.Trim();
                SqlCommand command = new SqlCommand();
                //command.CommandText = "INSERT INTO Student(Student_id，Student_name，Student_sex，Student_time，Student_class)VALUES('" + Student_id + "', '" + Student_name + "', '" + Student_sex + "', '" + Student_time + "', '" + Student_class + "')";
                command.CommandText = "INSERT INTO Student(Student_id，Student_name，Student_sex，Student_time，Student_class)VALUES(" + Student_id + ", " + Student_name + ", " + Student_sex + ", " + Student_time + ", " + Student_class + ")";
                command.CommandType = CommandType.Text;
                command.Connection = sqlcon;
                sqlcon.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("插入成功！", "消息", MessageBoxButtons.OK);
                    btnSeach_Click(null, null);
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

        private void btnSeach_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator f2 = new Administrator();
            f2.Show();
        }

        private void txtAllStu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
