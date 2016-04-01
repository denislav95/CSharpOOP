namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout) 
            : base(layout)
        {
        }

        public string File { get; set; }

        public override void Append(string message, ReportLevel reportLevel, DateTime dateTime)
        {
            if (ReportLevel <= reportLevel)
            {
                var formattedMessage = Layout.Format(message, reportLevel, dateTime);

                System.IO.File.AppendAllText(File, formattedMessage + Environment.NewLine);
            }
        }
    }
}
