using BUS.BusinessObject;
using DAO;
using DeviceManage.dbDeviceContext;
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

namespace DeviceManage
{
    public partial class reportThietBiTheoPhong : Form
    {
        //public List<ThongKeThietBiTheoPhong> danhsach = null;

        private string seletedRoom;
       
        public reportThietBiTheoPhong()
        {
            InitializeComponent();
        }

        private void reportThietBiTheoPhong_Load(object sender, EventArgs e)
        {

            cbNameRom.DataSource = RoomBus.GetRoomAfterDelete();
            cbNameRom.DisplayMember = "Name";
            cbNameRom.ValueMember = "Id";

            //this.rptThietbiTheoPhong.RefreshReport();
        }

        private void HienThiThietBiTheoPhong()
        {
            using(var _dbContext = new DbDeviceContext())
            {
                string sql = ProcString.sqlReportThietBiTheoPhong;
                string seletedRoom = cbNameRom.SelectedItem.ToString();
                string selectedRoom = cbNameRom.Text;
                List<ThongKeThietBiTheoPhong> danhsach = 
                 _dbContext.Database.SqlQuery<ThongKeThietBiTheoPhong>(sql).ToList();
                foreach(var a in danhsach)
                {
                    a.Device_SpecsName = a.Info;
                    a.Device_TypeName=a.DeviceTypeName;
                    a.SoLuong = a.SL;
                }
                danhsach = danhsach.Where(ds => ds.RoomName.ToLower() == selectedRoom.ToLower()).ToList();
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

        private void cbNameRom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        
    }
}
