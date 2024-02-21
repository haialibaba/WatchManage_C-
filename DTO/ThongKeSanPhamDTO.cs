using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeSanPhamDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string prices { get; set; }  
        public string quantity { get; set; }

        public ThongKeSanPhamDTO(string id, string name, string prices, string quantity)
        {
            this.id = id;
            this.name = name;
            this.prices = prices;
            this.quantity = quantity;
        }
    }
}
