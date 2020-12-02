using System;
using System.IO;

namespace Task_05Part_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface ILogger 
    {
        public void LogMessage(string mMessage);
    }
    public class DbLogger : ILogger 
    {
        public void LogMessage(string mMessage)
        {
            //Code to write message in database.  
        }
    }

    public class FileLogger : ILogger
    {
        public void LogMessage(string mStackTrace)
        {
            //code to log stack trace into a file.  
        }
    }

    public class ExceptionLogger
    {
        public ExceptionLogger(ILogger logger)
        {
            _logger = logger;
        }
        private ILogger _logger;
        public void LogException(Exception mException)
        {
            _logger.LogMessage(GetUserReadableMessage(mException));
        }
        private string GetUserReadableMessage(Exception ex)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user   
            // readable format.  
            return strMessage;
        }
    }

    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                //code to export data from files to database.  
            }
            catch (IOException ex)
            {
                //new ExceptionLogger().LogException(ex);
            }
        }
    }
}
