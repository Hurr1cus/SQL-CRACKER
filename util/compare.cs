using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLCRACKER
{
    static class compare
    {
        public static bool compareSql(string sql1, string sql2, bool isExact)
        {
            string sqlFormatted1 = sqlFormat.getSqlFormatted(sql1);
            string sqlFormatted2 = sqlFormat.getSqlFormatted(sql2);
            DataTable dt1 = SQLiteHelper.ExecuteDataSet(sqlConn.testDataSqliteConn, sqlFormatted1, null).Tables[0];
            DataTable dt2 = SQLiteHelper.ExecuteDataSet(sqlConn.testDataSqliteConn, sqlFormatted2, null).Tables[0];           
            return CompareDataTable(dt1, dt2,isExact);

        }
        public static bool CompareDataTable(DataTable dtA, DataTable dtB,bool isExact)
        {
            if (dtA.Rows.Count != dtB.Rows.Count) return false;
            if (dtA.Columns.Count != dtB.Columns.Count) return false;
            if (isExact && !CompareColumn(dtA.Columns, dtB.Columns)) return false;
                //比内容 
                for (int i = 0; i < dtA.Rows.Count; i++)
                {
                    for (int j = 0; j < dtA.Columns.Count; j++)
                    {
                        if (!dtA.Rows[i][j].Equals(dtB.Rows[i][j])) return false;

                    }
                }
            
            
            return true;
        }
        private static bool CompareColumn(System.Data.DataColumnCollection dcA, System.Data.DataColumnCollection dcB)
        {
            if (dcA.Count != dcB.Count) return false;
            foreach (DataColumn dc in dcA) 
            {
                if (dcB.IndexOf(dc.ColumnName) <= -1) return false;
                if (dc.DataType != dcB[dcB.IndexOf(dc.ColumnName)].DataType) return false;
            }
            return true;
        }        
    }
}
