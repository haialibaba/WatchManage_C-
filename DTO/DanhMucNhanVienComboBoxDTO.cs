using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucNhanVienComboBoxDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public DanhMucNhanVienComboBoxDTO(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
