using IPortfolio.BLL;
using IPortfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPortfolio.Web.Controllers
{
    public class ProjectPropertyController : Controller
    {
        private readonly ProjectPropertyBll projectPropertyBll = new ProjectPropertyBll();

        public ActionResult Index()
        {
            ViewBag.ProjectPropertyList = projectPropertyBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(ProjectPropertyViewModel model)
		{
			try
            {
				ProjectPropertyModel projectPropertyModel = new ProjectPropertyModel();
				projectPropertyModel.PropertyType = model.PropertyType;
				projectPropertyModel.PropertyKey = model.PropertyKey;
				projectPropertyModel.PropertyValue = model.PropertyValue;

				projectPropertyBll.Insert(projectPropertyModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int propertyID)
        {
            ViewBag.ProjectPropertyModel = projectPropertyBll.GetModel(propertyID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(ProjectPropertyViewModel model)
		{
			try
            {
				ProjectPropertyModel projectPropertyModel = projectPropertyBll.GetModel(model.PropertyID);
				projectPropertyModel.PropertyType = model.PropertyType;
				projectPropertyModel.PropertyKey = model.PropertyKey;
				projectPropertyModel.PropertyValue = model.PropertyValue;

				projectPropertyBll.Update(projectPropertyModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int propertyID)
        {
			try
            {
				ProjectPropertyModel model = projectPropertyBll.GetModel(propertyID);
				if (model != null)
				{
					projectPropertyBll.Delete(propertyID);
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
