using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrewEverywhere.Interfaces.Logging;
using log4net;

namespace BrewEverywhere.Services.Logging
{
    public class Log4NetLoggerService : ILoggerService
    {
        private readonly ILog _logger;

        public Log4NetLoggerService()
        {
            _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        public void Info(string message)
        {
            if(_logger.IsInfoEnabled)
                _logger.Info(message);
        }

        public void Warn(string message)
        {
            if (_logger.IsWarnEnabled)
                _logger.Warn(message);
        }

        public void Debug(string message)
        {
            if (_logger.IsDebugEnabled)
                _logger.Debug(message);
        }

        public void Error(string message)
        {
            if (_logger.IsErrorEnabled)
                _logger.Error(message);
        }

        public void Error(Exception ex)
        {
            if (_logger.IsErrorEnabled)
                _logger.Error(ex.Message, ex);
        }

        public void Fatal(string message)
        {
            if (_logger.IsFatalEnabled)
                _logger.Fatal(message);
        }

        public void Fatal(Exception ex)
        {
            if (_logger.IsFatalEnabled)
                _logger.Fatal(ex.Message, ex);
        }
    }
}
