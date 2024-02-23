using KeyedServicesWebApplication.Interfaces;

namespace KeyedServicesWebApplication.Services
{
    public class EmailNotificationService : INotificationService
    {
        public string SendNotification(string message)
        {
            var result = $"Email notification message: {message}";
           
            return result;
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public string SendNotification( string message)
        {
            var result = $"SMS notification message: {message}";

            return result;
        }
    }
}
