using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyService
{
    public class Connection
    {
        private static string comstr = @"data source = DESKTOP-0HLCOUT\SQLEXPRESS; database=Company;Integrated Security = SSPI; persist security info=True;";
        public string Company { get { return comstr;  } }
    }
}
