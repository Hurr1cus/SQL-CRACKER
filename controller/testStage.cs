using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLCRACKER {
    public partial class testStage : Form {       
        public string correctSql = "";
        public stageSelection stageSelection = null;
        public string tip = "";
        public bool isExact;
        public testStage() {
            InitializeComponent();
        }

        private void Stage_Load(object sender, EventArgs e) {         
            panel1.Visible = false;
            listBox_table.Items.Add("emp");
            listBox_table.Items.Add("dept");
        }
        private void buttonFindClick(object sender, EventArgs e) {
            listBox_row.Items.Clear();
            if (listBox_table.SelectedItem == null) return;
            string tableName = listBox_table.SelectedItem.ToString();
            DataSet myds = SQLiteHelper.ExecuteDataSet(sqlConn.testDataSqliteConn, "SELECT * FROM " + tableName); 
            dataGridView1.DataSource = myds.Tables[0];
            string tnSql = "Pragma Table_Info(" + tableName + ")";
            DataTable dt = SQLiteHelper.ExecuteDataSet(sqlConn.testDataSqliteConn, tnSql).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)           
                listBox_row.Items.Add(dt.Rows[i]["Name"]);        
        }       
        private void buttonSubmitClick(object sender, EventArgs e) {
            try {
                string sqlUser = text_sql.Text;
                dataGridView1.DataSource = SQLiteHelper.ExecuteDataSet(sqlConn.testDataSqliteConn, sqlUser).Tables[0];
                if (correctSql == "sandbox") return;
                bool isCorrect = compare.compareSql(sqlUser, correctSql,isExact);
                if (!isCorrect) { 
                    MessageBox.Show("您的SQL语句错误，请仔细检查:(", "语句错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }           
                panel1.Visible = true;
                if (stageSelection.currentStage >= userData.Stage) {
                    label2.Text = "获得通关奖励：金钱 * 10";
                    userData.Coin += 10;
                    userData.Stage++;
                    Button button = (Button)(stageSelection.Controls.Find("buttonQuestion" + userData.Stage, true)[0]);
                    button.Enabled = true;
                    button.Text = userData.Stage.ToString();
                }
            }
            catch(SQLiteException ex)
            {
                if (ex.ErrorCode == ((int)SQLiteErrorCode.ReadOnly))
                {
                    MessageBox.Show("请不要对该数据库做增删改操作！","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }       
        private void Stage_FormClosing(object sender, FormClosingEventArgs e) {
            stageSelection.stg = null;
            userData.saveData();
            stageSelection.refresh();
        }
        private void listBoxTableDoubleClick(object sender, EventArgs e) {
            if(listBox_table.SelectedItem==null) return;
            if (text_sql.Text == "") {
                text_sql.Text += listBox_table.SelectedItem.ToString();
                return;
            }
            text_sql.Text += text_sql.Text.Substring(text_sql.Text.Length - 1) == " " ? listBox_table.SelectedItem.ToString() : " " + listBox_table.SelectedItem.ToString();
           
        }
        private void listBoxRowDoubleClick(object sender, EventArgs e) {
            if (listBox_row.SelectedItem == null) return;
            if (text_sql.Text == "") {
                text_sql.Text += listBox_row.SelectedItem.ToString();
                return;
            }
            text_sql.Text += text_sql.Text.Substring(text_sql.Text.Length - 1) == " " ? listBox_row.SelectedItem.ToString() : " " + listBox_row.SelectedItem.ToString();
        }      
        private void buttonBlankClick(object sender, EventArgs e)
        {
            text_sql.Text += " ";
        }

        private void buttonBankSpaceClick(object sender, EventArgs e)
        {
            text_sql.Text = text_sql.Text.Substring(0, text_sql.Text.Length - 1);
        }
        private void buttonClearClick(object sender, EventArgs e) {
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

        private void buttonTipClick(object sender, EventArgs e)
        {
            if (stageSelection.currentStage < userData.Stage)
            {
                text_sql.Text = correctSql;
                return;
            }
            DialogResult result = MessageBox.Show("查看提示需要消耗20金币并清空已输入内容，确认要查看吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            if (userData.Coin < 20)
            {
                MessageBox.Show("金币不够辣！", "金币不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            userData.Coin -= 20;           
            text_sql.Text = tip;
        }
    }
}
