using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;
using System.Collections;
using System.Data.SQLite;

namespace SQLCRACKER {
    public class SQLiteHelper {
        
        private SQLiteHelper() {
        }
        public static DataSet ExecuteDataSet(SQLiteConnection cn, string commandText) {

            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = commandText;            
            DataSet ds = new DataSet();
            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(ds);
            da.Dispose();
            cmd.Dispose();
            cn.Close();
            return ds;
        }
        public static int ExecuteNonQuery(IDbCommand cmd) {
            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            cmd.Dispose();
            return result;
        }                
        
    }
}