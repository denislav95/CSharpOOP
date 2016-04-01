namespace SOLIDLogger.Loggers
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Logger : ILogger
    {
        public IList<IAppender> Appender { get; set; }

        public Logger(params IAppender[] appenders)
        {
            Appender = new List<IAppender>(appenders);
        }

        public void Info(string msg)
        {
            Log(msg, ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            Log(msg, ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            Log(msg, ReportLevel.Error);
        }

        public void Critical(string msg)
        {
            Log(msg, ReportLevel.Critical);
        }

        public void Fatal(string msg)
        {
            Log(msg, ReportLevel.Fatal);
        }

        private void Log(string msg, ReportLevel reportLevel)
        {
            foreach (var appender in Appender)
            {
                var date = DateTime.Now;
                appender.Append(msg, reportLevel, date);
            }
        }
    }
}
