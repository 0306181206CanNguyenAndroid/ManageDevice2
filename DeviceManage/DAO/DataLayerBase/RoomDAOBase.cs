using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO.ModelBase;
using System.Data.SqlClient;
using DAO;
using DAO.DataLayer;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DAO.DataLayerBase
{
    public class RoomDAOBase
    {
        public static DataTable getData()
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("GetAllRoom",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da= new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt=new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable SelectByPrimaryKey(int id)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("[dbo].[Room_SelectByPrimaryKey]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static RoomModel SelectRoomByDevice(int id)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("[dbo].[SelectRoomByDevice]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt != null && dt.Rows.Count > 0 ? CreateRoomFromDataRowShared(dt.Rows[0]) : null;
        }
        public static RoomModel SelectByTeacherId(int id)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("[dbo].[Room_SelectByTeacherId]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt != null && dt.Rows.Count > 0 ? CreateRoomFromDataRowShared(dt.Rows[0]) : null;
        }

        public static void InsertRoom(RoomModel room)
        {
                SqlConnection conn = new SqlConnection(PathString.ConnectionString);
                SqlCommand cmd = new SqlCommand("InsertRoom", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Code", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@DeviceQuantity", SqlDbType.Int);
                cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
                cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
                cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
                cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
                cmd.Parameters["@Code"].Value = room.Code;
                cmd.Parameters["@Name"].Value = room.Name;
                cmd.Parameters["@Description"].Value = room.Description;
                cmd.Parameters["@DeviceQuantity"].Value = room.DeviceQuantity;
                cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
                cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
                cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
                cmd.Parameters["@Status"].Value = room.Status;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        //Kiểm tra trùng mã phòng 
        public static bool CheckIdRoom(string Code)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "select COUNT(*) from D_Room where Code =@Code and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Code", Code);
                conn.Open();
                int count =(int)cmd.ExecuteScalar();
                conn.Close();
                //kiểm tra
                if(count > 0)
                {
                    return true;
                }else 
                { 
                    return false; 
                }
            }
        }
        //kiểm tra trùng tên phòng
        public static bool CheckNameRoom(string Name)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "select COUNT(*) from D_Room where Name =@Name and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", Name);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                //kiểm tra
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
       
        public static void UpdateRoom(RoomModel room)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("UpdateRoom", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", room.Id);
            cmd.Parameters.Add("@Code", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@DeviceQuantity", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            cmd.Parameters["@Code"].Value = room.Code;
            cmd.Parameters["@Name"].Value = room.Name;
            cmd.Parameters["@Description"].Value = room.Description;
            cmd.Parameters["@DeviceQuantity"].Value = room.DeviceQuantity;
            cmd.Parameters["@CreatedDate"].Value = room.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = room.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = room.IsDeleted;
            cmd.Parameters["@Status"].Value = room.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }
        //check code va name k trùng với bảng
        public static bool IsDuplicateRoom(RoomModel room,int Id)
        {
            using(SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "Select COUNT(*) from D_Room Where ((Code=@Code or Name=@Name)and Id <>@Id and IsDeleted=0)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Code",room.Code);
                cmd.Parameters.AddWithValue("@Name", room.Name);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if(count > 0)
                {
                    return true;
                }else { return false; }
            }
        }

        public static DataTable GetRoomAfterDelete()
        {
            DataTable room = new DataTable();
            using(SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd =new SqlCommand("GetRoomAfterDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
                
            }
            
        }
        public static void DeleteRoom(int Id)
        {
            using(SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();
                
                SqlCommand cmd= new SqlCommand("update D_Room set IsDeleted=1 where Id=@Id", conn);
               // cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Creates a Room object from the passed data row
        /// </summary>
        protected static RoomModel CreateRoomFromDataRowShared(DataRow dr)
        {
            RoomModel objRoom = new RoomModel();

            objRoom.Id = (int)dr["Id"];

            if (dr["Name"] != System.DBNull.Value)
                objRoom.Name = dr["Name"].ToString();
            else
                objRoom.Name = null;

            if (dr["Code"] != System.DBNull.Value)
                objRoom.Code = dr["Code"].ToString();
            else
                objRoom.Code = null;

            if (dr["DeviceQuantity"] != System.DBNull.Value)
                objRoom.DeviceQuantity = (int)dr["DeviceQuantity"];
            else
                objRoom.DeviceQuantity = 0;

            if (dr["Description"] != System.DBNull.Value)
                objRoom.Description = dr["Description"].ToString();
            else
                objRoom.Description = null;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objRoom.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objRoom.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objRoom.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objRoom.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objRoom.IsDeleted = (bool)dr["IsDeleted"];
            else
                objRoom.IsDeleted = false;

            return objRoom;
        }
        public static DataTable SearchRoomByName(string Name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchRoomByName", connection);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue ("@Name", Name);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
               
                da.Fill (dt);
            }
            return dt;
        }

        //LayThietBiTheoPhong

        public static DataTable LayThietBiTheoPhong(int? RoomId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("LayThietBiTheoPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                if(RoomId != null)
                {
                    cmd.Parameters.AddWithValue("@RoomId", RoomId);
                }else
                    cmd.Parameters.AddWithValue("@RoomId", DBNull.Value);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
        public static DataTable LayThietBiTheoTrangThai(int? Status, int? deviceTypeId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("LayThietBiTheoTrangThai", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Status != null)
                {
                    cmd.Parameters.AddWithValue("@Status", Status);
                }
                else
                    cmd.Parameters.AddWithValue("@Status", DBNull.Value);

                if (deviceTypeId != null)
                {
                    cmd.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
                }
                else
                    cmd.Parameters.AddWithValue("@deviceTypeId", DBNull.Value);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }

        public static DataTable LayThietBiBinhThuong(int? Status,int? deviceTypeId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("LayThietBiBinhThuong", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                if (Status != null)
                {
                    cmd.Parameters.AddWithValue("@Status", Status);
                }
                else
                    cmd.Parameters.AddWithValue("@Status", DBNull.Value);

                if (deviceTypeId != null)
                {
                    cmd.Parameters.AddWithValue("@deviceTypeId", deviceTypeId);
                }
                else
                    cmd.Parameters.AddWithValue("@deviceTypeId", DBNull.Value);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
    }
}
