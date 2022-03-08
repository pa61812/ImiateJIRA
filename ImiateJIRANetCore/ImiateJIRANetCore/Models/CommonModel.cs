using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImiateJIRANetCore.Models
{
    public class CommonModel
    {
        public bool result { get; set; }

        public string erroMessage { get; set; }
    }

    public class SelectListItem
    {
        public string codeName { get; set; }
        public string systemCode { get; set; }
    }
}
