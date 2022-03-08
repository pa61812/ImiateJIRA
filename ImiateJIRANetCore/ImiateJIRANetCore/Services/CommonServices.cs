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
    public class CommonServices : ICommonServices
    {
        private readonly string _dbconect;
        public CommonServices(IConfiguration configuration)
        {
            _dbconect = configuration["ConnectionStrings:DefaultConnection"];
        }
        public List<SelectListItem> GetListItems(string codetype)
        {
            using (SqlConnection dbconn = new SqlConnection(_dbconect))
            {
                dbconn.Open();
                try
                {

                    string strsql = @"select SystemCode ,CodeName from SystemCode where CodeType= @CodeType";
                    var result = dbconn.Query<SelectListItem>(strsql, new { CodeType = codetype }).ToList();

                    dbconn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    dbconn.Close();
                 
                    return null;
                }

            }
        }
    }
}
