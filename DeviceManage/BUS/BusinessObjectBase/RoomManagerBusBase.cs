using DAO.DataLayer;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessObjectBase
{
    public class RoomManagerBusBase
    {
        public static int Insert_RoomManager(RoomManagerModel roomManager)
        {
            return RoomManagerDAO.InsertRoomManager(roomManager);
        }
    }
}
