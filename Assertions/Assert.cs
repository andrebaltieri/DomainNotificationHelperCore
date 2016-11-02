using DomainNotificationHelperCore.Notifications;

namespace DomainNotificationHelperCore.Assertions
{
    public static class Assert
    {
        public static DomainNotification Lenght(string text, int min, int max, string key, string value)
        {
            if (text.Length < min || text.Length > max)
                return new DomainNotification(key, value);

            return null;
        }
    }
}