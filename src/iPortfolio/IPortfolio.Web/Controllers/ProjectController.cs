/**
 * Auto Create By Code Magic 2020-01-08 12:44:53
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using IPortfolio.BLL;
using IPortfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPortfolio.Web.Controllers
{
    public class ProjectController : Controller
    {
		public class ProjectViewModel
		{
			public int ProjectID { get; set; }
			public int OrgID { get; set; }
			public string ProjectName { get; set; }
			public string Tag { get; set; }
			public string Description { get; set; }
			public string CostCenter { get; set; }
			public string StartDate { get; set; }
			public string PlanGoLiveDate { get; set; }
			public string DueDate { get; set; }
			public string CreatedBy { get; set; }
			public DateTime CreateTime { get; set; }
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
			public int Status { get; set; }
			public decimal Saving { get; set; }
			public decimal EstimatedTime { get; set; }
			public decimal InternalBudget { get; set; }
			public decimal ExternalBudget { get; set; }
			public decimal ROI { get; set; }
			public string Phase { get; set; }
			public string CloseDate { get; set; }
			public decimal ActualTime { get; set; }
			public decimal ActualInternalCost { get; set; }
			public decimal ActualExternalCost { get; set; }
			public decimal ActualSaving { get; set; }
		}

        private readonly ProjectBll projectBll = new ProjectBll();

        public ActionResult Index()
        {
            ViewBag.ProjectList = projectBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(ProjectViewModel model)
		{
			try
            {
				ProjectModel projectModel = new ProjectModel();
				projectModel.OrgID = model.OrgID;
				projectModel.ProjectName = model.ProjectName;
				projectModel.Tag = model.Tag;
				projectModel.Description = model.Description;
				projectModel.CostCenter = model.CostCenter;
				projectModel.StartDate = model.StartDate;
				projectModel.PlanGoLiveDate = model.PlanGoLiveDate;
				projectModel.DueDate = model.DueDate;
				projectModel.CreatedBy = model.CreatedBy;
				projectModel.CreateTime = model.CreateTime;
				projectModel.Department = model.Department;
				projectModel.FunctionGroup = model.FunctionGroup;
				projectModel.Workcell = model.Workcell;
				projectModel.PM = model.PM;
				projectModel.SME = model.SME;
				projectModel.Source = model.Source;
				projectModel.Quarter = model.Quarter;
				projectModel.Type = model.Type;
				projectModel.Scope = model.Scope;
				projectModel.Sponsor = model.Sponsor;
				projectModel.IsMajor = model.IsMajor;
				projectModel.ARSNo = model.ARSNo;
				projectModel.Status = model.Status;
				projectModel.Saving = model.Saving;
				projectModel.EstimatedTime = model.EstimatedTime;
				projectModel.InternalBudget = model.InternalBudget;
				projectModel.ExternalBudget = model.ExternalBudget;
				projectModel.ROI = model.ROI;
				projectModel.Phase = model.Phase;
				projectModel.CloseDate = model.CloseDate;
				projectModel.ActualTime = model.ActualTime;
				projectModel.ActualInternalCost = model.ActualInternalCost;
				projectModel.ActualExternalCost = model.ActualExternalCost;
				projectModel.ActualSaving = model.ActualSaving;

				projectBll.Insert(projectModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int projectID)
        {
            ViewBag.ProjectModel = projectBll.GetModel(projectID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(ProjectViewModel model)
		{
			try
            {
				ProjectModel projectModel = projectBll.GetModel(model.ProjectID);
				projectModel.OrgID = model.OrgID;
				projectModel.ProjectName = model.ProjectName;
				projectModel.Tag = model.Tag;
				projectModel.Description = model.Description;
				projectModel.CostCenter = model.CostCenter;
				projectModel.StartDate = model.StartDate;
				projectModel.PlanGoLiveDate = model.PlanGoLiveDate;
				projectModel.DueDate = model.DueDate;
				projectModel.CreatedBy = model.CreatedBy;
				projectModel.CreateTime = model.CreateTime;
				projectModel.Department = model.Department;
				projectModel.FunctionGroup = model.FunctionGroup;
				projectModel.Workcell = model.Workcell;
				projectModel.PM = model.PM;
				projectModel.SME = model.SME;
				projectModel.Source = model.Source;
				projectModel.Quarter = model.Quarter;
				projectModel.Type = model.Type;
				projectModel.Scope = model.Scope;
				projectModel.Sponsor = model.Sponsor;
				projectModel.IsMajor = model.IsMajor;
				projectModel.ARSNo = model.ARSNo;
				projectModel.Status = model.Status;
				projectModel.Saving = model.Saving;
				projectModel.EstimatedTime = model.EstimatedTime;
				projectModel.InternalBudget = model.InternalBudget;
				projectModel.ExternalBudget = model.ExternalBudget;
				projectModel.ROI = model.ROI;
				projectModel.Phase = model.Phase;
				projectModel.CloseDate = model.CloseDate;
				projectModel.ActualTime = model.ActualTime;
				projectModel.ActualInternalCost = model.ActualInternalCost;
				projectModel.ActualExternalCost = model.ActualExternalCost;
				projectModel.ActualSaving = model.ActualSaving;

				projectBll.Update(projectModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int projectID)
        {
			try
            {
				ProjectModel model = projectBll.GetModel(projectID);
				if (model != null)
				{
					projectBll.Delete(projectID);
				}
				else
				{
					return Json(new { code = 500, msg = "parms is null" });
				}
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
        }
    }
}
