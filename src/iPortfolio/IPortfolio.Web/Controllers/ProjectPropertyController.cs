/**
 * Auto Create By Code Magic 2020-01-07 02:48:27
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
    public class ProjectPropertyController : Controller
    {
		public class ProjectPropertyViewModel
		{
			public int PropertyID { get; set; }
			public string PropertyType { get; set; }
			public string PropertyKey { get; set; }
			public string PropertyValue { get; set; }
		}

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
        public JsonResult AddSubmit(ProjectPropertyViewModel model)
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

        public ActionResult Modify(int PropertyID)
        {
            ViewBag.ProjectPropertyModel = projectPropertyBll.GetModel(PropertyID);
            return View();
        }

		[HttpPost]
        public JsonResult ModifySubmit(ProjectPropertyViewModel model)
		{
			try
            {
				ProjectPropertyModel projectPropertyModel = projectPropertyBll.GetModel(model.PropertyID);
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

        [HttpPost]
        public JsonResult Delete(int PropertyID)
        {
			try
            {
				ProjectPropertyModel model = projectPropertyBll.GetModel(PropertyID);
				if (model != null)
				{
					projectPropertyBll.Delete(PropertyID);
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
