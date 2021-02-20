using CanIRise.Services.PersonMS.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Services.PersonMS.DataAccess.Entities
{
    public class Person:BaseEntity, ITable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
