using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLCRACKER
{
    static class sqlFormat
    {
        public static String getSqlFormatted(String sql)
        {
            return replaceNvl(sql);
        }
        static string replaceNvl(String sql)
        {
            return Regex.Replace(sql,"nvl", "ifnull",RegexOptions.IgnoreCase);
        }

    }
}
