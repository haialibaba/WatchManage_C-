using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string Phone;
        public string Name;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;
        public int ToTal;
        public int Status;
        public KhachHangDTO()
        {
            Phone = null;
            Name = null;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            ToTal = 0;
            Status = 1;
        }

        public KhachHangDTO(string Phone, string Name, DateTime CreatedAt, DateTime UpdatedAt, int ToTal, int Status)
        {
            this.Phone = Phone;
            this.Name = Name;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.ToTal = ToTal;
            this.Status = Status;
        }

        public string getPhone { get; set; }    
        public string getName { get; set; } 
        public int getToTal() { return ToTal; } 
        public int getStatus() { return Status; }
        public DateTime getCreatedAt() { return CreatedAt; }    
        public DateTime getUpdatedAt() { return UpdatedAt; }    
    }
}
