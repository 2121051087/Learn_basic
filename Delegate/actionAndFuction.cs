using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic.Delegate
{
    internal class actionAndFuction
    {
        public delegate void ShowLog(string message);
        static public void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();

        }
        static public void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public static void TestShowLog()
        {
            ShowLog showLog;

            showLog = Info;
            showLog("Thông báo");

            showLog = Warning;
            showLog("Nguy hiem");
        }
    }
}
