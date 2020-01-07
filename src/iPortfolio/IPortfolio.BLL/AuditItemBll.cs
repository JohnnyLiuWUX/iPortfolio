/**
 * Auto Create By Code Magic 2020-01-07 02:48:22
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class AuditItemBll
    {
		#region Auto Create By Code Magic

		private readonly AuditItemDal dal = new AuditItemDal();

		public List<AuditItemModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<AuditItemModel> GetListByItemID(int itemID)
		{
			return dal.GetListByItemID(itemID);
		}

		public List<AuditItemModel> GetListByAuditID(int auditID)
		{
			return dal.GetListByAuditID(auditID);
		}

		public List<AuditItemModel> GetListByAuditRuleID(int auditRuleID)
		{
			return dal.GetListByAuditRuleID(auditRuleID);
		}

		public List<AuditItemModel> GetListByStatus(int status)
		{
			return dal.GetListByStatus(status);
		}

		public List<AuditItemModel> GetListByEvidence(string evidence)
		{
			return dal.GetListByEvidence(evidence);
		}

		public List<AuditItemModel> GetListByComments(string comments)
		{
			return dal.GetListByComments(comments);
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
		public List<AuditItemModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<AuditItemModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<AuditItemModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public AuditItemModel GetModel(int ItemID)
		{
			return dal.GetModel(ItemID);
		}

		public AuditItemModel GetModelByItemID(int itemID)
		{
			return dal.GetModelByItemID(itemID);
		}

		public AuditItemModel GetModelByAuditID(int auditID)
		{
			return dal.GetModelByAuditID(auditID);
		}

		public AuditItemModel GetModelByAuditRuleID(int auditRuleID)
		{
			return dal.GetModelByAuditRuleID(auditRuleID);
		}

		public AuditItemModel GetModelByStatus(int status)
		{
			return dal.GetModelByStatus(status);
		}

		public AuditItemModel GetModelByEvidence(string evidence)
		{
			return dal.GetModelByEvidence(evidence);
		}

		public AuditItemModel GetModelByComments(string comments)
		{
			return dal.GetModelByComments(comments);
		}



		public int Insert(AuditItemModel model)
		{
			return dal.Insert(model);
		}

		public int Update(AuditItemModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int ItemID)
		{
			return dal.Delete(ItemID);
		}

		public int DeleteByItemID(int itemID)
		{
			return dal.DeleteByItemID(itemID);
		}

		public int DeleteByAuditID(int auditID)
		{
			return dal.DeleteByAuditID(auditID);
		}

		public int DeleteByAuditRuleID(int auditRuleID)
		{
			return dal.DeleteByAuditRuleID(auditRuleID);
		}

		public int DeleteByStatus(int status)
		{
			return dal.DeleteByStatus(status);
		}

		public int DeleteByEvidence(string evidence)
		{
			return dal.DeleteByEvidence(evidence);
		}

		public int DeleteByComments(string comments)
		{
			return dal.DeleteByComments(comments);
		}



		#endregion
    }
}
