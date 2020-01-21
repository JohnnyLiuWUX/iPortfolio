using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using IPortfolio.Model;

namespace IPortfolio.DAL
{
    public partial class AuditItemDal
    {
		public List<AuditItemModel> GetAll()
		{
			List<AuditItemModel> result = new List<AuditItemModel>();
			string sql = "SELECT * FROM [AuditItem]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditItemModel> GetListByItemID(int itemID)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [ItemID]=@ItemID";
			SqlParameter[] parameters = {
				new SqlParameter("@ItemID", SqlDbType.Int),
			};
			parameters[0].Value = itemID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditItemModel> result = new List<AuditItemModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditItemModel> GetListByAuditID(int auditID)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [AuditID]=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
			};
			parameters[0].Value = auditID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditItemModel> result = new List<AuditItemModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditItemModel> GetListByAuditRuleID(int auditRuleID)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [AuditRuleID]=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
			};
			parameters[0].Value = auditRuleID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditItemModel> result = new List<AuditItemModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditItemModel> GetListByStatus(int status)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditItemModel> result = new List<AuditItemModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditItemModel> GetListByEvidence(string evidence)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [Evidence]=@Evidence";
			SqlParameter[] parameters = {
				new SqlParameter("@Evidence", SqlDbType.NVarChar),
			};
			parameters[0].Value = evidence;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditItemModel> result = new List<AuditItemModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<AuditItemModel> GetListByComments(string comments)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [Comments]=@Comments";
			SqlParameter[] parameters = {
				new SqlParameter("@Comments", SqlDbType.NVarChar),
			};
			parameters[0].Value = comments;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<AuditItemModel> result = new List<AuditItemModel>();
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
		public List<AuditItemModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [AuditItem] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<AuditItemModel> result = new List<AuditItemModel>();
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
		public List<AuditItemModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [AuditItem] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<AuditItemModel> result = new List<AuditItemModel>();
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
		public List<AuditItemModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [AuditItem] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<AuditItemModel> result = new List<AuditItemModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public AuditItemModel GetModel(int ItemID)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE  ItemID=@ItemID";
			SqlParameter[] parameters = {
				new SqlParameter("@ItemID", SqlDbType.Int),
			};
			parameters[0].Value = ItemID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditItemModel GetModelByItemID(int itemID)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [ItemID]=@ItemID";
			SqlParameter[] parameters = {
				new SqlParameter("@ItemID", SqlDbType.Int),
			};
			parameters[0].Value = itemID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditItemModel GetModelByAuditID(int auditID)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [AuditID]=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
			};
			parameters[0].Value = auditID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditItemModel GetModelByAuditRuleID(int auditRuleID)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [AuditRuleID]=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
			};
			parameters[0].Value = auditRuleID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditItemModel GetModelByStatus(int status)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditItemModel GetModelByEvidence(string evidence)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [Evidence]=@Evidence";
			SqlParameter[] parameters = {
				new SqlParameter("@Evidence", SqlDbType.NVarChar),
			};
			parameters[0].Value = evidence;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public AuditItemModel GetModelByComments(string comments)
		{
			string sql = "SELECT * FROM [AuditItem] WHERE [Comments]=@Comments";
			SqlParameter[] parameters = {
				new SqlParameter("@Comments", SqlDbType.NVarChar),
			};
			parameters[0].Value = comments;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(AuditItemModel model)
		{
			string sql = "INSERT INTO [AuditItem]([AuditID],[AuditRuleID],[Status],[Evidence],[Comments]) VALUES(@AuditID,@AuditRuleID,@Status,@Evidence,@Comments)";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@Evidence", SqlDbType.NVarChar),
				new SqlParameter("@Comments", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.AuditID == null ? (object)DBNull.Value : model.AuditID;
			parameters[1].Value = model.AuditRuleID == null ? (object)DBNull.Value : model.AuditRuleID;
			parameters[2].Value = model.Status == null ? (object)DBNull.Value : model.Status;
			parameters[3].Value = model.Evidence == null ? (object)DBNull.Value : model.Evidence;
			parameters[4].Value = model.Comments == null ? (object)DBNull.Value : model.Comments;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(AuditItemModel model)
		{
			string sql = "UPDATE [AuditItem] SET [AuditID]=@AuditID,[AuditRuleID]=@AuditRuleID,[Status]=@Status,[Evidence]=@Evidence,[Comments]=@Comments WHERE ItemID=@ItemID";
			SqlParameter[] parameters = {
				new SqlParameter("@ItemID", SqlDbType.Int),
				new SqlParameter("@AuditID", SqlDbType.Int),
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@Evidence", SqlDbType.NVarChar),
				new SqlParameter("@Comments", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.ItemID;
			parameters[1].Value = model.AuditID == null ? (object)DBNull.Value : model.AuditID;
			parameters[2].Value = model.AuditRuleID == null ? (object)DBNull.Value : model.AuditRuleID;
			parameters[3].Value = model.Status == null ? (object)DBNull.Value : model.Status;
			parameters[4].Value = model.Evidence == null ? (object)DBNull.Value : model.Evidence;
			parameters[5].Value = model.Comments == null ? (object)DBNull.Value : model.Comments;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int ItemID)
		{
			string sql = "DELETE FROM [AuditItem] WHERE  ItemID=@ItemID";
			SqlParameter[] parameters = {
				new SqlParameter("@ItemID", SqlDbType.Int),
			};
			parameters[0].Value = ItemID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByItemID(int itemID)
		{
			string sql = "DELETE FROM [AuditItem] WHERE [ItemID]=@ItemID";
			SqlParameter[] parameters = {
				new SqlParameter("@ItemID", SqlDbType.Int),
			};
			parameters[0].Value = itemID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByAuditID(int auditID)
		{
			string sql = "DELETE FROM [AuditItem] WHERE [AuditID]=@AuditID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditID", SqlDbType.Int),
			};
			parameters[0].Value = auditID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByAuditRuleID(int auditRuleID)
		{
			string sql = "DELETE FROM [AuditItem] WHERE [AuditRuleID]=@AuditRuleID";
			SqlParameter[] parameters = {
				new SqlParameter("@AuditRuleID", SqlDbType.Int),
			};
			parameters[0].Value = auditRuleID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStatus(int status)
		{
			string sql = "DELETE FROM [AuditItem] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByEvidence(string evidence)
		{
			string sql = "DELETE FROM [AuditItem] WHERE [Evidence]=@Evidence";
			SqlParameter[] parameters = {
				new SqlParameter("@Evidence", SqlDbType.NVarChar),
			};
			parameters[0].Value = evidence;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByComments(string comments)
		{
			string sql = "DELETE FROM [AuditItem] WHERE [Comments]=@Comments";
			SqlParameter[] parameters = {
				new SqlParameter("@Comments", SqlDbType.NVarChar),
			};
			parameters[0].Value = comments;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public AuditItemModel DataRowToModel(DataRow row)
		{
			AuditItemModel model = new AuditItemModel();
            if (row == null) return model;

			if (row["ItemID"] != null && row["ItemID"].ToString() != "")
			{
				model.ItemID = int.Parse(row["ItemID"].ToString());
			}
			if (row["AuditID"] != null && row["AuditID"].ToString() != "")
			{
				model.AuditID = int.Parse(row["AuditID"].ToString());
			}
			if (row["AuditRuleID"] != null && row["AuditRuleID"].ToString() != "")
			{
				model.AuditRuleID = int.Parse(row["AuditRuleID"].ToString());
			}
			if (row["Status"] != null && row["Status"].ToString() != "")
			{
				model.Status = int.Parse(row["Status"].ToString());
			}
			if (row["Evidence"] != null && row["Evidence"].ToString() != "")
			{
				model.Evidence = row["Evidence"].ToString();
			}
			if (row["Comments"] != null && row["Comments"].ToString() != "")
			{
				model.Comments = row["Comments"].ToString();
			}

			return model;
		}
    }
}
