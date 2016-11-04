using DomainNotificationHelperCore.Notifications;
using System.Collections.Generic;
using System.Linq;

namespace DomainNotificationHelperCore.Commands
{
    public class Command
    {
        public List<DomainNotification> Notifications { get; set; }

        public Command()
        {
            Notifications = new List<DomainNotification>();
        }

        public bool HasNotifications()
        {
            return Notifications.Any();
        }

        public void AddNotification(DomainNotification notification)
        {
            if (notification == null)
                return;

            Notifications.Add(notification);
        }

        public void AddNotifications(List<DomainNotification> notifications)
        {
            if (notifications == null)
                return;

            Notifications.AddRange(notifications);
        }
    }
}