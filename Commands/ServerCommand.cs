using DomainNotificationHelperCore.Notifications;
using System.Collections.Generic;

namespace DomainNotificationHelperCore.Commands
{
    public class ServerCommand
    {
        private List<DomainNotification> _notifications;
        private List<Command> _commands;

        public ServerCommand(Command command)
        {
            this._commands = new List<Command>();
            this._commands.Add(command);
            _notifications = command.Notifications;
        }

        public ServerCommand(List<Command> commands)
        {
            this._commands = new List<Command>();
            this._commands.AddRange(commands);
            foreach(var command in commands)
            {
                _notifications = command.Notifications;
            }
        }

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