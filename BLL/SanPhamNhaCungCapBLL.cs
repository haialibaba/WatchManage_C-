using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SanPhamNhaCungCapBLL
    {
        public static List<PProducerDTO> GetData()
        {
            return SanPhamNhaCungCapDAL.GetData();
        }

        public static string AddData(PProducerDTO pProducer)
        {
            if (pProducer.Name.Trim() == "" || pProducer.Name.Trim() == "Nhập tên sản phẩm" || pProducer.CategoryId == 0 || pProducer.Origin.Trim() == "Nhập xuất xứ" || pProducer.Origin.Trim() == "" || pProducer.Image == "" || pProducer.ProducerId == 0)
            {
                return "required";
            }

            if (SanPhamNhaCungCapDAL.AddData(pProducer) == true)
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
            return SanPhamNhaCungCapDAL.DeleteData(id);
        }

        public static string UpdateData(PProducerDTO pProducer)
        {
            if (pProducer.Name.Trim() == "" || pProducer.Name.Trim() == "Nhập tên sản phẩm" || pProducer.CategoryId == 0 || pProducer.Origin.Trim() == "Nhập xuất xứ" || pProducer.Origin.Trim() == "" || pProducer.Image == "" || pProducer.ProducerId == 0)
            {
                return "required";
            }

            if (SanPhamNhaCungCapDAL.UpdateData(pProducer))
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
