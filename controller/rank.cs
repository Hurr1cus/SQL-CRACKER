﻿using System;
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
            labelName.Text = "你好，" + userData.userName + "！";
            labelStage.Text = userData.stage.ToString();
            labelCoin .Text= userData.coin.ToString();
            string sql = "SELECT row_number() over(order by stage desc) 排名,user_name 用户名,stage 关卡数,coin 金钱 FROM user";
            DataSet myds = SQLiteHelper.ExecuteDataSet(sqlConn.userDataSqliteConn, sql, null);
            dataGridView1.DataSource = myds.Tables[0];
        }
    }
}