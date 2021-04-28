using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Event
{
   public class PushNotification: INotification
    {
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
    }
}
