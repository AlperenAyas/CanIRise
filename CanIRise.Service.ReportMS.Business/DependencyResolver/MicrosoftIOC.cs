using CanIRise.Service.ReportMS.Business.Interfaces;
using CanIRise.Service.RepostMS.DataAccess.Concrete.EfCore.Context;
using CanIRise.Service.RepostMS.DataAccess.Concrete.EfCore.Repositories;
using CanIRise.Service.RepostMS.DataAccess.Interfaces;
using CanIRise.Services.ReportMS.Business.Concrete;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.ReportMS.Business.DependencyResolver
{
    public static class MicrosoftIOC
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<CanIRiseReportContext>();

            services.AddScoped<IReportRepository, ReportRepository>();
            services.AddScoped<IReportService, ReportManager>();


            #region Rabbit

            //services.AddSingleton(serviceProvider =>
            //{
            //    var uri = new Uri("amqp://guest:guest@localhost:5672");
            //    return new ConnectionFactory
            //    {
            //        Uri = uri
            //    };
            //});

            #endregion
        }
    }
}
