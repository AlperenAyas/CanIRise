using CanIRise.Services.PersonMS.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Dtos.ContactTypeDtos
{
    public class ContactTypeUpdateDto : IUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
