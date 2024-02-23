namespace KeyedServicesWebApplication.Interfaces
{
    public interface INotificationService
    {
       string SendNotification(string message);
    }
    public enum NotificationEnum
    {
        Sms,
        Email
    }
}
