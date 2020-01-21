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
