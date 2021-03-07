using System.Collections.Generic;

namespace PetCare.Shared.Notifications
{
    public abstract class Notifiable
    {
        private readonly List<Notification> _notifications;
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected Notifiable() => _notifications = new List<Notification>();

        public void AddNotification(string key, string message)
        {
            _notifications.Add(new Notification(key, message));
        }
        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }
        public void AddNotifications(Notifiable item)
        {
            AddNotifications(item.Notifications);
        }

        public bool IsValid() => _notifications.Count == 0;
    }
}