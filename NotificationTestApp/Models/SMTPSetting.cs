using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationTestApp.Models
{
    public class SMTPSetting
    {
        public string ProfileName { get; set; }
        public string HostName { get; set; }
        public int PortNo { get; set; }
        public string FromAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}