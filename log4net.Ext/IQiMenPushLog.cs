using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net.Ext
{
    public interface IQiMenPushLog : ILog
    {
        void Info(long internalOrderID, string orderType, string customerId, string flag, string message);
        void Info(long internalOrderID, string orderType, string customerId, string flag, string message, Exception t);

        void Warn(long internalOrderID, string orderType, string customerId, string flag, string message);
        void Warn(long internalOrderID, string orderType, string customerId, string flag, string message, Exception t);

        void Error(long internalOrderID, string orderType, string customerId, string flag, string message);
        void Error(long internalOrderID, string orderType, string customerId, string flag, string message, Exception t);

        void Fatal(long internalOrderID, string orderType, string customerId, string flag, string message);
        void Fatal(long internalOrderID, string orderType, string customerId, string flag, string message, Exception t);
    }
}
