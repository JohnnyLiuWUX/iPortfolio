using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using IPortfolio.Model;

namespace IPortfolio.DAL
{
    public partial class StatusDal
    {
		public List<StatusModel> GetAll()
		{
			List<StatusModel> result = new List<StatusModel>();
			string sql = "SELECT * FROM [Status]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<StatusModel> GetListByStatus(int status)
		{
			string sql = "SELECT * FROM [Status] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<StatusModel> result = new List<StatusModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<StatusModel> GetListByStatusGroup(string statusGroup)
		{
			string sql = "SELECT * FROM [Status] WHERE [StatusGroup]=@StatusGroup";
			SqlParameter[] parameters = {
				new SqlParameter("@StatusGroup", SqlDbType.VarChar),
			};
			parameters[0].Value = statusGroup;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<StatusModel> result = new List<StatusModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<StatusModel> GetListByStatusDesc(string statusDesc)
		{
			string sql = "SELECT * FROM [Status] WHERE [StatusDesc]=@StatusDesc";
			SqlParameter[] parameters = {
				new SqlParameter("@StatusDesc", SqlDbType.NVarChar),
			};
			parameters[0].Value = statusDesc;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<StatusModel> result = new List<StatusModel>();
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
		public List<StatusModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Status] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<StatusModel> result = new List<StatusModel>();
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
		public List<StatusModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Status] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<StatusModel> result = new List<StatusModel>();
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
		public List<StatusModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Status] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<StatusModel> result = new List<StatusModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public StatusModel GetModel(int Status)
		{
			string sql = "SELECT * FROM [Status] WHERE  Status=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = Status;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public StatusModel GetModelByStatus(int status)
		{
			string sql = "SELECT * FROM [Status] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public StatusModel GetModelByStatusGroup(string statusGroup)
		{
			string sql = "SELECT * FROM [Status] WHERE [StatusGroup]=@StatusGroup";
			SqlParameter[] parameters = {
				new SqlParameter("@StatusGroup", SqlDbType.VarChar),
			};
			parameters[0].Value = statusGroup;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public StatusModel GetModelByStatusDesc(string statusDesc)
		{
			string sql = "SELECT * FROM [Status] WHERE [StatusDesc]=@StatusDesc";
			SqlParameter[] parameters = {
				new SqlParameter("@StatusDesc", SqlDbType.NVarChar),
			};
			parameters[0].Value = statusDesc;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(StatusModel model)
		{
			string sql = "INSERT INTO [Status]([Status],[StatusGroup],[StatusDesc]) VALUES(@Status,@StatusGroup,@StatusDesc)";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@StatusGroup", SqlDbType.VarChar),
				new SqlParameter("@StatusDesc", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.Status;
			parameters[1].Value = model.StatusGroup == null ? (object)DBNull.Value : model.StatusGroup;
			parameters[2].Value = model.StatusDesc == null ? (object)DBNull.Value : model.StatusDesc;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(StatusModel model)
		{
			string sql = "UPDATE [Status] SET [Status]=@Status,[StatusGroup]=@StatusGroup,[StatusDesc]=@StatusDesc WHERE Status=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@StatusGroup", SqlDbType.VarChar),
				new SqlParameter("@StatusDesc", SqlDbType.NVarChar),
			};
			parameters[0].Value = model.Status;
			parameters[1].Value = model.StatusGroup == null ? (object)DBNull.Value : model.StatusGroup;
			parameters[2].Value = model.StatusDesc == null ? (object)DBNull.Value : model.StatusDesc;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int Status)
		{
			string sql = "DELETE FROM [Status] WHERE  Status=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = Status;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStatus(int status)
		{
			string sql = "DELETE FROM [Status] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStatusGroup(string statusGroup)
		{
			string sql = "DELETE FROM [Status] WHERE [StatusGroup]=@StatusGroup";
			SqlParameter[] parameters = {
				new SqlParameter("@StatusGroup", SqlDbType.VarChar),
			};
			parameters[0].Value = statusGroup;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStatusDesc(string statusDesc)
		{
			string sql = "DELETE FROM [Status] WHERE [StatusDesc]=@StatusDesc";
			SqlParameter[] parameters = {
				new SqlParameter("@StatusDesc", SqlDbType.NVarChar),
			};
			parameters[0].Value = statusDesc;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public StatusModel DataRowToModel(DataRow row)
		{
			StatusModel model = new StatusModel();
            if (row == null) return model;

			if (row["Status"] != null && row["Status"].ToString() != "")
			{
				model.Status = int.Parse(row["Status"].ToString());
			}
			if (row["StatusGroup"] != null && row["StatusGroup"].ToString() != "")
			{
				model.StatusGroup = row["StatusGroup"].ToString();
			}
			if (row["StatusDesc"] != null && row["StatusDesc"].ToString() != "")
			{
				model.StatusDesc = row["StatusDesc"].ToString();
			}

			return model;
		}
    }
}
