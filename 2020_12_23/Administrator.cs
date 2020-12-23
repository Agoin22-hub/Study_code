using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_1
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            control_user f2 = new control_user();
            f2.Show();
        }

        private void 课程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            control_course f2 = new control_course();
            f2.Show();
        }

        private void 班级管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            control_user f2 = new control_user();
            f2.Show();
        }
    }
}
