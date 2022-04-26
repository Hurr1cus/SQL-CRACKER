using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SQLCRACKER
{
    public partial class userSelection : Form
    {
        public userSelection()
        {
            InitializeComponent();
        }
        private void GameData_Load(object sender, EventArgs e)
        {
            linkDataBase();
        }

        private void buttonAddClick(object sender, EventArgs e)
        {
            try
            {
                string newUserName = Interaction.InputBox("请输入新用户的用户名。", "提示", "", -1, -1);
                if (newUserName != "")
                {
                    string inSql = "INSERT INTO user (user_name) VALUES ('" + newUserName + "');";
                    int s = SQLiteHelper.ExecuteNonQuery(sqlConn.userDataSqliteConn, inSql);
                    if (s != 0)
                    {
                        MessageBox.Show("添加成功:D", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    linkDataBase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败:/", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteClick(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            DialogResult result = MessageBox.Show("您确定要删除本存档吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result != DialogResult.Yes) return;
            try
            {
                string dtSql = "";
                int indx = this.dataGridView1.CurrentRow.Index;
                string data = this.dataGridView1.Rows[indx].Cells[0].Value.ToString();
                dtSql = "DELETE FROM user WHERE user_name='" + data + "'";
                int s = SQLiteHelper.ExecuteNonQuery(sqlConn.userDataSqliteConn, dtSql);
                if (s != 0)
                {
                    MessageBox.Show("删除成功:D", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("删除失败:/", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                linkDataBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStartClick(object sender, EventArgs e)
        {
            string data = dataGridView1.CurrentCell.Value.ToString();
            userData.UserName = data;
            string dtsql = "select user_name,stage,coin,current_selection_stage from user where user_name= '" + data + "'";
            DataRow dr = SQLiteHelper.ExecuteDataSet(sqlConn.userDataSqliteConn, dtsql).Tables[0].Rows[0];
            userData.Stage = int.Parse(dr["stage"].ToString()); 
            userData.Coin = int.Parse(dr["coin"].ToString());
            userData.CurrentSelectionStage = int.Parse(dr["current_selection_stage"].ToString());
            Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonStartClick(sender, e);
        }
        private void linkDataBase()
        {
            string sql = "SELECT user_name 用户名 FROM user";
            DataSet myds = SQLiteHelper.ExecuteDataSet(sqlConn.userDataSqliteConn, sql);
            dataGridView1.DataSource = myds.Tables[0];
        }
    }
}

