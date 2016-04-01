namespace SOLIDLogger.Layouts
{
    using System;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        private const string LayoutFormat = "{0} - {1} - {2}";

        public string Format(string message, ReportLevel reportLevel, DateTime dateTime)
        {
            return string.Format(LayoutFormat, dateTime, reportLevel, message);
        }
    }
}
