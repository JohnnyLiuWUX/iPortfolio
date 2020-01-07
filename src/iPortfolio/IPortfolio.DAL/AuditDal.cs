/**
 * Auto Create By Code Magic 2020-01-07 02:48:21
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
    public partial class AuditDal
    {
		#region Auto Create By Code Magic

		public List<AuditModel> GetAll()
		{
			List<AuditModel> result = new List<AuditModel>();
			string sql = "SELECT * FROM [Audit]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditModel> GetListByAuditID(int auditID)
		{
			string sql = "SELECT * FROM [Audit] WHERE [AuditID]=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
			};
			parameters[0].Value = auditID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditModel> result = new List<AuditModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditModel> GetListByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [Audit] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditModel> result = new List<AuditModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditModel> GetListByStatus(int status)
		{
			string sql = "SELECT * FROM [Audit] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditModel> result = new List<AuditModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditModel> GetListByDueDate(string dueDate)
		{
			string sql = "SELECT * FROM [Audit] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditModel> result = new List<AuditModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditModel> GetListByAuditor(string auditor)
		{
			string sql = "SELECT * FROM [Audit] WHERE [Auditor]=@Auditor";
			SqlParameter[] parameters = {
				new SqlParameter("@Auditor", SqlDbType.VarChar),
			};
			parameters[0].Value = auditor;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditModel> result = new List<AuditModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditModel> GetListByCreatedTime(DateTime createdTime)
		{
			string sql = "SELECT * FROM [Audit] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditModel> result = new List<AuditModel>();
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
		public List<AuditModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Audit] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<AuditModel> result = new List<AuditModel>();
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
		public List<AuditModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Audit] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<AuditModel> result = new List<AuditModel>();
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
		public List<AuditModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Audit] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<AuditModel> result = new List<AuditModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public AuditModel GetModel(int AuditID)
		{
			string sql = "SELECT * FROM [Audit] WHERE  AuditID=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
			};
			parameters[0].Value = AuditID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditModel GetModelByAuditID(int auditID)
		{
			string sql = "SELECT * FROM [Audit] WHERE [AuditID]=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
			};
			parameters[0].Value = auditID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditModel GetModelByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [Audit] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditModel GetModelByStatus(int status)
		{
			string sql = "SELECT * FROM [Audit] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditModel GetModelByDueDate(string dueDate)
		{
			string sql = "SELECT * FROM [Audit] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditModel GetModelByAuditor(string auditor)
		{
			string sql = "SELECT * FROM [Audit] WHERE [Auditor]=@Auditor";
			SqlParameter[] parameters = {
				new SqlParameter("@Auditor", SqlDbType.VarChar),
			};
			parameters[0].Value = auditor;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditModel GetModelByCreatedTime(DateTime createdTime)
		{
			string sql = "SELECT * FROM [Audit] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(AuditModel model)
		{
			string sql = "INSERT INTO [Audit]([ProjectID],[Status],[DueDate],[Auditor],[CreatedTime]) VALUES(@ProjectID,@Status,@DueDate,@Auditor,@CreatedTime)";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@DueDate", SqlDbType.Date),
				new SqlParameter("@Auditor", SqlDbType.VarChar),
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = model.ProjectID == null ? (object)DBNull.Value : model.ProjectID;
			parameters[1].Value = model.Status == null ? (object)DBNull.Value : model.Status;
			parameters[2].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
			parameters[3].Value = model.Auditor == null ? (object)DBNull.Value : model.Auditor;
			parameters[4].Value = model.CreatedTime == null ? (object)DBNull.Value : model.CreatedTime;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(AuditModel model)
		{
			string sql = "UPDATE [Audit] SET [ProjectID]=@ProjectID,[Status]=@Status,[DueDate]=@DueDate,[Auditor]=@Auditor,[CreatedTime]=@CreatedTime WHERE AuditID=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@DueDate", SqlDbType.Date),
				new SqlParameter("@Auditor", SqlDbType.VarChar),
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = model.AuditID;
			parameters[1].Value = model.ProjectID == null ? (object)DBNull.Value : model.ProjectID;
			parameters[2].Value = model.Status == null ? (object)DBNull.Value : model.Status;
			parameters[3].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
			parameters[4].Value = model.Auditor == null ? (object)DBNull.Value : model.Auditor;
			parameters[5].Value = model.CreatedTime == null ? (object)DBNull.Value : model.CreatedTime;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int AuditID)
		{
			string sql = "DELETE FROM [Audit] WHERE  AuditID=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
			};
			parameters[0].Value = AuditID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByAuditID(int auditID)
		{
			string sql = "DELETE FROM [Audit] WHERE [AuditID]=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
			};
			parameters[0].Value = auditID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByProjectID(int projectID)
		{
			string sql = "DELETE FROM [Audit] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStatus(int status)
		{
			string sql = "DELETE FROM [Audit] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDueDate(string dueDate)
		{
			string sql = "DELETE FROM [Audit] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByAuditor(string auditor)
		{
			string sql = "DELETE FROM [Audit] WHERE [Auditor]=@Auditor";
			SqlParameter[] parameters = {
				new SqlParameter("@Auditor", SqlDbType.VarChar),
			};
			parameters[0].Value = auditor;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCreatedTime(DateTime createdTime)
		{
			string sql = "DELETE FROM [Audit] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public AuditModel DataRowToModel(DataRow row)
		{
			AuditModel model = new AuditModel();
            if (row == null) return model;

			if (row["AuditID"] != null && row["AuditID"].ToString() != "")
			{
				model.AuditID = int.Parse(row["AuditID"].ToString());
			}
			if (row["ProjectID"] != null && row["ProjectID"].ToString() != "")
			{
				model.ProjectID = int.Parse(row["ProjectID"].ToString());
			}
			if (row["Status"] != null && row["Status"].ToString() != "")
			{
				model.Status = int.Parse(row["Status"].ToString());
			}
			if (row["DueDate"] != null && row["DueDate"].ToString() != "")
			{
				model.DueDate = row["DueDate"].ToString();
			}
			if (row["Auditor"] != null && row["Auditor"].ToString() != "")
			{
				model.Auditor = row["Auditor"].ToString();
			}
			if (row["CreatedTime"] != null && row["CreatedTime"].ToString() != "")
			{
				model.CreatedTime = DateTime.Parse(row["CreatedTime"].ToString());
			}

			return model;
		}

		#endregion
    }
}
