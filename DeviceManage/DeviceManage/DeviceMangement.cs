﻿using BUS.BusinessObject;
using DTO.Model;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManage
{
    public partial class DeviceMangement : Form
    {
        public DeviceMangement()
        {
            InitializeComponent();
            //tkql = tkdn;
            Setting();
            Load_Source();
            Load_Form();
        }

        //private UserModel tkql;
        //Các cài đặt mặt định của form
        


        //Khai báo các class lấy dl cho form
        List<DeviceModel> listDevice = null;
        DeviceModel currentDevice = null;

        ////Khai báo biến lưu trữ tạm cho form
        BindingSource bs = new BindingSource();


        #region Load

        private void Setting()
        {
            dtgvQlThietBi.AutoGenerateColumns = false;
            dtgvQlThietBi.AllowUserToAddRows = false;
            txtPrice.Text = "0.0";
            ckb_isAddIntoRoom.Checked = true;
        }

        private void LoadListImg()
        {
            List<DeviceModel> l = new List<DeviceModel>();
            if (listDevice != null && listDevice.Count > 0)
            {
                foreach (DeviceModel d in listDevice)
                {
                    if (!String.IsNullOrEmpty(d.Image))
                    {
                        bool f = true;
                        foreach (DeviceModel dd in l)
                        {
                            if (dd.Image == d.Image)
                            {
                                f = false;
                            }
                        }
                        if (f)
                        {
                            l.Add(d);
                        }
                    }
                }
                cb_ListImg.DisplayMember = "Image";
                cb_ListImg.ValueMember = "Image";
                cb_ListImg.DataSource = l.ToList();

            }
        }

        public void ActionReset(int req)
        {
            if (req == 1)
            {
                Load_Source();
            }
            if (req == 2)
            {

            }
        }

        private void Load_Form()
        {
            LoadDataGridView();
            dtgvQlThietBi.ClearSelection();
            Load_Source();
            LoadListImg();
        }

        private void Load_Source()
        {

            cbLoaiTbi.DisplayMember = "Name";
            cbLoaiTbi.ValueMember = "Id";
            cbLoaiTbi.DataSource = Device_TypeBus.GetDevice_TypeAfterDelete();


            cbKhoa.DisplayMember = "Name";
            cbKhoa.ValueMember = "Id";
            cbKhoa.DataSource = FacultyBus.SelectAllDynamicWhere(null, null, null, null, null, null, false);


            cbPhong.DisplayMember = "Name";
            cbPhong.ValueMember = "Id";
            cbPhong.DataSource = RoomBus.GetRoomAfterDelete();

            //cbNhaCungCap.DataSource = BrandBus.GetAllBrand();


            cbNhaCungCap.DisplayMember = "Name";
            cbNhaCungCap.ValueMember = "Id";
            cbNhaCungCap.DataSource = BrandBus.GetBrandAfterDelete();


            //cbKhoa.DisplayMember = "Name";
            //cbKhoa.ValueMember = "Id";
            //cbKhoa.DataSource = FacultyBus.GetFacultyAfterDelete();
        }

        private void LoadDataGridView()
        {

            listDevice = GetListDevice(10, 0);
            if (listDevice != null)
            {
                foreach (DeviceModel device in listDevice)
                {
                    BrandModel brand = BrandBus.SelectById(device.BrandId);
                    device.BrandName = brand.Name;
                    device.deviceDetail = DeviceDetailBus.SelectAllDynamicWhere(null, device.Id, null, null, null, null, null, null, null, false, null);
                    if (device.deviceDetail == null)
                    {
                        device.deviceDetail = new List<DeviceDetailModel>();
                    }

                }
            }
            else
                listDevice = new List<DeviceModel>();
            ReLoadDataGridView(listDevice);

        }

        private List<DeviceModel> GetListDevice(int rows, int starRows)
        {
            return DeviceBus.SelectSkipAndTakeDynamicWhere(null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null, rows, starRows, "Id desc");
        }

        private void ReLoadDataGridView(List<DeviceModel> list)
        {
            bs.DataSource = list;
            dtgvQlThietBi.DataSource = bs;
            GC.Collect();
        }

        public void UploadImage()
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            //Khoi tao thiet lap cho dialog
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                if ((stream = open.OpenFile()) != null)
                {
                    ptb_Device.Image = Image.FromStream(stream);
                }
                stream.Close();
                stream.Dispose();
                GC.Collect();

            }
        }


        #endregion

        #region Event bug

        private void btOrder_Click(object sender, EventArgs e)
        {
            //Order od = new Order(nvBUS.LayNV(tkql.maTK));
            //od.actiondevices += Od_actiondevices;
            //od.ShowDialog();
        }



        //Xử lý trong form - tab Quản lý bàn
        //BanBUS tables = new BanBUS();
        //List<BanDTO> dsBan = new List<BanDTO>();






        private void QuanLyHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (constans.TB_Close())
            //{
            //    this.Dispose();
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
            this.Dispose();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            //ResetDS();
            //Reset();
        }


        #endregion

        #region Event

        private void dtgvQlThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvQlThietBi.SelectedCells.Count > 0)
            {
                int deviceId = (int)dtgvQlThietBi.SelectedCells[0].OwningRow.Cells["DeviceId"].Value;
                int col = dtgvQlThietBi.SelectedCells[0].ColumnIndex;
                //Người dùng nhấn nút xem trên Grid

                if (dtgvQlThietBi.Columns[col] == dtgvQlThietBi.Columns["DeviceDetail"])
                {
                    foreach (DeviceModel de in listDevice)
                    {
                        if(de.Id == deviceId)
                        {
                            Form f = new DeviceDetail(de);
                            f.Show();
                        }
                    }
                }
                else
                {
                    foreach (DeviceModel de in listDevice)
                    {
                        if (de.Id == deviceId)
                        {
                            cbLoaiTbi.SelectedValue = de.DeviceTypeId;
                            cbPhong.SelectedValue = de.RoomId == null ? 1 : de.RoomId.Value;
                            cbKhoa.SelectedValue = de.FacultyId;
                            cbNhaCungCap.SelectedValue = de.BrandId;
                            dtBaoHanh.Value = de.WarrantyPeriod.HasValue ? de.WarrantyPeriod.Value : DateTime.Now;
                            dtp_DateBuy.Value = de.CreatedDate.Value;
                            txtPrice.Text = de.Price.ToString();
                            txtTenTbi.Text = de.Name;
                            rtbGhiChuTbi.Text = de.Note;
                            var r = RoomBus.SelectRoomByDevice(de.Id);
                            
                            if (r != null)
                                cbPhong.SelectedValue = r.Id;
                            else
                                cbPhong.SelectedIndex = 0;
                            try
                            {
                                ptb_Device.Image = Image.FromFile(SettingClass.path_Folder_Image_Device + de.Image);                                
                            }
                            catch(Exception ex)
                            {
                                ptb_Device.Image = Image.FromFile(SettingClass.path_NoImage_Default);
                            }
                            ptb_Device.Tag = de.Image;

                            currentDevice = de;
                            return;
                        }
                    }
                }
                

            }
        }


        #endregion

        #region Create Device

        private void btnThemTbi_Click(object sender, EventArgs e)
        {
            if (Check_Null())
                return;

            DeviceModel device = GetDeviceInfo();

            try
            {
                if (device.Image != null)
                {
                    device.Image = SaveImage(device.Name, SettingClass.path_Folder_Image_Device, device.CreatedDate.Value);
                }
                device.Id = DeviceBus.Insert(device);
                if (ckb_isAddIntoRoom.Checked)
                {
                    int roomId = (int)cbPhong.SelectedValue;
                    List<LocationModel> ll = LocationBus.GetAllLocationUnUsing(roomId);
                    if (ll.Count > 0)
                    {
                        DeviceRegistrationModel dr = new DeviceRegistrationModel();
                        dr.CreatedDate = device.CreatedDate;
                        dr.CreatedUserId = device.CreatedUserId;
                        dr.DeviceId = device.Id;
                        dr.RoomId = roomId;
                        dr.LocationId = ll[0].Id;
                        dr.Status = 0;
                        dr.IsDeleted = false;
                        DeviceRegistrationBus.Insert(dr);
                    }
                    else
                    {
                        MessageBox.Show("Hết chỗ trống!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                //device.QR_Code = SaveQR_Code(SettingClass.path_Folder_QR_Image, device);
                //DeviceBus.Update(device);
                AddSpecsByType(device.DeviceTypeId, device.Id);
                MessageBox.Show("Thành công! Vui lòng cập nhật thông số chi tiết thiết bị sớm!", "Thông Báo", MessageBoxButtons.OK);
                listDevice = GetListDevice(10, 0);
                ReLoadDataGridView(listDevice);
                EmptyDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại! Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
            }

        }

        private DeviceModel GetDeviceInfo()
        {
            DeviceModel device = new DeviceModel();
            device.Id = currentDevice != null ? currentDevice.Id : 1;
            device.Name = txtTenTbi.Text;
            device.DeviceTypeId = (int)cbLoaiTbi.SelectedValue;
            device.BrandId = (int)cbNhaCungCap.SelectedValue;
            device.ShipmentId = 1; // test
            device.Image = ptb_Device.Tag != null ? ptb_Device.Tag.ToString() : null;
            device.FacultyId = (int)cbKhoa.SelectedValue;
            device.Note = rtbGhiChuTbi.Text;
            device.IsDeleted = false;
            device.Price = Convert.ToDecimal(txtPrice.Text);
            device.Status = 0;
            device.WarrantyPeriod = dtBaoHanh.Value;
            device.CreatedDate = DateTime.Now;
            device.CreatedUserId = 1;

            return device;
        }

        private string SaveImage(string fileName, string path, DateTime createdDate)
        {
            string fileSaveName = ((createdDate.ToString().Replace("/", "-")).Replace(":", "")).Replace(" ", "_") + "_" + fileName + ".jpg";
            //ptb_Device.Image.Save(path + fileSaveName, ImageFormat.Jpeg);
            var img = new Bitmap(ptb_Device.Image);
            img.Save(path + fileSaveName, ImageFormat.Jpeg);

            return fileSaveName;
        }

        private string SaveQR_Code(string path, DeviceModel device)
        {
            string fileSaveName = ((device.CreatedDate.ToString().Replace("/", "-")).Replace(":", "")).Replace(" ", "_") + "_QR_" + device.Id + "_" + device.Name + ".jpg";
            Image imageSave = Create_QR(DeviceInfo(device));
            imageSave.Save(path + fileSaveName, ImageFormat.Jpeg);
            return fileSaveName;
        }

        private string DeviceInfo(DeviceModel device)
        {
            string detail = "\n ";
            List<DeviceDetailModel> listDeviceDetail = DeviceDetailBus.SelectAllDynamicWhere(null, device.Id, null, null, null, null, null, null, null, null, null);
            foreach (DeviceDetailModel deviceDetail in listDeviceDetail)
            {
                detail += deviceDetail.NameSpecs + ": " + deviceDetail.Description + "\n";
            }
            string info = "Ngày tạo:" + device.CreatedDate.ToString() + "\n  Thiet bi: " + device.Name + detail;

            return info;
        }

        private Image Create_QR(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(4);
            Image img = qrCodeImage;

            return img;
        }



        public void AddSpecsByType(int deviveTypeId, int deviceId)
        {
            List<DeviceType_SpecsModel> listSpecs = DeviceType_SpecsBus.SelectAllDynamicWhere(null, deviveTypeId, null, null, null, null, false);
            foreach (DeviceType_SpecsModel dtp in listSpecs)
            {
                DeviceDetailModel dtl = new DeviceDetailModel();
                dtl.DeviceId = deviceId;
                dtl.DeviceTypeSpecsId = dtp.Id;
                dtl.NameSpecs = SpecsBus.SelectByPrimaryKey(dtp.SpecsId).Name;
                dtl.CreatedDate = DateTime.Now;
                dtl.CreatedUserId = 1;
                dtl.Description = "";
                dtl.IsDeleted = false;
                dtl.Status = 0;
                try
                {
                    int kq = DeviceDetailBus.Insert(dtl);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thất bại! Lỗi " + e.Message, "Thông Báo", MessageBoxButtons.OK);
                    return;
                }

            }
        }

        #endregion


        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {

                Form f = new DeviceDetail(currentDevice);
                f.Show();
            }
        }



        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        } 

        private bool Check_Null()
        {
            if (txtTenTbi.Text.Trim() == "")
            {
                MessageClass.Message_CheckEmpty("Tên thiết bị", "Lưu ý");
                return true;
            }
            if (ckb_isAddIntoRoom.Checked)
            {
                if(((int?)cbPhong.SelectedValue)==null)
                {
                    MessageClass.Message_IsChosen("phòng!", "Lưu ý");
                    return true;
                }
            }
            if ((int?)cbLoaiTbi.SelectedValue == null)
            {
                MessageClass.Message_CheckEmpty("Loại thiết bị", "Lưu ý");
                return true;
            }
            if ((int?)cbNhaCungCap.SelectedValue == null)
            {
                MessageClass.Message_CheckEmpty("Thương hiệu", "Lưu ý");
                return true;
            }
            if ((int?)cbKhoa.SelectedValue == null)
            {
                MessageClass.Message_CheckEmpty("Khoa", "Lưu ý");
                return true;
            }
            if (dtp_DateBuy.Value > DateTime.Now)
            {
                MessageClass.Message_CheckData("Ngày mua", "Lưu ý");
                return true;
            }
            

            return false;
        }

        private void ptb_Device_DoubleClick(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            //Khoi tao thiet lap cho dialog
            open.InitialDirectory = "C:\\";
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                if ((stream = open.OpenFile()) != null)
                {

                    ptb_Device.Image = Image.FromStream(stream);
                    ptb_Device.Tag = Path.GetFileName(open.FileName);
                }
                stream.Close();
                stream.Dispose();
                GC.Collect();

            }
        }

        private void btnSuaTbi_Click(object sender, EventArgs e)
        {
            if (Check_Null())
                return;
            DeviceModel device = GetDeviceInfo();
            if (device.Image != null)
            {
                device.Image = SaveImage(device.Name, SettingClass.path_Folder_Image_Device, device.CreatedDate.Value);
            }
            try
            {

                DeviceBus.Update(device);
                if (ckb_isAddIntoRoom.Checked)
                {
                    int roomId = (int)cbPhong.SelectedValue;
                    List<DeviceRegistrationModel> dsr = DeviceRegistrationBus.SelectAllDynamicWhere(null, device.Id, null, null, null, null, false, null);
                    if (dsr.Count > 0)
                    {
                        dsr[0].RoomId = roomId;
                        DeviceRegistrationBus.Update(dsr[0]);
                    }
                    else
                    {
                        List<LocationModel> ll = LocationBus.GetAllLocationUnUsing(roomId);
                        if (ll.Count > 0)
                        {
                            DeviceRegistrationModel dr = new DeviceRegistrationModel();
                            dr.CreatedDate = device.CreatedDate;
                            dr.CreatedUserId = device.CreatedUserId;
                            dr.DeviceId = device.Id;
                            dr.RoomId = roomId;
                            dr.LocationId = ll[0].Id;
                            dr.Status = 0;
                            dr.IsDeleted = false;
                            DeviceRegistrationBus.Insert(dr);
                        }
                        else
                        {
                            MessageBox.Show("Hết chỗ trống!", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }

                }
                MessageBox.Show("Thành công", "Thông Báo", MessageBoxButtons.OK);
                LoadDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại! Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoaTbi_Click(object sender, EventArgs e)
        {
            if(currentDevice!=null)
            {
                if (DeviceBus.CheckDeviceInRoom(currentDevice.Id))
                {
                    MessageBox.Show("Không thể xóa thiết bị đang sử dụng!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    DeviceBus.Update(currentDevice);
                    listDevice = GetListDevice(10, 0);
                    ReLoadDataGridView(listDevice);
                    EmptyDevice();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void EmptyDevice()
        {
            currentDevice = null;
            txtPrice.Text = "0.0";
            txtTenTbi.Text = "";
            rtbGhiChuTbi.Text = "";
        }

        private void btn_Make_QR_Click(object sender, EventArgs e)
        {
            if (currentDevice != null)
            {
                //string info = DeviceInfo(currentDevice);
                string info = currentDevice.Id+"";
                Form qr = new frmQR_Code(info);
                qr.Show();

            }

        }

        private void cb_ListImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string img = cb_ListImg.SelectedValue.ToString();
            ptb_Device.Tag = img;
            try
            {
                Image i = Image.FromFile(SettingClass.path_Folder_Image_Device + img);
                ptb_Device.Image = i;
            }
            catch (Exception ex)
            {
                ptb_Device.Image = Image.FromFile(SettingClass.path_NoImage_Default);
            }

        }

        private void ckb_isAddIntoRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_isAddIntoRoom.Checked)
            {
                cbPhong.Enabled = true;
            }
            else
            {
                cbPhong.Enabled = false;
            }
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            Form f = new frmShipment();
            f.Show();
        }

        private void txtTiemKiemTbi_TextChanged(object sender, EventArgs e)
        {
            string find = txtTiemKiemTbi.Text.Trim();
            if(find!= "")
            {
                listDevice = DeviceBus.Search(find);
                ReLoadDataGridView(listDevice);
            }
        }

        private void dtgvQlThietBi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgvQlThietBi.Columns["Status"].Index)
            {
                if (e.Value != null)
                {
                    int? gender = (int?)e.Value;
                    if (gender != null)
                    {
                        e.Value = gender == 0 ? "Mới" : gender == 1 ? "Chờ bảo trì" : gender == 2 ? "Bảo trì" : "Cũ";
                    }
                    else
                    {
                        e.Value = "Mới";
                    }
                }
            }
        }
    }
}
