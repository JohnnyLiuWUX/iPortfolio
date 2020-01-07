/**
 * Auto Create By Code Magic 2020-01-07 02:48:21
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class AuditBll
    {
		#region Auto Create By Code Magic

		private readonly AuditDal dal = new AuditDal();

		public List<AuditModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<AuditModel> GetListByAuditID(int auditID)
		{
			return dal.GetListByAuditID(auditID);
		}

		public List<AuditModel> GetListByProjectID(int projectID)
		{
			return dal.GetListByProjectID(projectID);
		}

		public List<AuditModel> GetListByStatus(int status)
		{
			return dal.GetListByStatus(status);
		}

		public List<AuditModel> GetListByDueDate(string dueDate)
		{
			return dal.GetListByDueDate(dueDate);
		}

		public List<AuditModel> GetListByAuditor(string auditor)
		{
			return dal.GetListByAuditor(auditor);
		}

		public List<AuditModel> GetListByCreatedTime(DateTime createdTime)
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
		public List<AuditModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<AuditModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<AuditModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public AuditModel GetModel(int AuditID)
		{
			return dal.GetModel(AuditID);
		}

		public AuditModel GetModelByAuditID(int auditID)
		{
			return dal.GetModelByAuditID(auditID);
		}

		public AuditModel GetModelByProjectID(int projectID)
		{
			return dal.GetModelByProjectID(projectID);
		}

		public AuditModel GetModelByStatus(int status)
		{
			return dal.GetModelByStatus(status);
		}

		public AuditModel GetModelByDueDate(string dueDate)
		{
			return dal.GetModelByDueDate(dueDate);
		}

		public AuditModel GetModelByAuditor(string auditor)
		{
			return dal.GetModelByAuditor(auditor);
		}

		public AuditModel GetModelByCreatedTime(DateTime createdTime)
		{
			return dal.GetModelByCreatedTime(createdTime);
		}



		public int Insert(AuditModel model)
		{
			return dal.Insert(model);
		}

		public int Update(AuditModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int AuditID)
		{
			return dal.Delete(AuditID);
		}

		public int DeleteByAuditID(int auditID)
		{
			return dal.DeleteByAuditID(auditID);
		}

		public int DeleteByProjectID(int projectID)
		{
			return dal.DeleteByProjectID(projectID);
		}

		public int DeleteByStatus(int status)
		{
			return dal.DeleteByStatus(status);
		}

		public int DeleteByDueDate(string dueDate)
		{
			return dal.DeleteByDueDate(dueDate);
		}

		public int DeleteByAuditor(string auditor)
		{
			return dal.DeleteByAuditor(auditor);
		}

		public int DeleteByCreatedTime(DateTime createdTime)
		{
			return dal.DeleteByCreatedTime(createdTime);
		}



		#endregion
    }
}
