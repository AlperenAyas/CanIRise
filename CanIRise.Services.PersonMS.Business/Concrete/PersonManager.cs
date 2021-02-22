using CanIRise.Services.PersonMS.Business.Dtos.PersonDtos;
using CanIRise.Services.PersonMS.Business.Dtos.ReportDtos;
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
    public class PersonManager : IPersonService
    {
        private readonly IPersonRepository _generic;

        public PersonManager(IPersonRepository generic)
        {
            _generic = generic;
        }

        public PersonCreateDto Create(PersonCreateDto dto)
        {
            _generic.Create(dto.Adapt<Person>());
            return dto;
        }

        public List<PersonListDto> GetAll()
        {
            return (_generic.GetAll().Adapt<List<PersonListDto>>());
        }

        public PersonListDto GetById(Guid id)
        {
            return (_generic.GetByFilter(I => I.Id == id).Adapt<PersonListDto>());
        }

        public void Remove(Guid id)
        {
            _generic.Remove(id);
        }

        public async Task<ReportDto> ReportByLocation(string param)
        {
            ReportDto dto = new ReportDto();
            dto.LocationContent = param;
            dto.PersonCount = await _generic.PersonCountByLocation(param);
            dto.PhoneNumberCount = await _generic.PhoneCountByLocation(param);
            return dto;
        }

        public void Update(PersonUpdateDto dto)
        {
            _generic.Update(dto.Adapt<Person>());
        }
    }
}
