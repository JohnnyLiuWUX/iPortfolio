/**
 * Auto Create By Code Magic 2020-01-08 12:44:50
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
    public class AuditItemController : Controller
    {
		public class AuditItemViewModel
		{
			public int ItemID { get; set; }
			public int AuditID { get; set; }
			public int AuditRuleID { get; set; }
			public int Status { get; set; }
			public string Evidence { get; set; }
			public string Comments { get; set; }
		}

        private readonly AuditItemBll auditItemBll = new AuditItemBll();

        public ActionResult Index()
        {
            ViewBag.AuditItemList = auditItemBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(AuditItemViewModel model)
		{
			try
            {
				AuditItemModel auditItemModel = new AuditItemModel();
				auditItemModel.AuditID = model.AuditID;
				auditItemModel.AuditRuleID = model.AuditRuleID;
				auditItemModel.Status = model.Status;
				auditItemModel.Evidence = model.Evidence;
				auditItemModel.Comments = model.Comments;

				auditItemBll.Insert(auditItemModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int itemID)
        {
            ViewBag.AuditItemModel = auditItemBll.GetModel(itemID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(AuditItemViewModel model)
		{
			try
            {
				AuditItemModel auditItemModel = auditItemBll.GetModel(model.ItemID);
				auditItemModel.AuditID = model.AuditID;
				auditItemModel.AuditRuleID = model.AuditRuleID;
				auditItemModel.Status = model.Status;
				auditItemModel.Evidence = model.Evidence;
				auditItemModel.Comments = model.Comments;

				auditItemBll.Update(auditItemModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int itemID)
        {
			try
            {
				AuditItemModel model = auditItemBll.GetModel(itemID);
				if (model != null)
				{
					auditItemBll.Delete(itemID);
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
