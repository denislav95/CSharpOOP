namespace SOLIDLogger.Interfaces
{
    using System;

    public interface IAppender
    {
        ILayout Layout { get; set; }

        ReportLevel ReportLevel { get; set; }

        void Append(string message, ReportLevel reportLeve, DateTime dateTime);
    }
}
