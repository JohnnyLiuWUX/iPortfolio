using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class ProjectPropertyBll
    {
		private readonly ProjectPropertyDal dal = new ProjectPropertyDal();

		public List<ProjectPropertyModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<ProjectPropertyModel> GetListByPropertyID(int propertyID)
		{
			return dal.GetListByPropertyID(propertyID);
		}

		public List<ProjectPropertyModel> GetListByPropertyType(string propertyType)
		{
			return dal.GetListByPropertyType(propertyType);
		}

		public List<ProjectPropertyModel> GetListByPropertyKey(string propertyKey)
		{
			return dal.GetListByPropertyKey(propertyKey);
		}

		public List<ProjectPropertyModel> GetListByPropertyValue(string propertyValue)
		{
			return dal.GetListByPropertyValue(propertyValue);
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
		public List<ProjectPropertyModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
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
		public List<ProjectPropertyModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<ProjectPropertyModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public ProjectPropertyModel GetModel(int PropertyID)
		{
			return dal.GetModel(PropertyID);
		}

		public ProjectPropertyModel GetModelByPropertyID(int propertyID)
		{
			return dal.GetModelByPropertyID(propertyID);
		}

		public ProjectPropertyModel GetModelByPropertyType(string propertyType)
		{
			return dal.GetModelByPropertyType(propertyType);
		}

		public ProjectPropertyModel GetModelByPropertyKey(string propertyKey)
		{
			return dal.GetModelByPropertyKey(propertyKey);
		}

		public ProjectPropertyModel GetModelByPropertyValue(string propertyValue)
		{
			return dal.GetModelByPropertyValue(propertyValue);
		}



		public int Insert(ProjectPropertyModel model)
		{
			return dal.Insert(model);
		}

		public int Update(ProjectPropertyModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int PropertyID)
		{
			return dal.Delete(PropertyID);
		}

		public int DeleteByPropertyID(int propertyID)
		{
			return dal.DeleteByPropertyID(propertyID);
		}

		public int DeleteByPropertyType(string propertyType)
		{
			return dal.DeleteByPropertyType(propertyType);
		}

		public int DeleteByPropertyKey(string propertyKey)
		{
			return dal.DeleteByPropertyKey(propertyKey);
		}

		public int DeleteByPropertyValue(string propertyValue)
		{
			return dal.DeleteByPropertyValue(propertyValue);
		}


    }
}
