using System;
using System.Windows.Forms;


namespace SQLCRACKER
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
            pictureBox2.Parent = pictureBox1;
            pictureBox2.Left = 558;
            pictureBox2.Top = 63;
        }
        private void labelChooseFileClick(object sender, EventArgs e)
        {
            MessageBox.Show("哎呀，别点人家嘛:P", "求放过", MessageBoxButtons.OK);
        }

        public void selectUserClick(object sender, EventArgs e)
        {
            userSelection data = new userSelection();
            data.ShowDialog();
            comboBox1.Text = userData.UserName;
        }

        private void buttonStartStageClick(object sender, EventArgs e)
        {
            if (!checkSave()) return;
            stageSelection data = new stageSelection();
            Hide();
            data.ShowDialog();
            Show();
        }

        private void showRankClick(object sender, EventArgs e)
        {
            if (!checkSave()) return;
            rank ranking = new rank();
            ranking.Show();
        }

        private void startChoiceClick(object sender, EventArgs e)
        {
            if (!checkSave()) return;
            testChoice testChoice = new testChoice();
            Hide();
            testChoice.ShowDialog();
            Show();
        }
        private bool checkSave()
        {
            if (comboBox1.Text != "") return true;
            MessageBox.Show("请先选择一个存档!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private void buttonContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hurricus\t\tMail:hurricus@foxmail.com\tGithub:Hurr1cus;\nHiraumi\t\tMail:hiraumi@foxmail.com\tGithub:Hiraumi;\nHawthorn\t\tMail:2313348831@qq.com;\n\n© 2022 Hurricus & Hiraumi Project", "开发人员", MessageBoxButtons.OK);
        }
    }
}
