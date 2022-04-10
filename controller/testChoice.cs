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
        public testChoice()
        {
            InitializeComponent();
            getInfor();
            if (userData.currentSelectionStage == 10)
            {
                MessageBox.Show("您已完成所有题目!");
            }

        }
        private void getInfor()
        {            
            string sql = "select * from choiceTest where `index` =" + userData.currentSelectionStage;
            sqlConn.testInforDataSqliteConn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, sqlConn.testInforDataSqliteConn);
            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    string indexString = dr["index"].ToString();
                    toolStripStatusLabelCurrentQuestion.Text = "当前第" + indexString + "题";
                    toolStripProgressBar1.Value = int.Parse(indexString) * 10;
                    labelQuestion.Text = dr["question_description"].ToString();
                    correctOption = int.Parse(dr["correct_option"].ToString());
                    buttonChoice0.Text = dr["option_description0"].ToString();
                    buttonChoice1.Text = dr["option_description1"].ToString();
                    buttonChoice2.Text = dr["option_description2"].ToString();
                    buttonChoice3.Text = dr["option_description3"].ToString();
                }
            }
            sqlConn.testInforDataSqliteConn.Close();
        }
        private void click(object sender, EventArgs e)
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
            if (userData.currentSelectionStage == 10)
            {
                MessageBox.Show("您已完成所有题目!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                userData.currentSelectionStage++;
                userData.saveData();               
            }
            getInfor();
            for(int i = 0; i < 4;i++)
            {
                Button button = (Button)this.Controls.Find("buttonChoice" + i, true)[0];
                button.Enabled = true;               
            }

        }
    }
}
