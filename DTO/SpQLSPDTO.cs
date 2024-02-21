using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SpQLSPDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string Origin { get; set; }

        public int Prices { get; set; }

        public int Quantity { get; set; }

        public string Image { get; set; }

        public string producer { get; set; }

        public SpQLSPDTO()
        {
            Id = 0;
            Name = null;
            Origin = null;
            Type = null;
            UpdatedAt = DateTime.Now;
            Prices = 0;
            Quantity = 0;
            Image = null;
            producer = null;
        }
        public SpQLSPDTO(int id, string name, string type, string origin,  DateTime updatedAt, int prices,int quantity, string image, string Producer)
        {
            Id = id;
            Name = name;
            Type = type;
            Origin = origin;
            UpdatedAt = updatedAt;
            Prices = prices;
            Quantity = quantity;
            Image = image;
            producer = Producer;
        }
    }
}
