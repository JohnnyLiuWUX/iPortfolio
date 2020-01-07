/**
 * Auto Create By Code Magic 2020-01-07 02:48:28
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class SpendingBll
    {
		#region Auto Create By Code Magic

		private readonly SpendingDal dal = new SpendingDal();

		public List<SpendingModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<SpendingModel> GetListBySpendID(int spendID)
		{
			return dal.GetListBySpendID(spendID);
		}

		public List<SpendingModel> GetListByTaskID(int taskID)
		{
			return dal.GetListByTaskID(taskID);
		}

		public List<SpendingModel> GetListByTitle(string title)
		{
			return dal.GetListByTitle(title);
		}

		public List<SpendingModel> GetListByRecordDate(string recordDate)
		{
			return dal.GetListByRecordDate(recordDate);
		}

		public List<SpendingModel> GetListBySpendHour(int spendHour)
		{
			return dal.GetListBySpendHour(spendHour);
		}

		public List<SpendingModel> GetListByCreatedBy(string createdBy)
		{
			return dal.GetListByCreatedBy(createdBy);
		}

		public List<SpendingModel> GetListByCreateTime(DateTime createTime)
		{
			return dal.GetListByCreateTime(createTime);
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
		public List<SpendingModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<SpendingModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<SpendingModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public SpendingModel GetModel(int SpendID)
		{
			return dal.GetModel(SpendID);
		}

		public SpendingModel GetModelBySpendID(int spendID)
		{
			return dal.GetModelBySpendID(spendID);
		}

		public SpendingModel GetModelByTaskID(int taskID)
		{
			return dal.GetModelByTaskID(taskID);
		}

		public SpendingModel GetModelByTitle(string title)
		{
			return dal.GetModelByTitle(title);
		}

		public SpendingModel GetModelByRecordDate(string recordDate)
		{
			return dal.GetModelByRecordDate(recordDate);
		}

		public SpendingModel GetModelBySpendHour(int spendHour)
		{
			return dal.GetModelBySpendHour(spendHour);
		}

		public SpendingModel GetModelByCreatedBy(string createdBy)
		{
			return dal.GetModelByCreatedBy(createdBy);
		}

		public SpendingModel GetModelByCreateTime(DateTime createTime)
		{
			return dal.GetModelByCreateTime(createTime);
		}



		public int Insert(SpendingModel model)
		{
			return dal.Insert(model);
		}

		public int Update(SpendingModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int SpendID)
		{
			return dal.Delete(SpendID);
		}

		public int DeleteBySpendID(int spendID)
		{
			return dal.DeleteBySpendID(spendID);
		}

		public int DeleteByTaskID(int taskID)
		{
			return dal.DeleteByTaskID(taskID);
		}

		public int DeleteByTitle(string title)
		{
			return dal.DeleteByTitle(title);
		}

		public int DeleteByRecordDate(string recordDate)
		{
			return dal.DeleteByRecordDate(recordDate);
		}

		public int DeleteBySpendHour(int spendHour)
		{
			return dal.DeleteBySpendHour(spendHour);
		}

		public int DeleteByCreatedBy(string createdBy)
		{
			return dal.DeleteByCreatedBy(createdBy);
		}

		public int DeleteByCreateTime(DateTime createTime)
		{
			return dal.DeleteByCreateTime(createTime);
		}



		#endregion
    }
}
