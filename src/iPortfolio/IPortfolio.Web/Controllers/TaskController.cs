/**
 * Auto Create By Code Magic 2020-01-08 12:44:57
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
    public class TaskController : Controller
    {
		public class TaskViewModel
		{
			public int TaskID { get; set; }
			public int ParentID { get; set; }
			public int ProjectID { get; set; }
			public int PhaseID { get; set; }
			public string TaskName { get; set; }
			public string Desription { get; set; }
			public string Assignee { get; set; }
			public int Priority { get; set; }
			public decimal EstimatedTime { get; set; }
			public string StartDate { get; set; }
			public string DueDate { get; set; }
			public string Tag { get; set; }
			public int Status { get; set; }
			public int DonePercent { get; set; }
			public string CloseDate { get; set; }
			public string AssignBy { get; set; }
			public DateTime CreatedTime { get; set; }
		}

        private readonly TaskBll taskBll = new TaskBll();

        public ActionResult Index()
        {
            ViewBag.TaskList = taskBll.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

		[HttpPost]
        public JsonResult Insert(TaskViewModel model)
		{
			try
            {
				TaskModel taskModel = new TaskModel();
				taskModel.ParentID = model.ParentID;
				taskModel.ProjectID = model.ProjectID;
				taskModel.PhaseID = model.PhaseID;
				taskModel.TaskName = model.TaskName;
				taskModel.Desription = model.Desription;
				taskModel.Assignee = model.Assignee;
				taskModel.Priority = model.Priority;
				taskModel.EstimatedTime = model.EstimatedTime;
				taskModel.StartDate = model.StartDate;
				taskModel.DueDate = model.DueDate;
				taskModel.Tag = model.Tag;
				taskModel.Status = model.Status;
				taskModel.DonePercent = model.DonePercent;
				taskModel.CloseDate = model.CloseDate;
				taskModel.AssignBy = model.AssignBy;
				taskModel.CreatedTime = model.CreatedTime;

				taskBll.Insert(taskModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        public ActionResult Modify(int taskID)
        {
            ViewBag.TaskModel = taskBll.GetModel(taskID);
            return View();
        }

		[HttpPost]
        public JsonResult Update(TaskViewModel model)
		{
			try
            {
				TaskModel taskModel = taskBll.GetModel(model.TaskID);
				taskModel.ParentID = model.ParentID;
				taskModel.ProjectID = model.ProjectID;
				taskModel.PhaseID = model.PhaseID;
				taskModel.TaskName = model.TaskName;
				taskModel.Desription = model.Desription;
				taskModel.Assignee = model.Assignee;
				taskModel.Priority = model.Priority;
				taskModel.EstimatedTime = model.EstimatedTime;
				taskModel.StartDate = model.StartDate;
				taskModel.DueDate = model.DueDate;
				taskModel.Tag = model.Tag;
				taskModel.Status = model.Status;
				taskModel.DonePercent = model.DonePercent;
				taskModel.CloseDate = model.CloseDate;
				taskModel.AssignBy = model.AssignBy;
				taskModel.CreatedTime = model.CreatedTime;

				taskBll.Update(taskModel);
                return Json(new { code = 200 });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = ex.Message });
            }
		}

        [HttpPost]
        public JsonResult Delete(int taskID)
        {
			try
            {
				TaskModel model = taskBll.GetModel(taskID);
				if (model != null)
				{
					taskBll.Delete(taskID);
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
