using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQLCRACKER
{
    public partial class mainForm : Form
    {
      
        public mainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("哎呀，别点人家嘛:P", "求放过", MessageBoxButtons.OK);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            userSelection data = new userSelection();
            DialogResult result = data.ShowDialog();
            if (result == DialogResult.Cancel)
                this.Visible = true;
            comboBox1.Text = userData.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "") {
                stageSelection data = new stageSelection();                
                this.Hide();
                DialogResult result = data.ShowDialog();                      
                if (result == DialogResult.Cancel)
                    this.Visible = true;
            } else {
                MessageBox.Show("请先选择一个存档!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if (comboBox1.Text == "") {
                MessageBox.Show("请先选择一个存档!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rank ranking = new rank();
            ranking.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请先选择一个存档!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            testChoice testChoice=new testChoice();
            this.Hide();
            //testChoice.labelQuestion.Text = "";
            DialogResult dialogResult = testChoice.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
                this.Visible = true;
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hurricus\t\tMail:hurricus@foxmail.com\tGithub:Hurr1cus;\nHiraumi\t\tMail:hiraumi@foxmail.com\tGithub:Hiraumi;\nHawthorn\t\tMail:2313348831@qq.com;\n\n© 2022 Hurricus & Hiraumi Project", "开发人员", MessageBoxButtons.OK);
        }
    }
}
