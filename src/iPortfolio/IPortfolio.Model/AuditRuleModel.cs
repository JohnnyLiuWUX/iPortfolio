using System;

namespace IPortfolio.Model
{
    public class AuditRuleModel
    {
		public int AuditRuleID { get; set; }
		public string Area { get; set; }
		public string Rule { get; set; }
		public int? Status { get; set; }
    }
}