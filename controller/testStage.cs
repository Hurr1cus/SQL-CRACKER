using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SQLCRACKER {
    public partial class testStage : Form {       
        public string correctSql = "";
        public stageSelection stageSelection = null;
        public testStage() {
            InitializeComponent();
        }

        private void Stage_Load(object sender, EventArgs e) {
            // 初始化
            dataGridView1.DataSource = null;
            listBox_table.Items.Clear();
            listBox_row.Items.Clear();
            panel1.Visible = false;
            linkDataBase();
        }

        public void linkDataBase() {          
            string sqlfieldName = "select name from sqlite_master where type='table' order by name";           
            SQLiteCommand cmd = new SQLiteCommand(sqlfieldName, sqlConn.testDataSqliteConn);
            sqlConn.testDataSqliteConn.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader()) {
                while (dr.Read()) {
                    // 字段名
                    listBox_table.Items.Add(dr["Name"]);
                }
            }
            sqlConn.testDataSqliteConn.Close();
        }
        private void button_find_Click(object sender, EventArgs e) {
            listBox_row.Items.Clear();
            string tableName = "";
            if (listBox_table.SelectedItem == null) return;
            tableName = listBox_table.SelectedItem.ToString();
            DataSet myds = queryBySql("SELECT * FROM " + tableName);
            dataGridView1.DataSource = myds.Tables[0];
            //显示指定表的字段名
            string tnSql = "Pragma Table_Info(" + tableName + ")";
            SQLiteCommand cmd = new SQLiteCommand(tnSql, sqlConn.testDataSqliteConn);
            sqlConn.testDataSqliteConn.Open();
            using (SQLiteDataReader dr = cmd.ExecuteReader()) {
                while (dr.Read()) {
                    // 字段名
                    listBox_row.Items.Add(dr["Name"]);
                }
            }
            dataGridView1.ClearSelection();
            dataGridView1.Rows[0].Selected = true; // 定位到指定的行
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
            dataGridView1.CurrentRow.Selected = true; // 使定位到的行处于选中状态
            sqlConn.testDataSqliteConn.Close();
        }
        //查询数据
        private DataSet queryBySql(String sql) {
            DataSet myds = new DataSet();
            try {
                myds = SQLiteHelper.ExecuteDataSet(sqlConn.testDataSqliteConn, sql, null);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return myds;
        }

        private void button_submit_Click(object sender, EventArgs e) {
            try {
                DataTable dtUser = queryBySql(text_sql.Text).Tables[0];
                dataGridView1.DataSource = dtUser;
                DataTable dtCorrect = queryBySql(correctSql).Tables[0];
                bool isCorrect = CompareDataTable(dtUser, dtCorrect);
                String correctString = "恭喜，您的SQL语句正确:D";
                String wrongString = "您的SQL语句错误，请仔细检查:(";
                MessageBox.Show(isCorrect ? correctString : wrongString);
                if (isCorrect) panel1.Visible = true;                
                if (isCorrect && stageSelection.currentStage >= userData.stage) {
                    label2.Text = "获得通关奖励：金钱 * 10";
                    userData.coin += 10;
                    userData.stage++;
                    Button button = (Button)(stageSelection.Controls.Find("buttonQuestion" + userData.stage, true)[0]);
                    button.Enabled = true;
                    button.Text = userData.stage.ToString();
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.StackTrace);
            }
        }

        public static bool CompareDataTable(DataTable dtA, DataTable dtB) {
            if (dtA.Rows.Count == dtB.Rows.Count) {
                if (CompareColumn(dtA.Columns, dtB.Columns)) {
                    //比内容 
                    for (int i = 0; i < dtA.Rows.Count; i++) {
                        for (int j = 0; j < dtA.Columns.Count; j++) {
                            if (!dtA.Rows[i][j].Equals(dtB.Rows[i][j])) {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }
        private static bool CompareColumn(System.Data.DataColumnCollection dcA, System.Data.DataColumnCollection dcB) {

            if (dcA.Count == dcB.Count) {
                foreach (DataColumn dc in dcA) {
                    //找相同字段名称 
                    if (dcB.IndexOf(dc.ColumnName) > -1) {
                        //测试数据类型 
                        if (dc.DataType != dcB[dcB.IndexOf(dc.ColumnName)].DataType) {
                            return false;
                        }
                    }
                    else {
                        return false;
                    }
                }
                return true;
            }
            else {
                return false;
            }
        }
        private void Stage_FormClosing(object sender, FormClosingEventArgs e) {
            stageSelection.stg = null;
            saveData();
        }
        public void saveData() {
            string updateSql = "UPDATE `user` SET stage=" + userData.stage + ",coin=" + userData.coin + " WHERE user_name='" + userData.userName + "';";
            SQLiteHelper.ExecuteDataSet(sqlConn.userDataSqliteConn, updateSql, null);
            stageSelection.refresh();
        }

        // 下面是快捷输入
        private void listBox_table_DoubleClick(object sender, EventArgs e) {
            if (text_sql.Text == "") {
                text_sql.Text += listBox_table.SelectedItem.ToString();
                return;
            }
            text_sql.Text += text_sql.Text.Substring(text_sql.Text.Length - 1) == " " ? listBox_table.SelectedItem.ToString() : " " + listBox_table.SelectedItem.ToString();
           
        }
        
        private void listBox_row_DoubleClick(object sender, EventArgs e) {
            if (text_sql.Text == "") {
                text_sql.Text += listBox_row.SelectedItem.ToString();
                return;
            }
            text_sql.Text += text_sql.Text.Substring(text_sql.Text.Length - 1) == " " ? listBox_row.SelectedItem.ToString() : " " + listBox_row.SelectedItem.ToString();
        }

        private void text_sql_TextChanged(object sender, EventArgs e) {
            if (text_sql.Text.Length > 1 && text_sql.Text.Substring(0, 1) == " ") text_sql.Text = text_sql.Text.Trim();
        }

        private void button45_Click(object sender, EventArgs e) {
            // 添加空格
            text_sql.Text += " ";
        }

        private void button44_Click(object sender, EventArgs e) {
            // 退格 1 字符
            text_sql.Text = text_sql.Text.Substring(0, text_sql.Text.Length - 1);
        }

        private void button_clear_Click(object sender, EventArgs e) {
            // 清空输入框
            text_sql.Text = "";
        }

        private void buttonClick(object sender, EventArgs e) {
            text_sql.Text += ((Button)sender).Text;
        }
        private void buttonClickWithBlank(object sender, EventArgs e) {
            if (text_sql.Text == "") {
                text_sql.Text += ((Button)sender).Text;
                return;
            }
            text_sql.Text += text_sql.Text.Substring(text_sql.Text.Length - 1) == " " ? ((Button)sender).Text : " " + ((Button)sender).Text;
           
            
        }


    }
}
