using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        public static List<string> _GetDataUrlMatch(string id)
        {
            return LoginDAL._GetDataUrlMatch(id);
        }
        public static List<string> _GetDataLeftMenu(string id)
        {
            return LoginDAL._GetDataLeftMenu(id);
        }
        public static List<LoginDTO> _GetDataLogin()
        {
            return LoginDAL._GetDataLogin();
        }
    }
}
