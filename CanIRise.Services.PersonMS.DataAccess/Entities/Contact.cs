using CanIRise.Services.PersonMS.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Services.PersonMS.DataAccess.Entities
{
    public class Contact : BaseEntity, ITable
    {
        public string Content { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
        public Guid ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }
    }
}
