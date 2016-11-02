using DomainNotificationHelperCore.Notifications;
using System.Collections.Generic;

namespace DomainNotificationHelperCore
{
    public class Runtime
    {
        public List<DomainNotification> Notifications { get; set; }

        public Runtime()
        {
            Notifications = new List<DomainNotification>();
        }

        public bool HasNotifications()
        {
            return Notifications.Count > 0;
        }

        public List<DomainNotification> GetNotifications()
        {
            return Notifications;
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