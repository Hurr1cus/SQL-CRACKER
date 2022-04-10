using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCRACKER
{
    public static class userData
    {
        public static string userName;
        public static int stage;
        public static int coin;
        public static int currentSelectionStage;
        public static void saveData()
        {
            string updateSql = "UPDATE `user` SET stage=" + userData.stage + ",coin=" + userData.coin + ",current_selection_stage="+currentSelectionStage+" WHERE user_name='" + userData.userName + "';";
            SQLiteHelper.ExecuteDataSet(sqlConn.userDataSqliteConn, updateSql, null);
        }

    }
    
}

        