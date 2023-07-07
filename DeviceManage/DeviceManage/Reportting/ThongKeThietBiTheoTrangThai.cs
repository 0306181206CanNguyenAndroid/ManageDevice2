using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManage.Reportting
{
    public class ThongKeThietBiTheoTrangThai

    {
        public string DeviceName { get; set; }
        public string Device_TypeName { get; set; }
        public string Device_SpecsName { get; set; }
        public string RoomName { get; set; }

        public string ErrorName { get; set; }
        public string ErrorDescription { get; set; } //mô tả lỗi

        public string Remediation { get; set; } //hướng khắc phục
    }
}
