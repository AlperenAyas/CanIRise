using CanIRise.Service.RepostMS.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Service.RepostMS.DataAccess.Entities
{
    public class Report : ITable
    {
        public Guid Id { get; set; }
        public DateTime CreatingTime { get; set; }
        public string State { get; set; }
    }
}
