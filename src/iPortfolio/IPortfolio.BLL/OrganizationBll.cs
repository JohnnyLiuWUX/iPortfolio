using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class OrganizationBll
    {
		private readonly OrganizationDal dal = new OrganizationDal();

		public List<OrganizationModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<OrganizationModel> GetListByOrgID(int orgID)
		{
			return dal.GetListByOrgID(orgID);
		}

		public List<OrganizationModel> GetListByOrganization(string organization)
		{
			return dal.GetListByOrganization(organization);
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
		public List<OrganizationModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<OrganizationModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<OrganizationModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public OrganizationModel GetModel(int OrgID)
		{
			return dal.GetModel(OrgID);
		}

		public OrganizationModel GetModelByOrgID(int orgID)
		{
			return dal.GetModelByOrgID(orgID);
		}

		public OrganizationModel GetModelByOrganization(string organization)
		{
			return dal.GetModelByOrganization(organization);
		}



		public int Insert(OrganizationModel model)
		{
			return dal.Insert(model);
		}

		public int Update(OrganizationModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int OrgID)
		{
			return dal.Delete(OrgID);
		}

		public int DeleteByOrgID(int orgID)
		{
			return dal.DeleteByOrgID(orgID);
		}

		public int DeleteByOrganization(string organization)
		{
			return dal.DeleteByOrganization(organization);
		}


    }
}
