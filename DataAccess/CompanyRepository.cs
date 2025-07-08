using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileShopProject.DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace MobileShopProject.DataAccess
{
    internal class CompanyRepository
    {
        public class Company
        {
            public int CompId { get; set; }
            public string CompName { get; set; }
        }

        public static int GetNextId()
        {
            string sql = "SELECT ISNULL(MAX(CompId), 0) + 1 FROM Company";
            int nextId = Convert.ToInt32(DbHelper.ExecuteScalar(sql));
            return nextId;
        }

        public static int AddCompany(Company company)
        {
            var cmd = "INSERT INTO Company (CompId, CompName) VALUES (@compId, @compName)";

            return DbHelper.ExecuteNonQuery(cmd,
                new SqlParameter("@compId", company.CompId),
                new SqlParameter("@compName", company.CompName));
        }

        public static DataTable GetCompanies()
        {
            string sql = "SELECT CompId, CompName FROM Company ORDER BY CompName";
            return DbHelper.ExecuteQuery(sql);
        }
    }
}
