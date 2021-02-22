using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanIRise.Services.ReportMS.WebApi.RabbitMQ
{
    public interface IRabbit
    {
        Task RabbitInit();
    }
}
