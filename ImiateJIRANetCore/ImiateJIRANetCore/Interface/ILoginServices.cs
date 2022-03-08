using ImiateJIRANetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImiateJIRANetCore.Interface
{
    public interface ILoginServices
    {
        public CommonModel Login(LoginModel login);

        public void LogOut();
    }
}
