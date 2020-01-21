using System;

namespace IPortfolio.Model
{
    public class ProjectModel
    {
		public int ProjectID { get; set; }
		public int? OrgID { get; set; }
		public string ProjectName { get; set; }
		public string Tag { get; set; }
		public string Description { get; set; }
		public string CostCenter { get; set; }
		public string StartDate { get; set; }
		public string PlanGoLiveDate { get; set; }
		public string DueDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreateTime { get; set; }
		public string Department { get; set; }
		public string FunctionGroup { get; set; }
		public string Workcell { get; set; }
		public string PM { get; set; }
		public string SME { get; set; }
		public string Source { get; set; }
		public string Quarter { get; set; }
		public string Type { get; set; }
		public string Scope { get; set; }
		public string Sponsor { get; set; }
		public string IsMajor { get; set; }
		public string ARSNo { get; set; }
		public int? Status { get; set; }
		public decimal? Saving { get; set; }
		public decimal? EstimatedTime { get; set; }
		public decimal? InternalBudget { get; set; }
		public decimal? ExternalBudget { get; set; }
		public decimal? ROI { get; set; }
		public string Phase { get; set; }
		public string CloseDate { get; set; }
		public decimal? ActualTime { get; set; }
		public decimal? ActualInternalCost { get; set; }
		public decimal? ActualExternalCost { get; set; }
		public decimal? ActualSaving { get; set; }
    }
}