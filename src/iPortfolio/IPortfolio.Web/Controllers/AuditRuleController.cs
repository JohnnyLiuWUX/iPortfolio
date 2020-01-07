/**
 * Auto Create By Code Magic 2020-01-07 02:48:23
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
    public class AuditRuleController : Controller
    {
		public class AuditRuleViewModel
		{
			public int AuditRuleID { get; set; }
			public string Area { get; set; }
			public string Rule { get; set; }
			public int Status { get; set; }
		}

        private readonly AuditRuleBll auditRuleBll = new AuditRuleBll();

        public ActionResult Index()
        {
            ViewBag.AuditRuleList = auditRuleBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult AddSubmit(AuditRuleViewModel model)
		{
			try
            {
				AuditRuleModel auditRuleModel = new AuditRuleModel();
				auditRuleModel.Area = model.Area;
				auditRuleModel.Rule = model.Rule;
				auditRuleModel.Status = model.Status;

				auditRuleBll.Insert(auditRuleModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int AuditRuleID)
        {
            ViewBag.AuditRuleModel = auditRuleBll.GetModel(AuditRuleID);
            return View();
        }

		[HttpPost]
        public JsonResult ModifySubmit(AuditRuleViewModel model)
		{
			try
            {
				AuditRuleModel auditRuleModel = auditRuleBll.GetModel(model.AuditRuleID);
				auditRuleModel.Area = model.Area;
				auditRuleModel.Rule = model.Rule;
				auditRuleModel.Status = model.Status;

				auditRuleBll.Insert(auditRuleModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int AuditRuleID)
        {
			try
            {
				AuditRuleModel model = auditRuleBll.GetModel(AuditRuleID);
				if (model != null)
				{
					auditRuleBll.Delete(AuditRuleID);
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
