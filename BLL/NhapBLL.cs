using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhapBLL
    {
        public static List<NhapDTO> GetDataAction()
        {
            return NhapDAL.getDataNhap();
        }
    }
}
