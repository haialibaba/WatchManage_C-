using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BaoHanhBLL
    {
        public static List<BaoHanhDTO> GetData()
        {
            return BaoHanhDAL.GetData();
        }

        public static string AddData(BaoHanhDTO maintain, List<BaoHanhDTO> maintains)
        {
            if (maintain.Time <= 0)
            {
                return "required_time";
            }

            foreach(BaoHanhDTO item in maintains)
            {
                if(item.ProductId == maintain.ProductId)
                {
                    return "duplicate";
                }
            }

          

            if (BaoHanhDAL.AddData(maintain) == true)
            {
                return "success";
            }
            else
            {
                return "mysql_error";
            }
        }

        public static bool DeleteData(int id)
        {
            return BaoHanhDAL.DeleteData(id);
        }

        public static string UpdateData(BaoHanhDTO maintain)
        {
            if (maintain.Time <= 0)
            {
                return "required_time";
            }

            if (BaoHanhDAL.UpdateData(maintain) == true)
            {
                return "success";
            }
            else
            {
                return "mysql_error";
            }
        }
    }
}
