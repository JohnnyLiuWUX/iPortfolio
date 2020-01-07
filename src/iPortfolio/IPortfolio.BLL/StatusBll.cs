/**
 * Auto Create By Code Magic 2020-01-07 02:48:29
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class StatusBll
    {
		#region Auto Create By Code Magic

		private readonly StatusDal dal = new StatusDal();

		public List<StatusModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<StatusModel> GetListByStatus(int status)
		{
			return dal.GetListByStatus(status);
		}

		public List<StatusModel> GetListByStatusGroup(string statusGroup)
		{
			return dal.GetListByStatusGroup(statusGroup);
		}

		public List<StatusModel> GetListByStatusDesc(string statusDesc)
		{
			return dal.GetListByStatusDesc(statusDesc);
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
		public List<StatusModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<StatusModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<StatusModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public StatusModel GetModel(int Status)
		{
			return dal.GetModel(Status);
		}

		public StatusModel GetModelByStatus(int status)
		{
			return dal.GetModelByStatus(status);
		}

		public StatusModel GetModelByStatusGroup(string statusGroup)
		{
			return dal.GetModelByStatusGroup(statusGroup);
		}

		public StatusModel GetModelByStatusDesc(string statusDesc)
		{
			return dal.GetModelByStatusDesc(statusDesc);
		}



		public int Insert(StatusModel model)
		{
			return dal.Insert(model);
		}

		public int Update(StatusModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int Status)
		{
			return dal.Delete(Status);
		}

		public int DeleteByStatus(int status)
		{
			return dal.DeleteByStatus(status);
		}

		public int DeleteByStatusGroup(string statusGroup)
		{
			return dal.DeleteByStatusGroup(statusGroup);
		}

		public int DeleteByStatusDesc(string statusDesc)
		{
			return dal.DeleteByStatusDesc(statusDesc);
		}



		#endregion
    }
}
