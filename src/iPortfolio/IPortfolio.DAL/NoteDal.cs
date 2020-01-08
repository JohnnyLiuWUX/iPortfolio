/**
 * Auto Create By Code Magic 2020-01-08 11:27:01
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
    public partial class NoteDal
    {
		#region Auto Create By Code Magic

		public List<NoteModel> GetAll()
		{
			List<NoteModel> result = new List<NoteModel>();
			string sql = "SELECT * FROM [Note]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<NoteModel> GetListByNoteID(int noteID)
		{
			string sql = "SELECT * FROM [Note] WHERE [NoteID]=@NoteID";
			SqlParameter[] parameters = {
				new SqlParameter("@NoteID", SqlDbType.Int),
			};
			parameters[0].Value = noteID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<NoteModel> result = new List<NoteModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<NoteModel> GetListByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [Note] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<NoteModel> result = new List<NoteModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<NoteModel> GetListByTaskID(int taskID)
		{
			string sql = "SELECT * FROM [Note] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<NoteModel> result = new List<NoteModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<NoteModel> GetListByNote(string note)
		{
			string sql = "SELECT * FROM [Note] WHERE [Note]=@Note";
			SqlParameter[] parameters = {
				new SqlParameter("@Note", SqlDbType.NVarChar),
			};
			parameters[0].Value = note;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<NoteModel> result = new List<NoteModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<NoteModel> GetListByCreatedBy(string createdBy)
		{
			string sql = "SELECT * FROM [Note] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<NoteModel> result = new List<NoteModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<NoteModel> GetListByCreatedTime(DateTime createdTime)
		{
			string sql = "SELECT * FROM [Note] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<NoteModel> result = new List<NoteModel>();
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
		public List<NoteModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Note] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<NoteModel> result = new List<NoteModel>();
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
		public List<NoteModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Note] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<NoteModel> result = new List<NoteModel>();
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
		public List<NoteModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Note] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<NoteModel> result = new List<NoteModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public NoteModel GetModel(int NoteID)
		{
			string sql = "SELECT * FROM [Note] WHERE  NoteID=@NoteID";
			SqlParameter[] parameters = {
				new SqlParameter("@NoteID", SqlDbType.Int),
			};
			parameters[0].Value = NoteID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public NoteModel GetModelByNoteID(int noteID)
		{
			string sql = "SELECT * FROM [Note] WHERE [NoteID]=@NoteID";
			SqlParameter[] parameters = {
				new SqlParameter("@NoteID", SqlDbType.Int),
			};
			parameters[0].Value = noteID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public NoteModel GetModelByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [Note] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public NoteModel GetModelByTaskID(int taskID)
		{
			string sql = "SELECT * FROM [Note] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public NoteModel GetModelByNote(string note)
		{
			string sql = "SELECT * FROM [Note] WHERE [Note]=@Note";
			SqlParameter[] parameters = {
				new SqlParameter("@Note", SqlDbType.NVarChar),
			};
			parameters[0].Value = note;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public NoteModel GetModelByCreatedBy(string createdBy)
		{
			string sql = "SELECT * FROM [Note] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public NoteModel GetModelByCreatedTime(DateTime createdTime)
		{
			string sql = "SELECT * FROM [Note] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(NoteModel model)
		{
			string sql = "INSERT INTO [Note]([ProjectID],[TaskID],[Note],[CreatedBy],[CreatedTime]) VALUES(@ProjectID,@TaskID,@Note,@CreatedBy,@CreatedTime)";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@TaskID", SqlDbType.Int),
				new SqlParameter("@Note", SqlDbType.NVarChar),
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = model.ProjectID == null ? (object)DBNull.Value : model.ProjectID;
			parameters[1].Value = model.TaskID == null ? (object)DBNull.Value : model.TaskID;
			parameters[2].Value = model.Note == null ? (object)DBNull.Value : model.Note;
			parameters[3].Value = model.CreatedBy == null ? (object)DBNull.Value : model.CreatedBy;
			parameters[4].Value = model.CreatedTime == null ? (object)DBNull.Value : model.CreatedTime;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(NoteModel model)
		{
			string sql = "UPDATE [Note] SET [ProjectID]=@ProjectID,[TaskID]=@TaskID,[Note]=@Note,[CreatedBy]=@CreatedBy,[CreatedTime]=@CreatedTime WHERE NoteID=@NoteID";
			SqlParameter[] parameters = {
				new SqlParameter("@NoteID", SqlDbType.Int),
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@TaskID", SqlDbType.Int),
				new SqlParameter("@Note", SqlDbType.NVarChar),
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = model.NoteID;
			parameters[1].Value = model.ProjectID == null ? (object)DBNull.Value : model.ProjectID;
			parameters[2].Value = model.TaskID == null ? (object)DBNull.Value : model.TaskID;
			parameters[3].Value = model.Note == null ? (object)DBNull.Value : model.Note;
			parameters[4].Value = model.CreatedBy == null ? (object)DBNull.Value : model.CreatedBy;
			parameters[5].Value = model.CreatedTime == null ? (object)DBNull.Value : model.CreatedTime;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int NoteID)
		{
			string sql = "DELETE FROM [Note] WHERE  NoteID=@NoteID";
			SqlParameter[] parameters = {
				new SqlParameter("@NoteID", SqlDbType.Int),
			};
			parameters[0].Value = NoteID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByNoteID(int noteID)
		{
			string sql = "DELETE FROM [Note] WHERE [NoteID]=@NoteID";
			SqlParameter[] parameters = {
				new SqlParameter("@NoteID", SqlDbType.Int),
			};
			parameters[0].Value = noteID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByProjectID(int projectID)
		{
			string sql = "DELETE FROM [Note] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByTaskID(int taskID)
		{
			string sql = "DELETE FROM [Note] WHERE [TaskID]=@TaskID";
			SqlParameter[] parameters = {
				new SqlParameter("@TaskID", SqlDbType.Int),
			};
			parameters[0].Value = taskID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByNote(string note)
		{
			string sql = "DELETE FROM [Note] WHERE [Note]=@Note";
			SqlParameter[] parameters = {
				new SqlParameter("@Note", SqlDbType.NVarChar),
			};
			parameters[0].Value = note;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCreatedBy(string createdBy)
		{
			string sql = "DELETE FROM [Note] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCreatedTime(DateTime createdTime)
		{
			string sql = "DELETE FROM [Note] WHERE [CreatedTime]=@CreatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createdTime;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public NoteModel DataRowToModel(DataRow row)
		{
			NoteModel model = new NoteModel();
            if (row == null) return model;

			if (row["NoteID"] != null && row["NoteID"].ToString() != "")
			{
				model.NoteID = int.Parse(row["NoteID"].ToString());
			}
			if (row["ProjectID"] != null && row["ProjectID"].ToString() != "")
			{
				model.ProjectID = int.Parse(row["ProjectID"].ToString());
			}
			if (row["TaskID"] != null && row["TaskID"].ToString() != "")
			{
				model.TaskID = int.Parse(row["TaskID"].ToString());
			}
			if (row["Note"] != null && row["Note"].ToString() != "")
			{
				model.Note = row["Note"].ToString();
			}
			if (row["CreatedBy"] != null && row["CreatedBy"].ToString() != "")
			{
				model.CreatedBy = row["CreatedBy"].ToString();
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
