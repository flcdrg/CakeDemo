using System;
using System.Diagnostics;
using Cake.Core;

namespace CakeDemoAddin
{
    public static class UtilityExtension
    {
        public static void WriteArgumentsEvent(this ICakeContext context, string source, string message)
        {
            if (!EventLog.SourceExists(source))
                EventLog.CreateEventSource(source, "Application");

            EventLog.WriteEntry(source, message, EventLogEntryType.Information);
        }
    }
}
