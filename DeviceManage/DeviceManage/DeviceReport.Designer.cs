
namespace DeviceManage
{
    partial class DeviceReport
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
            this.dtgv_ListDeviceError = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radSerious = new System.Windows.Forms.RadioButton();
            this.radVerySerious = new System.Windows.Forms.RadioButton();
            this.radNomal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cb_ErrorDevice = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnBaoTri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Option1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDeviceError)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_ListDeviceError
            // 
            this.dtgv_ListDeviceError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_ListDeviceError.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListDeviceError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListDeviceError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DeviceName,
            this.Note,
            this.Severity,
            this.Solution,
            this.Fix,
            this.Option1});
            this.dtgv_ListDeviceError.Location = new System.Drawing.Point(15, 223);
            this.dtgv_ListDeviceError.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_ListDeviceError.MultiSelect = false;
            this.dtgv_ListDeviceError.Name = "dtgv_ListDeviceError";
            this.dtgv_ListDeviceError.RowHeadersWidth = 51;
            this.dtgv_ListDeviceError.RowTemplate.Height = 24;
            this.dtgv_ListDeviceError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_ListDeviceError.Size = new System.Drawing.Size(1226, 438);
            this.dtgv_ListDeviceError.TabIndex = 0;
            this.dtgv_ListDeviceError.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListDeviceError_CellClick);
            this.dtgv_ListDeviceError.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_ListDeviceError_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnComplete);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSolution);
            this.panel1.Controls.Add(this.btnBaoTri);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbRoom);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.cb_ErrorDevice);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 202);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giải pháp:";
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(707, 66);
            this.txtSolution.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(329, 126);
            this.txtSolution.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phòng:";
            // 
            // cbRoom
            // 
            this.cbRoom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(491, 18);
            this.cbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(192, 27);
            this.cbRoom.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.radSerious);
            this.panel2.Controls.Add(this.radVerySerious);
            this.panel2.Controls.Add(this.radNomal);
            this.panel2.Location = new System.Drawing.Point(389, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 126);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phân loại hư hại:";
            // 
            // radSerious
            // 
            this.radSerious.AutoSize = true;
            this.radSerious.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSerious.ForeColor = System.Drawing.Color.DarkOrange;
            this.radSerious.Location = new System.Drawing.Point(8, 54);
            this.radSerious.Margin = new System.Windows.Forms.Padding(4);
            this.radSerious.Name = "radSerious";
            this.radSerious.Size = new System.Drawing.Size(137, 23);
            this.radSerious.TabIndex = 6;
            this.radSerious.TabStop = true;
            this.radSerious.Text = "Nghiêm trọng";
            this.radSerious.UseVisualStyleBackColor = true;
            // 
            // radVerySerious
            // 
            this.radVerySerious.AutoSize = true;
            this.radVerySerious.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVerySerious.ForeColor = System.Drawing.Color.Red;
            this.radVerySerious.Location = new System.Drawing.Point(8, 85);
            this.radVerySerious.Margin = new System.Windows.Forms.Padding(4);
            this.radVerySerious.Name = "radVerySerious";
            this.radVerySerious.Size = new System.Drawing.Size(167, 23);
            this.radVerySerious.TabIndex = 7;
            this.radVerySerious.TabStop = true;
            this.radVerySerious.Text = "Rất nghiêm trọng";
            this.radVerySerious.UseVisualStyleBackColor = true;
            // 
            // radNomal
            // 
            this.radNomal.AutoSize = true;
            this.radNomal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNomal.ForeColor = System.Drawing.Color.Yellow;
            this.radNomal.Location = new System.Drawing.Point(8, 23);
            this.radNomal.Margin = new System.Windows.Forms.Padding(4);
            this.radNomal.Name = "radNomal";
            this.radNomal.Size = new System.Drawing.Size(61, 23);
            this.radNomal.TabIndex = 5;
            this.radNomal.TabStop = true;
            this.radNomal.Text = "Nhẹ";
            this.radNomal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mô tả lỗi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thiết bị:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(28, 101);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(329, 91);
            this.txtNote.TabIndex = 2;
            // 
            // cb_ErrorDevice
            // 
            this.cb_ErrorDevice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ErrorDevice.FormattingEnabled = true;
            this.cb_ErrorDevice.Location = new System.Drawing.Point(182, 18);
            this.cb_ErrorDevice.Margin = new System.Windows.Forms.Padding(4);
            this.cb_ErrorDevice.Name = "cb_ErrorDevice";
            this.cb_ErrorDevice.Size = new System.Drawing.Size(175, 27);
            this.cb_ErrorDevice.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "DeviceName";
            this.DeviceName.HeaderText = "Thiết bị lỗi";
            this.DeviceName.MinimumWidth = 6;
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Mô tả lỗi";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Severity
            // 
            this.Severity.DataPropertyName = "Severity";
            this.Severity.FillWeight = 60F;
            this.Severity.HeaderText = "Mức độ nghiêm trọng";
            this.Severity.MinimumWidth = 6;
            this.Severity.Name = "Severity";
            this.Severity.ReadOnly = true;
            // 
            // Solution
            // 
            this.Solution.DataPropertyName = "Solution";
            this.Solution.FillWeight = 150F;
            this.Solution.HeaderText = "Giải pháp";
            this.Solution.MinimumWidth = 6;
            this.Solution.Name = "Solution";
            this.Solution.ReadOnly = true;
            // 
            // Fix
            // 
            this.Fix.DataPropertyName = "Status";
            this.Fix.FillWeight = 60F;
            this.Fix.HeaderText = "Trạng thái bảo trì";
            this.Fix.MinimumWidth = 6;
            this.Fix.Name = "Fix";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 60F;
            this.dataGridViewImageColumn1.HeaderText = "Ngưng bảo trì";
            this.dataGridViewImageColumn1.Image = global::DeviceManage.Properties.Resources.remove;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 133;
            // 
            // btnComplete
            // 
            this.btnComplete.Image = global::DeviceManage.Properties.Resources.success;
            this.btnComplete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplete.Location = new System.Drawing.Point(1049, 62);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(174, 50);
            this.btnComplete.TabIndex = 14;
            this.btnComplete.Text = "HOÀN THÀNH";
            this.btnComplete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.Image = global::DeviceManage.Properties.Resources.settings__1_;
            this.btnBaoTri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoTri.Location = new System.Drawing.Point(1049, 135);
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(174, 50);
            this.btnBaoTri.TabIndex = 11;
            this.btnBaoTri.Text = "BẢO TRÌ NGAY";
            this.btnBaoTri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoTri.UseVisualStyleBackColor = true;
            this.btnBaoTri.Click += new System.EventHandler(this.btnBaoTri_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DeviceManage.Properties.Resources.settings;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1414, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "BẢO TRÌ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Option1
            // 
            this.Option1.FillWeight = 60F;
            this.Option1.HeaderText = "Ngưng bảo trì";
            this.Option1.Image = global::DeviceManage.Properties.Resources.remove;
            this.Option1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Option1.MinimumWidth = 6;
            this.Option1.Name = "Option1";
            this.Option1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Option1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeviceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_ListDeviceError);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeviceReport";
            this.Text = "DeviceReport";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListDeviceError)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ListDeviceError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cb_ErrorDevice;
        private System.Windows.Forms.Button btnBaoTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radSerious;
        private System.Windows.Forms.RadioButton radVerySerious;
        private System.Windows.Forms.RadioButton radNomal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solution;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fix;
        private System.Windows.Forms.DataGridViewImageColumn Option1;
        private System.Windows.Forms.Button btnComplete;
    }
}