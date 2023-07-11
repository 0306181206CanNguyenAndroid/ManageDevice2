using BUS.BusinessObject;
using DTO.Model;
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
    public partial class Malfunction : Form
    {
        public Malfunction()
        {
            InitializeComponent();
        }
        public int user = 1;
        public UserModel teacher = null;
        private List<ReportModel> listReport = null;
        private List<MalfunctionModel> listError = null;
        private void Setting()
        {
            dtgv_listDeviceError.AutoGenerateColumns = false;
            dtgv_Report.AutoGenerateColumns = false;
        }
        #region Load Data
        #region DataGrid
        #endregion
        #endregion

        #region Click
        #endregion
    }
}
