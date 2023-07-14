using DAO.DataLayerBase;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessObjectBase
{
    public class ReportBusBase
    {
        public static int Insert(ReportModel report)
        {
            return ReportDataLayer.InsertReport(report);
        }
    }
}
