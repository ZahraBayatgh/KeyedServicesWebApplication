using KeyedServicesWebApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyedServicesWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;

        public NotificationController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [HttpPost()]
        public IActionResult SendNotification(NotificationEnum type, string message)
        {
            var notificationService = _serviceProvider.GetRequiredKeyedService<INotificationService>(type.ToString());
            var result = notificationService.SendNotification(message);

            return Ok(result);
        }
    }
}
