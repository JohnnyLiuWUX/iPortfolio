/**
 * Auto Create By Code Magic 2020-01-07 02:48:25
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
    public class OrganizationController : Controller
    {
		public class OrganizationViewModel
		{
			public int OrgID { get; set; }
			public string Organization { get; set; }
		}

        private readonly OrganizationBll organizationBll = new OrganizationBll();

        public ActionResult Index()
        {
            ViewBag.OrganizationList = organizationBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult AddSubmit(OrganizationViewModel model)
		{
			try
            {
				OrganizationModel organizationModel = new OrganizationModel();
				organizationModel.Organization = model.Organization;

				organizationBll.Insert(organizationModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int OrgID)
        {
            ViewBag.OrganizationModel = organizationBll.GetModel(OrgID);
            return View();
        }

		[HttpPost]
        public JsonResult ModifySubmit(OrganizationViewModel model)
		{
			try
            {
				OrganizationModel organizationModel = organizationBll.GetModel(model.OrgID);
				organizationModel.Organization = model.Organization;

				organizationBll.Insert(organizationModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int OrgID)
        {
			try
            {
				OrganizationModel model = organizationBll.GetModel(OrgID);
				if (model != null)
				{
					organizationBll.Delete(OrgID);
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
