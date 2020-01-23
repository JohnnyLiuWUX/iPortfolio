using IPortfolio.BLL;
using IPortfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPortfolio.Web.Controllers
{
    public class ProjectsStatusController : BaseController
    {
        private readonly ProjectsStatusBll projectsStatusBll = new ProjectsStatusBll();

        public ActionResult Index()
        {
            ViewBag.ProjectsStatusList = projectsStatusBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(ProjectsStatusViewModel model)
		{
			try
            {
				ProjectsStatusModel projectsStatusModel = new ProjectsStatusModel();
				projectsStatusModel.ProjectID = model.ProjectID;
				projectsStatusModel.ReportDate = model.ReportDate;
				projectsStatusModel.Phase = model.Phase;
				projectsStatusModel.DueDate = model.DueDate;
				projectsStatusModel.DonePercent = model.DonePercent;
				projectsStatusModel.SpendHour = model.SpendHour;
				projectsStatusModel.SpendingRemark = model.SpendingRemark;

				projectsStatusBll.Insert(projectsStatusModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int projectID, DateTime reportDate)
        {
            ViewBag.ProjectsStatusModel = projectsStatusBll.GetModel(projectID, reportDate);
            return View();
        }

		[HttpPost]
        public JsonResult Update(ProjectsStatusViewModel model)
		{
			try
            {
				ProjectsStatusModel projectsStatusModel = projectsStatusBll.GetModel(model.ProjectID, model.ReportDate);
				projectsStatusModel.ProjectID = model.ProjectID;
				projectsStatusModel.ReportDate = model.ReportDate;
				projectsStatusModel.Phase = model.Phase;
				projectsStatusModel.DueDate = model.DueDate;
				projectsStatusModel.DonePercent = model.DonePercent;
				projectsStatusModel.SpendHour = model.SpendHour;
				projectsStatusModel.SpendingRemark = model.SpendingRemark;

				projectsStatusBll.Update(projectsStatusModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int projectID, DateTime reportDate)
        {
			try
            {
				ProjectsStatusModel model = projectsStatusBll.GetModel(projectID, reportDate);
				if (model != null)
				{
					projectsStatusBll.Delete(projectID, reportDate);
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
