using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoHanhDTO
    {
        public int Id { get; set; }

        public  int ProductId {get;set;}

        public int Time { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public BaoHanhDTO()
        {
            DateTime currentTime = DateTime.Now;
            CreatedAt = currentTime;
            UpdatedAt = currentTime;
        }
    }
}
