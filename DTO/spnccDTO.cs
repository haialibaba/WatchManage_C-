using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DTO
{

    public class spnccDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string TypeID { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Origin { get; set; }

        public int Quantity { get; set; }

        public int Prices { get; set; }

        public string Image { get; set; }
        public int Producer { get; set; }

        public spnccDTO()
        {
            Id = 0;
            Name = null;
            Origin = null;
            Type = null;
            TypeID = null;
            UpdatedAt = DateTime.Now;
            Prices = 0;
            Quantity = 0;
            Image = null;
            Producer = 0;
        }
        public spnccDTO(int id, string name, string type,string typeID, string origin, DateTime updatedAt, int prices,int quantity, string image,int idproducer)
        {
            Id = id;
            Name = name;
            Type = type;
            TypeID = typeID;
            Origin = origin;
            UpdatedAt = updatedAt;
            Prices = prices;
            Quantity = quantity;
            Image = image;
            Producer = idproducer;
        }
    }


}
