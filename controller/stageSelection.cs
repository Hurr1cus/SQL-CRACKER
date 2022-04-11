using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;

namespace SQLCRACKER {
    public partial class stageSelection : Form {
        public static testStage stg = null; // 定义主界面全局变量
        public static int currentStage; // 传递关卡数        
        public static mainForm MainForm;
        public static DataTable testDataTable; 
        

        public stageSelection() {
            InitializeComponent();            
            for (int i=userData.Stage+1;i<=50;i++) {
                Button button = (Button)this.Controls.Find("buttonQuestion" + i, true)[0];
                button.Enabled = false;
                button.Text = "--";               
            }            
            string sql = "select stage_description,question_description,grammer_tip,correct_sql,tip,is_exact from stageTest";
            testDataTable = SQLiteHelper.ExecuteDataSet(sqlConn.testInforDataSqliteConn, sql).Tables[0];
            
        }
        
               
        private void StageSelection_Load(object sender, EventArgs e) {
            label_username.Text = userData.UserName + "，欢迎回来!";
            refresh();
        }

        public void refresh() {
            label_belong.Text = "您目前的进度：" + userData.Stage + "/50，所持金币数：" + userData.Coin;
        }
        private void StageSelection_FormClosing(object sender, FormClosingEventArgs e) {
            stg = null;
        }


        private void createStage(int index)
        {            
            stg = new testStage();
            stg.stageSelection = this;
            if (index < 51)
            {
                stg.toolStripProgressBar1.Text = "当前关卡 " + ((index - 1) / 5 + 1) + " - " + ((index - 1) % 5 + 1);
                stg.toolStripProgressBar2.Value = index * 2;
                stg.toolStripStatusLabel1.Text = index + "/50";
            }
            DataRow dataRow = testDataTable.Rows[--index];
            stg.label_stage.Text = dataRow[0].ToString();
            stg.label_question.Text = dataRow[1].ToString();
            stg.label_hint.Text = dataRow[2].ToString();
            stg.correctSql = dataRow[3].ToString();
            stg.tip = dataRow[4].ToString();
            stg.isExact = dataRow[5].ToString() == "True";            
            this.Hide();           
            DialogResult result = stg.ShowDialog();
            this.Show();

        }
               
        private void selectStage(object sender, EventArgs e) {
            currentStage = int.Parse(((Button)sender).Text);            
            createStage(currentStage);
        }

        private void createEmpty(object sender,EventArgs e)
        {
            createStage(51);
        }

       
    }
}
