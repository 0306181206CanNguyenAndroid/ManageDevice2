﻿using DAO.DataLayer;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessOjectBase
{
    public class RoomBusBase
    {
        RoomDAO roomDAO = new RoomDAO();

        public static DataTable GetAllRoom()
        {
            return RoomDAO.getData();
        }
        public static DataTable SelectByPrimaryKey(int id)
        {
            return RoomDAO.SelectByPrimaryKey(id);
        }
        public static void InSertRoom(RoomModel room)
        {
            if (RoomDAO.CheckIdRoom(room.Code))
            {
                throw new Exception("Mã Phòng Đã Tồn Tại");
            }
            else if (RoomDAO.CheckNameRoom(room.Name))
            {
                throw new Exception("Tên Phòng Đã Tồn Tại");
            }
            else
            {
                RoomDAO.InsertRoom(room);
            }
        }
        
        
        public static void UpdateRoom(RoomModel room)
        {
            if (RoomDAO.IsDuplicateRoom(room, room.Id))
            {
                throw new Exception("Mã Phòng Hoặc Tên Phòng Đã Tồn Tại");
            }
            RoomDAO.UpdateRoom(room);
            
        }
        public static DataTable GetRoomAfterDelete()
        {
            return RoomDAO.GetRoomAfterDelete();
        }
        public static void DeleteRoom(int Id)
        {
            RoomDAO.DeleteRoom(Id);
        }

        public static DataTable SearchRoomByName(string Name)
        {
            return RoomDAO.SearchRoomByName(Name);
        }

        public static DataTable LayThongTinTheoPhong(int? RoomId) {
            return RoomDAO.LayThietBiTheoPhong(RoomId);
        }
        public static DataTable LayThietBiTheoTrangThai(int? Status, int? deviceTypeId)
        {
            return RoomDAO.LayThietBiTheoTrangThai(Status,deviceTypeId);
        }
        public static DataTable LayThietBiBinhThuong(int? Status, int? deviceTypeId)
        {
            return RoomDAO.LayThietBiBinhThuong(Status, deviceTypeId);
        }
    }
}
