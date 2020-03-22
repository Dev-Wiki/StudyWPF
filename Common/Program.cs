using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Log;
using log4net;
using log4net.Config;

namespace Common
{
    public class Program
    {
        private static XLog log = XLog.getLog(nameof(Program));

        static void Main(string[] args) {
            log.Error("Main", new Exception("发生了一个异常"));//错误
            log.Fatal("Main", new Exception("发生了一个致命错误"));//严重错误
            log.Info("Main", "信息"); //记录一般信息
            log.Debug("Main", "调试信息");//记录调试信息
            log.Warn("Main", "警告");//记录警告信息
            Console.ReadKey();
        }
    }
}
