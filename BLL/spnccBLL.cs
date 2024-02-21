using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class spnccBLL
    {
        public spnccBLL() { }
        public static List<spnccDTO> GetData()
        {
            return SpnccQLSPDAL.GetData();
        }
        public static List<spnccDTO> GetDatacbbType()
        {
            return SpnccQLSPDAL.GetDatacbbType();
        }

        public static bool AddData(spnccDTO cart)
        {
            return SpnccQLSPDAL.AddData(cart);
        }

        public static List<spnccDTO> GetDatacbb()
        {
            return SpnccQLSPDAL.GetDatacbb();
        }

        public static bool UpdateData(spnccDTO cart)
        {
            return SpnccQLSPDAL.UpdateData(cart);
        }

        public static bool AddDataSPC(List<spcDTO> spc)
        {
            return SpnccQLSPDAL.AddDataSPC(spc);
        }

    }
}
