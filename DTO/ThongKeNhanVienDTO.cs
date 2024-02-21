using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeNhanVienDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string soluongdonhang { get; set; }
        public ThongKeNhanVienDTO(string id, string name, string soluongdonhang)
        {
            this.id = id;
            this.name = name;
            this.soluongdonhang = soluongdonhang;
        }
    }
}
