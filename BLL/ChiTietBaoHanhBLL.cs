using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ChiTietBaoHanhBLL
    {

        public static List<ChiTietBaoHanhDTO> GetData()
        {
            return ChiTietBaoHanhDAL.GetData();
        }

        public static bool UpdateData(ChiTietBaoHanhDTO detail)
        {
            return ChiTietBaoHanhDAL.UpdateData(detail);
        } 
    }
}
