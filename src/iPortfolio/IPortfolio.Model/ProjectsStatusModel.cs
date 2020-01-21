using System;

namespace IPortfolio.Model
{
    public class ProjectsStatusModel
    {
		public int ProjectID { get; set; }
		public DateTime ReportDate { get; set; }
		public string Phase { get; set; }
		public DateTime? DueDate { get; set; }
		public int? DonePercent { get; set; }
		public int? SpendHour { get; set; }
		public string SpendingRemark { get; set; }
    }
}