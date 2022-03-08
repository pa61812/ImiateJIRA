using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImiateJIRANetCore.Models
{
    public class JiraOrder
    {
        public string ID { get; set; }
        public string JiraID { get; set; }

        public string JiraTitle { get; set; }

        public string JiraStatus { get; set; }

        public string Jiradescription { get; set; }

        public string CreatedUser { get; set; }

        public string CreatedDate { get; set; }

        public string UpdateUser { get; set; }

        public string UpdateDate { get; set; }
    }
}
