using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietBaoHanhDTO
    {
        public int Id { get; set; }
        public int DetailProductId { get; set; }
        public string CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime OutOfDate { get; set; }

        public int Status { get; set; }

        public ChiTietBaoHanhDTO()
        {
            DateTime currentTime = DateTime.Now;
            CreatedAt = currentTime;
        }
    }
}
