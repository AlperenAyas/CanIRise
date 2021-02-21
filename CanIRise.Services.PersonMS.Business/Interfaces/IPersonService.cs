using CanIRise.Services.PersonMS.Business.Dtos.PersonDtos;
using CanIRise.Services.PersonMS.Business.Dtos.ReportDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Interfaces
{
    public interface IPersonService : IGenericService<PersonListDto,PersonCreateDto,PersonUpdateDto>
    {
        Task<ReportDto> ReportByLocation(string param);
    }
}
