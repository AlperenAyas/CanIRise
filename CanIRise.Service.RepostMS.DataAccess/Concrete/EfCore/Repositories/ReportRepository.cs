using CanIRise.Service.RepostMS.DataAccess.Concrete.EfCore.Context;
using CanIRise.Service.RepostMS.DataAccess.Entities;
using CanIRise.Service.RepostMS.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanIRise.Service.RepostMS.DataAccess.Concrete.EfCore.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly CanIRiseReportContext _context;

        public ReportRepository(CanIRiseReportContext context)
        {
            _context = context;
        }

        public void Create(Report entity)
        {
            _context.Reports.Add(entity);
            _context.SaveChanges();
        }

        public List<Report> GetAll()
        {
            return _context.Reports.ToList();
        }

        public void UpdateStatus(DateTime createTime)
        {
            var data =_context.Reports.FirstOrDefault(x => x.CreatingTime == createTime);
            data.State = "Tamamlandı";
            _context.SaveChanges();
        }
    }
}
