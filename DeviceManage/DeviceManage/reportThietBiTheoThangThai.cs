using DeviceManage.Reportting;
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
    public partial class reportThietBiTheoThangThai : Form
    {
        public reportThietBiTheoThangThai()
        {
            InitializeComponent();
            rdError.Checked = true;
            int? status = null;
            if (rdError.Checked)
            {
                status = SettingClass.Status_Error;
            }else
            {
                status = SettingClass.Status_Nomal;
            }
            ///
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

        private void reportThietBiTheoThangThai_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }


}
