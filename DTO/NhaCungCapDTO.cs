using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string PhoneNumber { get; set; }

        public NhaCungCapDTO()
        {
            Id = 0;
            Name = null;
            Status = 0;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            PhoneNumber = null;
        }

        public NhaCungCapDTO(int id, string Name, int status, DateTime createdAt, DateTime updatedAt, string phoneNumber)
        {
            Id = id;
            Name = Name;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            PhoneNumber = phoneNumber;
        }
    }
}
