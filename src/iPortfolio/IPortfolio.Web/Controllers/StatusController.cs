/**
 * Auto Create By Code Magic 2020-01-08 12:44:56
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
    public class StatusController : Controller
    {
		public class StatusViewModel
		{
			public int Status { get; set; }
			public string StatusGroup { get; set; }
			public string StatusDesc { get; set; }
		}

        private readonly StatusBll statusBll = new StatusBll();

        public ActionResult Index()
        {
            ViewBag.StatusList = statusBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(StatusViewModel model)
		{
			try
            {
				StatusModel statusModel = new StatusModel();
				statusModel.Status = model.Status;
				statusModel.StatusGroup = model.StatusGroup;
				statusModel.StatusDesc = model.StatusDesc;

				statusBll.Insert(statusModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int status)
        {
            ViewBag.StatusModel = statusBll.GetModel(status);
            return View();
        }

		[HttpPost]
        public JsonResult Update(StatusViewModel model)
		{
			try
            {
				StatusModel statusModel = statusBll.GetModel(model.Status);
				statusModel.Status = model.Status;
				statusModel.StatusGroup = model.StatusGroup;
				statusModel.StatusDesc = model.StatusDesc;

				statusBll.Update(statusModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int status)
        {
			try
            {
				StatusModel model = statusBll.GetModel(status);
				if (model != null)
				{
					statusBll.Delete(status);
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
