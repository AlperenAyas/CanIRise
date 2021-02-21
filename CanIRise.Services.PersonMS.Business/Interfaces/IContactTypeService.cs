using CanIRise.Services.PersonMS.Business.Dtos.ContactTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Interfaces
{
    public interface IContactTypeService : IGenericService<ContactTypeListDto,ContactTypeCreateDto,ContactTypeUpdateDto>
    {
    }
}
