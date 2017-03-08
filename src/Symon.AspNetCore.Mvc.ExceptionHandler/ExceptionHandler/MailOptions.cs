using System.Collections.Generic;
using zxm.MailKit.Abstractions;

namespace Symon.AspNetCore.Mvc.ExceptionHandler.ExceptionHandler
{
    public class MailOptions
    {
        public string Subject { get; set; }

        public IEnumerable<MailAddress> To { get; set; }
    }
}
