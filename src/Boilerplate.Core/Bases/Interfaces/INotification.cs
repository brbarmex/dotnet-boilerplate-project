using System.Collections.Generic;
using Boilerplate.Core.Bases.Entities;

namespace Boilerplate.Core.Bases.Interfaces
{
    public interface INotification
    {
        bool HasNotifications();
        void AddNotification(List<Notification> notifications);
        void AddNotification(Notification notifications);
        void AddNotification(string key, string message);
        IReadOnlyCollection<Notification> GetNotifications();
    }
}