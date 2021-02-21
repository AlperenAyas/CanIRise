using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Service.ReportMS.Business.Dtos.ReportDtos
{
    public class ReportListDto
    {
        public Guid Id { get; set; }
        public DateTime CreatingTime { get; set; }
        public string State { get; set; }
    }
}
