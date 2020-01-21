using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using IPortfolio.Model;

namespace IPortfolio.DAL
{
    public partial class TaskDal
    {
		public List<TaskModel> GetAll()
		{
			List<TaskModel> result = new List<TaskModel>();
			string sql = "SELECT * FROM [Task]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByTaskID(int taskID)
		{
			string sql = "SELECT * FROM [Task] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByParentID(int parentID)
		{
			string sql = "SELECT * FROM [Task] WHERE [ParentID]=@ParentID";
			SqlParameter[] parameters = {
				new SqlParameter("@ParentID", SqlDbType.Int),
			};
			parameters[0].Value = parentID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [Task] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByPhaseID(int phaseID)
		{
			string sql = "SELECT * FROM [Task] WHERE [PhaseID]=@PhaseID";
			SqlParameter[] parameters = {
				new SqlParameter("@PhaseID", SqlDbType.Int),
			};
			parameters[0].Value = phaseID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByTaskName(string taskName)
		{
			string sql = "SELECT * FROM [Task] WHERE [TaskName]=@TaskName";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskName", SqlDbType.NVarChar),
			};
			parameters[0].Value = taskName;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByDesription(string desription)
		{
			string sql = "SELECT * FROM [Task] WHERE [Desription]=@Desription";
			SqlParameter[] parameters = {
				new SqlParameter("@Desription", SqlDbType.NVarChar),
			};
			parameters[0].Value = desription;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByAssignee(string assignee)
		{
			string sql = "SELECT * FROM [Task] WHERE [Assignee]=@Assignee";
			SqlParameter[] parameters = {
				new SqlParameter("@Assignee", SqlDbType.VarChar),
			};
			parameters[0].Value = assignee;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByPriority(int priority)
		{
			string sql = "SELECT * FROM [Task] WHERE [Priority]=@Priority";
			SqlParameter[] parameters = {
				new SqlParameter("@Priority", SqlDbType.Int),
			};
			parameters[0].Value = priority;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByEstimatedTime(decimal estimatedTime)
		{
			string sql = "SELECT * FROM [Task] WHERE [EstimatedTime]=@EstimatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
			};
			parameters[0].Value = estimatedTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByStartDate(string startDate)
		{
			string sql = "SELECT * FROM [Task] WHERE [StartDate]=@StartDate";
			SqlParameter[] parameters = {
				new SqlParameter("@StartDate", SqlDbType.Date),
			};
			parameters[0].Value = startDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByDueDate(string dueDate)
		{
			string sql = "SELECT * FROM [Task] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByTag(string tag)
		{
			string sql = "SELECT * FROM [Task] WHERE [Tag]=@Tag";
			SqlParameter[] parameters = {
				new SqlParameter("@Tag", SqlDbType.NVarChar),
			};
			parameters[0].Value = tag;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByStatus(int status)
		{
			string sql = "SELECT * FROM [Task] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByDonePercent(int donePercent)
		{
			string sql = "SELECT * FROM [Task] WHERE [DonePercent]=@DonePercent";
			SqlParameter[] parameters = {
				new SqlParameter("@DonePercent", SqlDbType.Int),
			};
			parameters[0].Value = donePercent;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByCloseDate(string closeDate)
		{
			string sql = "SELECT * FROM [Task] WHERE [CloseDate]=@CloseDate";
			SqlParameter[] parameters = {
				new SqlParameter("@CloseDate", SqlDbType.Date),
			};
			parameters[0].Value = closeDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByAssignBy(string assignBy)
		{
			string sql = "SELECT * FROM [Task] WHERE [AssignBy]=@AssignBy";
			SqlParameter[] parameters = {
				new SqlParameter("@AssignBy", SqlDbType.VarChar),
			};
			parameters[0].Value = assignBy;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<TaskModel> GetListByCreatedTime(DateTime createdTime)
		{
			string sql = "SELECT * FROM [Task] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<TaskModel> result = new List<TaskModel>();
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
		public List<TaskModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Task] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<TaskModel> result = new List<TaskModel>();
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
		public List<TaskModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Task] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<TaskModel> result = new List<TaskModel>();
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
		public List<TaskModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Task] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<TaskModel> result = new List<TaskModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public TaskModel GetModel(int TaskID)
		{
			string sql = "SELECT * FROM [Task] WHERE  TaskID=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = TaskID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByTaskID(int taskID)
		{
			string sql = "SELECT * FROM [Task] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByParentID(int parentID)
		{
			string sql = "SELECT * FROM [Task] WHERE [ParentID]=@ParentID";
			SqlParameter[] parameters = {
				new SqlParameter("@ParentID", SqlDbType.Int),
			};
			parameters[0].Value = parentID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [Task] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByPhaseID(int phaseID)
		{
			string sql = "SELECT * FROM [Task] WHERE [PhaseID]=@PhaseID";
			SqlParameter[] parameters = {
				new SqlParameter("@PhaseID", SqlDbType.Int),
			};
			parameters[0].Value = phaseID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByTaskName(string taskName)
		{
			string sql = "SELECT * FROM [Task] WHERE [TaskName]=@TaskName";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskName", SqlDbType.NVarChar),
			};
			parameters[0].Value = taskName;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByDesription(string desription)
		{
			string sql = "SELECT * FROM [Task] WHERE [Desription]=@Desription";
			SqlParameter[] parameters = {
				new SqlParameter("@Desription", SqlDbType.NVarChar),
			};
			parameters[0].Value = desription;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByAssignee(string assignee)
		{
			string sql = "SELECT * FROM [Task] WHERE [Assignee]=@Assignee";
			SqlParameter[] parameters = {
				new SqlParameter("@Assignee", SqlDbType.VarChar),
			};
			parameters[0].Value = assignee;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByPriority(int priority)
		{
			string sql = "SELECT * FROM [Task] WHERE [Priority]=@Priority";
			SqlParameter[] parameters = {
				new SqlParameter("@Priority", SqlDbType.Int),
			};
			parameters[0].Value = priority;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByEstimatedTime(decimal estimatedTime)
		{
			string sql = "SELECT * FROM [Task] WHERE [EstimatedTime]=@EstimatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
			};
			parameters[0].Value = estimatedTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByStartDate(string startDate)
		{
			string sql = "SELECT * FROM [Task] WHERE [StartDate]=@StartDate";
			SqlParameter[] parameters = {
				new SqlParameter("@StartDate", SqlDbType.Date),
			};
			parameters[0].Value = startDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByDueDate(string dueDate)
		{
			string sql = "SELECT * FROM [Task] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByTag(string tag)
		{
			string sql = "SELECT * FROM [Task] WHERE [Tag]=@Tag";
			SqlParameter[] parameters = {
				new SqlParameter("@Tag", SqlDbType.NVarChar),
			};
			parameters[0].Value = tag;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByStatus(int status)
		{
			string sql = "SELECT * FROM [Task] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByDonePercent(int donePercent)
		{
			string sql = "SELECT * FROM [Task] WHERE [DonePercent]=@DonePercent";
			SqlParameter[] parameters = {
				new SqlParameter("@DonePercent", SqlDbType.Int),
			};
			parameters[0].Value = donePercent;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByCloseDate(string closeDate)
		{
			string sql = "SELECT * FROM [Task] WHERE [CloseDate]=@CloseDate";
			SqlParameter[] parameters = {
				new SqlParameter("@CloseDate", SqlDbType.Date),
			};
			parameters[0].Value = closeDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByAssignBy(string assignBy)
		{
			string sql = "SELECT * FROM [Task] WHERE [AssignBy]=@AssignBy";
			SqlParameter[] parameters = {
				new SqlParameter("@AssignBy", SqlDbType.VarChar),
			};
			parameters[0].Value = assignBy;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public TaskModel GetModelByCreatedTime(DateTime createdTime)
		{
			string sql = "SELECT * FROM [Task] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(TaskModel model)
		{
			string sql = "INSERT INTO [Task]([ParentID],[ProjectID],[PhaseID],[TaskName],[Desription],[Assignee],[Priority],[EstimatedTime],[StartDate],[DueDate],[Tag],[Status],[DonePercent],[CloseDate],[AssignBy],[CreatedTime]) VALUES(@ParentID,@ProjectID,@PhaseID,@TaskName,@Desription,@Assignee,@Priority,@EstimatedTime,@StartDate,@DueDate,@Tag,@Status,@DonePercent,@CloseDate,@AssignBy,@CreatedTime)";
			SqlParameter[] parameters = {
				new SqlParameter("@ParentID", SqlDbType.Int),
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@PhaseID", SqlDbType.Int),
				new SqlParameter("@TaskName", SqlDbType.NVarChar),
				new SqlParameter("@Desription", SqlDbType.NVarChar),
				new SqlParameter("@Assignee", SqlDbType.VarChar),
				new SqlParameter("@Priority", SqlDbType.Int),
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
				new SqlParameter("@StartDate", SqlDbType.Date),
				new SqlParameter("@DueDate", SqlDbType.Date),
				new SqlParameter("@Tag", SqlDbType.NVarChar),
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@DonePercent", SqlDbType.Int),
				new SqlParameter("@CloseDate", SqlDbType.Date),
				new SqlParameter("@AssignBy", SqlDbType.VarChar),
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = model.ParentID == null ? (object)DBNull.Value : model.ParentID;
			parameters[1].Value = model.ProjectID == null ? (object)DBNull.Value : model.ProjectID;
			parameters[2].Value = model.PhaseID == null ? (object)DBNull.Value : model.PhaseID;
			parameters[3].Value = model.TaskName == null ? (object)DBNull.Value : model.TaskName;
			parameters[4].Value = model.Desription == null ? (object)DBNull.Value : model.Desription;
			parameters[5].Value = model.Assignee == null ? (object)DBNull.Value : model.Assignee;
			parameters[6].Value = model.Priority == null ? (object)DBNull.Value : model.Priority;
			parameters[7].Value = model.EstimatedTime == null ? (object)DBNull.Value : model.EstimatedTime;
			parameters[8].Value = model.StartDate == null ? (object)DBNull.Value : model.StartDate;
			parameters[9].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
			parameters[10].Value = model.Tag == null ? (object)DBNull.Value : model.Tag;
			parameters[11].Value = model.Status == null ? (object)DBNull.Value : model.Status;
			parameters[12].Value = model.DonePercent == null ? (object)DBNull.Value : model.DonePercent;
			parameters[13].Value = model.CloseDate == null ? (object)DBNull.Value : model.CloseDate;
			parameters[14].Value = model.AssignBy == null ? (object)DBNull.Value : model.AssignBy;
			parameters[15].Value = model.CreatedTime == null ? (object)DBNull.Value : model.CreatedTime;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(TaskModel model)
		{
			string sql = "UPDATE [Task] SET [ParentID]=@ParentID,[ProjectID]=@ProjectID,[PhaseID]=@PhaseID,[TaskName]=@TaskName,[Desription]=@Desription,[Assignee]=@Assignee,[Priority]=@Priority,[EstimatedTime]=@EstimatedTime,[StartDate]=@StartDate,[DueDate]=@DueDate,[Tag]=@Tag,[Status]=@Status,[DonePercent]=@DonePercent,[CloseDate]=@CloseDate,[AssignBy]=@AssignBy,[CreatedTime]=@CreatedTime WHERE TaskID=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
				new SqlParameter("@ParentID", SqlDbType.Int),
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@PhaseID", SqlDbType.Int),
				new SqlParameter("@TaskName", SqlDbType.NVarChar),
				new SqlParameter("@Desription", SqlDbType.NVarChar),
				new SqlParameter("@Assignee", SqlDbType.VarChar),
				new SqlParameter("@Priority", SqlDbType.Int),
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
				new SqlParameter("@StartDate", SqlDbType.Date),
				new SqlParameter("@DueDate", SqlDbType.Date),
				new SqlParameter("@Tag", SqlDbType.NVarChar),
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@DonePercent", SqlDbType.Int),
				new SqlParameter("@CloseDate", SqlDbType.Date),
				new SqlParameter("@AssignBy", SqlDbType.VarChar),
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = model.TaskID;
			parameters[1].Value = model.ParentID == null ? (object)DBNull.Value : model.ParentID;
			parameters[2].Value = model.ProjectID == null ? (object)DBNull.Value : model.ProjectID;
			parameters[3].Value = model.PhaseID == null ? (object)DBNull.Value : model.PhaseID;
			parameters[4].Value = model.TaskName == null ? (object)DBNull.Value : model.TaskName;
			parameters[5].Value = model.Desription == null ? (object)DBNull.Value : model.Desription;
			parameters[6].Value = model.Assignee == null ? (object)DBNull.Value : model.Assignee;
			parameters[7].Value = model.Priority == null ? (object)DBNull.Value : model.Priority;
			parameters[8].Value = model.EstimatedTime == null ? (object)DBNull.Value : model.EstimatedTime;
			parameters[9].Value = model.StartDate == null ? (object)DBNull.Value : model.StartDate;
			parameters[10].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
			parameters[11].Value = model.Tag == null ? (object)DBNull.Value : model.Tag;
			parameters[12].Value = model.Status == null ? (object)DBNull.Value : model.Status;
			parameters[13].Value = model.DonePercent == null ? (object)DBNull.Value : model.DonePercent;
			parameters[14].Value = model.CloseDate == null ? (object)DBNull.Value : model.CloseDate;
			parameters[15].Value = model.AssignBy == null ? (object)DBNull.Value : model.AssignBy;
			parameters[16].Value = model.CreatedTime == null ? (object)DBNull.Value : model.CreatedTime;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int TaskID)
		{
			string sql = "DELETE FROM [Task] WHERE  TaskID=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = TaskID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByTaskID(int taskID)
		{
			string sql = "DELETE FROM [Task] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByParentID(int parentID)
		{
			string sql = "DELETE FROM [Task] WHERE [ParentID]=@ParentID";
			SqlParameter[] parameters = {
				new SqlParameter("@ParentID", SqlDbType.Int),
			};
			parameters[0].Value = parentID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByProjectID(int projectID)
		{
			string sql = "DELETE FROM [Task] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPhaseID(int phaseID)
		{
			string sql = "DELETE FROM [Task] WHERE [PhaseID]=@PhaseID";
			SqlParameter[] parameters = {
				new SqlParameter("@PhaseID", SqlDbType.Int),
			};
			parameters[0].Value = phaseID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByTaskName(string taskName)
		{
			string sql = "DELETE FROM [Task] WHERE [TaskName]=@TaskName";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskName", SqlDbType.NVarChar),
			};
			parameters[0].Value = taskName;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDesription(string desription)
		{
			string sql = "DELETE FROM [Task] WHERE [Desription]=@Desription";
			SqlParameter[] parameters = {
				new SqlParameter("@Desription", SqlDbType.NVarChar),
			};
			parameters[0].Value = desription;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByAssignee(string assignee)
		{
			string sql = "DELETE FROM [Task] WHERE [Assignee]=@Assignee";
			SqlParameter[] parameters = {
				new SqlParameter("@Assignee", SqlDbType.VarChar),
			};
			parameters[0].Value = assignee;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPriority(int priority)
		{
			string sql = "DELETE FROM [Task] WHERE [Priority]=@Priority";
			SqlParameter[] parameters = {
				new SqlParameter("@Priority", SqlDbType.Int),
			};
			parameters[0].Value = priority;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByEstimatedTime(decimal estimatedTime)
		{
			string sql = "DELETE FROM [Task] WHERE [EstimatedTime]=@EstimatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
			};
			parameters[0].Value = estimatedTime;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStartDate(string startDate)
		{
			string sql = "DELETE FROM [Task] WHERE [StartDate]=@StartDate";
			SqlParameter[] parameters = {
				new SqlParameter("@StartDate", SqlDbType.Date),
			};
			parameters[0].Value = startDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDueDate(string dueDate)
		{
			string sql = "DELETE FROM [Task] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByTag(string tag)
		{
			string sql = "DELETE FROM [Task] WHERE [Tag]=@Tag";
			SqlParameter[] parameters = {
				new SqlParameter("@Tag", SqlDbType.NVarChar),
			};
			parameters[0].Value = tag;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStatus(int status)
		{
			string sql = "DELETE FROM [Task] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDonePercent(int donePercent)
		{
			string sql = "DELETE FROM [Task] WHERE [DonePercent]=@DonePercent";
			SqlParameter[] parameters = {
				new SqlParameter("@DonePercent", SqlDbType.Int),
			};
			parameters[0].Value = donePercent;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCloseDate(string closeDate)
		{
			string sql = "DELETE FROM [Task] WHERE [CloseDate]=@CloseDate";
			SqlParameter[] parameters = {
				new SqlParameter("@CloseDate", SqlDbType.Date),
			};
			parameters[0].Value = closeDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByAssignBy(string assignBy)
		{
			string sql = "DELETE FROM [Task] WHERE [AssignBy]=@AssignBy";
			SqlParameter[] parameters = {
				new SqlParameter("@AssignBy", SqlDbType.VarChar),
			};
			parameters[0].Value = assignBy;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCreatedTime(DateTime createdTime)
		{
			string sql = "DELETE FROM [Task] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public TaskModel DataRowToModel(DataRow row)
		{
			TaskModel model = new TaskModel();
            if (row == null) return model;

			if (row["TaskID"] != null && row["TaskID"].ToString() != "")
			{
				model.TaskID = int.Parse(row["TaskID"].ToString());
			}
			if (row["ParentID"] != null && row["ParentID"].ToString() != "")
			{
				model.ParentID = int.Parse(row["ParentID"].ToString());
			}
			if (row["ProjectID"] != null && row["ProjectID"].ToString() != "")
			{
				model.ProjectID = int.Parse(row["ProjectID"].ToString());
			}
			if (row["PhaseID"] != null && row["PhaseID"].ToString() != "")
			{
				model.PhaseID = int.Parse(row["PhaseID"].ToString());
			}
			if (row["TaskName"] != null && row["TaskName"].ToString() != "")
			{
				model.TaskName = row["TaskName"].ToString();
			}
			if (row["Desription"] != null && row["Desription"].ToString() != "")
			{
				model.Desription = row["Desription"].ToString();
			}
			if (row["Assignee"] != null && row["Assignee"].ToString() != "")
			{
				model.Assignee = row["Assignee"].ToString();
			}
			if (row["Priority"] != null && row["Priority"].ToString() != "")
			{
				model.Priority = int.Parse(row["Priority"].ToString());
			}
			if (row["EstimatedTime"] != null && row["EstimatedTime"].ToString() != "")
			{
				model.EstimatedTime = decimal.Parse(row["EstimatedTime"].ToString());
			}
			if (row["StartDate"] != null && row["StartDate"].ToString() != "")
			{
				model.StartDate = row["StartDate"].ToString();
			}
			if (row["DueDate"] != null && row["DueDate"].ToString() != "")
			{
				model.DueDate = row["DueDate"].ToString();
			}
			if (row["Tag"] != null && row["Tag"].ToString() != "")
			{
				model.Tag = row["Tag"].ToString();
			}
			if (row["Status"] != null && row["Status"].ToString() != "")
			{
				model.Status = int.Parse(row["Status"].ToString());
			}
			if (row["DonePercent"] != null && row["DonePercent"].ToString() != "")
			{
				model.DonePercent = int.Parse(row["DonePercent"].ToString());
			}
			if (row["CloseDate"] != null && row["CloseDate"].ToString() != "")
			{
				model.CloseDate = row["CloseDate"].ToString();
			}
			if (row["AssignBy"] != null && row["AssignBy"].ToString() != "")
			{
				model.AssignBy = row["AssignBy"].ToString();
			}
			if (row["CreatedTime"] != null && row["CreatedTime"].ToString() != "")
			{
				model.CreatedTime = DateTime.Parse(row["CreatedTime"].ToString());
			}

			return model;
		}
    }
}
