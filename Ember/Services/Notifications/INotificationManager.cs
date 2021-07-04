using System;

namespace Ember.Services.Notifications
{
    public interface INotificationManager
    {
        void Initialize();
        void SendNotification(string title, string message, DateTime? notifyTime = null);
    }
}
