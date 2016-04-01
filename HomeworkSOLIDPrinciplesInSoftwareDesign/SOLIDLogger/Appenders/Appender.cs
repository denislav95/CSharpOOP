namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            Layout = layout;
        }

        public ILayout Layout { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string message, ReportLevel reportLevel, DateTime dateTime);
    }
}
