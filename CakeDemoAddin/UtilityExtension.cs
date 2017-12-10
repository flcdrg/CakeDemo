using System;
using System.Diagnostics;
using Cake.Core;
using Cake.Core.Annotations;

namespace CakeDemoAddin
{
    public static class UtilityExtension
    {
        [CakeMethodAlias]
        public static void WriteArgumentsEvent(this ICakeContext context, string source, string message)
        {
            if (!EventLog.SourceExists(source))
                EventLog.CreateEventSource(source, "Application");

            EventLog.WriteEntry(source, message, EventLogEntryType.Information);
        }
    }
}
