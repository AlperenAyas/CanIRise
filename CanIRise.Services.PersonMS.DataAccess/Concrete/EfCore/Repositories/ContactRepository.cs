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
    public class ContactRepository : GenericRepository<Contact>,IContactRepository
    {
        private readonly CanIRiseContext _context;

        public ContactRepository(CanIRiseContext context):base(context)
        {
            _context = context;
        }
    }
}
