using DAO.DataLayerBase;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessObjectBase
{
    public class MalfunctionBusBase
    { 

        public static int Insert(MalfunctionModel mal)
        {
            return MalfunctionDataLayer.Insert(mal);
        }
        public static void UpDate(MalfunctionModel mal)
        {
            MalfunctionDataLayer.Update(mal);
        }

        public static List<MalfunctionModel> SelectALlDynamicWhere(int? id, int? deviceId, string note, string solution, int? severity, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            return MalfunctionDataLayer.SelectAllDynamicWhere(id, deviceId, note, solution, severity, createdDate, createdUserId, isDeleted, status);
        }
    }
}
