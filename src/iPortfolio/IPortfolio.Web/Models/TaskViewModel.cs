﻿using System;

namespace IPortfolio.Web.Controllers
{
    public class TaskViewModel
    {
		public int TaskID { get; set; }
		public int ParentID { get; set; }
		public int ProjectID { get; set; }
		public int PhaseID { get; set; }
		public string TaskName { get; set; }
		public string Desription { get; set; }
		public string Assignee { get; set; }
		public int Priority { get; set; }
		public decimal EstimatedTime { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime DueDate { get; set; }
		public string Tag { get; set; }
		public int Status { get; set; }
		public int DonePercent { get; set; }
		public DateTime CloseDate { get; set; }
		public string AssignBy { get; set; }
		public DateTime CreatedTime { get; set; }
    }
}