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
    public partial class DeviceReport : Form
    {
        public DeviceReport()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        public DeviceReport(int userId)
        {
            InitializeComponent();
            UserId = userId;
            
            Setting();
            LoadCbDevice();
            LoadCbPhong();
            LoadListError();
            LoadDataGrid();
        }

        public void Setting()
        {
            dtgv_ListDeviceError.AutoGenerateColumns = false;
            dtgv_ListDeviceError.AllowUserToAddRows = false;
            radNomal.Checked = true;
        }
        public int UserId = 1;
        private List<MalfunctionModel> list = null;
        private List<DeviceModel> ListDeviceError = null;
        private MalfunctionModel currentDevice = null;
        private BindingSource bs = new BindingSource();
        private void LoadDataGrid()
        {
            bs.DataSource = list;
            dtgv_ListDeviceError.DataSource = bs;
            if(list.Count > 0)
            {
                currentDevice = list[0];
                btnBaoTri.Enabled = currentDevice.Status != SettingClass.Status_Error ? false : true;
                btnComplete.Enabled = currentDevice.Status != SettingClass.Status_Fixing ? false : true;
                
            }
            else
            {
                currentDevice = null;
                btnBaoTri.Enabled = false;
                btnComplete.Enabled = false;
            }
            BindingData(currentDevice);
        }

        private void LoadCbPhong()
        {
            cbRoom.DisplayMember = "Name";
            cbRoom.ValueMember = "Id";
            cbRoom.DataSource = RoomBus.GetRoomAfterDelete();
        }

        private void BindingData(MalfunctionModel m)
        {
            if(m!= null)
            {
                if (m.RoomId != null)
                    cbRoom.SelectedValue = m.RoomId;
                else
                    cbRoom.SelectedIndex = 0;
                cb_ErrorDevice.SelectedValue = m.DeviceId;
                txtNote.Text = m.Note;
                txtSolution.Text = m.Solution;
                if (m.Severity == SettingClass.Status_Error)
                    radNomal.Checked = true;
                else if (m.Severity == SettingClass.Status_Error_Serious)
                    radSerious.Checked = true;
                else if (m.Severity == SettingClass.Status_Error_VerySerious)
                    radVerySerious.Checked = true;

                if (m.Status == SettingClass.Status_Nomal)
                {
                    btnBaoTri.Enabled = true;
                    btnComplete.Enabled = false;
                    txtNote.ReadOnly = false;
                    txtSolution.ReadOnly = false;
                }
                else 
                {
                    if (m.Status == SettingClass.Status_Fixing)
                    {
                        btnBaoTri.Enabled = false;
                        btnComplete.Enabled = true;
                    }
                    else
                    {
                        btnBaoTri.Enabled = false;
                        btnComplete.Enabled = false;
                    }

                    txtNote.ReadOnly = true;
                    txtSolution.ReadOnly = true;

                }
                
            }
            else
            {
                radNomal.Checked = true;
                txtNote.Text = "";
                txtSolution.Text = "";
            }
        }
        private void LoadCbDevice()
        {
            cb_ErrorDevice.DisplayMember = "Name";
            cb_ErrorDevice.ValueMember = "Id";
            ListDeviceError = DeviceBus.SelectAllDynamicWhere(null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, SettingClass.Status_Error);
            cb_ErrorDevice.DataSource = ListDeviceError;
        }
        private void LoadListError()
        {
            list = MalfunctionBus.SelectALlDynamicWhere(null, null, null, null, null, null, null, false, null);
            if (list.Count > 0)
            {
                foreach (MalfunctionModel mp in list)
                {
                    DeviceModel d = DeviceBus.SelectByPrimaryKey(mp.DeviceId);
                    RoomModel r = RoomBus.SelectRoomByDevice(mp.DeviceId);
                    mp.DeviceName = d != null ? d.Name : "";
                    mp.RoomId = r != null ? r.Id : (int?)null;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_ListDeviceError_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgv_ListDeviceError.Columns["Fix"].Index)
            {
                if (e.Value != null)
                {
                    int? gender = (int?)e.Value;
                    if (gender != null)
                    {
                        e.Value = gender == SettingClass.Status_Nomal ? "Chờ bảo trì" : gender == SettingClass.Status_Fixing ? "Đang bảo trì" :  "Hoàn thành";
                    }
                    else
                    {
                        e.Value = "Chờ bảo trì";
                    }
                }
            }
            if (e.ColumnIndex == dtgv_ListDeviceError.Columns["Severity"].Index)
            {
                if (e.Value != null)
                {
                    int? se = (int?)e.Value;
                    if (se != null)
                    {
                        e.Value = se == SettingClass.Status_Error ? "Nhẹ" : se == SettingClass.Status_Error_Serious ? "Nghiêm trọng" : se == SettingClass.Status_Error_VerySerious ? "Rất nghiêm trọng" : "Hỏng";
                    }
                    else
                    {
                        e.Value = "Nhẹ";
                    }
                }
            }
        }

        private void dtgv_ListDeviceError_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgv_ListDeviceError.SelectedCells.Count > 0)
            {
                int id = (int)dtgv_ListDeviceError.SelectedCells[0].OwningRow.Cells["Id"].Value;
                int col = dtgv_ListDeviceError.SelectedCells[0].ColumnIndex;
                foreach (MalfunctionModel ma in list)
                {
                    if (ma.Id == id)
                    {
                        
                        if (dtgv_ListDeviceError.Columns[col] == dtgv_ListDeviceError.Columns["Option1"])
                        {
                            if(MessageClass.Message_Event_YesNo("ngưng bảo trì"))
                            {
                                ma.Status = SettingClass.Status_Error_Broken;
                                MalfunctionBus.UpDate(ma);
                                LoadListError();
                                LoadDataGrid();
                                currentDevice = null;
                            }
                            
                        }
                        else
                        {
                            currentDevice = ma;
                            BindingData(currentDevice);
                        }
                        return;
                    }
                }
                
            }
        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            if (CheckNull())
                return;
            
            if (currentDevice!=null)
            {
                currentDevice.Note = txtNote.Text.Trim();
                currentDevice.Solution = txtSolution.Text.Trim();
                currentDevice.Severity = radNomal.Checked ? SettingClass.Status_Error
                    : radSerious.Checked ? SettingClass.Status_Error_Serious
                    : radVerySerious.Checked ? SettingClass.Status_Error_VerySerious : 4;
                currentDevice.Status = SettingClass.Status_Fixing;

                MalfunctionBus.UpDate(currentDevice);
                
                LoadDataGrid();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                currentDevice.Note = txtNote.Text.Trim();
                currentDevice.Solution = txtSolution.Text.Trim();
                currentDevice.Severity = radNomal.Checked ? SettingClass.Status_Error
                    : radSerious.Checked ? SettingClass.Status_Error_Serious
                    : radVerySerious.Checked ? SettingClass.Status_Error_VerySerious : 4;
                currentDevice.Status = SettingClass.Status_Fixed;

                MalfunctionBus.UpDate(currentDevice);
                
                LoadDataGrid();
            }
        }

        private bool CheckNull()
        {
            if(String.IsNullOrEmpty(txtSolution.Text.Trim()))
            {
                MessageClass.Message_CheckEmpty("Giải pháp!", "Lưu ý!");
                return true;
            }
            if (String.IsNullOrEmpty(txtNote.Text.Trim()))
            {
                MessageClass.Message_CheckEmpty("Mô tả lỗi!", "Lưu ý!");
                return true;
            }
            return false;
        }
    }
}
