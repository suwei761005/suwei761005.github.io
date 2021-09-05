using System;
using Dapper;
using System.Collections.Generic;
using CompanyService.Models;
using System.Data.SqlClient;

namespace CompanyService
{
    public class DepartMentService
    {
        //資料庫連線
        private Connection con = new Connection();

        public List<DepartMent> Query(string inputValue)
        {
            using (var cn = new SqlConnection(con.Company))
            {
                cn.Open();
                string sql = @"EXEC DepartMentQuery @InputValue";
                List<DepartMent> departMents = cn.Query<DepartMent>(sql, new { InputValue = inputValue }).AsList();
                return departMents;
            }

                
        }
    }
}
