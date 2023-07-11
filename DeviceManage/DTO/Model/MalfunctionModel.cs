using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class MalfunctionModel : MalfunctionModelBase
    {
        public MalfunctionModel() { }
        public string TeacherName { get; set; }
        public string DeviceName { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public List<DeviceErrorModel> listError { get; set; }
    }
}
