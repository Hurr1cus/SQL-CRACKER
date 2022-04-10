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
    public partial class testChoice : Form
    {
        private int correctOption;
        private static DataTable testChoiceTable = SQLiteHelper.ExecuteDataSet(sqlConn.testInforDataSqliteConn, "select * from choiceTest", null).Tables[0];
        public testChoice()
        {
            InitializeComponent();
            getInfor();
            if (userData.CurrentSelectionStage == 10)
            {
                MessageBox.Show("您已完成所有题目!");
            }

        }
        private void getInfor()
        {            
            int index = userData.CurrentSelectionStage - 1;
            toolStripStatusLabelCurrentQuestion.Text = "当前第" + testChoiceTable.Rows[index]["index"].ToString() + "题";
            toolStripProgressBar1.Value = index * 10 + 10;
            labelQuestion.Text = testChoiceTable.Rows[index ]["question_description"].ToString();
            correctOption = int.Parse(testChoiceTable.Rows[index ]["correct_option"].ToString());
            buttonChoice0.Text = testChoiceTable.Rows[index]["option_description0"].ToString();
            buttonChoice1.Text = testChoiceTable.Rows[index ]["option_description1"].ToString();
            buttonChoice2.Text = testChoiceTable.Rows[index ]["option_description2"].ToString();
            buttonChoice3.Text = testChoiceTable.Rows[index]["option_description3"].ToString();
        }
        private void optionClick(object sender, EventArgs e)
        {
            string currentChoiceText = ((Button)sender).Name;
            int currentChoice = int.Parse(currentChoiceText.Substring(currentChoiceText.Length - 1));
            
            if (currentChoice != correctOption)
            {
                MessageBox.Show("错了:/", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ((Button)sender).Enabled = false;
                return;
            }
            MessageBox.Show("答对了:D", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (userData.CurrentSelectionStage == 10)
            {
                MessageBox.Show("您已完成所有题目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                userData.CurrentSelectionStage++;
                userData.saveData();               
            }
            getInfor();
            for(int i = 0; i < 4;i++)
            {
                Button button = (Button)this.Controls.Find("buttonChoice" + i, true)[0];
                button.Enabled = true;               
            }

        }

        private void testChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
