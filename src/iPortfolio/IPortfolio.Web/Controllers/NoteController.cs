/**
 * Auto Create By Code Magic 2020-01-08 12:44:51
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
    public class NoteController : Controller
    {
		public class NoteViewModel
		{
			public int NoteID { get; set; }
			public int ProjectID { get; set; }
			public int TaskID { get; set; }
			public string Note { get; set; }
			public string CreatedBy { get; set; }
			public DateTime CreatedTime { get; set; }
		}

        private readonly NoteBll noteBll = new NoteBll();

        public ActionResult Index()
        {
            ViewBag.NoteList = noteBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(NoteViewModel model)
		{
			try
            {
				NoteModel noteModel = new NoteModel();
				noteModel.ProjectID = model.ProjectID;
				noteModel.TaskID = model.TaskID;
				noteModel.Note = model.Note;
				noteModel.CreatedBy = model.CreatedBy;
				noteModel.CreatedTime = model.CreatedTime;

				noteBll.Insert(noteModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int noteID)
        {
            ViewBag.NoteModel = noteBll.GetModel(noteID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(NoteViewModel model)
		{
			try
            {
				NoteModel noteModel = noteBll.GetModel(model.NoteID);
				noteModel.ProjectID = model.ProjectID;
				noteModel.TaskID = model.TaskID;
				noteModel.Note = model.Note;
				noteModel.CreatedBy = model.CreatedBy;
				noteModel.CreatedTime = model.CreatedTime;

				noteBll.Update(noteModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int noteID)
        {
			try
            {
				NoteModel model = noteBll.GetModel(noteID);
				if (model != null)
				{
					noteBll.Delete(noteID);
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
