using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using IPortfolio.Model;

namespace IPortfolio.DAL
{
    public partial class SpendingDal
    {
		public List<SpendingModel> GetAll()
		{
			List<SpendingModel> result = new List<SpendingModel>();
			string sql = "SELECT * FROM [Spending]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<SpendingModel> GetListBySpendID(int spendID)
		{
			string sql = "SELECT * FROM [Spending] WHERE [SpendID]=@SpendID";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendID", SqlDbType.Int),
			};
			parameters[0].Value = spendID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<SpendingModel> result = new List<SpendingModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<SpendingModel> GetListByTaskID(int taskID)
		{
			string sql = "SELECT * FROM [Spending] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<SpendingModel> result = new List<SpendingModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<SpendingModel> GetListByTitle(string title)
		{
			string sql = "SELECT * FROM [Spending] WHERE [Title]=@Title";
			SqlParameter[] parameters = {
				new SqlParameter("@Title", SqlDbType.NVarChar),
			};
			parameters[0].Value = title;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<SpendingModel> result = new List<SpendingModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<SpendingModel> GetListByRecordDate(DateTime recordDate)
		{
			string sql = "SELECT * FROM [Spending] WHERE [RecordDate]=@RecordDate";
			SqlParameter[] parameters = {
				new SqlParameter("@RecordDate", SqlDbType.Date),
			};
			parameters[0].Value = recordDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<SpendingModel> result = new List<SpendingModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<SpendingModel> GetListBySpendHour(int spendHour)
		{
			string sql = "SELECT * FROM [Spending] WHERE [SpendHour]=@SpendHour";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendHour", SqlDbType.Int),
			};
			parameters[0].Value = spendHour;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<SpendingModel> result = new List<SpendingModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<SpendingModel> GetListByCreatedBy(string createdBy)
		{
			string sql = "SELECT * FROM [Spending] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<SpendingModel> result = new List<SpendingModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<SpendingModel> GetListByCreateTime(DateTime createTime)
		{
			string sql = "SELECT * FROM [Spending] WHERE [CreateTime]=@CreateTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<SpendingModel> result = new List<SpendingModel>();
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
		public List<SpendingModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Spending] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<SpendingModel> result = new List<SpendingModel>();
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
		public List<SpendingModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Spending] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<SpendingModel> result = new List<SpendingModel>();
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
		public List<SpendingModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Spending] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<SpendingModel> result = new List<SpendingModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public SpendingModel GetModel(int SpendID)
		{
			string sql = "SELECT * FROM [Spending] WHERE  SpendID=@SpendID";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendID", SqlDbType.Int),
			};
			parameters[0].Value = SpendID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public SpendingModel GetModelBySpendID(int spendID)
		{
			string sql = "SELECT * FROM [Spending] WHERE [SpendID]=@SpendID";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendID", SqlDbType.Int),
			};
			parameters[0].Value = spendID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public SpendingModel GetModelByTaskID(int taskID)
		{
			string sql = "SELECT * FROM [Spending] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public SpendingModel GetModelByTitle(string title)
		{
			string sql = "SELECT * FROM [Spending] WHERE [Title]=@Title";
			SqlParameter[] parameters = {
				new SqlParameter("@Title", SqlDbType.NVarChar),
			};
			parameters[0].Value = title;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public SpendingModel GetModelByRecordDate(DateTime recordDate)
		{
			string sql = "SELECT * FROM [Spending] WHERE [RecordDate]=@RecordDate";
			SqlParameter[] parameters = {
				new SqlParameter("@RecordDate", SqlDbType.Date),
			};
			parameters[0].Value = recordDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public SpendingModel GetModelBySpendHour(int spendHour)
		{
			string sql = "SELECT * FROM [Spending] WHERE [SpendHour]=@SpendHour";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendHour", SqlDbType.Int),
			};
			parameters[0].Value = spendHour;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public SpendingModel GetModelByCreatedBy(string createdBy)
		{
			string sql = "SELECT * FROM [Spending] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public SpendingModel GetModelByCreateTime(DateTime createTime)
		{
			string sql = "SELECT * FROM [Spending] WHERE [CreateTime]=@CreateTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(SpendingModel model)
		{
			string sql = "INSERT INTO [Spending]([TaskID],[Title],[RecordDate],[SpendHour],[CreatedBy],[CreateTime]) VALUES(@TaskID,@Title,@RecordDate,@SpendHour,@CreatedBy,@CreateTime)";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
				new SqlParameter("@Title", SqlDbType.NVarChar),
				new SqlParameter("@RecordDate", SqlDbType.Date),
				new SqlParameter("@SpendHour", SqlDbType.Int),
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
			};
			parameters[0].Value = model.TaskID == null ? (object)DBNull.Value : model.TaskID;
			parameters[1].Value = model.Title == null ? (object)DBNull.Value : model.Title;
			parameters[2].Value = model.RecordDate == null ? (object)DBNull.Value : model.RecordDate;
			parameters[3].Value = model.SpendHour == null ? (object)DBNull.Value : model.SpendHour;
			parameters[4].Value = model.CreatedBy == null ? (object)DBNull.Value : model.CreatedBy;
			parameters[5].Value = model.CreateTime == null ? (object)DBNull.Value : model.CreateTime;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(SpendingModel model)
		{
			string sql = "UPDATE [Spending] SET [TaskID]=@TaskID,[Title]=@Title,[RecordDate]=@RecordDate,[SpendHour]=@SpendHour,[CreatedBy]=@CreatedBy,[CreateTime]=@CreateTime WHERE SpendID=@SpendID";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendID", SqlDbType.Int),
				new SqlParameter("@TaskID", SqlDbType.Int),
				new SqlParameter("@Title", SqlDbType.NVarChar),
				new SqlParameter("@RecordDate", SqlDbType.Date),
				new SqlParameter("@SpendHour", SqlDbType.Int),
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
			};
			parameters[0].Value = model.SpendID;
			parameters[1].Value = model.TaskID == null ? (object)DBNull.Value : model.TaskID;
			parameters[2].Value = model.Title == null ? (object)DBNull.Value : model.Title;
			parameters[3].Value = model.RecordDate == null ? (object)DBNull.Value : model.RecordDate;
			parameters[4].Value = model.SpendHour == null ? (object)DBNull.Value : model.SpendHour;
			parameters[5].Value = model.CreatedBy == null ? (object)DBNull.Value : model.CreatedBy;
			parameters[6].Value = model.CreateTime == null ? (object)DBNull.Value : model.CreateTime;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int SpendID)
		{
			string sql = "DELETE FROM [Spending] WHERE  SpendID=@SpendID";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendID", SqlDbType.Int),
			};
			parameters[0].Value = SpendID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteBySpendID(int spendID)
		{
			string sql = "DELETE FROM [Spending] WHERE [SpendID]=@SpendID";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendID", SqlDbType.Int),
			};
			parameters[0].Value = spendID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByTaskID(int taskID)
		{
			string sql = "DELETE FROM [Spending] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByTitle(string title)
		{
			string sql = "DELETE FROM [Spending] WHERE [Title]=@Title";
			SqlParameter[] parameters = {
				new SqlParameter("@Title", SqlDbType.NVarChar),
			};
			parameters[0].Value = title;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByRecordDate(DateTime recordDate)
		{
			string sql = "DELETE FROM [Spending] WHERE [RecordDate]=@RecordDate";
			SqlParameter[] parameters = {
				new SqlParameter("@RecordDate", SqlDbType.Date),
			};
			parameters[0].Value = recordDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteBySpendHour(int spendHour)
		{
			string sql = "DELETE FROM [Spending] WHERE [SpendHour]=@SpendHour";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendHour", SqlDbType.Int),
			};
			parameters[0].Value = spendHour;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCreatedBy(string createdBy)
		{
			string sql = "DELETE FROM [Spending] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCreateTime(DateTime createTime)
		{
			string sql = "DELETE FROM [Spending] WHERE [CreateTime]=@CreateTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createTime;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public SpendingModel DataRowToModel(DataRow row)
		{
			SpendingModel model = new SpendingModel();
            if (row == null) return model;

			if (row["SpendID"] != null && row["SpendID"].ToString() != "")
			{
				model.SpendID = int.Parse(row["SpendID"].ToString());
			}
			if (row["TaskID"] != null && row["TaskID"].ToString() != "")
			{
				model.TaskID = int.Parse(row["TaskID"].ToString());
			}
			if (row["Title"] != null && row["Title"].ToString() != "")
			{
				model.Title = row["Title"].ToString();
			}
			if (row["RecordDate"] != null && row["RecordDate"].ToString() != "")
			{
				model.RecordDate = DateTime.Parse(row["RecordDate"].ToString());
			}
			if (row["SpendHour"] != null && row["SpendHour"].ToString() != "")
			{
				model.SpendHour = int.Parse(row["SpendHour"].ToString());
			}
			if (row["CreatedBy"] != null && row["CreatedBy"].ToString() != "")
			{
				model.CreatedBy = row["CreatedBy"].ToString();
			}
			if (row["CreateTime"] != null && row["CreateTime"].ToString() != "")
			{
				model.CreateTime = DateTime.Parse(row["CreateTime"].ToString());
			}

			return model;
		}
    }
}
