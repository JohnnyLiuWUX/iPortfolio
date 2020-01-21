using System;

namespace IPortfolio.Web.Controllers
{
    public class AuditViewModel
    {
		public int AuditID { get; set; }
		public int ProjectID { get; set; }
		public int Status { get; set; }
		public string DueDate { get; set; }
		public string Auditor { get; set; }
		public DateTime CreatedTime { get; set; }
    }
}