using DTO.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO.Model
{
    public class DeviceDetailModel : DeviceDetailModelBase
    {
        
        public DeviceDetailModel() { }

        public string DataType { get; set; }
        public int SpecsId { get; set; }
    }
}
