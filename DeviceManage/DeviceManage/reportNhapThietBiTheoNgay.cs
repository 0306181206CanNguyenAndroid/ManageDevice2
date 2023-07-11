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
    public partial class reportNhapThietBiTheoNgay : Form
    {
        public List<ThongKeNhapThietBiTheoNgay> danhsach = null;
        public reportNhapThietBiTheoNgay()
        {
            InitializeComponent();
            dtTuNgay.CustomFormat= "dd/MM/yyyy";
            dtDenNgay.CustomFormat= "dd/MM/yyyy";
        }

        private void reportNhapThietBiTheoNgay_Load(object sender, EventArgs e)
        {

            this.rptThongKeNhapThietBiTheoNgay.RefreshReport();
        }

        private void btnXemNhapThietBiTheoNgay_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = Convert.ToDateTime(dtTuNgay.Text);
            DateTime denNgay=Convert.ToDateTime(dtDenNgay.Text);
            HienThongKeNhapThietBiTheoNgay(tuNgay, denNgay.AddDays(1).AddSeconds(-1));
        }

        private void HienThongKeNhapThietBiTheoNgay(DateTime tuNgay, DateTime denNgay)
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
                danhsach = new List<ThongKeNhapThietBiTheoNgay>();
                for (int i = 0; i < 3; i++)
                {
                    ThongKeNhapThietBiTheoNgay a = new ThongKeNhapThietBiTheoNgay();

                    a.DeviceName = "Máy Tính Asus";
                    a.Device_TypeName = "Máy Tính";
                    a.Name = "Nguyễn Trọng Cần";
                    a.NgayNhap=DateTime.Now;
                    a.Soluong = 2;
                    a.TongGia = 2000000;
                    danhsach.Add(a);
                }

                this.rptThongKeNhapThietBiTheoNgay.LocalReport.ReportPath = "rptThongKeNhapThietBiTheoNgay.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeNhapThietBiTheoNgayDataset", danhsach);
                this.rptThongKeNhapThietBiTheoNgay.LocalReport.DataSources.Clear();
                this.rptThongKeNhapThietBiTheoNgay.LocalReport.DataSources.Add(reportDataSource);
                this.rptThongKeNhapThietBiTheoNgay.LocalReport.SetParameters(new ReportParameter("prTuNgay", tuNgay.ToString("MM/dd/yyyy")));
                this.rptThongKeNhapThietBiTheoNgay.LocalReport.SetParameters(new ReportParameter("prDenNgay", denNgay.ToString("MM/dd/yyyy")));
                this.rptThongKeNhapThietBiTheoNgay.RefreshReport();
            }
        }
    }
}
