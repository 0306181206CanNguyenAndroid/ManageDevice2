using BUS.BusinessObject;
using DeviceManage.Reportting;
using DTO.Model;
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

namespace DeviceManage
{
    public partial class ThongKeThietBiTheoRoom : Form
    {
        public ThongKeThietBiTheoRoom()
        {
            InitializeComponent();
            
        }
        public List<ThongKeThietBiTheoPhong> danhsach = null;

        private void reportThietBiTheoPhong_Load(object sender, EventArgs e)
        {
            

            //this.rptThietbiTheoPhong.RefreshReport();
        }


        private void HienThiThietBiTheoPhong()
        {
            using (var _dbContext = new DbDeviceContext())
            {
                //string sql = ProcString.sqlReportThietBiTheoPhong;
                string seletedRoom = cbNameRom.SelectedItem.ToString();
                string selectedRoom = cbNameRom.Text;
                int? RoomId = (int)cbNameRom.SelectedValue;
                
                DataTable dt = RoomBus.LayThongTinTheoPhong(RoomId);
                if (dt != null)
                {
                    danhsach = new List<ThongKeThietBiTheoPhong>();
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            ThongKeThietBiTheoPhong thietBiTheoPhong = new ThongKeThietBiTheoPhong();
                            thietBiTheoPhong.DeviceName = dr["DeviceName"].ToString();
                            thietBiTheoPhong.Device_SpecsName = dr["Info"].ToString();
                            thietBiTheoPhong.Device_TypeName = dr["DeviceTypeName"].ToString();
                            thietBiTheoPhong.RoomName = dr["RoomName"].ToString();
                            thietBiTheoPhong.NgayMua = dr["NgayMua"]!= DBNull.Value ? ((DateTime)dr["NgayMua"]): (DateTime?)null;
                            thietBiTheoPhong.SoLuong = (int)dr["SL"];
                            danhsach.Add(thietBiTheoPhong);
                        }
                    }
                    else MessageClass.Message_Event("Không Có Thiết Nào Trong Phòng", "Thông Báo",false);

                }

                //_dbContext.Database.SqlQuery<ThongKeThietBiTheoPhong>(sql).ToList();

                //danhsach = danhsach.Where(ds => ds.RoomName.ToLower() == selectedRoom.ToLower()).ToList();
                this.rptThietbiTheoPhong.LocalReport.ReportPath = "rptThongKeThietBiTheoPhong.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeThietBiTheoPhongDataset", danhsach);
                this.rptThietbiTheoPhong.LocalReport.DataSources.Clear();
                this.rptThietbiTheoPhong.LocalReport.DataSources.Add(reportDataSource);
                this.rptThietbiTheoPhong.RefreshReport();
            }
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            HienThiThietBiTheoPhong();
        }
        private void ThongKeThietBiTheoRoom_Load(object sender, EventArgs e)
        {
            cbNameRom.DataSource = RoomBus.GetRoomAfterDelete();
            cbNameRom.DisplayMember = "Name";
            cbNameRom.ValueMember = "Id";


            

            //this.reportViewer1.RefreshReport();
        }

        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
