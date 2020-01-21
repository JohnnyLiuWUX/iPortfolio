using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using IPortfolio.Model;

namespace IPortfolio.DAL
{
    public partial class OrgUserDal
    {
		public List<OrgUserModel> GetAll()
		{
			List<OrgUserModel> result = new List<OrgUserModel>();
			string sql = "SELECT * FROM [OrgUser]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<OrgUserModel> GetListByUserID(string userID)
		{
			string sql = "SELECT * FROM [OrgUser] WHERE [UserID]=@UserID";
			SqlParameter[] parameters = {
				new SqlParameter("@UserID", SqlDbType.VarChar),
			};
			parameters[0].Value = userID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<OrgUserModel> result = new List<OrgUserModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<OrgUserModel> GetListByOrgID(int orgID)
		{
			string sql = "SELECT * FROM [OrgUser] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<OrgUserModel> result = new List<OrgUserModel>();
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
		public List<OrgUserModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [OrgUser] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<OrgUserModel> result = new List<OrgUserModel>();
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
		public List<OrgUserModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [OrgUser] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<OrgUserModel> result = new List<OrgUserModel>();
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
		public List<OrgUserModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [OrgUser] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<OrgUserModel> result = new List<OrgUserModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public OrgUserModel GetModel(string UserID, int OrgID)
		{
			string sql = "SELECT * FROM [OrgUser] WHERE  UserID=@UserID and OrgID=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@UserID", SqlDbType.VarChar),
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = UserID;
			parameters[1].Value = OrgID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public OrgUserModel GetModelByUserID(string userID)
		{
			string sql = "SELECT * FROM [OrgUser] WHERE [UserID]=@UserID";
			SqlParameter[] parameters = {
				new SqlParameter("@UserID", SqlDbType.VarChar),
			};
			parameters[0].Value = userID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public OrgUserModel GetModelByOrgID(int orgID)
		{
			string sql = "SELECT * FROM [OrgUser] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(OrgUserModel model)
		{
			string sql = "INSERT INTO [OrgUser]([UserID],[OrgID]) VALUES(@UserID,@OrgID)";
			SqlParameter[] parameters = {
				new SqlParameter("@UserID", SqlDbType.VarChar),
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.OrgID;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(OrgUserModel model)
		{
			string sql = "UPDATE [OrgUser] SET [UserID]=@UserID,[OrgID]=@OrgID WHERE UserID=@UserID and OrgID=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@UserID", SqlDbType.VarChar),
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.OrgID;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(string UserID, int OrgID)
		{
			string sql = "DELETE FROM [OrgUser] WHERE  UserID=@UserID and OrgID=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@UserID", SqlDbType.VarChar),
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = UserID;
			parameters[1].Value = OrgID;
            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByUserID(string userID)
		{
			string sql = "DELETE FROM [OrgUser] WHERE [UserID]=@UserID";
			SqlParameter[] parameters = {
				new SqlParameter("@UserID", SqlDbType.VarChar),
			};
			parameters[0].Value = userID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByOrgID(int orgID)
		{
			string sql = "DELETE FROM [OrgUser] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public OrgUserModel DataRowToModel(DataRow row)
		{
			OrgUserModel model = new OrgUserModel();
            if (row == null) return model;

			if (row["UserID"] != null && row["UserID"].ToString() != "")
			{
				model.UserID = row["UserID"].ToString();
			}
			if (row["OrgID"] != null && row["OrgID"].ToString() != "")
			{
				model.OrgID = int.Parse(row["OrgID"].ToString());
			}

			return model;
		}
    }
}
