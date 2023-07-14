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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        public Report(UserModel user, DeviceModel device)
        {
            InitializeComponent();
            nguoiLap = user;
            this.device = device;
            LoadForm();
        }
        public event FireEventForAction_ReportSuccess report = null;
        private UserModel nguoiLap = null;
        private DeviceModel device = null;

        private void LoadForm()
        {
            if(nguoiLap != null && device !=null)
            {
                TeacherModel t = TeacherBus.SelectTeacherByUserId(nguoiLap.Id, false);
                txtNguoiLap.Text = t.FullName;
                txtDevice.Text = device.Name;
                device.Info = DeviceBus.GetInfoDevice(device.Id);
                txtInfo.Text = device.Info;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNote.Text.Trim()))
            {
                MessageClass.Message_CheckEmpty("Mô tả lỗi", "Lưu ý!");
                return;
            }
            ReportModel re = new ReportModel();
            re.CreatedDate = DateTime.Now;
            re.IsDeleted = false;
            re.Status = 0;
            re.DeviceId = device.Id;
            re.Title = "Báo cáo thiết bị" + device.Name;
            re.Note = txtNote.Text.Trim();
            re.CreatedUserId = nguoiLap.Id;
            try
            {
                ReportBus.Insert(re);
                ThemVaodanhSachLoi(device.Id);
                device.Status = SettingClass.Status_Error;
                DeviceBus.Update(device);
                MessageClass.Message_Event("Thành công", "Thông báo");
                if(report!=null)
                {
                    report(this, new Action_ReportSuccessEventArgs{ });
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageClass.Message_Event(ex.Message, "Error");
            }
        }
        public int ThemVaodanhSachLoi(int deviceId)
        {
            MalfunctionModel mal = new MalfunctionModel();
            mal.Severity = checkMissing.Checked ? SettingClass.Status_Error_VerySerious : SettingClass.Status_Error;
            mal.IsDeleted = false;
            mal.CreatedDate = DateTime.Now;
            mal.CreatedUserId = nguoiLap.Id;
            mal.Status = SettingClass.Status_Nomal;
            mal.DeviceId = device.Id;
            mal.Note = txtNote.Text.Trim();
            
            return MalfunctionBus.Insert(mal);
        }
    }
}
