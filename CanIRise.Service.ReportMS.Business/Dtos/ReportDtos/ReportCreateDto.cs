using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Service.ReportMS.Business.Dtos.ReportDtos
{
    public class ReportCreateDto
    {
        public string State { get; set; }
        public DateTime CreatingTime { get; set; } = DateTime.Now;
    }
}
