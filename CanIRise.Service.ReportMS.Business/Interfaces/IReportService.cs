using CanIRise.Service.ReportMS.Business.Dtos.ReportDtos;
using CanIRise.Service.RepostMS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Service.ReportMS.Business.Interfaces
{
    public interface IReportService
    {
        List<ReportListDto> GetAll();
        ReportCreateDto Create(ReportCreateDto dto);
        void UpdateStatus(DateTime createTime);
    }
}
