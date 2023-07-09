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
        public AddDeviceFromShipment(ShipmentModel ship, int userId)
        {
            InitializeComponent();
            shipment = ship;
            UserId = userId; 
            Setting();
            Load_Source();
            Load_Form();
            ptb_Device.Image = Image.FromFile(SettingClass.path_NoImage_Default);
            
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
        public int shipmentId = 0;
        private int UserId = 0;
        private DeviceModel device;
        private List<DeviceModel> listDevice = null;
        private List<DeviceModel> listSampleDevice = null;
        private DeviceModel currentDevice = null;
        public DeviceDetailModel currientDetail = null;

        List<DeviceDetailModel> listDetail = null;

        ////Khai báo biến lưu trữ tạm cho form
        BindingSource bsDetail = new BindingSource();

        #endregion

        #region Load
        private void Setting()
        {
            txtPrice.Text = "0.0";
            dtgv_ListDetail.AutoGenerateColumns = false;
            ptb_Device.SizeMode = PictureBoxSizeMode.Zoom;
        }

        #region Image
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
            }
        }


        #endregion

        #region DataGrid

        private void LoadDTGVDeviceDetail()
        {
            //Load_ComboboxSpecs();
            Load_DataGridView();
        }

        public void Load_DataGridView()
        {
            try
            {
                DtgvDevice_SourceChange((int)cbLoaiTbi.SelectedValue, (DeviceModel)cb_Device.SelectedItem);
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
                LoadListDetail(device.Id);
            else
            { 
                listDetail = null;
                listDetail = LoadDetailByDeviceType(deviceTypeId);
                GC.Collect();
            }
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

        //public void Load_ComboboxSpecs()
        //{
        //    var cbData = (DataGridViewComboBoxColumn)dtgv_ListDetail.Columns["Specs"];
        //    cbData.DisplayMember = "NameSpecs";
        //    cbData.ValueMember = "Id";
        //    cbData.DataSource = LoadDetailByDeviceType((int)cbLoaiTbi.SelectedValue);
        //}

        private void LoadListDetail(int deviceId)
        {
            listDetail = GetDetail(deviceId);
        }

        private List<DeviceDetailModel> GetDetail(int deviceId)
        {
            return DeviceDetailBus.SelectAllDynamicWhere(null, deviceId, null, null, null, null, null, null, null, false, null);
        }
        #endregion


        private void Load_Form()  
        {
            Load_Source();
            LoadListImg();
            LoadDTGVDeviceDetail();
        }

        
        private void Load_Source()
        {


            cbLoaiTbi.DisplayMember = "Name";
            cbLoaiTbi.ValueMember = "Id";
            cbLoaiTbi.DataSource = Device_TypeBus.GetDevice_TypeAfterDelete();

            LoadDeviceSource((int)cbLoaiTbi.SelectedValue);

            cbNhaCungCap.DisplayMember = "Name";
            cbNhaCungCap.ValueMember = "Id";
            cbNhaCungCap.DataSource = BrandBus.GetBrandAfterDelete();
        }

        #endregion

        #region Event select change

        private void cb_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeviceInfoChange((DeviceModel)cb_Device.SelectedItem);
        }

        private void cbLoaiTbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDeviceSource((int)cbLoaiTbi.SelectedValue);

        }

        private void DeviceInfoChange(DeviceModel device)
        {
            ptb_Device.Image = String.IsNullOrEmpty(device.Image) ? Image.FromFile(SettingClass.path_Folder_Image_Device + device.Image)
                : Image.FromFile(SettingClass.path_NoImage_Default);
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
                }
                
                //AddSpecsByType(device.DeviceTypeId, device.Id);
                listDevice.Add(DeviceBus.SelectByPrimaryKey(device.Id));
                currentDevice = null;
            }
            catch (Exception ex)
            {
                MessageClass.Message_Event(ex.Message, SettingClass.TextTitle_ThongBao, true);
            }

        }

        private bool Check_Null()
        {
            if (txtTenTbi.Text.Trim() == "")
                return true;
            if (txtPrice.Text.Trim() == "")
                return true;
            if (txt_ShipmentCode.Text.Trim() == "")
                return true;

            //if()
            if (cbLoaiTbi.SelectedItem == null)
                return true;
            if (cbNhaCungCap.SelectedItem == null)
                return true;

            return false;
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
            device.Note = rtbGhiChuTbi.Text;
            device.IsDeleted = false;
            device.Price = Convert.ToDecimal(txtPrice.Text);
            device.Status = 0;
            device.WarrantyPeriod = dtBaoHanh.Value;
            device.CreatedDate = DateTime.Now;
            device.CreatedUserId = 1;

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

        
        private void dtgv_ListDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgv_ListDetail.Columns["Icon"].Index)
            {
                if (e.Value != null)
                {
                    int gender = (int) e.Value;
                    Button p = new Button();
                    p.Dock = DockStyle.Fill;
                    p.BackgroundImageLayout = ImageLayout.Zoom;
                    p.BackgroundImage = Image.FromFile(SettingClass.path_Folder_Resource + "btn_delete.png");
                    p.Tag = gender;
                    p.Click += P_Click;
                    e.Value = p;
                }
            }
        }

        private void P_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            int specsId = (int) ((Button)sender).Tag;
            MessageBox.Show("" + specsId);
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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
                int detailId = (int)dtgv_ListDetail.SelectedCells[0].OwningRow.Cells["Specs"].Value;

                foreach (DeviceDetailModel de in listDetail)
                {
                    if (de.Id == detailId)
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
    }
}
