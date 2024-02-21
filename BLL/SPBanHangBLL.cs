using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SPBanHangBLL
    {
        public static List<SPBanHangDTO> GetData()
        {
            return SPBanHangDAL.GetData();
        }
    }
}
