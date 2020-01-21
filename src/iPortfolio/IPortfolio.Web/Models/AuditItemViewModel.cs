using System;

namespace IPortfolio.Web.Controllers
{
    public class AuditItemViewModel
    {
		public int ItemID { get; set; }
		public int AuditID { get; set; }
		public int AuditRuleID { get; set; }
		public int Status { get; set; }
		public string Evidence { get; set; }
		public string Comments { get; set; }
    }
}