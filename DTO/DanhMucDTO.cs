using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { set; get; }
        public DateTime UpdateAt { set; get; }
        public DanhMucDTO()
        {
            Id = 0;
            Name = "";
            CreateAt = DateTime.Now;
            UpdateAt = DateTime.Now; 
        }
        public DanhMucDTO(int id, string name, DateTime createAt, DateTime updateAt)
        {
            Id = id;
            Name = name;
            CreateAt = createAt;
            UpdateAt = updateAt;
        }
    }
}
