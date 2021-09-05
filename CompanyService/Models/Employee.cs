using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyService.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }

        public string EmpCode { get; set; }

        public string EmpName { get; set; }

        public int DepartNo { get; set; }

        public string Email { get; set; }

        public byte TranStatus { get; set; }

        public int SystemUser { get; set; }

        public DateTime SystemTime { get; set; }


    }
}