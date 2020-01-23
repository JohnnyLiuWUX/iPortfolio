using IPortfolio.BLL;
using IPortfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPortfolio.Web.Controllers
{
    public class OrgUserController : BaseController
    {
        private readonly OrgUserBll orgUserBll = new OrgUserBll();

        public ActionResult Index()
        {
            ViewBag.OrgUserList = orgUserBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(OrgUserViewModel model)
		{
			try
            {
				OrgUserModel orgUserModel = new OrgUserModel();
				orgUserModel.UserID = model.UserID;
				orgUserModel.OrgID = model.OrgID;

				orgUserBll.Insert(orgUserModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(string userID, int orgID)
        {
            ViewBag.OrgUserModel = orgUserBll.GetModel(userID, orgID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(OrgUserViewModel model)
		{
			try
            {
				OrgUserModel orgUserModel = orgUserBll.GetModel(model.UserID, model.OrgID);
				orgUserModel.UserID = model.UserID;
				orgUserModel.OrgID = model.OrgID;

				orgUserBll.Update(orgUserModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(string userID, int orgID)
        {
			try
            {
				OrgUserModel model = orgUserBll.GetModel(userID, orgID);
				if (model != null)
				{
					orgUserBll.Delete(userID, orgID);
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
