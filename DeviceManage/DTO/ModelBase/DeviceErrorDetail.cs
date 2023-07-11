using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelBase
{
    public class DeviceErrorDetailModelBase
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int? ErrorId { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int Severity { get; set; }
    }
}
