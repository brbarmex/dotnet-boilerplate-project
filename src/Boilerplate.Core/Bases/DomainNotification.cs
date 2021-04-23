using System.Collections.Generic;
using Boilerplate.Core.Bases.Entities;
using Boilerplate.Core.Bases.Interfaces;

namespace Boilerplate.Core.Bases
{
    public sealed class DomainNotification : INotification
    {
        private readonly List<Notification> _notifications;
        public DomainNotification() => _notifications = new List<Notification>(0);
        public void AddNotification(List<Notification> notifications) => _notifications.AddRange(notifications);
        public void AddNotification(Notification notifications) => _notifications.Add(notifications);
        public void AddNotification(string key, string message) => _notifications.Add(new Notification(key, message));
        public bool HasNotifications() => _notifications.Count > 0;
        public IReadOnlyCollection<Notification> GetNotifications() => _notifications;
    }
}