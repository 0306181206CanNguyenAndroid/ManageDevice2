using BUS.BusinessObject;
using DeviceManage.Reportting;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeviceManage
{
    public partial class reportThietBiTheoThangThai : Form
    {
        int? status = null;
        public reportThietBiTheoThangThai()
        {
            InitializeComponent();
            rdError.Checked = true;
            
            
            
            // DataTable dt = RoomBus.LayThongTinTheoPhong(status);
            // viet lai if (dt != null)
            //{
            //    danhsach = new List<ThongKeThietBiTheoPhong>();
            //    if (dt.Rows.Count > 0)
            //    {
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            ThongKeThietBiTheoPhong thietBiTheoPhong = new ThongKeThietBiTheoPhong();
            //            thietBiTheoPhong.DeviceName = dr["DeviceName"].ToString();
            //            thietBiTheoPhong.Device_SpecsName = dr["Info"].ToString();
            //            thietBiTheoPhong.Device_TypeName = dr["DeviceTypeName"].ToString();
            //            thietBiTheoPhong.RoomName = dr["RoomName"].ToString();
            //            thietBiTheoPhong.NgayMua = ((DateTime)dr["NgayMua"]);
            //            thietBiTheoPhong.SoLuong = (int)dr["SL"];
            //            danhsach.Add(thietBiTheoPhong);
            //        }
            //    }
        }
        public List<ThongKeThietBiTheoTrangThai> danhsach = null;

        private void reportThietBiTheoThangThai_Load(object sender, EventArgs e)
        {
            //this.rptThietBiTheoTrangThai.RefreshReport();
        }

        private void HienThiThietBiTheoTrangThai()
        {
            if (rdError.Checked)
            {
                status = SettingClass.Status_Error;
            }
            else
            {
                status = SettingClass.Status_Nomal;
            }
            using (var _dbContext = new DbDeviceContext())
            {
                DataTable dt = RoomBus.LayThietBiTheoTrangThai(status, null);
                
                if (dt != null)
                {
                    danhsach = new List<ThongKeThietBiTheoTrangThai>();
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            ThongKeThietBiTheoTrangThai thietBiTheoTrangThai = new ThongKeThietBiTheoTrangThai();
                            thietBiTheoTrangThai.DeviceName = dr["DeviceName"].ToString();
                            thietBiTheoTrangThai.Device_SpecsName = dr["Info"].ToString();
                            thietBiTheoTrangThai.Device_TypeName = dr["DeviceTypeName"].ToString();
                            thietBiTheoTrangThai.RoomName = dr["RoomName"].ToString();
                            thietBiTheoTrangThai.ErrorName = dr["ErrorName"] != System.DBNull.Value ? dr["ErrorName"].ToString() : "Không Có";
                            thietBiTheoTrangThai.Remediation = dr["Remediation"] != System.DBNull.Value ? dr["Remediation"].ToString() : "Không Có";
                            thietBiTheoTrangThai.ErrorDescription = dr["ErrorDescription"] != System.DBNull.Value ? dr["ErrorDescription"].ToString() : "Không Có";
                            danhsach.Add(thietBiTheoTrangThai);
                        }
                    }
                    else MessageClass.Message_Event("Không Có Thiết Nào Trong Phòng", "Thông Báo", false);
                }
                
                //danhsach.Add(a);
                this.rptThietBiTheoTrangThai.LocalReport.ReportPath = "rptThongKeThietBiTheoTrangThai.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeThietBiTheoTrangThaiDataset", danhsach);
                this.rptThietBiTheoTrangThai.LocalReport.DataSources.Clear();
                this.rptThietBiTheoTrangThai.LocalReport.DataSources.Add(reportDataSource);
                this.rptThietBiTheoTrangThai.RefreshReport();
            }
        }

        private void btnXemTKTheoTrangThai_Click(object sender, EventArgs e)
        {
            HienThiThietBiTheoTrangThai();
        }
    }


}
