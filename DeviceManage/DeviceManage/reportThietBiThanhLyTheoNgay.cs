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

namespace DeviceManage
{
    public partial class reportThietBiThanhLyTheoNgay : Form
    {
        public List<ThongKeThietBiThanhLyTheoNgay> danhsach=null;
        public reportThietBiThanhLyTheoNgay()
        {
            InitializeComponent();
            dtTuNgay.CustomFormat= "dd/MM/yyyy";
            dtDenNgay.CustomFormat = "dd/MM/yyyy";
        }

        private void reportThietBiThanhLyTheoNgay_Load(object sender, EventArgs e)
        {

            this.rptThietBiThanhLyTheoNgay.RefreshReport();
        }

        private void btnXemThietBiThanhLyTheoNgay_Click(object sender, EventArgs e)
        {
           DateTime tuNgay = dtTuNgay.Value;
           DateTime denNgay = dtDenNgay.Value;
           HienThongKeThanhLyTheoNgay(tuNgay, denNgay.AddDays(1).AddSeconds(-1));
        }

        private void HienThongKeThanhLyTheoNgay(DateTime tuNgay,DateTime denNgay)
        {
            using (var _dbContext = new DbDeviceContext())
            {
                //tuNgay=Convert.ToDateTime(dtTuNgay.Text);
                //denNgay=Convert.ToDateTime(dtDenNgay.Text);
                //TimeSpan time = denNgay - tuNgay;
                //int TongSoNgay=time.Days;
                //if(TongSoNgay<0)
                //{ 

                //}
                danhsach = new List<ThongKeThietBiThanhLyTheoNgay>();
                for(int i = 0; i < 3; i++)
                {
                    ThongKeThietBiThanhLyTheoNgay a = new ThongKeThietBiThanhLyTheoNgay();

                    a.DeviceName = "Máy Tính";
                    a.Device_TypeName = "Máy Tính";
                    a.Name = "Nguyễn Thanh Bình";
                    a.NgayThanhLy = DateTime.Now.Date;
                    a.Gia = 20000;
                    danhsach.Add(a);
                }
                
                this.rptThietBiThanhLyTheoNgay.LocalReport.ReportPath = "rptThongKeThietBiThanhLyTheoNgay.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeThietBiThanhLyTheoNgayDataset", danhsach);
                this.rptThietBiThanhLyTheoNgay.LocalReport.DataSources.Clear();
                this.rptThietBiThanhLyTheoNgay.LocalReport.DataSources.Add(reportDataSource);
                this.rptThietBiThanhLyTheoNgay.LocalReport.SetParameters(new ReportParameter("prTuNgay", tuNgay.ToString("dd/MM/yyyy")));
                this.rptThietBiThanhLyTheoNgay.LocalReport.SetParameters(new ReportParameter("prDenNgay", denNgay.ToString("dd/MM/yyyy")));
                this.rptThietBiThanhLyTheoNgay.RefreshReport();
            }
        }
    }
}
