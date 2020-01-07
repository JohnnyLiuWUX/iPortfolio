/**
 * Auto Create By Code Magic 2020-01-07 02:48:25
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class OrgUserBll
    {
		#region Auto Create By Code Magic

		private readonly OrgUserDal dal = new OrgUserDal();

		public List<OrgUserModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<OrgUserModel> GetListByUserID(string userID)
		{
			return dal.GetListByUserID(userID);
		}

		public List<OrgUserModel> GetListByOrgID(int orgID)
		{
			return dal.GetListByOrgID(orgID);
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
		public List<OrgUserModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<OrgUserModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<OrgUserModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public OrgUserModel GetModel(string UserID, int OrgID)
		{
			return dal.GetModel(UserID, OrgID);
		}

		public OrgUserModel GetModelByUserID(string userID)
		{
			return dal.GetModelByUserID(userID);
		}

		public OrgUserModel GetModelByOrgID(int orgID)
		{
			return dal.GetModelByOrgID(orgID);
		}



		public int Insert(OrgUserModel model)
		{
			return dal.Insert(model);
		}

		public int Update(OrgUserModel model)
		{
			return dal.Update(model);
		}

		public int Delete(string UserID, int OrgID)
		{
			return dal.Delete(UserID, OrgID);
		}

		public int DeleteByUserID(string userID)
		{
			return dal.DeleteByUserID(userID);
		}

		public int DeleteByOrgID(int orgID)
		{
			return dal.DeleteByOrgID(orgID);
		}



		#endregion
    }
}
