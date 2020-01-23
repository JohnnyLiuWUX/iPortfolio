using IPortfolio.BLL;
using IPortfolio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPortfolio.Web.Controllers
{
    public class SpendingController : BaseController
    {
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
        public JsonResult Insert(SpendingViewModel model)
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

        public ActionResult Modify(int spendID)
        {
            ViewBag.SpendingModel = spendingBll.GetModel(spendID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(SpendingViewModel model)
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

				spendingBll.Update(spendingModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int spendID)
        {
			try
            {
				SpendingModel model = spendingBll.GetModel(spendID);
				if (model != null)
				{
					spendingBll.Delete(spendID);
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
