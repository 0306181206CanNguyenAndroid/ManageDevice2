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
    public partial class AddDeviceFromShipment : Form
    {
        public event FireEventForActionAddDeviceFromShipment addDevice = null;
        public AddDeviceFromShipment(ShipmentModel ship, int userId)
        {
            InitializeComponent();
            shipment = ship;
            UserId = userId; 
            Setting();
            Load_Source();
            Load_Form();
            //ptb_Device.Image = Image.FromFile(SettingClass.path_NoImage_Default);
            
        }
        public AddDeviceFromShipment()
        {
            InitializeComponent();
            UserId = 1;
            Setting();
            Load_Source();
            Load_Form();
            ptb_Device.Image = Image.FromFile(SettingClass.path_NoImage_Default);
        }

        //private UserModel tkql;
        //Các cài đặt mặt định của form

        #region Model

        //Khai báo các class lấy dl cho form
        public ShipmentModel shipment = null;
        private int UserId = 0;
        
        private List<DeviceModel> listDevice = null;
        private List<DeviceModel> listSampleDevice = null;
        public DeviceDetailModel currientDetail = null;

        List<DeviceDetailModel> listDetail = null;

        ////Khai báo biến lưu trữ tạm cho form
        BindingSource bsDetail = new BindingSource();

        #endregion

        #region Load

        #region Constraint
        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void Setting()
        {
            txtPrice.Text = "0.0";
            dtgv_ListDetail.AutoGenerateColumns = false;
            ptb_Device.SizeMode = PictureBoxSizeMode.Zoom;
            dtBaoHanh.CustomFormat = "dd/MM/yyyy";
        }
        #endregion

        #region Combobox
        private void LoadDeviceSource(int deviceTypeId)
        {
            cb_Device.ValueMember = "Id";
            cb_Device.DisplayMember = "Name";
            listSampleDevice = null;
            GC.Collect();
            listSampleDevice = DeviceBus.SelectSampleDeviceByType(deviceTypeId);
            cb_Device.DataSource = listSampleDevice;
            if (listSampleDevice.Count > 0)
            {
                DeviceInfoChange(listSampleDevice[0]);
                Load_DataGridView(deviceTypeId, listSampleDevice[0]);
            }
            else
            {
                Load_DataGridView(deviceTypeId, null);
            }
        }


        #endregion

        #region DataGrid
        public void Load_DataGridView(int deviceTypeId, DeviceModel device)
        {
            try
            {
                DtgvDevice_SourceChange(deviceTypeId, device);
                currientDetail = listDetail[0];
            }
            catch (Exception e)
            {
                listDetail = new List<DeviceDetailModel>();
            }

            bsDetail.DataSource = listDetail.ToList();
            dtgv_ListDetail.DataSource = bsDetail;
        }

        private void DtgvDevice_SourceChange(int deviceTypeId, DeviceModel device)
        {
            if (device != null)
            {
                LoadListDetail(device);
            }
            else
            { 
                listDetail = null;
                listDetail = LoadDetailByDeviceType(deviceTypeId);
            }
            bsDetail.DataSource = listDetail;
            dtgv_ListDetail.DataSource = bsDetail;
            GC.Collect();
        }
        private List<DeviceDetailModel> LoadDetailByDeviceType(int deviveTypeId)
        {
            List<DeviceDetailModel> list = new List<DeviceDetailModel>();
            List<DeviceType_SpecsModel> listSpecs = DeviceType_SpecsBus.SelectAllDynamicWhere(null, deviveTypeId, null, null, null, null, false);
            foreach (DeviceType_SpecsModel dtp in listSpecs)
            {
                DeviceDetailModel dtl = new DeviceDetailModel();
                dtl.DeviceTypeSpecsId = dtp.Id;
                dtl.SpecsId = dtp.SpecsId;
                dtl.NameSpecs = SpecsBus.SelectByPrimaryKey(dtp.SpecsId).Name;
                dtl.CreatedDate = DateTime.Now;
                dtl.CreatedUserId = 1;
                dtl.Description = "";
                dtl.IsDeleted = false;
                dtl.Status = 0;
                list.Add(dtl);
            }
            return list;
        }

        private void LoadListDetail(DeviceModel device)
        {
            listDetail = null;
            listDetail = GetDetail(device);
        }

        private List<DeviceDetailModel> GetDetail(DeviceModel device)
        {
            List<DeviceDetailModel> list = DeviceDetailBus.SelectAllDynamicWhere(null, device.Id, null, null, null, null, null, null, null, false, null);
            
            foreach(DeviceDetailModel ddm in list)
            {
                DeviceType_SpecsModel dts = DeviceType_SpecsBus.SelectByPrimaryKey(ddm.DeviceTypeSpecsId);
                ddm.SpecsId = dts.SpecsId;
            }
            return list;
        }
        #endregion


        private void Load_Form()  
        {
            Load_Source();
            
        }

        
        private void Load_Source()
        {
            cbLoaiTbi.DisplayMember = "Name";
            cbLoaiTbi.ValueMember = "Id";
            cbLoaiTbi.DataSource = Device_TypeBus.SelectDeviceTypeHasSpecs(false);

            cbNhaCungCap.DisplayMember = "Name";
            cbNhaCungCap.ValueMember = "Id";
            cbNhaCungCap.DataSource = BrandBus.GetBrandAfterDelete();

            LoadDeviceSource((int)cbLoaiTbi.SelectedValue);
        }

        #endregion

        #region Event select change

        private void cb_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeviceModel d = (DeviceModel)cb_Device.SelectedItem;
            DeviceInfoChange(d);
            Load_DataGridView(d.DeviceTypeId, d);
        }

        private void cbLoaiTbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDeviceSource((int)cbLoaiTbi.SelectedValue);

        }

        private void DeviceInfoChange(DeviceModel device)
        {
            if (!String.IsNullOrEmpty(device.Image))
                ptb_Device.Image = Image.FromFile(SettingClass.path_Folder_Image_Device + device.Image);
            else ptb_Device.Image = Image.FromFile(SettingClass.path_NoImage_Default);
            ptb_Device.Tag = device.Image;

            txtTenTbi.Text = device.Name;
            cbNhaCungCap.SelectedValue = device.BrandId;
            txtPrice.Text = device.Price + "";
            rtbGhiChuTbi.Text = device.Note;
            dtBaoHanh.Value = device.WarrantyPeriod.Value;
        }

        #endregion

        #region Create Device

        private void btnThemTbi_Click(object sender, EventArgs e)
        {
            if (Check_Null())
                return;

            DeviceModel device = GetDeviceInfo();
            int num = Convert.ToInt32(num_NumberAdd.Value);

            try
            {
                if (device.Image != null)
                {
                    device.Image = SaveImage(device.Name, SettingClass.path_Folder_Image_Device, device.CreatedDate.Value);
                }
                for (int i = 0; i < num;i++)
                {
                    device.Id = DeviceBus.Insert(device);
                    ShipmentDetailModel shipmentDetail = new ShipmentDetailModel();
                    shipmentDetail.IsDeleted = false;
                    shipmentDetail.CreatedDate = shipment.CreatedDate;
                    shipmentDetail.CreatedUserId = UserId;
                    shipmentDetail.Status = 0;
                    shipmentDetail.Code = txt_ShipmentCode.Text.Trim();
                    shipmentDetail.ShipmentId = shipment.Id;
                    shipmentDetail.DeviceId = device.Id;
                    ShipmentDetailBus.Insert(shipmentDetail);

                    foreach (DeviceDetailModel ddm in listDetail)
                    {
                        ddm.DeviceId = device.Id;
                        DeviceDetailBus.Insert(ddm);
                    }
                }
                MessageClass.Message_Event("Nhập thành công! Tiếp tục!", SettingClass.TextTitle_ThongBao, false);
                txt_ShipmentCode.Text = "";
            }
            catch (Exception ex)
            {
                MessageClass.Message_Event(ex.Message, SettingClass.TextTitle_ThongBao, true);
            }

        }

        private bool Check_Null()
        {
            if (String.IsNullOrEmpty(txtTenTbi.Text.Trim()))
            {
                MessageClass.Message_CheckData("Tên thiết bị", "Cảnh báo!");
                return true;
            }    
            if ( String.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageClass.Message_CheckData("Giá thiết bị", "Cảnh báo!");
                return true;
            }
            if (String.IsNullOrEmpty(txt_ShipmentCode.Text.Trim()))
            {
                MessageClass.Message_CheckData("Mã lô hàng", "Cảnh báo!");
                return true;
            }

            if (cbLoaiTbi.SelectedItem == null)
                return true;
            if (cbNhaCungCap.SelectedItem == null)
                return true;

            return false;
        }


        private DeviceModel GetDeviceInfo()
        {
            DeviceModel device = new DeviceModel();
            device.Name = txtTenTbi.Text;
            device.DeviceTypeId = (int)cbLoaiTbi.SelectedValue;
            device.BrandId = (int)cbNhaCungCap.SelectedValue;
            device.ShipmentId = shipment.Id; 
            device.Image = ptb_Device.Tag != null ? ptb_Device.Tag.ToString() : null;
            device.Note = rtbGhiChuTbi.Text;
            device.IsDeleted = false;
            device.Price = Convert.ToDecimal(txtPrice.Text);
            device.Status = 0;
            device.WarrantyPeriod = dtBaoHanh.Value;
            device.CreatedDate = DateTime.Now;
            device.CreatedUserId = UserId;

            return device;
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


        private string SaveImage(string fileName, string path, DateTime createdDate)
        {
            string fileSaveName = ((createdDate.ToString().Replace("/", "-")).Replace(":", "")).Replace(" ", "_") + "_" + fileName + ".jpg";
            //ptb_Device.Image.Save(path + fileSaveName, ImageFormat.Jpeg);
            var img = new Bitmap(ptb_Device.Image);
            img.Save(path + fileSaveName, ImageFormat.Jpeg);

            return fileSaveName;
        }

        #endregion

        private void P_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //int specsId = (int) ((Button)sender).Tag;
            //MessageBox.Show("" + specsId);
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


        private void dtgv_ListDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ListDetail.SelectedCells.Count > 0)
            {
                int specsId = (int)dtgv_ListDetail.SelectedCells[0].OwningRow.Cells["SpecsId"].Value;
                foreach (DeviceDetailModel de in listDetail)
                {
                    if (de.SpecsId == specsId)
                    {
                        currientDetail = de;
                        return;
                    }
                }
                

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgv_ListDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ListDetail.CurrentRow != null)
            {
                DataGridViewRow dr = dtgv_ListDetail.CurrentRow;
                var values = dr.Cells["SpecsId"].Value != null ? dr.Cells["SpecsId"].Value : 0;
                foreach (DeviceDetailModel ddm in listDetail)
                {
                    if(ddm.SpecsId == (int)values)
                    {
                        ddm.Description = dr.Cells["Description"].Value != null ? dr.Cells["Description"].Value.ToString() : "";
                        return;
                    }
                }
            }
        }

        private void AddDeviceFromShipment_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(addDevice != null)
            {
                addDevice(this, new ActionAddDeviceFromShipmentEventArgs{ });
                GC.Collect();
                this.Dispose();
            }
        }
    }
}
