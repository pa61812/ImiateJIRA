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
    public class CommonController : ControllerBase
    {
        private readonly ILogger<CommonController> _logger;

        private readonly ICommonServices _common;

        public CommonController(ILogger<CommonController> logger, ICommonServices common)
        {
            _logger = logger;
            _common = common;
        }

        [HttpGet("getSelects")]
        public List<SelectListItem> GetSelects(string codeType)
        {
            return _common.GetListItems(codeType);
        }
    }
}
