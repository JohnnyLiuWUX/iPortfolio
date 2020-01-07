/**
 * Auto Create By Code Magic 2020-01-07 02:48:21
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
    public class AuditController : Controller
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
        public JsonResult AddSubmit(AuditViewModel model)
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

        public ActionResult Modify(int AuditID)
        {
            ViewBag.AuditModel = auditBll.GetModel(AuditID);
            return View();
        }

		[HttpPost]
        public JsonResult ModifySubmit(AuditViewModel model)
		{
			try
            {
				AuditModel auditModel = auditBll.GetModel(model.AuditID);
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

        [HttpPost]
        public JsonResult Delete(int AuditID)
        {
			try
            {
				AuditModel model = auditBll.GetModel(AuditID);
				if (model != null)
				{
					auditBll.Delete(AuditID);
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
