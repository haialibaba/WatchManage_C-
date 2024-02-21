using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeKhachHangDTO
    {
        public string id { get; set; }  
        public string name { get; set; }
        public string soluongdon { get; set; }
        public string tongtien { get; set; }
        public ThongKeKhachHangDTO(string id, string name, string soluongdon, string tongtien)
        {
            this.id = id;
            this.name = name;
            this.soluongdon = soluongdon;
            this.tongtien = tongtien;
        }
    }
}
