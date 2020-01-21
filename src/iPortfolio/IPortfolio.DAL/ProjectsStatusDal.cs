using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using IPortfolio.Model;

namespace IPortfolio.DAL
{
    public partial class ProjectsStatusDal
    {
		public List<ProjectsStatusModel> GetAll()
		{
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
			string sql = "SELECT * FROM [ProjectsStatus]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectsStatusModel> GetListByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectsStatusModel> GetListByReportDate(DateTime reportDate)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [ReportDate]=@ReportDate";
			SqlParameter[] parameters = {
				new SqlParameter("@ReportDate", SqlDbType.DateTime),
			};
			parameters[0].Value = reportDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectsStatusModel> GetListByPhase(string phase)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [Phase]=@Phase";
			SqlParameter[] parameters = {
				new SqlParameter("@Phase", SqlDbType.NVarChar),
			};
			parameters[0].Value = phase;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectsStatusModel> GetListByDueDate(DateTime dueDate)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.DateTime),
			};
			parameters[0].Value = dueDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectsStatusModel> GetListByDonePercent(int donePercent)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [DonePercent]=@DonePercent";
			SqlParameter[] parameters = {
				new SqlParameter("@DonePercent", SqlDbType.Int),
			};
			parameters[0].Value = donePercent;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectsStatusModel> GetListBySpendHour(int spendHour)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [SpendHour]=@SpendHour";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendHour", SqlDbType.Int),
			};
			parameters[0].Value = spendHour;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectsStatusModel> GetListBySpendingRemark(string spendingRemark)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [SpendingRemark]=@SpendingRemark";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendingRemark", SqlDbType.NVarChar),
			};
			parameters[0].Value = spendingRemark;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
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
		public List<ProjectsStatusModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [ProjectsStatus] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
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
		public List<ProjectsStatusModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [ProjectsStatus] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
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
		public List<ProjectsStatusModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [ProjectsStatus] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<ProjectsStatusModel> result = new List<ProjectsStatusModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public ProjectsStatusModel GetModel(int ProjectID, DateTime ReportDate)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE  ProjectID=@ProjectID and ReportDate=@ReportDate";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@ReportDate", SqlDbType.DateTime),
			};
			parameters[0].Value = ProjectID;
			parameters[1].Value = ReportDate;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectsStatusModel GetModelByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectsStatusModel GetModelByReportDate(DateTime reportDate)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [ReportDate]=@ReportDate";
			SqlParameter[] parameters = {
				new SqlParameter("@ReportDate", SqlDbType.DateTime),
			};
			parameters[0].Value = reportDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectsStatusModel GetModelByPhase(string phase)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [Phase]=@Phase";
			SqlParameter[] parameters = {
				new SqlParameter("@Phase", SqlDbType.NVarChar),
			};
			parameters[0].Value = phase;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectsStatusModel GetModelByDueDate(DateTime dueDate)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.DateTime),
			};
			parameters[0].Value = dueDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectsStatusModel GetModelByDonePercent(int donePercent)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [DonePercent]=@DonePercent";
			SqlParameter[] parameters = {
				new SqlParameter("@DonePercent", SqlDbType.Int),
			};
			parameters[0].Value = donePercent;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectsStatusModel GetModelBySpendHour(int spendHour)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [SpendHour]=@SpendHour";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendHour", SqlDbType.Int),
			};
			parameters[0].Value = spendHour;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectsStatusModel GetModelBySpendingRemark(string spendingRemark)
		{
			string sql = "SELECT * FROM [ProjectsStatus] WHERE [SpendingRemark]=@SpendingRemark";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendingRemark", SqlDbType.NVarChar),
			};
			parameters[0].Value = spendingRemark;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(ProjectsStatusModel model)
		{
			string sql = "INSERT INTO [ProjectsStatus]([ProjectID],[ReportDate],[Phase],[DueDate],[DonePercent],[SpendHour],[SpendingRemark]) VALUES(@ProjectID,@ReportDate,@Phase,@DueDate,@DonePercent,@SpendHour,@SpendingRemark)";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@ReportDate", SqlDbType.DateTime),
				new SqlParameter("@Phase", SqlDbType.NVarChar),
				new SqlParameter("@DueDate", SqlDbType.DateTime),
				new SqlParameter("@DonePercent", SqlDbType.Int),
				new SqlParameter("@SpendHour", SqlDbType.Int),
				new SqlParameter("@SpendingRemark", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.ProjectID;
			parameters[1].Value = model.ReportDate;
			parameters[2].Value = model.Phase == null ? (object)DBNull.Value : model.Phase;
			parameters[3].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
			parameters[4].Value = model.DonePercent == null ? (object)DBNull.Value : model.DonePercent;
			parameters[5].Value = model.SpendHour == null ? (object)DBNull.Value : model.SpendHour;
			parameters[6].Value = model.SpendingRemark == null ? (object)DBNull.Value : model.SpendingRemark;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(ProjectsStatusModel model)
		{
			string sql = "UPDATE [ProjectsStatus] SET [ProjectID]=@ProjectID,[ReportDate]=@ReportDate,[Phase]=@Phase,[DueDate]=@DueDate,[DonePercent]=@DonePercent,[SpendHour]=@SpendHour,[SpendingRemark]=@SpendingRemark WHERE ProjectID=@ProjectID and ReportDate=@ReportDate";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@ReportDate", SqlDbType.DateTime),
				new SqlParameter("@Phase", SqlDbType.NVarChar),
				new SqlParameter("@DueDate", SqlDbType.DateTime),
				new SqlParameter("@DonePercent", SqlDbType.Int),
				new SqlParameter("@SpendHour", SqlDbType.Int),
				new SqlParameter("@SpendingRemark", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.ProjectID;
			parameters[1].Value = model.ReportDate;
			parameters[2].Value = model.Phase == null ? (object)DBNull.Value : model.Phase;
			parameters[3].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
			parameters[4].Value = model.DonePercent == null ? (object)DBNull.Value : model.DonePercent;
			parameters[5].Value = model.SpendHour == null ? (object)DBNull.Value : model.SpendHour;
			parameters[6].Value = model.SpendingRemark == null ? (object)DBNull.Value : model.SpendingRemark;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int ProjectID, DateTime ReportDate)
		{
			string sql = "DELETE FROM [ProjectsStatus] WHERE  ProjectID=@ProjectID and ReportDate=@ReportDate";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@ReportDate", SqlDbType.DateTime),
			};
			parameters[0].Value = ProjectID;
			parameters[1].Value = ReportDate;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByProjectID(int projectID)
		{
			string sql = "DELETE FROM [ProjectsStatus] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByReportDate(DateTime reportDate)
		{
			string sql = "DELETE FROM [ProjectsStatus] WHERE [ReportDate]=@ReportDate";
			SqlParameter[] parameters = {
				new SqlParameter("@ReportDate", SqlDbType.DateTime),
			};
			parameters[0].Value = reportDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPhase(string phase)
		{
			string sql = "DELETE FROM [ProjectsStatus] WHERE [Phase]=@Phase";
			SqlParameter[] parameters = {
				new SqlParameter("@Phase", SqlDbType.NVarChar),
			};
			parameters[0].Value = phase;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDueDate(DateTime dueDate)
		{
			string sql = "DELETE FROM [ProjectsStatus] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.DateTime),
			};
			parameters[0].Value = dueDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDonePercent(int donePercent)
		{
			string sql = "DELETE FROM [ProjectsStatus] WHERE [DonePercent]=@DonePercent";
			SqlParameter[] parameters = {
				new SqlParameter("@DonePercent", SqlDbType.Int),
			};
			parameters[0].Value = donePercent;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteBySpendHour(int spendHour)
		{
			string sql = "DELETE FROM [ProjectsStatus] WHERE [SpendHour]=@SpendHour";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendHour", SqlDbType.Int),
			};
			parameters[0].Value = spendHour;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteBySpendingRemark(string spendingRemark)
		{
			string sql = "DELETE FROM [ProjectsStatus] WHERE [SpendingRemark]=@SpendingRemark";
			SqlParameter[] parameters = {
				new SqlParameter("@SpendingRemark", SqlDbType.NVarChar),
			};
			parameters[0].Value = spendingRemark;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public ProjectsStatusModel DataRowToModel(DataRow row)
		{
			ProjectsStatusModel model = new ProjectsStatusModel();
            if (row == null) return model;

			if (row["ProjectID"] != null && row["ProjectID"].ToString() != "")
			{
				model.ProjectID = int.Parse(row["ProjectID"].ToString());
			}
			if (row["ReportDate"] != null && row["ReportDate"].ToString() != "")
			{
				model.ReportDate = DateTime.Parse(row["ReportDate"].ToString());
			}
			if (row["Phase"] != null && row["Phase"].ToString() != "")
			{
				model.Phase = row["Phase"].ToString();
			}
			if (row["DueDate"] != null && row["DueDate"].ToString() != "")
			{
				model.DueDate = DateTime.Parse(row["DueDate"].ToString());
			}
			if (row["DonePercent"] != null && row["DonePercent"].ToString() != "")
			{
				model.DonePercent = int.Parse(row["DonePercent"].ToString());
			}
			if (row["SpendHour"] != null && row["SpendHour"].ToString() != "")
			{
				model.SpendHour = int.Parse(row["SpendHour"].ToString());
			}
			if (row["SpendingRemark"] != null && row["SpendingRemark"].ToString() != "")
			{
				model.SpendingRemark = row["SpendingRemark"].ToString();
			}

			return model;
		}
    }
}
