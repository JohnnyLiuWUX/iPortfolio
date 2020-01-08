/**
 * Auto Create By Code Magic 2020-01-08 11:27:10
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;

namespace IPortfolio.Model
{
    public class TaskModel
    {
		public int TaskID { get; set; }
		public int? ParentID { get; set; }
		public int? ProjectID { get; set; }
		public int? PhaseID { get; set; }
		public string TaskName { get; set; }
		public string Desription { get; set; }
		public string Assignee { get; set; }
		public int? Priority { get; set; }
		public decimal? EstimatedTime { get; set; }
		public string StartDate { get; set; }
		public string DueDate { get; set; }
		public string Tag { get; set; }
		public int? Status { get; set; }
		public int? DonePercent { get; set; }
		public string CloseDate { get; set; }
		public string AssignBy { get; set; }
		public DateTime? CreatedTime { get; set; }
    }
}