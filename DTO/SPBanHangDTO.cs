using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SPBanHangDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string Origin { get; set; }

        public string Prices { get; set; }

        public string Image { get; set; }

        public string producer { get; set; }

        public SPBanHangDTO()
        {
            Id = 0;
            Name = null;
            Origin = null;
            Type = null;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Prices = null;
            Image = null;
            producer = null;
        }
        public SPBanHangDTO(int id, string name, string type, string origin, DateTime createdAt, DateTime updatedAt, string prices,string image,string Producer)
        {
            Id = id;
            Name = name;
            Type = type;
            Origin = origin;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Prices = Prices;
            Image = Image;
            Producer = producer;
        }
       

    }
  
}
