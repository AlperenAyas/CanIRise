using CanIRise.Services.PersonMS.Business.Dtos.ContactTypeDtos;
using CanIRise.Services.PersonMS.Business.Interfaces;
using CanIRise.Services.PersonMS.DataAccess.Entities;
using CanIRise.Services.PersonMS.DataAccess.Interfaces;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Concrete
{
    public class ContactTypeManager : IContactTypeService
    {
        private readonly IGenericRepository<ContactType> _generic;

        public ContactTypeManager(IGenericRepository<ContactType> generic)
        {
            _generic = generic;
        }

        public ContactTypeCreateDto Create(ContactTypeCreateDto dto)
        {
            _generic.Create(dto.Adapt<ContactType>());
            return dto;
        }

        public List<ContactTypeListDto> GetAll()
        {
            return (_generic.GetAll().Adapt<List<ContactTypeListDto>>());
        }

        public ContactTypeListDto GetById(Guid id)
        {
            return (_generic.GetByFilter(x => x.Id == id).Adapt<ContactTypeListDto>());
        }

        public void Remove(Guid id)
        {
            _generic.Remove(id);
        }

        public void Update(ContactTypeUpdateDto dto)
        {
            _generic.Update(dto.Adapt<ContactType>());
        }
    }
}
