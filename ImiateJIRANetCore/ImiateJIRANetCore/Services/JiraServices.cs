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
    public class JiraServices: IJiraServices
    {
        private readonly string _dbconect;

        public JiraServices(IConfiguration configuration)
        {
            _dbconect = configuration["ConnectionStrings:DefaultConnection"];
        }

        public bool AddJiraOrders(List<JiraOrder> jiras)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_dbconect))
                {

                    string strSql = @"INSERT INTO JiraOrder(JiraID,JiraTitle,JiraStatus,Jiradescription,CreatedUser,CreatedDate,UpdateUser,UpdateDate) 
                                      VALUES (@JiraID,@JiraTitle,'NS',@Jiradescription,@CreatedUser,GetDate(),@UpdateUser,GetDate()); ";

                    conn.Execute(strSql, jiras);

                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<JiraOrder> GetJiraOrders()
        {
            List<JiraOrder> result = new List<JiraOrder>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_dbconect))
                {

                    string strSql = "SELECT * FROM JiraOrder ";

                     result = conn.Query<JiraOrder>(strSql).ToList();

                }
            }
            catch (Exception ex)
            {
                return null;
            }


            return result;
        }

        public JiraOrder GetJiraOrders(string key)
        {
            JiraOrder result = new JiraOrder();
            try
            {
                using (SqlConnection conn = new SqlConnection(_dbconect))
                {

                    string strSql = "SELECT * FROM JiraOrder where ID=@JiraID";

                    result = conn.Query<JiraOrder>(strSql,new { JiraID=key }).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                return null;
            }


            return result;
        }

        public bool UpdateJiraOrders(JiraOrder jira)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_dbconect))
                {

                    string strSql = @"Update JiraOrder
                                      set JiraTitle=@JiraTitle,JiraStatus=@JiraStatus,Jiradescription=@Jiradescription
                                         ,UpdateUser=@UpdateUser,UpdateDate=GetDate()
                                      where ID=@ID";

                    conn.Execute(strSql, jira);

                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
