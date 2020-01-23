using IPortfolio.BLL;
using IPortfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPortfolio.Web.Controllers
{
    public class ProjectController : BaseController
    {
        private readonly ProjectBll projectBll = new ProjectBll();
		private readonly ProjectPropertyBll projectPropertyBll = new ProjectPropertyBll();

		public ActionResult Index()
        {
            ViewBag.ProjectList = projectBll.GetAll();
            return View();
        }

		public ActionResult MyProject()
		{
			ViewBag.ProjectList = projectBll.GetAll();
			return View();
		}

		public ActionResult Add()
        {
			ViewBag.ProjectPropertyList = projectPropertyBll.GetAll();
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
				if (string.IsNullOrEmpty(model.ProjectName))
				{
					return Json(new { code = 400, msg = "ProjectName is null" });
				}
				projectModel.Tag = model.Tag;
				projectModel.Description = model.Description;
				projectModel.CostCenter = model.CostCenter;
				projectModel.StartDate = model.StartDate;
				projectModel.PlanGoLiveDate = model.PlanGoLiveDate;
				projectModel.DueDate = model.DueDate;
				projectModel.CreatedBy = HttpContext.User.Identity.Name;
				projectModel.CreateTime = DateTime.Now;
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
				projectModel.DonePercent = model.DonePercent;

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
			ViewBag.ProjectPropertyList = projectPropertyBll.GetAll();
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
				projectModel.DonePercent = model.DonePercent;

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
