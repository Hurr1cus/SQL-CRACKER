using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLCRACKER {
    public partial class rank : Form {
        public rank() {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e) {
            labelName.Text = "你好，" + userData.UserName + "！";
            labelStage.Text = userData.Stage.ToString();
            labelCoin .Text= userData.Coin.ToString();
            int stageChoiceNum = userData.CurrentSelectionStage > 11 ? 10 : userData.CurrentSelectionStage-1;
            labelChoice.Text=(stageChoiceNum).ToString();
            string sql = "SELECT row_number() over(order by stage desc) 排名,user_name 用户名,stage 关卡数,coin 金钱,current_selection_stage 所在训练关 FROM user";
            DataSet myds = SQLiteHelper.ExecuteDataSet(sqlConn.userDataSqliteConn, sql, null);
            dataGridView1.DataSource = myds.Tables[0];
        }
    }
}
