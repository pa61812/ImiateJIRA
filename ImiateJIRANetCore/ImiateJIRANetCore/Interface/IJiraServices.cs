using ImiateJIRANetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImiateJIRANetCore.Interface
{
    public interface IJiraServices
    {
        public List<JiraOrder> GetJiraOrders();

        public JiraOrder GetJiraOrders(string key);

        public bool AddJiraOrders(List<JiraOrder> jiras);

        public bool UpdateJiraOrders(JiraOrder jira);
    }
}
