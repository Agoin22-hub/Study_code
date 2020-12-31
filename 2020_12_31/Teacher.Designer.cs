namespace V_1
{
    partial class Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAllTea = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息ToolStripMenuItem,
            this.课程信息ToolStripMenuItem,
            this.班级信息ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(535, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // 课程信息ToolStripMenuItem
            // 
            this.课程信息ToolStripMenuItem.Name = "课程信息ToolStripMenuItem";
            this.课程信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.课程信息ToolStripMenuItem.Text = "课程信息";
            this.课程信息ToolStripMenuItem.Click += new System.EventHandler(this.课程信息ToolStripMenuItem_Click);
            // 
            // 班级信息ToolStripMenuItem
            // 
            this.班级信息ToolStripMenuItem.Name = "班级信息ToolStripMenuItem";
            this.班级信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.班级信息ToolStripMenuItem.Text = "班级信息";
            this.班级信息ToolStripMenuItem.Click += new System.EventHandler(this.班级信息ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // txtAllTea
            // 
            this.txtAllTea.Location = new System.Drawing.Point(12, 49);
            this.txtAllTea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAllTea.Multiline = true;
            this.txtAllTea.Name = "txtAllTea";
            this.txtAllTea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAllTea.Size = new System.Drawing.Size(511, 169);
            this.txtAllTea.TabIndex = 3;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 246);
            this.Controls.Add(this.txtAllTea);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAllTea;
    }
}