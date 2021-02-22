using CanIRise.Service.ReportMS.Business.Dtos.ReportDtos;
using CanIRise.Service.ReportMS.Business.Interfaces;
using CanIRise.Service.RepostMS.DataAccess.Entities;
using CanIRise.Service.RepostMS.DataAccess.Interfaces;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.ReportMS.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportRepository _repository;

        public ReportManager(IReportRepository repository)
        {
            _repository = repository;
        }

        public ReportCreateDto Create(ReportCreateDto dto)
        {
            dto.State = "Hazirlaniyor";
            _repository.Create(dto.Adapt<Report>());
            return dto;
        }

        public List<ReportListDto> GetAll()
        {
            return (_repository.GetAll().Adapt<List<ReportListDto>>());
        }

        public void UpdateStatus(DateTime createTime)
        {
            _repository.UpdateStatus(createTime);
        }
    }
}
