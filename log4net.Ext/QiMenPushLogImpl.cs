using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net.Ext
{
    public class QiMenPushLogImpl : LogImpl, IQiMenPushLog
    {
        private readonly static Type ThisDeclaringType = typeof(QiMenPushLogImpl);

        public QiMenPushLogImpl(ILogger logger)
            : base(logger)
        {
        }

        public void Error(long internalOrderID, string orderType, string customerId, string flag, string message)
        {
            Error(internalOrderID, orderType, customerId, flag, message, null);
        }

        public void Error(long internalOrderID, string orderType, string customerId, string flag, string message, Exception t)
        {
            if (this.IsErrorEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Error, message, t);
                loggingEvent.Properties["InternalOrderID"] = internalOrderID;
                loggingEvent.Properties["OrderType"] = orderType;
                loggingEvent.Properties["CustomerId"] = customerId;
                loggingEvent.Properties["Flag"] = flag;
                loggingEvent.Properties["Message"] = message;
                Logger.Log(loggingEvent);
            }
        }

        public void Fatal(long internalOrderID, string orderType, string customerId, string flag, string message)
        {
            Fatal(internalOrderID, orderType, customerId, flag, message, null);
        }

        public void Fatal(long internalOrderID, string orderType, string customerId, string flag, string message, Exception t)
        {
            if (this.IsFatalEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Fatal, message, t);
                loggingEvent.Properties["InternalOrderID"] = internalOrderID;
                loggingEvent.Properties["OrderType"] = orderType;
                loggingEvent.Properties["CustomerId"] = customerId;
                loggingEvent.Properties["Flag"] = flag;
                loggingEvent.Properties["Message"] = message;
                Logger.Log(loggingEvent);
            }
        }

        public void Info(long internalOrderID, string orderType, string customerId, string flag, string message)
        {
            Info(internalOrderID, orderType, customerId, flag, message, null);
        }

        public void Info(long internalOrderID, string orderType, string customerId, string flag, string message, Exception t)
        {
            if (this.IsInfoEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Info, message, t);
                loggingEvent.Properties["InternalOrderID"] = internalOrderID;
                loggingEvent.Properties["OrderType"] = orderType;
                loggingEvent.Properties["CustomerId"] = customerId;
                loggingEvent.Properties["Flag"] = flag;
                loggingEvent.Properties["Message"] = message;
                Logger.Log(loggingEvent);
            }
        }

        public void Warn(long internalOrderID, string orderType, string customerId, string flag, string message)
        {
            Warn(internalOrderID, orderType, customerId, flag, message, null);
        }

        public void Warn(long internalOrderID, string orderType, string customerId, string flag, string message, Exception t)
        {
            if (this.IsWarnEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Warn, message, t);
                loggingEvent.Properties["InternalOrderID"] = internalOrderID;
                loggingEvent.Properties["OrderType"] = orderType;
                loggingEvent.Properties["CustomerId"] = customerId;
                loggingEvent.Properties["Flag"] = flag;
                loggingEvent.Properties["Message"] = message;
                Logger.Log(loggingEvent);
            }
        }
    }
}
