namespace DeviceManage
{
    partial class frmQuanLyPhongMay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblQlPhong = new System.Windows.Forms.Label();
            this.qbPhongMay = new System.Windows.Forms.GroupBox();
            this.btn_ViewDevice = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Room = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.num_AddDevice = new System.Windows.Forms.NumericUpDown();
            this.txt_RoomQuantityUsing = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_RoomQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTb = new System.Windows.Forms.Label();
            this.gbTimKiemPhong = new System.Windows.Forms.GroupBox();
            this.btnTimKiemPhong = new System.Windows.Forms.Button();
            this.txtTiemKiemPhong = new System.Windows.Forms.TextBox();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.dgvPhongMay = new System.Windows.Forms.DataGridView();
            this.RoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsingStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.qbPhongMay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_AddDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RoomQuantity)).BeginInit();
            this.gbTimKiemPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongMay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQlPhong
            // 
            this.lblQlPhong.AutoSize = true;
            this.lblQlPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQlPhong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblQlPhong.Location = new System.Drawing.Point(0, 0);
            this.lblQlPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQlPhong.Name = "lblQlPhong";
            this.lblQlPhong.Size = new System.Drawing.Size(370, 50);
            this.lblQlPhong.TabIndex = 0;
            this.lblQlPhong.Text = "Quản Lý Phòng Máy";
            // 
            // qbPhongMay
            // 
            this.qbPhongMay.Controls.Add(this.panel1);
            this.qbPhongMay.Controls.Add(this.btn_ViewDevice);
            this.qbPhongMay.Controls.Add(this.comboBox1);
            this.qbPhongMay.Controls.Add(this.label3);
            this.qbPhongMay.Controls.Add(this.cb_Room);
            this.qbPhongMay.Controls.Add(this.txt_RoomQuantityUsing);
            this.qbPhongMay.Controls.Add(this.label1);
            this.qbPhongMay.Controls.Add(this.num_RoomQuantity);
            this.qbPhongMay.Controls.Add(this.lblSoLuongTb);
            this.qbPhongMay.Controls.Add(this.gbTimKiemPhong);
            this.qbPhongMay.Controls.Add(this.btnXoaPhong);
            this.qbPhongMay.Controls.Add(this.btnSuaPhong);
            this.qbPhongMay.Controls.Add(this.btnThemPhong);
            this.qbPhongMay.Controls.Add(this.lblTenPhong);
            this.qbPhongMay.Dock = System.Windows.Forms.DockStyle.Top;
            this.qbPhongMay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.qbPhongMay.Location = new System.Drawing.Point(0, 50);
            this.qbPhongMay.Margin = new System.Windows.Forms.Padding(2);
            this.qbPhongMay.Name = "qbPhongMay";
            this.qbPhongMay.Padding = new System.Windows.Forms.Padding(2);
            this.qbPhongMay.Size = new System.Drawing.Size(1118, 200);
            this.qbPhongMay.TabIndex = 0;
            this.qbPhongMay.TabStop = false;
            this.qbPhongMay.Text = "Thông tin phòng máy";
            // 
            // btn_ViewDevice
            // 
            this.btn_ViewDevice.BackColor = System.Drawing.Color.Transparent;
            this.btn_ViewDevice.BackgroundImage = global::DeviceManage.Properties.Resources.documents;
            this.btn_ViewDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ViewDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewDevice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ViewDevice.Location = new System.Drawing.Point(431, 64);
            this.btn_ViewDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewDevice.Name = "btn_ViewDevice";
            this.btn_ViewDevice.Size = new System.Drawing.Size(75, 32);
            this.btn_ViewDevice.TabIndex = 29;
            this.t.SetToolTip(this.btn_ViewDevice, "Xem");
            this.btn_ViewDevice.UseVisualStyleBackColor = false;
            this.btn_ViewDevice.Click += new System.EventHandler(this.btn_ViewDevice_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 64);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 32);
            this.comboBox1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Thiết bị:";
            // 
            // cb_Room
            // 
            this.cb_Room.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Room.FormattingEnabled = true;
            this.cb_Room.Location = new System.Drawing.Point(208, 26);
            this.cb_Room.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cb_Room.Name = "cb_Room";
            this.cb_Room.Size = new System.Drawing.Size(202, 32);
            this.cb_Room.TabIndex = 26;
            this.cb_Room.SelectedValueChanged += new System.EventHandler(this.cb_Room_SelectedValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(139, 39);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 28);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Làm đầy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // num_AddDevice
            // 
            this.num_AddDevice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_AddDevice.Location = new System.Drawing.Point(14, 38);
            this.num_AddDevice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.num_AddDevice.Name = "num_AddDevice";
            this.num_AddDevice.Size = new System.Drawing.Size(110, 30);
            this.num_AddDevice.TabIndex = 24;
            // 
            // txt_RoomQuantityUsing
            // 
            this.txt_RoomQuantityUsing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RoomQuantityUsing.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoomQuantityUsing.Location = new System.Drawing.Point(204, 160);
            this.txt_RoomQuantityUsing.Margin = new System.Windows.Forms.Padding(2);
            this.txt_RoomQuantityUsing.Name = "txt_RoomQuantityUsing";
            this.txt_RoomQuantityUsing.ReadOnly = true;
            this.txt_RoomQuantityUsing.Size = new System.Drawing.Size(94, 30);
            this.txt_RoomQuantityUsing.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Thêm tự động:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hiện có :";
            // 
            // num_RoomQuantity
            // 
            this.num_RoomQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_RoomQuantity.Location = new System.Drawing.Point(44, 160);
            this.num_RoomQuantity.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.num_RoomQuantity.Name = "num_RoomQuantity";
            this.num_RoomQuantity.Size = new System.Drawing.Size(108, 30);
            this.num_RoomQuantity.TabIndex = 20;
            // 
            // lblSoLuongTb
            // 
            this.lblSoLuongTb.AutoSize = true;
            this.lblSoLuongTb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTb.Location = new System.Drawing.Point(44, 122);
            this.lblSoLuongTb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongTb.Name = "lblSoLuongTb";
            this.lblSoLuongTb.Size = new System.Drawing.Size(115, 24);
            this.lblSoLuongTb.TabIndex = 19;
            this.lblSoLuongTb.Text = "Sức chứa :";
            // 
            // gbTimKiemPhong
            // 
            this.gbTimKiemPhong.Controls.Add(this.btnTimKiemPhong);
            this.gbTimKiemPhong.Controls.Add(this.txtTiemKiemPhong);
            this.gbTimKiemPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimKiemPhong.Location = new System.Drawing.Point(655, 14);
            this.gbTimKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.gbTimKiemPhong.Name = "gbTimKiemPhong";
            this.gbTimKiemPhong.Padding = new System.Windows.Forms.Padding(2);
            this.gbTimKiemPhong.Size = new System.Drawing.Size(452, 87);
            this.gbTimKiemPhong.TabIndex = 17;
            this.gbTimKiemPhong.TabStop = false;
            this.gbTimKiemPhong.Text = "Tìm Kiếm";
            // 
            // btnTimKiemPhong
            // 
            this.btnTimKiemPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemPhong.BackgroundImage = global::DeviceManage.Properties.Resources.search;
            this.btnTimKiemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTimKiemPhong.Location = new System.Drawing.Point(316, 27);
            this.btnTimKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemPhong.Name = "btnTimKiemPhong";
            this.btnTimKiemPhong.Size = new System.Drawing.Size(108, 32);
            this.btnTimKiemPhong.TabIndex = 9;
            this.t.SetToolTip(this.btnTimKiemPhong, "Tìm Kiếm Phòng ");
            this.btnTimKiemPhong.UseVisualStyleBackColor = false;
            this.btnTimKiemPhong.Click += new System.EventHandler(this.btnTimKiemPhong_Click);
            // 
            // txtTiemKiemPhong
            // 
            this.txtTiemKiemPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTiemKiemPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiemKiemPhong.Location = new System.Drawing.Point(26, 34);
            this.txtTiemKiemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiemKiemPhong.Name = "txtTiemKiemPhong";
            this.txtTiemKiemPhong.Size = new System.Drawing.Size(202, 30);
            this.txtTiemKiemPhong.TabIndex = 8;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaPhong.BackgroundImage = global::DeviceManage.Properties.Resources.xoa;
            this.btnXoaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaPhong.Location = new System.Drawing.Point(530, 70);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(108, 32);
            this.btnXoaPhong.TabIndex = 7;
            this.t.SetToolTip(this.btnXoaPhong, "Xóa");
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaPhong.BackgroundImage = global::DeviceManage.Properties.Resources.sua;
            this.btnSuaPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaPhong.Location = new System.Drawing.Point(530, 21);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(108, 32);
            this.btnSuaPhong.TabIndex = 6;
            this.t.SetToolTip(this.btnSuaPhong, "Cập nhật");
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnThemPhong.BackgroundImage = global::DeviceManage.Properties.Resources.Them;
            this.btnThemPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemPhong.Location = new System.Drawing.Point(971, 153);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(108, 32);
            this.btnThemPhong.TabIndex = 5;
            this.t.SetToolTip(this.btnThemPhong, "Thêm Mới");
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.Location = new System.Drawing.Point(44, 29);
            this.lblTenPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(126, 24);
            this.lblTenPhong.TabIndex = 1;
            this.lblTenPhong.Text = "Tên Phòng :";
            // 
            // dgvPhongMay
            // 
            this.dgvPhongMay.AllowUserToAddRows = false;
            this.dgvPhongMay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomId,
            this.Location,
            this.Status,
            this.UsingStatus,
            this.Id});
            this.dgvPhongMay.Location = new System.Drawing.Point(0, 245);
            this.dgvPhongMay.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhongMay.Name = "dgvPhongMay";
            this.dgvPhongMay.ReadOnly = true;
            this.dgvPhongMay.RowHeadersWidth = 62;
            this.dgvPhongMay.RowTemplate.Height = 33;
            this.dgvPhongMay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPhongMay.Size = new System.Drawing.Size(1106, 205);
            this.dgvPhongMay.TabIndex = 2;
            this.t.SetToolTip(this.dgvPhongMay, "q");
            this.dgvPhongMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongMay_CellClick);
            this.dgvPhongMay.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhongMay_CellFormatting);
            this.dgvPhongMay.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongMay_CellMouseEnter);
            this.dgvPhongMay.MouseHover += new System.EventHandler(this.dgvPhongMay_MouseHover);
            // 
            // RoomId
            // 
            this.RoomId.DataPropertyName = "Name";
            this.RoomId.FillWeight = 120F;
            this.RoomId.HeaderText = "Thiết bị";
            this.RoomId.MinimumWidth = 6;
            this.RoomId.Name = "RoomId";
            this.RoomId.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "LocationName";
            this.Location.FillWeight = 50F;
            this.Location.HeaderText = "Số máy";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 50F;
            this.Status.HeaderText = "Tình trạng thiết bị";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UsingStatus
            // 
            this.UsingStatus.FillWeight = 60F;
            this.UsingStatus.HeaderText = "Hoạt động";
            this.UsingStatus.Image = global::DeviceManage.Properties.Resources.laptop_3131622;
            this.UsingStatus.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UsingStatus.MinimumWidth = 6;
            this.UsingStatus.Name = "UsingStatus";
            this.UsingStatus.ReadOnly = true;
            this.UsingStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UsingStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.num_AddDevice);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(405, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 73);
            this.panel1.TabIndex = 30;
            // 
            // frmQuanLyPhongMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 450);
            this.Controls.Add(this.dgvPhongMay);
            this.Controls.Add(this.qbPhongMay);
            this.Controls.Add(this.lblQlPhong);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyPhongMay";
            this.Text = "QuanLyPhongMay";
            this.Load += new System.EventHandler(this.frmQuanLyPhongMay_Load);
            this.qbPhongMay.ResumeLayout(false);
            this.qbPhongMay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_AddDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RoomQuantity)).EndInit();
            this.gbTimKiemPhong.ResumeLayout(false);
            this.gbTimKiemPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongMay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQlPhong;
        private System.Windows.Forms.GroupBox qbPhongMay;
        private System.Windows.Forms.DataGridView dgvPhongMay;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.GroupBox gbTimKiemPhong;
        private System.Windows.Forms.Button btnTimKiemPhong;
        private System.Windows.Forms.TextBox txtTiemKiemPhong;
        private System.Windows.Forms.Label lblSoLuongTb;
        private System.Windows.Forms.ComboBox cb_Room;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown num_AddDevice;
        private System.Windows.Forms.TextBox txt_RoomQuantityUsing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_RoomQuantity;
        private System.Windows.Forms.ToolTip t;
        private System.Windows.Forms.Button btn_ViewDevice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn UsingStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Panel panel1;
    }
}