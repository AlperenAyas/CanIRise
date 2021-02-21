using CanIRise.Services.PersonMS.Business.Dtos.ContactTypeDtos;
using CanIRise.Services.PersonMS.Business.Dtos.PersonDtos;
using CanIRise.Services.PersonMS.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Dtos.ContactDtos
{
    public class ContactListDto : IListDto
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public Guid PersonId { get; set; }
        public PersonListDto Person { get; set; }
        public Guid ContactTypeId { get; set; }
        public ContactTypeListDto ContactType { get; set; }
    }
}
