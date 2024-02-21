using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string phone;
        public string pass;
        public string name;
        public DateTime createdAt;
        public DateTime updatedAt;
        public int status;
        public int type;
        public NhanVienDTO()
        {
            phone = null;
            pass = null;
            name = null;
            createdAt = DateTime.Now;
            updatedAt = DateTime.Now;
            status = 1;
            type = 1;
        }

        public NhanVienDTO(string phone, string pass, string name, DateTime createdAt, DateTime updatedAt, int status, int type)
        {
            this.phone = phone;
            this.pass = pass;
            this.name = name;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.status = status;
            this.type = type;
        }

        public string getPhone { get => phone; set => phone = value; }
        public string getPass { get => pass; set => pass = value; }
        public string getName { get => name; set => name = value; }
        public DateTime getCreatedAt() { return createdAt; }
        public DateTime getUpdatedAt() { return updatedAt; }
    }
}
