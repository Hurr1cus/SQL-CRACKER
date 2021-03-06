using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCRACKER
{
    public static class sqlConn
    {
        private static string testDataPath = @".\.db\Data.db;Read Only=True;";
        private static string userDataPath = @".\.db\userData.db";
        private static string testInforDataPath = @".\.db\testInfor.db";
        public static SQLiteConnection testDataSqliteConn = new SQLiteConnection("data source=" + testDataPath);
        public static SQLiteConnection userDataSqliteConn = new SQLiteConnection("data source=" + userDataPath);
        public static SQLiteConnection testInforDataSqliteConn = new SQLiteConnection("data source=" + testInforDataPath);
    }
}
