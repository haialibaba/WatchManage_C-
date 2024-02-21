using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ShowChiTietPhieuNhapBLL
    {
        public static List<ChiTietPhieuDTO> getDataAction(int id)
        {
            return ShowChiTietPhieuNhapDAL.getDataChiTietPN(id);
        }
    }
}
