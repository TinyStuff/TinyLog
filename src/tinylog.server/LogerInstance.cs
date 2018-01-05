using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("tinylog.server.test")]
namespace tinylog.server
{
    public class LoggerInstance
    {
        private TemplateService _templateService;
        internal event ReceievedLogTextHandler ReceievedLogText;
        internal ReceivedLogEventArgs e;
        internal delegate void ReceievedLogTextHandler(LoggerInstance instance, ReceivedLogEventArgs e);
        
        public LoggerInstance(TemplateService templateService)
        {
            _templateService = templateService;

        }

        internal void LogText(string text)
        {
            if(ReceievedLogText != null)
            {
                e = new ReceivedLogEventArgs
                {
                    logText = text
                };
                ReceievedLogText(this, e);
            }
               
        }
    }
}
