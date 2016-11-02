using DomainNotificationHelperCore.Notifications;
using System.Collections.Generic;

namespace DomainNotificationHelperCore.Commands
{
    public class ServerCommand
    {
        private List<DomainNotification> _notifications;
        public ServerCommand(Command command)
        {
            this._command = command;
            _notifications = command.Notifications;
        }

        private Command _command;

        public bool HasNotifications()
        {
            return _notifications.Count > 0;
        }

        public List<DomainNotification> GetNotifications()
        {
            return _notifications;
        }

        public void AddNotification(DomainNotification notification)
        {
            if (notification == null)
                return;

            _notifications.Add(notification);
        }

        public void AddNotifications(List<DomainNotification> notifications)
        {
            if (notifications == null)
                return;

            _notifications.AddRange(notifications);
        }
    }
}