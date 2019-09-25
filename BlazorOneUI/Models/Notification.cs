using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorOneUI.Models
{
    public class Notification
    {
        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public NotificationTypeEnum NotificationType { get; set; }
    }

    public enum NotificationTypeEnum
    {
        Success = 1,
        Info,
        Warning,
        Danger
    }
}
