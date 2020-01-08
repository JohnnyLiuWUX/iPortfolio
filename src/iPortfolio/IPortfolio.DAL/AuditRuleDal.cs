/**
 * Auto Create By Code Magic 2020-01-08 11:26:59
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
    public partial class AuditRuleDal
    {
		#region Auto Create By Code Magic

		public List<AuditRuleModel> GetAll()
		{
			List<AuditRuleModel> result = new List<AuditRuleModel>();
			string sql = "SELECT * FROM [AuditRule]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditRuleModel> GetListByAuditRuleID(int auditRuleID)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE [AuditRuleID]=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
			};
			parameters[0].Value = auditRuleID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditRuleModel> result = new List<AuditRuleModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditRuleModel> GetListByArea(string area)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE [Area]=@Area";
			SqlParameter[] parameters = {
				new SqlParameter("@Area", SqlDbType.NVarChar),
			};
			parameters[0].Value = area;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditRuleModel> result = new List<AuditRuleModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditRuleModel> GetListByRule(string rule)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE [Rule]=@Rule";
			SqlParameter[] parameters = {
				new SqlParameter("@Rule", SqlDbType.NVarChar),
			};
			parameters[0].Value = rule;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditRuleModel> result = new List<AuditRuleModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditRuleModel> GetListByStatus(int status)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditRuleModel> result = new List<AuditRuleModel>();
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
		public List<AuditRuleModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [AuditRule] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<AuditRuleModel> result = new List<AuditRuleModel>();
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
		public List<AuditRuleModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [AuditRule] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<AuditRuleModel> result = new List<AuditRuleModel>();
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
		public List<AuditRuleModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [AuditRule] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<AuditRuleModel> result = new List<AuditRuleModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public AuditRuleModel GetModel(int AuditRuleID)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE  AuditRuleID=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
			};
			parameters[0].Value = AuditRuleID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditRuleModel GetModelByAuditRuleID(int auditRuleID)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE [AuditRuleID]=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
			};
			parameters[0].Value = auditRuleID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditRuleModel GetModelByArea(string area)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE [Area]=@Area";
			SqlParameter[] parameters = {
				new SqlParameter("@Area", SqlDbType.NVarChar),
			};
			parameters[0].Value = area;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditRuleModel GetModelByRule(string rule)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE [Rule]=@Rule";
			SqlParameter[] parameters = {
				new SqlParameter("@Rule", SqlDbType.NVarChar),
			};
			parameters[0].Value = rule;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditRuleModel GetModelByStatus(int status)
		{
			string sql = "SELECT * FROM [AuditRule] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(AuditRuleModel model)
		{
			string sql = "INSERT INTO [AuditRule]([Area],[Rule],[Status]) VALUES(@Area,@Rule,@Status)";
			SqlParameter[] parameters = {
				new SqlParameter("@Area", SqlDbType.NVarChar),
				new SqlParameter("@Rule", SqlDbType.NVarChar),
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = model.Area == null ? (object)DBNull.Value : model.Area;
			parameters[1].Value = model.Rule == null ? (object)DBNull.Value : model.Rule;
			parameters[2].Value = model.Status == null ? (object)DBNull.Value : model.Status;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(AuditRuleModel model)
		{
			string sql = "UPDATE [AuditRule] SET [Area]=@Area,[Rule]=@Rule,[Status]=@Status WHERE AuditRuleID=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
				new SqlParameter("@Area", SqlDbType.NVarChar),
				new SqlParameter("@Rule", SqlDbType.NVarChar),
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = model.AuditRuleID;
			parameters[1].Value = model.Area == null ? (object)DBNull.Value : model.Area;
			parameters[2].Value = model.Rule == null ? (object)DBNull.Value : model.Rule;
			parameters[3].Value = model.Status == null ? (object)DBNull.Value : model.Status;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int AuditRuleID)
		{
			string sql = "DELETE FROM [AuditRule] WHERE  AuditRuleID=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
			};
			parameters[0].Value = AuditRuleID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByAuditRuleID(int auditRuleID)
		{
			string sql = "DELETE FROM [AuditRule] WHERE [AuditRuleID]=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
			};
			parameters[0].Value = auditRuleID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByArea(string area)
		{
			string sql = "DELETE FROM [AuditRule] WHERE [Area]=@Area";
			SqlParameter[] parameters = {
				new SqlParameter("@Area", SqlDbType.NVarChar),
			};
			parameters[0].Value = area;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByRule(string rule)
		{
			string sql = "DELETE FROM [AuditRule] WHERE [Rule]=@Rule";
			SqlParameter[] parameters = {
				new SqlParameter("@Rule", SqlDbType.NVarChar),
			};
			parameters[0].Value = rule;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStatus(int status)
		{
			string sql = "DELETE FROM [AuditRule] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public AuditRuleModel DataRowToModel(DataRow row)
		{
			AuditRuleModel model = new AuditRuleModel();
            if (row == null) return model;

			if (row["AuditRuleID"] != null && row["AuditRuleID"].ToString() != "")
			{
				model.AuditRuleID = int.Parse(row["AuditRuleID"].ToString());
			}
			if (row["Area"] != null && row["Area"].ToString() != "")
			{
				model.Area = row["Area"].ToString();
			}
			if (row["Rule"] != null && row["Rule"].ToString() != "")
			{
				model.Rule = row["Rule"].ToString();
			}
			if (row["Status"] != null && row["Status"].ToString() != "")
			{
				model.Status = int.Parse(row["Status"].ToString());
			}

			return model;
		}

		#endregion
    }
}
