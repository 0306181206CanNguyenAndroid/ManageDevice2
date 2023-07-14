using BUS.BusinessObject;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeviceManage
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public UserModel LoginInUser;
        public frmQuanLyTaiKhoan(UserModel user)
        {
            InitializeComponent();
            LoginInUser = user;

           
            
            //dgvTaiKhoan.AutoGenerateColumns = false;


            //dgvTaiKhoan.AutoGenerateColumns = false;
            dgvTaiKhoan.CellFormatting += dgvTaiKhoan_CellFormatting;
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";

            btnSuaTk.Enabled = false;
            btnSuaTk.BackColor = System.Drawing.Color.LightGray;

        }

        private void CkbMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            cbTeacher.DataSource = TeacherBus.GetTeachersAfterDelete();
            cbTeacher.DisplayMember = "FullName";
            cbTeacher.ValueMember = "Id";

          
            dgvTaiKhoan.DataSource = UserBus.GetAllUser();
        }

        //private void btnTaoTk_Click(object sender, EventArgs e)
        //{
        //    frmTaoTaiKhoan frmTaoTaiKhoan = new frmTaoTaiKhoan(LoginInUser);
        //    frmTaoTaiKhoan.Show();
        //}

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvTaiKhoan.Rows[e.RowIndex];
                cbTeacher.Text = row.Cells["FullName"].Value.ToString();
                bool currentGender = (bool)dgvTaiKhoan.Rows[e.RowIndex].Cells["TeacherGender"].Value;
                if (currentGender)
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtSDT.Text = row.Cells["Phone"].Value.ToString();
                dtNgaySinh.Text = row.Cells["Birth"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["UserName"].Value.ToString();
                txtMatKhau.Text = row.Cells["Pass"].Value.ToString();
                //cbQuyen.Text = row.Cells["Status"].Value.ToString();
                int status = Convert.ToInt32(row.Cells["Status"].Value);
                if (status == 1)
                {
                    cbQuyen.Text = "Admin";
                }
                else if (status == 0)
                {
                    cbQuyen.Text = "Giáo Viên";
                }
                else
                {
                    cbQuyen.Text = string.Empty;
                }


            }
            catch
            {

            }
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvTaiKhoan.Columns["TeacherGender"].Index)
            {
                if (e.Value != null)
                {
                    string gender = e.Value.ToString();
                    {
                        if (gender == "True")
                        {
                            e.Value = "Nam";
                        }
                        else if (gender == "False")
                        {
                            e.Value = "Nữ";
                        }
                    }
                }
            }
            if (e.ColumnIndex == dgvTaiKhoan.Columns["Pass"].Index)
            {
                if (e.Value != null)
                {
                    string password = e.Value.ToString();
                    e.Value = new string('*', password.Length);
                }
            }
            if (e.ColumnIndex == dgvTaiKhoan.Columns["Status"].Index)
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString(); 
                    if(status=="1")
                    {
                        e.Value = "Admin";
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        e.Value = "Giáo Viên";
                        e.FormattingApplied = false;
                    }
                }
            }

        }

        private void btnThemTk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Check())
                {

                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int status = 0;
                    if (cbQuyen.SelectedItem.ToString() == "Admin")
                    {
                        status = 1;
                    }
                    TeacherModel teacher=(TeacherModel)cbTeacher.SelectedItem;
                    UserModel user = new UserModel();
                    user.TeacherId = (int)cbTeacher.SelectedValue;
                    user.CreatedDate = DateTime.Now;
                    user.CreatedUserId = LoginInUser.Id;
                    user.IsDeleted = false;
                    user.Status = status;
                    user.UserName = txtTenDangNhap.Text;
                    user.Pass = SettingClass.GetMD5(txtMatKhau.Text);
                    user.Name = teacher.FullName;
                    
                    UserBus.InsertUser(user);
                    MessageBox.Show("Tạo Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTaiKhoan.DataSource = UserBus.GetAllUser();
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                    //cbQuyen.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSuaTk_Click(object sender, EventArgs e)
        {


            try
            {
                if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                {
                    MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int status = 0;
                    if (cbQuyen.SelectedItem.ToString() == "Admin")
                    {
                        status = 1;
                    }
                    int Id = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["Id"].Value);
                    UserModel user = new UserModel();
                    user.Id = Id;
                    user.UserName = txtTenDangNhap.Text;
                    user.Pass = SettingClass.GetMD5(txtMatKhau.Text);
                    user.CreatedDate = DateTime.Now;
                    user.CreatedUserId = LoginInUser.Id;
                    user.IsDeleted = false;
                    user.Status = status;
                    DecentralizationBus.UpdateUserNameAndPass(user);
                    MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTaiKhoan.DataSource = UserBus.GetAllUser();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void btnCapNhatUser_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
        //        {
        //            MessageBox.Show("Thông Tin Không Được Trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            int Id = Convert.ToInt32(dgvTaiKhoan.CurrentRow.Cells["UserId"].Value);
        //            UserModel user = new UserModel();
        //            user.Id = Id;
        //            user.UserName = txtTenDangNhap.Text;
        //            user.Pass = SettingClass.GetMD5(txtMatKhau.Text);
        //            user.CreatedDate = DateTime.Now;
        //            user.CreatedUserId = LoginInUser.Id;
        //            user.IsDeleted = false;
        //            DecentralizationBus.UpdateUserNameAndPass(user);
        //            MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}

        private void btnThuHoiTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTaiKhoan.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvTaiKhoan.SelectedRows[0].Index;
                    int Id = Int32.Parse(dgvTaiKhoan.Rows[rowIndex].Cells["Id"].Value.ToString());

                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dgvTaiKhoan.DataSource];
                    currencyManager.SuspendBinding();
                    DialogResult result = MessageBox.Show("Bạn Có Muốn Thu Hồi Không?", "Thu Hồi", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //dgvPhongMay.CurrentCell = dgvPhongMay.Rows[0].Cells[0];
                        DecentralizationBus.DeleteDecentralization(Id);
                        dgvTaiKhoan.Rows[rowIndex].Visible = false;
                        MessageBox.Show("Thu Hồi Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTaiKhoan.DataSource = UserBus.GetAllUser();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTeacher.SelectedIndex != -1)
            {
                TeacherModel teacher=(TeacherModel)cbTeacher.SelectedItem;
                txtSDT.Text = teacher.Phone;
                dtNgaySinh.Value = teacher.Birth;
                if (teacher.Gender==true)
                {
                    rdNam.Checked= true;
                }
                else 
                {
                    rdNu.Checked= true;
                }
            }
        }

        private bool Check()
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                return false;
            }
            if (txtMatKhau.Text.Trim() == "" || txtMatKhau.Text.Length <= 6)
            {
                return false;
            }
            if (cbQuyen.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void btnTimKiemTk_Click(object sender, EventArgs e)
        {
            string Name = txtTimKiem.Text;
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Nhập Thông Tin Cần Tìm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable result = UserBus.SearchUser(Name);
                dgvTaiKhoan.DataSource = result;

            }
        }

        private void ckSuaTk_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSuaTk.Checked)
            {
                cbTeacher.Enabled = false;
                btnSuaTk.Enabled = true;
                btnSuaTk.BackColor = System.Drawing.Color.Transparent;

            }
            else
            {
                btnSuaTk.Enabled=false;
                cbTeacher.Enabled=true;
                btnSuaTk.BackColor = System.Drawing.Color.LightGray;
            }
        }
    }
}
