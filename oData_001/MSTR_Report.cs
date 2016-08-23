using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace oData_001
{
    [DataServiceKey("Id")]
    public class MSTR_Report
    {
        public string Id { get; set; }
        public string ResportName { get; set; }
        public string Description { get; set; }
    }
}