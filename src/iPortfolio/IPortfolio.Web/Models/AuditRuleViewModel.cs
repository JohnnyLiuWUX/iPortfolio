using System;

namespace IPortfolio.Web.Controllers
{
    public class AuditRuleViewModel
    {
		public int AuditRuleID { get; set; }
		public string Area { get; set; }
		public string Rule { get; set; }
		public int Status { get; set; }
    }
}