using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CheckedPermissionsDTO
    {
        public string idDanhMucNhanVien {get; set;}
        public string idQuyen { get; set;}
        public CheckedPermissionsDTO(string idDanhMucNhanVien, string idQuyen)
        {
            this.idDanhMucNhanVien = idDanhMucNhanVien;
            this.idQuyen = idQuyen;
        }
    }
}
