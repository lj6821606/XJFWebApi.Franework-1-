using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogTools
{
    /// <summary>
    /// 日志帮助类
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// 初始化
        /// </summary>
        private static void InitLog4net()
        {
            var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
            XmlConfigurator.ConfigureAndWatch(logCfg);
        }

        //public static void WriteLog()
    }
}
