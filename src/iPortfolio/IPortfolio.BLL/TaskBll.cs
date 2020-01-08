/**
 * Auto Create By Code Magic 2020-01-08 11:27:10
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class TaskBll
    {
		#region Auto Create By Code Magic

		private readonly TaskDal dal = new TaskDal();

		public List<TaskModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<TaskModel> GetListByTaskID(int taskID)
		{
			return dal.GetListByTaskID(taskID);
		}

		public List<TaskModel> GetListByParentID(int parentID)
		{
			return dal.GetListByParentID(parentID);
		}

		public List<TaskModel> GetListByProjectID(int projectID)
		{
			return dal.GetListByProjectID(projectID);
		}

		public List<TaskModel> GetListByPhaseID(int phaseID)
		{
			return dal.GetListByPhaseID(phaseID);
		}

		public List<TaskModel> GetListByTaskName(string taskName)
		{
			return dal.GetListByTaskName(taskName);
		}

		public List<TaskModel> GetListByDesription(string desription)
		{
			return dal.GetListByDesription(desription);
		}

		public List<TaskModel> GetListByAssignee(string assignee)
		{
			return dal.GetListByAssignee(assignee);
		}

		public List<TaskModel> GetListByPriority(int priority)
		{
			return dal.GetListByPriority(priority);
		}

		public List<TaskModel> GetListByEstimatedTime(decimal estimatedTime)
		{
			return dal.GetListByEstimatedTime(estimatedTime);
		}

		public List<TaskModel> GetListByStartDate(string startDate)
		{
			return dal.GetListByStartDate(startDate);
		}

		public List<TaskModel> GetListByDueDate(string dueDate)
		{
			return dal.GetListByDueDate(dueDate);
		}

		public List<TaskModel> GetListByTag(string tag)
		{
			return dal.GetListByTag(tag);
		}

		public List<TaskModel> GetListByStatus(int status)
		{
			return dal.GetListByStatus(status);
		}

		public List<TaskModel> GetListByDonePercent(int donePercent)
		{
			return dal.GetListByDonePercent(donePercent);
		}

		public List<TaskModel> GetListByCloseDate(string closeDate)
		{
			return dal.GetListByCloseDate(closeDate);
		}

		public List<TaskModel> GetListByAssignBy(string assignBy)
		{
			return dal.GetListByAssignBy(assignBy);
		}

		public List<TaskModel> GetListByCreatedTime(DateTime createdTime)
		{
			return dal.GetListByCreatedTime(createdTime);
		}



		/// <summary>
        /// 根据查询条件(SQL语句)检索数据
        /// </summary>
        /// <param name="where">where查询条件</param>
		/// <param name="orderName">order字段名</param>
		/// <param name="orderValue">ASC || DESC</param>
        /// <returns></returns>
		/// <example>
        /// GetListByWhere("RoleID=5", "ID", "ASC");
        /// </example>
		public List<TaskModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			return dal.GetListByWhere(where, orderName, orderValue);
		}

		/// <summary>
        /// 根据多查询条件(SQL AND)检索数据
        /// </summary>
        /// <param name="whereAnd">多查询条件</param>
		/// <param name="orderName">order字段名</param>
		/// <param name="orderValue">ASC || DESC</param>
        /// <returns></returns>
		/// <example>
		/// List<string> whereAnd = new List<string>();
		/// whereAnd.Add("RoleID=5");
		/// whereAnd.Add("IsAdmin=1");
        /// GetListByWhereAnd(whereAnd, "ID", "DESC");
        /// </example>
		public List<TaskModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereAnd(whereAnd, orderName, orderValue);
		}

		/// <summary>
        /// 根据多查询条件(SQL OR)检索数据
        /// </summary>
        /// <param name="whereAnd">多查询条件</param>
		/// <param name="orderName">order字段名</param>
		/// <param name="orderValue">ASC || DESC</param>
        /// <returns></returns>
		/// <example>
		/// List<string> whereOR = new List<string>();
		/// whereOR.Add("RoleID IN (1,2,3)");
		/// whereOR.Add("IsAdmin=1");
        /// GetListByWhereOr(whereOR, "ID", "DESC");
        /// </example>
		public List<TaskModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public TaskModel GetModel(int TaskID)
		{
			return dal.GetModel(TaskID);
		}

		public TaskModel GetModelByTaskID(int taskID)
		{
			return dal.GetModelByTaskID(taskID);
		}

		public TaskModel GetModelByParentID(int parentID)
		{
			return dal.GetModelByParentID(parentID);
		}

		public TaskModel GetModelByProjectID(int projectID)
		{
			return dal.GetModelByProjectID(projectID);
		}

		public TaskModel GetModelByPhaseID(int phaseID)
		{
			return dal.GetModelByPhaseID(phaseID);
		}

		public TaskModel GetModelByTaskName(string taskName)
		{
			return dal.GetModelByTaskName(taskName);
		}

		public TaskModel GetModelByDesription(string desription)
		{
			return dal.GetModelByDesription(desription);
		}

		public TaskModel GetModelByAssignee(string assignee)
		{
			return dal.GetModelByAssignee(assignee);
		}

		public TaskModel GetModelByPriority(int priority)
		{
			return dal.GetModelByPriority(priority);
		}

		public TaskModel GetModelByEstimatedTime(decimal estimatedTime)
		{
			return dal.GetModelByEstimatedTime(estimatedTime);
		}

		public TaskModel GetModelByStartDate(string startDate)
		{
			return dal.GetModelByStartDate(startDate);
		}

		public TaskModel GetModelByDueDate(string dueDate)
		{
			return dal.GetModelByDueDate(dueDate);
		}

		public TaskModel GetModelByTag(string tag)
		{
			return dal.GetModelByTag(tag);
		}

		public TaskModel GetModelByStatus(int status)
		{
			return dal.GetModelByStatus(status);
		}

		public TaskModel GetModelByDonePercent(int donePercent)
		{
			return dal.GetModelByDonePercent(donePercent);
		}

		public TaskModel GetModelByCloseDate(string closeDate)
		{
			return dal.GetModelByCloseDate(closeDate);
		}

		public TaskModel GetModelByAssignBy(string assignBy)
		{
			return dal.GetModelByAssignBy(assignBy);
		}

		public TaskModel GetModelByCreatedTime(DateTime createdTime)
		{
			return dal.GetModelByCreatedTime(createdTime);
		}



		public int Insert(TaskModel model)
		{
			return dal.Insert(model);
		}

		public int Update(TaskModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int TaskID)
		{
			return dal.Delete(TaskID);
		}

		public int DeleteByTaskID(int taskID)
		{
			return dal.DeleteByTaskID(taskID);
		}

		public int DeleteByParentID(int parentID)
		{
			return dal.DeleteByParentID(parentID);
		}

		public int DeleteByProjectID(int projectID)
		{
			return dal.DeleteByProjectID(projectID);
		}

		public int DeleteByPhaseID(int phaseID)
		{
			return dal.DeleteByPhaseID(phaseID);
		}

		public int DeleteByTaskName(string taskName)
		{
			return dal.DeleteByTaskName(taskName);
		}

		public int DeleteByDesription(string desription)
		{
			return dal.DeleteByDesription(desription);
		}

		public int DeleteByAssignee(string assignee)
		{
			return dal.DeleteByAssignee(assignee);
		}

		public int DeleteByPriority(int priority)
		{
			return dal.DeleteByPriority(priority);
		}

		public int DeleteByEstimatedTime(decimal estimatedTime)
		{
			return dal.DeleteByEstimatedTime(estimatedTime);
		}

		public int DeleteByStartDate(string startDate)
		{
			return dal.DeleteByStartDate(startDate);
		}

		public int DeleteByDueDate(string dueDate)
		{
			return dal.DeleteByDueDate(dueDate);
		}

		public int DeleteByTag(string tag)
		{
			return dal.DeleteByTag(tag);
		}

		public int DeleteByStatus(int status)
		{
			return dal.DeleteByStatus(status);
		}

		public int DeleteByDonePercent(int donePercent)
		{
			return dal.DeleteByDonePercent(donePercent);
		}

		public int DeleteByCloseDate(string closeDate)
		{
			return dal.DeleteByCloseDate(closeDate);
		}

		public int DeleteByAssignBy(string assignBy)
		{
			return dal.DeleteByAssignBy(assignBy);
		}

		public int DeleteByCreatedTime(DateTime createdTime)
		{
			return dal.DeleteByCreatedTime(createdTime);
		}



		#endregion
    }
}
