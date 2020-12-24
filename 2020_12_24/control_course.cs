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
    public partial class control_course : Form
    {
        string strcon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseManagementSystem;Integrated Security=True";

        public control_course()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(strcon);
            try
            {
                string Course_id = textBox1.Text.Trim();
                string Course_name = textBox2.Text.Trim();
                string Course_period = textBox3.Text.Trim();
                //string Course_credit = textBox4.Text.Trim();
                string Course_describe = textBox4.Text.Trim();

                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO Course(Course_id，Course_name，Course_period，Course_describe)VALUES('" + Course_id + "', '" + Course_name + "', '" + Course_period + "',  '" + Course_describe + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            txtAllStu.Clear();
            using (SqlConnection sqlcon = new SqlConnection(strcon))
            {
                sqlcon.Open();
                string sql = "SELECT * FROM Course";
                SqlCommand command = new SqlCommand(sql, sqlcon);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtAllStu.Text += reader[0].ToString() + "    "
    + reader[1].ToString() + "    "
    + reader[2].ToString() + "    "
    + reader[4].ToString() + "\r\n";
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

        private void control_course_Load(object sender, EventArgs e)
        {

        }
    }
}
