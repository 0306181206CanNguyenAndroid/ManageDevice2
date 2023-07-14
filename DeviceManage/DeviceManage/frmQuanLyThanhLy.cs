using BUS.BusinessObject;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceManage
{
    public partial class frmQuanLyThanhLy : Form
    {
        public frmQuanLyThanhLy()
        {
            InitializeComponent();
        }

        private void frmQuanLyThanhLy_Load(object sender, EventArgs e)
        {
            cbTenTBThanhLy.DataSource = DeviceBus.SelectAllDynamicWhere(null, null, null, null, null, null, null,null,null,null,null,null,null,null,false,4); 
            cbTenTBThanhLy.DisplayMember = "Name";
            cbTenTBThanhLy.ValueMember= "Id";
        }
    }
}
