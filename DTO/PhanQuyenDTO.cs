using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyenDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string createAt { get; set; }
        public string updateAt { get; set; }
        public string status { get; set; }
        public PhanQuyenDTO(int id, string name, string createAt, string updateAt, string status)
        {
            this.id = id;
            this.name = name;
            this.createAt = createAt;
            this.updateAt = updateAt;
            this.status = status;
        }
    }
}
