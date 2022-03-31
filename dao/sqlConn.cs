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
        private static string testDataPath = @".\DataBase\Data.db";
        private static string userDataPath = @".\DataBase\userData.db";
        public static SQLiteConnection testDataSqliteConn = new SQLiteConnection("data source=" + testDataPath);
        public static SQLiteConnection userDataSqliteConn = new SQLiteConnection("data source=" + userDataPath);
    }
}
