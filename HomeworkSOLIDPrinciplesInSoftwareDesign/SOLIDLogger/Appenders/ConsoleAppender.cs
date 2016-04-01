namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(string message, ReportLevel reportLevel, DateTime dateTime)
        {
            if (ReportLevel <= reportLevel)
            {
                var formattedMessage = Layout.Format(message, reportLevel, dateTime);
                Console.WriteLine(formattedMessage);
            }
        }
    }
}
