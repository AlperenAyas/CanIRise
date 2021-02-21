using CanIRise.Services.PersonMS.Business.Dtos.ContactDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Interfaces
{
    public interface IContactService : IGenericService<ContactListDto,ContactCreateDto,ContactUpdateDto>
    {
    }
}
