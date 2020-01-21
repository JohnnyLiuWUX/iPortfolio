using IPortfolio.BLL;
using IPortfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPortfolio.Web.Controllers
{
    public class AuditController : Controller
    {
        private readonly AuditBll auditBll = new AuditBll();

        public ActionResult Index()
        {
            ViewBag.AuditList = auditBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(AuditViewModel model)
		{
			try
            {
				AuditModel auditModel = new AuditModel();
				auditModel.ProjectID = model.ProjectID;
				auditModel.Status = model.Status;
				auditModel.DueDate = model.DueDate;
				auditModel.Auditor = model.Auditor;
				auditModel.CreatedTime = model.CreatedTime;

				auditBll.Insert(auditModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int auditID)
        {
            ViewBag.AuditModel = auditBll.GetModel(auditID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(AuditViewModel model)
		{
			try
            {
				AuditModel auditModel = auditBll.GetModel(model.AuditID);
				auditModel.ProjectID = model.ProjectID;
				auditModel.Status = model.Status;
				auditModel.DueDate = model.DueDate;
				auditModel.Auditor = model.Auditor;
				auditModel.CreatedTime = model.CreatedTime;

				auditBll.Update(auditModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int auditID)
        {
			try
            {
				AuditModel model = auditBll.GetModel(auditID);
				if (model != null)
				{
					auditBll.Delete(auditID);
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
