﻿using IPortfolio.BLL;
using IPortfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPortfolio.Web.Controllers
{
    public class OrganizationController : BaseController
    {
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
        public JsonResult Insert(OrganizationViewModel model)
		{
			try
            {
				OrganizationModel organizationModel = new OrganizationModel();
				organizationModel.OrgID = model.OrgID;
				organizationModel.Organization = model.Organization;

				organizationBll.Insert(organizationModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int orgID)
        {
            ViewBag.OrganizationModel = organizationBll.GetModel(orgID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(OrganizationViewModel model)
		{
			try
            {
				OrganizationModel organizationModel = organizationBll.GetModel(model.OrgID);
				organizationModel.OrgID = model.OrgID;
				organizationModel.Organization = model.Organization;

				organizationBll.Update(organizationModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int orgID)
        {
			try
            {
				OrganizationModel model = organizationBll.GetModel(orgID);
				if (model != null)
				{
					organizationBll.Delete(orgID);
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
