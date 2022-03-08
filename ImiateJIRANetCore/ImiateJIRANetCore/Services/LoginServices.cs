using Dapper;
using ImiateJIRANetCore.Interface;
using ImiateJIRANetCore.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ImiateJIRANetCore.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly string _dbconect;

        public static string JiraUser="";
        public LoginServices(IConfiguration configuration)
        {
            _dbconect= configuration["ConnectionStrings:DefaultConnection"];
        }

        public CommonModel Login(LoginModel login)
        {
            CommonModel result = new CommonModel();
            try
            {            
                using (SqlConnection conn = new SqlConnection(_dbconect))
                {

                    string strSql = "SELECT Count(*) FROM JiraUser WHERE UserId = @strAccount and UserPass=@strPass";

                    var user = conn.Query<int>(strSql, login).FirstOrDefault();

                    if (user > 0)
                    {
                        JiraUser = login.strAccount;
                        result.result = true;
                    }
                    else
                    {
                        result.result = false;
                        result.erroMessage = "未找到帳密，請柬查帳密是否錯誤";
                    }
                }
            }
            catch (Exception ex)
            {
                result.result = false;
                result.erroMessage = "未找到帳密，請柬查帳密是否錯誤";
            }
          

            return result;
        }


        public void LogOut()
        {
            JiraUser = "";
        }
    }
}
