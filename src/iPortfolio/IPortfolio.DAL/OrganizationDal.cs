using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using IPortfolio.Model;

namespace IPortfolio.DAL
{
    public partial class OrganizationDal
    {
		public List<OrganizationModel> GetAll()
		{
			List<OrganizationModel> result = new List<OrganizationModel>();
			string sql = "SELECT * FROM [Organization]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<OrganizationModel> GetListByOrgID(int orgID)
		{
			string sql = "SELECT * FROM [Organization] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<OrganizationModel> result = new List<OrganizationModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<OrganizationModel> GetListByOrganization(string organization)
		{
			string sql = "SELECT * FROM [Organization] WHERE [Organization]=@Organization";
			SqlParameter[] parameters = {
				new SqlParameter("@Organization", SqlDbType.NVarChar),
			};
			parameters[0].Value = organization;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<OrganizationModel> result = new List<OrganizationModel>();
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
		public List<OrganizationModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Organization] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<OrganizationModel> result = new List<OrganizationModel>();
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
		public List<OrganizationModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Organization] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<OrganizationModel> result = new List<OrganizationModel>();
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
		public List<OrganizationModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Organization] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<OrganizationModel> result = new List<OrganizationModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public OrganizationModel GetModel(int OrgID)
		{
			string sql = "SELECT * FROM [Organization] WHERE  OrgID=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = OrgID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public OrganizationModel GetModelByOrgID(int orgID)
		{
			string sql = "SELECT * FROM [Organization] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public OrganizationModel GetModelByOrganization(string organization)
		{
			string sql = "SELECT * FROM [Organization] WHERE [Organization]=@Organization";
			SqlParameter[] parameters = {
				new SqlParameter("@Organization", SqlDbType.NVarChar),
			};
			parameters[0].Value = organization;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(OrganizationModel model)
		{
			string sql = "INSERT INTO [Organization]([OrgID],[Organization]) VALUES(@OrgID,@Organization)";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
				new SqlParameter("@Organization", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.OrgID;
			parameters[1].Value = model.Organization == null ? (object)DBNull.Value : model.Organization;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(OrganizationModel model)
		{
			string sql = "UPDATE [Organization] SET [OrgID]=@OrgID,[Organization]=@Organization WHERE OrgID=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
				new SqlParameter("@Organization", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.OrgID;
			parameters[1].Value = model.Organization == null ? (object)DBNull.Value : model.Organization;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int OrgID)
		{
			string sql = "DELETE FROM [Organization] WHERE  OrgID=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = OrgID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByOrgID(int orgID)
		{
			string sql = "DELETE FROM [Organization] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByOrganization(string organization)
		{
			string sql = "DELETE FROM [Organization] WHERE [Organization]=@Organization";
			SqlParameter[] parameters = {
				new SqlParameter("@Organization", SqlDbType.NVarChar),
			};
			parameters[0].Value = organization;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public OrganizationModel DataRowToModel(DataRow row)
		{
			OrganizationModel model = new OrganizationModel();
            if (row == null) return model;

			if (row["OrgID"] != null && row["OrgID"].ToString() != "")
			{
				model.OrgID = int.Parse(row["OrgID"].ToString());
			}
			if (row["Organization"] != null && row["Organization"].ToString() != "")
			{
				model.Organization = row["Organization"].ToString();
			}

			return model;
		}
    }
}
