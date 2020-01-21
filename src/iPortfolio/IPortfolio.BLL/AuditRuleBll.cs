using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class AuditRuleBll
    {
		private readonly AuditRuleDal dal = new AuditRuleDal();

		public List<AuditRuleModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<AuditRuleModel> GetListByAuditRuleID(int auditRuleID)
		{
			return dal.GetListByAuditRuleID(auditRuleID);
		}

		public List<AuditRuleModel> GetListByArea(string area)
		{
			return dal.GetListByArea(area);
		}

		public List<AuditRuleModel> GetListByRule(string rule)
		{
			return dal.GetListByRule(rule);
		}

		public List<AuditRuleModel> GetListByStatus(int status)
		{
			return dal.GetListByStatus(status);
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
		public List<AuditRuleModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<AuditRuleModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<AuditRuleModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public AuditRuleModel GetModel(int AuditRuleID)
		{
			return dal.GetModel(AuditRuleID);
		}

		public AuditRuleModel GetModelByAuditRuleID(int auditRuleID)
		{
			return dal.GetModelByAuditRuleID(auditRuleID);
		}

		public AuditRuleModel GetModelByArea(string area)
		{
			return dal.GetModelByArea(area);
		}

		public AuditRuleModel GetModelByRule(string rule)
		{
			return dal.GetModelByRule(rule);
		}

		public AuditRuleModel GetModelByStatus(int status)
		{
			return dal.GetModelByStatus(status);
		}



		public int Insert(AuditRuleModel model)
		{
			return dal.Insert(model);
		}

		public int Update(AuditRuleModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int AuditRuleID)
		{
			return dal.Delete(AuditRuleID);
		}

		public int DeleteByAuditRuleID(int auditRuleID)
		{
			return dal.DeleteByAuditRuleID(auditRuleID);
		}

		public int DeleteByArea(string area)
		{
			return dal.DeleteByArea(area);
		}

		public int DeleteByRule(string rule)
		{
			return dal.DeleteByRule(rule);
		}

		public int DeleteByStatus(int status)
		{
			return dal.DeleteByStatus(status);
		}


    }
}
