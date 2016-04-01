namespace SOLIDLogger.Interfaces
{
    using System;

    public interface ILayout
    {
        string Format(string message, ReportLevel reportLevel, DateTime dateTime);
    }
}
