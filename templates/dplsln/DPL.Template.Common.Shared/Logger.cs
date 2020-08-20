using System;

namespace DPL.Template.Common.Shared
{
    public class Logger
    {
        public void Error(Exception ex)
        {
            _ = ex;
        }
        public void Error(string message)
        {
            _ = message;
        }

        public void Error(string message, Exception ex)
        {
            _ = message;
            _ = ex;
        }

        public void Info(string message)
        {
            _ = message;
        }
        public void Debug(string message)
        {
            _ = message;
        }
    }
}
