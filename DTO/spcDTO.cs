using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class spcDTO
    {
        public string Id { get; set; }
        public string Quantity { get; set; }

        public spcDTO()
        {
            Id = null;
            Quantity = null;
        }
        public spcDTO(string id, string quantity)
        {
            Id = id;
            Quantity = quantity;
        } 
        }
}
