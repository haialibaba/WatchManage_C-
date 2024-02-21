using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PermissionsDTO
    {
        public string name { get; set; }
        public string urlmatch { get; set; }
        public PermissionsDTO(string name, string urlmatch)
        {
            this.name = name;
            this.urlmatch = urlmatch;
        }
    }
}
