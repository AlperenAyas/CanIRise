using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.Business.Dtos.ReportDtos
{
    public class ReportDto
    {
        public string LocationContent { get; set; }
        public int PersonCount { get; set; }
        public int PhoneNumberCount { get; set; }
    }
}
