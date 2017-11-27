using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotificationTestApp.Models
{
    public class Alert
    {
        public string TopicName { get; set; }
        public DateTime ScheduleTime { get; set; }
        public bool Repeat { get; set; }
        public string Subcribers { get; set; }
        public string URL { get; set; }

    }
}
