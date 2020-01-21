using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class ProjectsStatusBll
    {
		private readonly ProjectsStatusDal dal = new ProjectsStatusDal();

		public List<ProjectsStatusModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<ProjectsStatusModel> GetListByProjectID(int projectID)
		{
			return dal.GetListByProjectID(projectID);
		}

		public List<ProjectsStatusModel> GetListByReportDate(DateTime reportDate)
		{
			return dal.GetListByReportDate(reportDate);
		}

		public List<ProjectsStatusModel> GetListByPhase(string phase)
		{
			return dal.GetListByPhase(phase);
		}

		public List<ProjectsStatusModel> GetListByDueDate(DateTime dueDate)
		{
			return dal.GetListByDueDate(dueDate);
		}

		public List<ProjectsStatusModel> GetListByDonePercent(int donePercent)
		{
			return dal.GetListByDonePercent(donePercent);
		}

		public List<ProjectsStatusModel> GetListBySpendHour(int spendHour)
		{
			return dal.GetListBySpendHour(spendHour);
		}

		public List<ProjectsStatusModel> GetListBySpendingRemark(string spendingRemark)
		{
			return dal.GetListBySpendingRemark(spendingRemark);
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
		public List<ProjectsStatusModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<ProjectsStatusModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<ProjectsStatusModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public ProjectsStatusModel GetModel(int ProjectID, DateTime ReportDate)
		{
			return dal.GetModel(ProjectID, ReportDate);
		}

		public ProjectsStatusModel GetModelByProjectID(int projectID)
		{
			return dal.GetModelByProjectID(projectID);
		}

		public ProjectsStatusModel GetModelByReportDate(DateTime reportDate)
		{
			return dal.GetModelByReportDate(reportDate);
		}

		public ProjectsStatusModel GetModelByPhase(string phase)
		{
			return dal.GetModelByPhase(phase);
		}

		public ProjectsStatusModel GetModelByDueDate(DateTime dueDate)
		{
			return dal.GetModelByDueDate(dueDate);
		}

		public ProjectsStatusModel GetModelByDonePercent(int donePercent)
		{
			return dal.GetModelByDonePercent(donePercent);
		}

		public ProjectsStatusModel GetModelBySpendHour(int spendHour)
		{
			return dal.GetModelBySpendHour(spendHour);
		}

		public ProjectsStatusModel GetModelBySpendingRemark(string spendingRemark)
		{
			return dal.GetModelBySpendingRemark(spendingRemark);
		}



		public int Insert(ProjectsStatusModel model)
		{
			return dal.Insert(model);
		}

		public int Update(ProjectsStatusModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int ProjectID, DateTime ReportDate)
		{
			return dal.Delete(ProjectID, ReportDate);
		}

		public int DeleteByProjectID(int projectID)
		{
			return dal.DeleteByProjectID(projectID);
		}

		public int DeleteByReportDate(DateTime reportDate)
		{
			return dal.DeleteByReportDate(reportDate);
		}

		public int DeleteByPhase(string phase)
		{
			return dal.DeleteByPhase(phase);
		}

		public int DeleteByDueDate(DateTime dueDate)
		{
			return dal.DeleteByDueDate(dueDate);
		}

		public int DeleteByDonePercent(int donePercent)
		{
			return dal.DeleteByDonePercent(donePercent);
		}

		public int DeleteBySpendHour(int spendHour)
		{
			return dal.DeleteBySpendHour(spendHour);
		}

		public int DeleteBySpendingRemark(string spendingRemark)
		{
			return dal.DeleteBySpendingRemark(spendingRemark);
		}


    }
}
