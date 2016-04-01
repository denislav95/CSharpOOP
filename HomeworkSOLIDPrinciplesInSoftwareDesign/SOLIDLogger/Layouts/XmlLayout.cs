namespace SOLIDLogger.Layouts
{
    using System;
    using System.Text;
    using Interfaces;

    public class XmlLayout : ILayout
    {
        public string Format(string message, ReportLevel reportLevel, DateTime dateTime)
        {
            var output = new StringBuilder();
            output.AppendLine("<log>");
            output.AppendLine(string.Format("\t<date>{0}</date>", dateTime));
            output.AppendLine(string.Format("\t<leve>{0}</level>", reportLevel));
            output.AppendLine(string.Format("\t<message>{0}</message>", message));
            output.Append("</log>");

            return output.ToString();
        }
    }
}
