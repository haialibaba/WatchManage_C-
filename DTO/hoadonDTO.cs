using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace DTO
{
    public class hoadonDTO
    {
        public int IdNV { get; set; }
        public string PhoneKH { get; set; }
        public int IdHD { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string NameSP { get; set; }

        public int Quantity { get; set; }
        public int Prices { get; set; }
        public hoadonDTO()
        {
            IdNV = 0;
            PhoneKH = null;
            IdHD = 0;
            NameSP = null;
            Quantity = 0;
            Prices = 0;
            UpdatedAt = DateTime.Now;

        }
        public hoadonDTO(int idNV, string phoneKH, int idHD, DateTime updatedAt, string nameSP, int quantity, string prices)
        {
            IdNV = idNV;
            PhoneKH = phoneKH;
            IdHD = idHD;
            UpdatedAt = updatedAt;
            NameSP = nameSP;
            Quantity = quantity;
            Prices = Prices;
        }
    }
}
