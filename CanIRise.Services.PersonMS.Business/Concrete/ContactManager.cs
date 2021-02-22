using CanIRise.Services.PersonMS.Business.Dtos.ContactDtos;
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
    public class ContactManager : IContactService
    {
        private readonly IContactRepository _generic;

        public ContactManager(IContactRepository generic)
        {
            _generic = generic;
        }

        public ContactCreateDto Create(ContactCreateDto dto)
        {
            _generic.Create(dto.Adapt<Contact>());
            return dto;
        }

        public List<ContactListDto> GetAll()
        {
            return (_generic.GetAll().Adapt<List<ContactListDto>>());
        }

        public ContactListDto GetById(Guid id)
        {
            return (_generic.GetByFilter(x => x.Id == id).Adapt<ContactListDto>());
        }

        public void Remove(Guid id)
        {
            _generic.Remove(id);
        }

        public void Update(ContactUpdateDto dto)
        {
            _generic.Update(dto.Adapt<Contact>());
        }
    }
}
