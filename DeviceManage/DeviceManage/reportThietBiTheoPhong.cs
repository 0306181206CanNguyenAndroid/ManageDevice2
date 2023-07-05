using BUS.BusinessObject;
using DeviceManage.dbDeviceContext;
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
        public reportThietBiTheoPhong()
        {
            InitializeComponent();
        }

        private void reportThietBiTheoPhong_Load(object sender, EventArgs e)
        {

            cbNameRom.DataSource = RoomBus.GetRoomAfterDelete();
            cbNameRom.DisplayMember = "Name";
            cbNameRom.ValueMember = "Id";

            this.rptThietbiTheoPhong.RefreshReport();
        }

        private void HienThiThietBiTheoPhong()
        {
            using(var _dbContext = new DbDeviceContext())
            {
                string sql = "";
            }
        }
    }
}
