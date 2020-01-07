/**
 * Auto Create By Code Magic 2020-01-07 02:48:28
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
    public class SpendingController : Controller
    {
		public class SpendingViewModel
		{
			public int SpendID { get; set; }
			public int TaskID { get; set; }
			public string Title { get; set; }
			public string RecordDate { get; set; }
			public int SpendHour { get; set; }
			public string CreatedBy { get; set; }
			public DateTime CreateTime { get; set; }
		}

        private readonly SpendingBll spendingBll = new SpendingBll();

        public ActionResult Index()
        {
            ViewBag.SpendingList = spendingBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult AddSubmit(SpendingViewModel model)
		{
			try
            {
				SpendingModel spendingModel = new SpendingModel();
				spendingModel.TaskID = model.TaskID;
				spendingModel.Title = model.Title;
				spendingModel.RecordDate = model.RecordDate;
				spendingModel.SpendHour = model.SpendHour;
				spendingModel.CreatedBy = model.CreatedBy;
				spendingModel.CreateTime = model.CreateTime;

				spendingBll.Insert(spendingModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int SpendID)
        {
            ViewBag.SpendingModel = spendingBll.GetModel(SpendID);
            return View();
        }

		[HttpPost]
        public JsonResult ModifySubmit(SpendingViewModel model)
		{
			try
            {
				SpendingModel spendingModel = spendingBll.GetModel(model.SpendID);
				spendingModel.TaskID = model.TaskID;
				spendingModel.Title = model.Title;
				spendingModel.RecordDate = model.RecordDate;
				spendingModel.SpendHour = model.SpendHour;
				spendingModel.CreatedBy = model.CreatedBy;
				spendingModel.CreateTime = model.CreateTime;

				spendingBll.Insert(spendingModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int SpendID)
        {
			try
            {
				SpendingModel model = spendingBll.GetModel(SpendID);
				if (model != null)
				{
					spendingBll.Delete(SpendID);
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
