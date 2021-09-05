using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyService.Models
{
    public class DepartMent
    {
      public int DepartNo { get; set; }

      public string DepartName { get; set; }

      public string DepartEgName { get; set; }

      public byte TranStatus { get; set; }

      public int SystemUser { get; set; }

      public DateTime SystemTime { get; set; }

    }
}