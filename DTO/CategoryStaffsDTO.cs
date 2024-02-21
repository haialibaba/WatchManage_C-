using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryStaffsDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public CategoryStaffsDTO(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
