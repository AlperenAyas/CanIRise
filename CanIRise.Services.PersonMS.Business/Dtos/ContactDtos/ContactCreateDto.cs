using CanIRise.Services.PersonMS.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Dtos.ContactDtos
{
    public class ContactCreateDto : ICreateDto
    {
        public string Content { get; set; }
        public Guid PersonId { get; set; }
        public Guid ContactTypeId { get; set; }
    }
}
