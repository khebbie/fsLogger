using System;
using fsLogger;

namespace logTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger1 = LoggerManager.GetLogger("test");
            logger1.Log(LogMessage.NewDebug("test"));
            logger1.Log(LogMessage.NewError("big error", new Exception("tet")));
        }
    }
}
