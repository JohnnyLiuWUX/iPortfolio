/**
 * Auto Create By Code Magic 2020-01-07 02:48:27
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using IPortfolio.Model;

namespace IPortfolio.DAL
{
    public partial class ProjectPropertyDal
    {
		#region Auto Create By Code Magic

		public List<ProjectPropertyModel> GetAll()
		{
			List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
			string sql = "SELECT * FROM [ProjectProperty]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectPropertyModel> GetListByPropertyID(int propertyID)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE [PropertyID]=@PropertyID";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyID", SqlDbType.Int),
			};
			parameters[0].Value = propertyID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectPropertyModel> GetListByPropertyType(string propertyType)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE [PropertyType]=@PropertyType";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyType", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyType;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectPropertyModel> GetListByPropertyKey(string propertyKey)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE [PropertyKey]=@PropertyKey";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyKey", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyKey;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectPropertyModel> GetListByPropertyValue(string propertyValue)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE [PropertyValue]=@PropertyValue";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyValue", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyValue;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
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
			StringBuilder sql = new StringBuilder("SELECT * FROM [ProjectProperty] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
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
		public List<ProjectPropertyModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [ProjectProperty] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
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
		public List<ProjectPropertyModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [ProjectProperty] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public ProjectPropertyModel GetModel(int PropertyID)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE  PropertyID=@PropertyID";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyID", SqlDbType.Int),
			};
			parameters[0].Value = PropertyID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectPropertyModel GetModelByPropertyID(int propertyID)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE [PropertyID]=@PropertyID";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyID", SqlDbType.Int),
			};
			parameters[0].Value = propertyID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectPropertyModel GetModelByPropertyType(string propertyType)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE [PropertyType]=@PropertyType";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyType", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyType;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectPropertyModel GetModelByPropertyKey(string propertyKey)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE [PropertyKey]=@PropertyKey";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyKey", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyKey;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectPropertyModel GetModelByPropertyValue(string propertyValue)
		{
			string sql = "SELECT * FROM [ProjectProperty] WHERE [PropertyValue]=@PropertyValue";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyValue", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyValue;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(ProjectPropertyModel model)
		{
			string sql = "INSERT INTO [ProjectProperty]([PropertyType],[PropertyKey],[PropertyValue]) VALUES(@PropertyType,@PropertyKey,@PropertyValue)";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyType", SqlDbType.NVarChar),
				new SqlParameter("@PropertyKey", SqlDbType.NVarChar),
				new SqlParameter("@PropertyValue", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.PropertyType == null ? (object)DBNull.Value : model.PropertyType;
			parameters[1].Value = model.PropertyKey == null ? (object)DBNull.Value : model.PropertyKey;
			parameters[2].Value = model.PropertyValue == null ? (object)DBNull.Value : model.PropertyValue;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(ProjectPropertyModel model)
		{
			string sql = "UPDATE [ProjectProperty] SET [PropertyType]=@PropertyType,[PropertyKey]=@PropertyKey,[PropertyValue]=@PropertyValue WHERE PropertyID=@PropertyID";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyID", SqlDbType.Int),
				new SqlParameter("@PropertyType", SqlDbType.NVarChar),
				new SqlParameter("@PropertyKey", SqlDbType.NVarChar),
				new SqlParameter("@PropertyValue", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.PropertyID;
			parameters[1].Value = model.PropertyType == null ? (object)DBNull.Value : model.PropertyType;
			parameters[2].Value = model.PropertyKey == null ? (object)DBNull.Value : model.PropertyKey;
			parameters[3].Value = model.PropertyValue == null ? (object)DBNull.Value : model.PropertyValue;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int PropertyID)
		{
			string sql = "DELETE FROM [ProjectProperty] WHERE  PropertyID=@PropertyID";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyID", SqlDbType.Int),
			};
			parameters[0].Value = PropertyID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPropertyID(int propertyID)
		{
			string sql = "DELETE FROM [ProjectProperty] WHERE [PropertyID]=@PropertyID";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyID", SqlDbType.Int),
			};
			parameters[0].Value = propertyID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPropertyType(string propertyType)
		{
			string sql = "DELETE FROM [ProjectProperty] WHERE [PropertyType]=@PropertyType";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyType", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyType;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPropertyKey(string propertyKey)
		{
			string sql = "DELETE FROM [ProjectProperty] WHERE [PropertyKey]=@PropertyKey";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyKey", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyKey;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPropertyValue(string propertyValue)
		{
			string sql = "DELETE FROM [ProjectProperty] WHERE [PropertyValue]=@PropertyValue";
			SqlParameter[] parameters = {
				new SqlParameter("@PropertyValue", SqlDbType.NVarChar),
			};
			parameters[0].Value = propertyValue;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public ProjectPropertyModel DataRowToModel(DataRow row)
		{
			ProjectPropertyModel model = new ProjectPropertyModel();
            if (row == null) return model;

			if (row["PropertyID"] != null && row["PropertyID"].ToString() != "")
			{
				model.PropertyID = int.Parse(row["PropertyID"].ToString());
			}
			if (row["PropertyType"] != null && row["PropertyType"].ToString() != "")
			{
				model.PropertyType = row["PropertyType"].ToString();
			}
			if (row["PropertyKey"] != null && row["PropertyKey"].ToString() != "")
			{
				model.PropertyKey = row["PropertyKey"].ToString();
			}
			if (row["PropertyValue"] != null && row["PropertyValue"].ToString() != "")
			{
				model.PropertyValue = row["PropertyValue"].ToString();
			}

			return model;
		}

		#endregion
    }
}
