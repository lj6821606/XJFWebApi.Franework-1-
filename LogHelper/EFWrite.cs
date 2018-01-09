using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace LogTools
{
    /// <summary>
    /// ef使用时保存sql语句
    /// </summary>
    public static class EFWrite
    {
        /// <summary>
        /// 写入sql语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        public static void WriteSQL(string sql)
        {
            ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            log.Info(sql);
        }
    }
}
