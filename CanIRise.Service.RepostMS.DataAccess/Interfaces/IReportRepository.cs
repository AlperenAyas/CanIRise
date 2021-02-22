using CanIRise.Service.RepostMS.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Service.RepostMS.DataAccess.Interfaces
{
    public interface IReportRepository
    {
        void Create(Report entity);
        void UpdateStatus(DateTime createTime);
        List<Report> GetAll();
    }
}
