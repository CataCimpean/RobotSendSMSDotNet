using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMS.utils
{
    class LogMessage
    {
        public static void PrintEventError(string message)
        {
            string source = "RobotSendSMS";
            string log = "Application";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, message, EventLogEntryType.Error, 0);
        }

        public static void PrintEventMessage(string message)
        {
            string source = "RobotSendSMS";
            string log = "Application";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, message, EventLogEntryType.Information, 0);
        }
        public static void PrintEventWarning(string message)
        {
            string source = "RobotSendSMS";
            string log = "Application";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }

            EventLog.WriteEntry(source, message, EventLogEntryType.Warning, 0);
        }
    }

}
