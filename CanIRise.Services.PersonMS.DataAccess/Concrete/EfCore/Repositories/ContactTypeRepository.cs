using CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Context;
using CanIRise.Services.PersonMS.DataAccess.Entities;
using CanIRise.Services.PersonMS.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Repositories
{
    public class ContactTypeRepository : GenericRepository<ContactType>,IContactTypeRepository
    {
        private readonly CanIRiseContext _context;

        public ContactTypeRepository(CanIRiseContext context):base(context)
        {
            _context = context;
        }
    }
}
