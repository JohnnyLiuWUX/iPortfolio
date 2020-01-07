/**
 * Auto Create By Code Magic 2020-01-07 02:48:26
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
    public class OrgUserController : Controller
    {
		public class OrgUserViewModel
		{
			public string UserID { get; set; }
			public int OrgID { get; set; }
		}

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
        public JsonResult AddSubmit(OrgUserViewModel model)
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

        public ActionResult Modify(string UserID, int OrgID)
        {
            ViewBag.OrgUserModel = orgUserBll.GetModel(UserID, OrgID);
            return View();
        }

		[HttpPost]
        public JsonResult ModifySubmit(OrgUserViewModel model)
		{
			try
            {
				OrgUserModel orgUserModel = orgUserBll.GetModel(model.UserID, model.OrgID);
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

        [HttpPost]
        public JsonResult Delete(string UserID, int OrgID)
        {
			try
            {
				OrgUserModel model = orgUserBll.GetModel(UserID, OrgID);
				if (model != null)
				{
					orgUserBll.Delete(UserID, OrgID);
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
