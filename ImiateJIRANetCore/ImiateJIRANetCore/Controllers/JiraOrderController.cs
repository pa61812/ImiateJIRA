using ImiateJIRANetCore.Interface;
using ImiateJIRANetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImiateJIRANetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JiraOrderController : ControllerBase
    {
        private readonly ILogger<JiraOrderController> _logger;

        private readonly IJiraServices _jira;

        public JiraOrderController(ILogger<JiraOrderController> logger, IJiraServices jira)
        {
            _logger = logger;
            _jira = jira;
        }

        [HttpPost("getJiraOrder")]
        public List<JiraOrder> GetJiraOrder()
        {
            return _jira.GetJiraOrders();        
        }

        [HttpPost("addJiraOrder")]
        public bool AddJiraOrder(List<JiraOrder> jiras)
        {

            return _jira.AddJiraOrders(jiras);
        }

        [HttpPost("updateJiraOrder")]
        public bool UpdateJiraOrder(JiraOrder jira)
        {

            return _jira.UpdateJiraOrders(jira);
        }
    }
}
