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
    public class ReportDataLayer : ReportDataLayerBase
    {
        

        public static int InsertReport(ReportModel report)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("Report_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CreatedDate", report.CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedUserId", report.CreatedUserId);
            cmd.Parameters.AddWithValue("@IsDeleted", report.IsDeleted);
            cmd.Parameters.AddWithValue("@Status", report.Status);
            cmd.Parameters.AddWithValue("@DeviceId", report.DeviceId);
            cmd.Parameters.AddWithValue("@Note", report.Note);
            cmd.Parameters.AddWithValue("@Title", report.Title);
            conn.Open();
            int kq =  (int)cmd.ExecuteScalar();
            conn.Close();
            return kq;
        }
        
        public static void Updatereport(ReportModel report)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("Updatereport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", report.Id);
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 100);
            cmd.Parameters.AddWithValue("@CreatedDate", SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@CreatedUserId", SqlDbType.Int);
            cmd.Parameters.AddWithValue("@IsDeleted", SqlDbType.Bit);
            cmd.Parameters.AddWithValue("@Status", SqlDbType.Int);
            
            
            cmd.Parameters["@CreatedDate"].Value = report.CreatedDate;
            cmd.Parameters["@CreatedUserId"].Value = report.CreatedUserId;
            cmd.Parameters["@IsDeleted"].Value = report.IsDeleted;
            cmd.Parameters["@Status"].Value = report.Status;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //check Name có trùng với bảng
        public static bool IsDuplicatereport(ReportModel ReportModel, int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                string sql = "Select COUNT(*) from D_report Where (Name=@Name and Id <>@Id) and IsDeleted=0";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }
        //lấy danh sách thương hiệu sau khi xóa
        public static List<ReportModel> GetreportAfterDelete()
        {
            DataTable report = new DataTable();
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetreportAfterDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                conn.Close();
                return CreateReportModelfromDataTable(dt);
            }
        }
        public static void Deletereport(int Id)
        {
            using (SqlConnection conn = new SqlConnection(PathString.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update D_report set IsDeleted=1 where Id=@Id", conn);
                //cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static DataTable SearchreportByName(string Name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SearchreportByName", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
        //Tạo model từ datatable
        public static List<ReportModel> CreateReportModelfromDataTable(DataTable dt)
        {
            List<ReportModel> reports = new List<ReportModel>();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        ReportModel ReportModel = new ReportModel();
                        ReportModel.Id = (int)dr["Id"];
                        if (dr["CreatedDate"] != System.DBNull.Value)
                            ReportModel.CreatedDate = (DateTime)dr["CreatedDate"];
                        else ReportModel.CreatedDate = null;
                        if (dr["CreatedUserId"] != System.DBNull.Value)
                            ReportModel.CreatedUserId = (int)dr["CreatedUserId"];
                        else ReportModel.CreatedUserId = null;
                        if (dr["IsDeleted"] != System.DBNull.Value)
                            ReportModel.IsDeleted = (bool)dr["IsDeleted"];
                        else ReportModel.IsDeleted = false;
                        if (dr["Status"] != System.DBNull.Value)
                            ReportModel.Status = (int)dr["Status"];
                        else ReportModel.Status = null;

                        reports.Add(ReportModel);
                    }
                }
            }
            return reports;
        }
        protected static ReportModel CreatereportfromDataRow(DataRow dr)
        {
            ReportModel objReport = new ReportModel();

            objReport.Id = (int)dr["Id"];
            if (dr["CreatedDate"] != System.DBNull.Value)
                objReport.CreatedDate = (DateTime)dr["CreatedDate"];
            else objReport.CreatedDate = null;
            if (dr["CreatedUserId"] != System.DBNull.Value)
                objReport.CreatedUserId = (int)dr["CreatedUserId"];
            else objReport.CreatedUserId = null;
            if (dr["IsDeleted"] != System.DBNull.Value)
                objReport.IsDeleted = (bool)dr["IsDeleted"];
            else objReport.IsDeleted = false;
            if (dr["Status"] != System.DBNull.Value)
                objReport.Status = (int)dr["Status"];
            else objReport.Status = null;
            return objReport;
        }
    }
}
