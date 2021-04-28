using CleanArchitecture.Application.Event;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Handler.Event
{
  public  class PushNotificationHandler : INotificationHandler<PushNotification>
    {
        private readonly ILogger _logger;
        public PushNotificationHandler(ILogger<PushNotificationHandler> logger)
        {
            _logger = logger;
        }
        public async Task Handle(PushNotification notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{notification.Message} at : {notification.DateTime}");
        }
    }
}
