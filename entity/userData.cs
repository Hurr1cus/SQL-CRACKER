using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCRACKER
{
    public static class userData
    {
        public static string UserName
        {
            get;set;
        }
        public static int Stage
        {
            get;set;
        }
        public static int Coin
        {
            get; set;
        }
        public static int CurrentSelectionStage
        {
            get; set;
        }
        public static void saveData()
        {
            string updateSql = "UPDATE `user` SET stage=" + userData.Stage + ",coin=" + userData.Coin + ",current_selection_stage="+CurrentSelectionStage+" WHERE user_name='" + userData.UserName + "';";
            SQLiteHelper.ExecuteDataSet(sqlConn.userDataSqliteConn, updateSql, null);
        }

    }
    
}

        