using CanIRise.Services.PersonMS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.DataAccess.Interfaces
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        Task<int> PersonCountByLocation(string param);
        Task<int> PhoneCountByLocation(string param);
    }
}
