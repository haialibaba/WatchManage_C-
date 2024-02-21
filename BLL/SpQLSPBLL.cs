using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SpQLSPBLL
    {
        public static List<SpQLSPDTO> GetData()
        {
            return SpQLSPDAL.GetData();
        }

        public static bool UpdateData(SpQLSPDTO product)
        {
            return SpQLSPDAL.UpdateData(product);
        }
        public static List<SpQLSPDTO> GetDatacbbType()
        {
            return SpQLSPDAL.GetDatacbbType();
        }

         public static List<SpQLSPDTO> GetDatacbbProducer()
        {
            return SpQLSPDAL.GetDatacbbProducer();
        }




    }
}
