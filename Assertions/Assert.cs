using System;
using System.Text.RegularExpressions;
using DomainNotificationHelperCore.Notifications;

namespace DomainNotificationHelperCore.Assertions
{
    public static class Assert
    {
        public static DomainNotification Length(string text, int min, int max, string key, string val)
        {
            var length = text.Trim().Length;

            return (length < min || length > max)
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification Matches(string pattern, string text, string key, string val)
        {
            var regex = new Regex(pattern);

            return (!regex.IsMatch(text))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification NotEmpty(string text, string key, string val)
        {
            return (string.IsNullOrWhiteSpace(text))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification IsNotNull(object obj, string key, string val)
        {
            return (obj == null)
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification IsNull(object obj, string key, string val)
        {
            return (obj != null)
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification IsTrue(bool obj, string key, string val)
        {
            return (!obj)
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification AreEquals(string text, string match, string key, string val)
        {
            return (!(text == match))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification IsGreaterThan(int value1, int value2, string key, string val)
        {
            return (!(value1 > value2))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification IsGreaterThan(decimal value1, decimal value2, string key, string val)
        {
            return (!(value1 > value2))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification IsGreaterOrEqualThan(int value1, int value2, string key, string val)
        {
            return (!(value1 >= value2))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification IsGreaterOrEqualThan(decimal value1, decimal value2, string key, string val)
        {
            return (!(value1 >= value2))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification RegexMatch(string value, string regex, string key, string val)
        {
            return (!Regex.IsMatch(value, regex, RegexOptions.IgnoreCase))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification GuidIsNotEmpty(Guid value, string key, string val)
        {
            return (value == Guid.Empty)
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification EmailIsValid(string email, string key, string val)
        {
            var emailRegex =
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            return (!Regex.IsMatch(email, emailRegex, RegexOptions.IgnoreCase))
                ? new DomainNotification(key, val)
                : null;
        }

        public static DomainNotification UrlIsValid(string url, string key, string val)
        {
            if (String.IsNullOrEmpty(url))
                return null;

            var regex = @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";

            return (!Regex.IsMatch(url, regex, RegexOptions.IgnoreCase))
                ? new DomainNotification(key, val)
                : null;
        }
    }
}