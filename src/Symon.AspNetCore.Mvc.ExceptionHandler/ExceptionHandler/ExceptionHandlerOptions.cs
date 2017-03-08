using System;

namespace Symon.AspNetCore.Mvc.ExceptionHandler.ExceptionHandler
{
    /// <summary>
    /// ExceptionHandlerOptions
    /// </summary>
    public class ExceptionHandlerOptions
    {
        public MailOptions MailOptions { get; set; }

        public Action<System.Exception> ManualProcess { get; set; }

        public bool OutputErrorResult { get; set; } = true;
    }
}
