using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SQLCRACKER {
    public partial class userSelection : Form {            
        public userSelection() {           
            InitializeComponent();
        }        
        private void GameData_Load(object sender, EventArgs e) {           
            linkDataBase();
        }

        private void buttonAddClick(object sender, EventArgs e)
        {
            // 新建存档
            if (dataGridView1.RowCount != 0)
            {
                try
                {
                    string newUserName = Interaction.InputBox("请输入新用户的用户名。", "提示", "", -1, -1);
                    if (newUserName != "")
                    {
                        // 插入数据库
                        string inSql = "INSERT INTO user (user_name) VALUES ('" + newUserName + "');";
                        SQLiteCommand sqlcommand = new SQLiteCommand(inSql, sqlConn.userDataSqliteConn);
                        int s = SQLiteHelper.ExecuteNonQuery(sqlcommand);
                        if (s != 0)
                        {
                            MessageBox.Show("添加成功:D", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("添加失败:/", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        linkDataBase();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDeleteClick(object sender, EventArgs e) {
            // 删除存档
            if (dataGridView1.RowCount != 0) {
                DialogResult result = MessageBox.Show("您确定要删除本存档吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result != DialogResult.Yes) return;
                try {
                    string dtSql = "";
                    int indx = this.dataGridView1.CurrentRow.Index;
                    string data = this.dataGridView1.Rows[indx].Cells[0].Value.ToString();
                    dtSql = "DELETE FROM user WHERE user_name='" + data + "'";
                    SQLiteCommand sqlcommand = new SQLiteCommand(dtSql, sqlConn.userDataSqliteConn);
                    int s = SQLiteHelper.ExecuteNonQuery(sqlcommand);
                    if (s != 0) {
                        MessageBox.Show("删除成功:D", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("删除失败:/", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                    linkDataBase();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                if (dataGridView1.SelectedRows.Count > 0) {
                    DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                    drv.Delete();
                }
            }
        }

        private void buttonStartClick(object sender, EventArgs e) {
            // 读取存档
            string onStage = "";
            string onCoin = "";
            int indx = this.dataGridView1.CurrentRow.Index; // 当前选中的项目
            string data = this.dataGridView1.Rows[indx].Cells[0].Value.ToString(); // 当前选中的用户名
            userData.UserName = data;
            string dtsql = "select user_name,stage,coin,current_selection_stage from user where user_name= '" + data + "'";
            sqlConn.userDataSqliteConn.Open();
            SQLiteCommand sqlcommand = new SQLiteCommand(dtsql, sqlConn.userDataSqliteConn);
            IDataReader dr = sqlcommand.ExecuteReader();
            while (dr.Read()) {
                onStage = dr["stage"].ToString(); // 存放当前关卡
                onCoin = dr["coin"].ToString(); // 存放当前金币数量
                userData.CurrentSelectionStage = int.Parse(dr["current_selection_stage"].ToString());
                
            }
            userData.Stage = Convert.ToInt32(onStage);
            userData.Coin = Convert.ToInt32(onCoin);           
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            buttonStartClick(sender, e);
        }
        private void linkDataBase()
        {
            string sql = "SELECT user_name 用户名 FROM user";
            DataSet myds = SQLiteHelper.ExecuteDataSet(sqlConn.userDataSqliteConn, sql, null);
            dataGridView1.DataSource = myds.Tables[0];
        }
    }
}

