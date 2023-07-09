
namespace DeviceManage
{
    partial class DeviceDetail
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ptb_Device = new System.Windows.Forms.PictureBox();
            this.cb_ListSpecs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_ListDetail = new System.Windows.Forms.DataGridView();
            this.Specs = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Update.Image = global::DeviceManage.Properties.Resources.Save;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(407, 22);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 53);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "SAVE";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btn_Update, "LƯU");
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // ptb_Device
            // 
            this.ptb_Device.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_Device.Location = new System.Drawing.Point(76, 2);
            this.ptb_Device.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptb_Device.Name = "ptb_Device";
            this.ptb_Device.Size = new System.Drawing.Size(228, 158);
            this.ptb_Device.TabIndex = 4;
            this.ptb_Device.TabStop = false;
            // 
            // cb_ListSpecs
            // 
            this.cb_ListSpecs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ListSpecs.FormattingEnabled = true;
            this.cb_ListSpecs.Location = new System.Drawing.Point(27, 286);
            this.cb_ListSpecs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ListSpecs.Name = "cb_ListSpecs";
            this.cb_ListSpecs.Size = new System.Drawing.Size(321, 27);
            this.cb_ListSpecs.TabIndex = 6;
            this.cb_ListSpecs.SelectedIndexChanged += new System.EventHandler(this.cb_ListSpecs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên thông số:";
            // 
            // dtgv_ListDetail
            // 
            this.dtgv_ListDetail.AllowDrop = true;
            this.dtgv_ListDetail.AllowUserToAddRows = false;
            this.dtgv_ListDetail.AllowUserToResizeColumns = false;
            this.dtgv_ListDetail.AllowUserToResizeRows = false;
            this.dtgv_ListDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ListDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Specs,
            this.Description});
            this.dtgv_ListDetail.Location = new System.Drawing.Point(407, 83);
            this.dtgv_ListDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_ListDetail.Name = "dtgv_ListDetail";
            this.dtgv_ListDetail.RowHeadersWidth = 51;
            this.dtgv_ListDetail.RowTemplate.Height = 29;
            this.dtgv_ListDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_ListDetail.Size = new System.Drawing.Size(602, 381);
            this.dtgv_ListDetail.TabIndex = 8;
            this.dtgv_ListDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListDetail_CellClick);
            this.dtgv_ListDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListDetail_CellValueChanged);
            // 
            // Specs
            // 
            this.Specs.DataPropertyName = "Id";
            this.Specs.FillWeight = 40F;
            this.Specs.HeaderText = "Thông số";
            this.Specs.MinimumWidth = 100;
            this.Specs.Name = "Specs";
            this.Specs.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Giá trị";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(27, 358);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(321, 54);
            this.txt_Description.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nội dung:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(703, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 49);
            this.label3.TabIndex = 12;
            this.label3.Text = "CHI TIẾT THIẾT BỊ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.txtDeviceName);
            this.panel1.Controls.Add(this.txt_Description);
            this.panel1.Controls.Add(this.cb_ListSpecs);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ptb_Device);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 434);
            this.panel1.TabIndex = 13;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDeviceName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(76, 187);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(228, 27);
            this.txtDeviceName.TabIndex = 11;
            // 
            // DeviceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1021, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgv_ListDetail);
            this.Controls.Add(this.btn_Update);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1239, 700);
            this.Name = "DeviceDetail";
            this.Text = "DeviceDetail";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox ptb_Device;
        private System.Windows.Forms.ComboBox cb_ListSpecs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_ListDetail;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Specs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDeviceName;
    }
}