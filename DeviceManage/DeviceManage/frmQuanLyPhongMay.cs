using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO.Model;
using BUS.BusinessObject;

namespace DeviceManage
{
    public partial class frmQuanLyPhongMay : Form
    {
        //private int selectedRowIndex;
        public UserModel LoginLoginInUser = null;
        public int teacherId = 1;
        public TeacherModel GV = null;
        private List<DeviceModel> listDevice = null;
        private BindingSource bs = new BindingSource();
        public frmQuanLyPhongMay(int id)
        {
            InitializeComponent();
            dgvPhongMay.AutoGenerateColumns = false;
            LoginLoginInUser = UserBus.SelectByPrimaryKey(id);
            if (LoginLoginInUser.Status == 1)
                teacherId = 0;
            else
            {
                teacherId = 1;
                GV = TeacherBus.SelectTeacherByUserId(LoginLoginInUser.Id, false);
            }
            //dgvPhongMay.DataSource = RoomBus.GetAllRoom();
            //dgvPhongMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cb_Room.DisplayMember = "Name";
            cb_Room.ValueMember = "Id";
            if (teacherId == 0)
            {
                cb_Room.DataSource = RoomBus.GetRoomAfterDelete();
            }
            else
            {
                cb_Room.DataSource = RoomBus.SelectByTeacherId(teacherId);
            }

            LoadDanhSachThietBi((int)cb_Room.SelectedValue);
            LoadDataGrid();
            //dgvPhongMay.DataSource = RoomBus.GetRoomAfterDelete();


        }

        private void LoadDataGrid()
        {
            bs.DataSource = listDevice;
            dgvPhongMay.DataSource = bs;
        }

        private void LoadDanhSachThietBi(int roomId)
        {
            listDevice = DeviceBus.GetAllDeviceInRoom(roomId);
        }

        private void frmQuanLyPhongMay_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            

        }

        private void dgvPhongMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int deviceId = (int)dgvPhongMay.SelectedCells[0].OwningRow.Cells["Id"].Value;
            int col = dgvPhongMay.SelectedCells[0].ColumnIndex;
            //Người dùng nhấn nút xem trên Grid

            if (dgvPhongMay.Columns[col] == dgvPhongMay.Columns["UsingStatus"])
            {
                //MessageBox.Show("Báo cáo lỗi");

                Report f = new Report(LoginLoginInUser, DeviceBus.SelectByPrimaryKey(deviceId));
                f.report += F_report;
                f.Show();
            }
            else
            {
                foreach (DeviceModel de in listDevice)
                {
                    if (de.Id == deviceId)
                    {
                        
                    }
                }
            }
        }

        private void F_report(object sender, Action_ReportSuccessEventArgs e)
        {
            //throw new NotImplementedException();
            LoadDanhSachThietBi((int)cb_Room.SelectedValue);
            LoadDataGrid();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiemPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ViewDevice_Click(object sender, EventArgs e)
        {

        }

        private void cb_Room_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachThietBi((int)(cb_Room.SelectedValue==null ? 0 : cb_Room.SelectedValue));
            LoadDataGrid();
        }

        private void dgvPhongMay_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvPhongMay.Columns["Status"].Index)
            {
                if (e.Value != null)
                {
                    int? gender = (int?)e.Value;
                    if (gender != null)
                    {
                        e.Value = gender == 0 ? "Còn tốt" : gender == 1 ? "Chờ bảo trì" : gender == 2 ? "Bảo trì" : "Cũ";
                    }
                    else
                    {
                        e.Value = "Mới";
                    }
                }
            }
        }

        private void dgvPhongMay_MouseHover(object sender, EventArgs e)
        {
            DataGridView.HitTestInfo info = dgvPhongMay.HitTest(dgvPhongMay.PointToClient(Cursor.Position).X, dgvPhongMay.PointToClient(Cursor.Position).Y);
            if(info.Type==DataGridViewHitTestType.Cell)
            {
                DataGridViewRow currentRow = dgvPhongMay.Rows[info.RowIndex];
                ToolTip ttp = new ToolTip();
                ttp.SetToolTip(dgvPhongMay, "" + currentRow);
                dgvPhongMay.Show();
            }
        }

        private void dgvPhongMay_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int? id = (int?) dgvPhongMay.Rows[e.RowIndex].Cells["Id"].Value;
                
                if(id != null)
                {
                    string tooltiptext = DeviceBus.GetInfoDevice(id.Value);
                    t.ToolTipTitle = tooltiptext;
                    t.SetToolTip(dgvPhongMay, tooltiptext);
                }
            }
        }
    }
}
