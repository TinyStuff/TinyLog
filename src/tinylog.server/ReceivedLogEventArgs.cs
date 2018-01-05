using System;

namespace tinylog.server
{
    internal class ReceivedLogEventArgs : EventArgs
    {
        internal string logText { get; set; }
    }
}