using DomainNotificationHelperCore.Notifications;
using System.Collections.Generic;

namespace DomainNotificationHelperCore.Commands
{
    public class Command
    {
        public List<DomainNotification> Notifications { get; set; }

        public Command()
        {
            Notifications = new List<DomainNotification>();
        }
    }
}