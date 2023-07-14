using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataLayerBase
{
    public class RoomManagerDAOBase
    {
        public static int InsertRoomManager(RoomManagerModel roomManager)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("RoomManager_Inser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@RoomId", roomManager.RoomId);
            cmd.Parameters.AddWithValue("@TeacherId", roomManager.TeacherId);
            cmd.Parameters.AddWithValue("@CreatedDate", roomManager.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedUserId", roomManager.CreatedUserId);
           
            cmd.Parameters.AddWithValue("@IsDeleted", roomManager.IsDeleted);
            
            conn.Open();
            int roomManagerId = (int)cmd.ExecuteScalar();
            conn.Close();
            return roomManagerId;
        }
    }
}
