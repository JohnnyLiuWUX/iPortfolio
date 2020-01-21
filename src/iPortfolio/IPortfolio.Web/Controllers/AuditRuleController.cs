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
        public JsonResult Insert(AuditRuleViewModel model)
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

        public ActionResult Modify(int auditRuleID)
        {
            ViewBag.AuditRuleModel = auditRuleBll.GetModel(auditRuleID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(AuditRuleViewModel model)
		{
			try
            {
				AuditRuleModel auditRuleModel = auditRuleBll.GetModel(model.AuditRuleID);
				auditRuleModel.Area = model.Area;
				auditRuleModel.Rule = model.Rule;
				auditRuleModel.Status = model.Status;

				auditRuleBll.Update(auditRuleModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int auditRuleID)
        {
			try
            {
				AuditRuleModel model = auditRuleBll.GetModel(auditRuleID);
				if (model != null)
				{
					auditRuleBll.Delete(auditRuleID);
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
