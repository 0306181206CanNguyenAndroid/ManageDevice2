using DAO;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataLayerBase
{
    public class MalfunctionDataLayerBase
    {
        public static int Insert(MalfunctionModel mal)
        {
           
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("[dbo].[Malfuntion_Insert]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CreatedDate", mal.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedUserId", mal.CreatedUserId);
            cmd.Parameters.AddWithValue("@IsDeleted", mal.IsDeleted);
            cmd.Parameters.AddWithValue("@Status", mal.Status);
            cmd.Parameters.AddWithValue("@DeviceId", mal.DeviceId);
            cmd.Parameters.AddWithValue("@Note", mal.Note);
            cmd.Parameters.AddWithValue("@Solution", mal.Solution != null ? mal.Solution : "");
            cmd.Parameters.AddWithValue("@Severity", mal.Severity);
            conn.Open();
            int kq = (int)cmd.ExecuteScalar();
            conn.Close();
            return kq;
        }

        public static void Update(MalfunctionModel mal)
        {

            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("[dbo].[Malfuntion_Update]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CreatedDate", mal.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedUserId", mal.CreatedUserId);
            cmd.Parameters.AddWithValue("@Id", mal.Id);
            cmd.Parameters.AddWithValue("@IsDeleted", mal.IsDeleted);
            cmd.Parameters.AddWithValue("@Status", mal.Status);
            cmd.Parameters.AddWithValue("@DeviceId", mal.DeviceId);
            cmd.Parameters.AddWithValue("@Note", mal.Note);
            cmd.Parameters.AddWithValue("@Solution", mal.Solution!=null?mal.Solution:"");
            cmd.Parameters.AddWithValue("@Severity", mal.Severity);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static List<MalfunctionModel> SelectAllDynamicWhere(int? id, int? deviceId, string note, string solution,int? severity, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            List<MalfunctionModel> objMalfunctionCol = new List<MalfunctionModel>();
            string storedProcdeviceId = "[dbo].[Malfunction_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcdeviceId, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, deviceId, note, solution, severity, createdDate, createdUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    MalfunctionModel objDevice = CreateDeviceFromDataRowShared(dr);
                                    objMalfunctionCol.Add(objDevice);
                                }
                            }
                        }
                    }
                }
            }

            return objMalfunctionCol;
        }
        protected static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? deviceId, string note, string solution, int? severity, DateTime? createdDate, int? createdUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);
            if (severity != null)
                command.Parameters.AddWithValue("@severity", id);
            else
                command.Parameters.AddWithValue("@severity", System.DBNull.Value);

            if (deviceId != null)
                command.Parameters.AddWithValue("@deviceId", deviceId);
            else
                command.Parameters.AddWithValue("@deviceId", System.DBNull.Value);

            if (solution != null)
                command.Parameters.AddWithValue("@solution", solution);
            else
                command.Parameters.AddWithValue("@solution", System.DBNull.Value);

            if (!String.IsNullOrEmpty(note))
                command.Parameters.AddWithValue("@note", note);
            else
                command.Parameters.AddWithValue("@note", System.DBNull.Value);

            if (createdDate != null)
                command.Parameters.AddWithValue("@createdDate", createdDate);
            else
                command.Parameters.AddWithValue("@createdDate", System.DBNull.Value);

            if (createdUserId != null)
                command.Parameters.AddWithValue("@createdUserId", createdUserId);
            else
                command.Parameters.AddWithValue("@createdUserId", System.DBNull.Value);

            if (isDeleted != null)
                command.Parameters.AddWithValue("@isDeleted", isDeleted);
            else
                command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

            if (status != null)
                command.Parameters.AddWithValue("@status", status);
            else
                command.Parameters.AddWithValue("@status", System.DBNull.Value);

        }

        protected static MalfunctionModel CreateDeviceFromDataRowShared(DataRow dr)
        {
            MalfunctionModel objDevice = new MalfunctionModel();

            objDevice.Id = (int)dr["Id"];

            if (dr["Note"] != System.DBNull.Value)
                objDevice.Note = dr["Note"].ToString();
            else
                objDevice.Note = null;
            
            //if (dr["Title"] != System.DBNull.Value)
            //    objDevice.Title = dr["Title"].ToString();
            //else
            //    objDevice.Title = null;

            if (dr["Severity"] != System.DBNull.Value)
                objDevice.Severity = (int)dr["Severity"];
            else
                objDevice.Severity = 1;

            if (dr["CreatedDate"] != System.DBNull.Value)
                objDevice.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                objDevice.CreatedDate = null;

            if (dr["Solution"] != System.DBNull.Value)
                objDevice.Solution = dr["Solution"].ToString();
            else
                objDevice.Solution = null;

            objDevice.DeviceId = (int)dr["DeviceId"];
            

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objDevice.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objDevice.CreatedUserId = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                objDevice.IsDeleted = (bool)dr["IsDeleted"];
            else
                objDevice.IsDeleted = false;

            if (dr["Status"] != System.DBNull.Value)
                objDevice.Status = (int)dr["Status"];
            else
                objDevice.Status = null;

            return objDevice;
        }

    }
}
