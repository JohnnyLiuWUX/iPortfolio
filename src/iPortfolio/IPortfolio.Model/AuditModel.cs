using System;

namespace IPortfolio.Model
{
    public class AuditModel
    {
		public int AuditID { get; set; }
		public int? ProjectID { get; set; }
		public int? Status { get; set; }
		public DateTime? DueDate { get; set; }
		public string Auditor { get; set; }
		public DateTime? CreatedTime { get; set; }
    }
}