using ImiateJIRANetCore.Interface;
using ImiateJIRANetCore.Models;
using ImiateJIRANetCore.Services;
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
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;

        private readonly ILoginServices _login;

        public LoginController(ILogger<LoginController> logger, ILoginServices login)
        {
            _logger = logger;
            _login = login;
        }

        [HttpPost("login")]
        public CommonModel Login([FromBody] LoginModel login)
        {
            CommonModel result = _login.Login(login);

            return result;
        }

        [HttpPost("logout")]
        public void LogOut()
        {
           _login.LogOut();     
        }
    }
}
