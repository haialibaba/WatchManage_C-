using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        public string product_name { set; get; }
        public Double prices { set; get; }
        public int quantity { set; get; }
        public DateTime createdAt { set; get; }
        public DateTime updatedAt { set; get; }
        public ChiTietPhieuNhapDTO()
        {

        }
        public ChiTietPhieuNhapDTO(string product_name, double prices, int quantity, DateTime createdAt, DateTime updatedAt)
        {
            this.product_name = product_name;
            this.prices = prices;
            this.quantity = quantity;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
        }
    }
}
