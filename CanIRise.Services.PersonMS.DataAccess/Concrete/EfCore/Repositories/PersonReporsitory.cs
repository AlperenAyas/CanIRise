using CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Context;
using CanIRise.Services.PersonMS.DataAccess.Entities;
using CanIRise.Services.PersonMS.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Repositories
{
    public class PersonReporsitory : GenericRepository<Person>, IPersonRepository
    {
        private readonly CanIRiseContext _context;

        public PersonReporsitory(CanIRiseContext context):base(context)
        {
            _context = context;
        }

        public async Task<int> PersonCountByLocation(string param)
        {
            var data = _context.Contacts.Include(x => x.Person).Include(x => x.ContactType).Where(x => x.ContactType.Name == "Location" && x.Content == param).Distinct().CountAsync();
            return await data;
        }

        public async Task<int> PhoneCountByLocation(string param)
        {
            var data = _context.Contacts.Include(x => x.Person).Include(x => x.ContactType).Where(x => x.ContactType.Name == "Location" && x.Content == param && x.ContactType.Name == "Phone").Distinct().CountAsync();
            return await data;
        }
    }
}
