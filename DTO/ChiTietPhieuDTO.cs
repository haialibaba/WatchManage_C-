using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuDTO
    {
        public string product_name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public double intoMoney { get; set; }
        public ChiTietPhieuDTO()
        {

        }
        public ChiTietPhieuDTO(string product_name, double price, int quantity, double intoMoney)
        {
            this.product_name = product_name;
            this.price = price;
            this.quantity = quantity;
            this.intoMoney = intoMoney;
        }
    }
}
