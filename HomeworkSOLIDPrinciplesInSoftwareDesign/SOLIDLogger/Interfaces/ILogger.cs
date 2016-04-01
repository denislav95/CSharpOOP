namespace SOLIDLogger.Interfaces
{
    using System.Collections.Generic;

    public interface ILogger
    {
        IList<IAppender> Appender { get; }

        void Info(string msg);

        void Warn(string msg);

        void Error(string msg);

        void Critical(string msg);

        void Fatal(string msg);
    }
}
