using CanIRise.Services.PersonMS.Business.Concrete;
using CanIRise.Services.PersonMS.Business.Interfaces;
using CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Context;
using CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Repositories;
using CanIRise.Services.PersonMS.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.DependencyResolver
{
    public static class MicrosoftIOC
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<CanIRiseContext>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IPersonRepository, PersonReporsitory>();
            services.AddScoped<IPersonService, PersonManager>();

            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IContactTypeRepository, ContactTypeRepository>();
            services.AddScoped<IContactTypeService, ContactTypeManager>();
        }
    }
}
