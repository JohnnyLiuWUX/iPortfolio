/**
 * Auto Create By Code Magic 2020-01-07 02:48:26
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
    public partial class ProjectDal
    {
		#region Auto Create By Code Magic

		public List<ProjectModel> GetAll()
		{
			List<ProjectModel> result = new List<ProjectModel>();
			string sql = "SELECT * FROM [Project]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [Project] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByOrgID(int orgID)
		{
			string sql = "SELECT * FROM [Project] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByProjectName(string projectName)
		{
			string sql = "SELECT * FROM [Project] WHERE [ProjectName]=@ProjectName";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectName", SqlDbType.NVarChar),
			};
			parameters[0].Value = projectName;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByTag(string tag)
		{
			string sql = "SELECT * FROM [Project] WHERE [Tag]=@Tag";
			SqlParameter[] parameters = {
				new SqlParameter("@Tag", SqlDbType.NVarChar),
			};
			parameters[0].Value = tag;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByDescription(string description)
		{
			string sql = "SELECT * FROM [Project] WHERE [Description]=@Description";
			SqlParameter[] parameters = {
				new SqlParameter("@Description", SqlDbType.NVarChar),
			};
			parameters[0].Value = description;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByCostCenter(string costCenter)
		{
			string sql = "SELECT * FROM [Project] WHERE [CostCenter]=@CostCenter";
			SqlParameter[] parameters = {
				new SqlParameter("@CostCenter", SqlDbType.VarChar),
			};
			parameters[0].Value = costCenter;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByStartDate(string startDate)
		{
			string sql = "SELECT * FROM [Project] WHERE [StartDate]=@StartDate";
			SqlParameter[] parameters = {
				new SqlParameter("@StartDate", SqlDbType.Date),
			};
			parameters[0].Value = startDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByPlanGoLiveDate(string planGoLiveDate)
		{
			string sql = "SELECT * FROM [Project] WHERE [PlanGoLiveDate]=@PlanGoLiveDate";
			SqlParameter[] parameters = {
				new SqlParameter("@PlanGoLiveDate", SqlDbType.Date),
			};
			parameters[0].Value = planGoLiveDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByDueDate(string dueDate)
		{
			string sql = "SELECT * FROM [Project] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByCreatedBy(string createdBy)
		{
			string sql = "SELECT * FROM [Project] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByCreateTime(DateTime createTime)
		{
			string sql = "SELECT * FROM [Project] WHERE [CreateTime]=@CreateTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByDepartment(string department)
		{
			string sql = "SELECT * FROM [Project] WHERE [Department]=@Department";
			SqlParameter[] parameters = {
				new SqlParameter("@Department", SqlDbType.NVarChar),
			};
			parameters[0].Value = department;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByFunctionGroup(string functionGroup)
		{
			string sql = "SELECT * FROM [Project] WHERE [FunctionGroup]=@FunctionGroup";
			SqlParameter[] parameters = {
				new SqlParameter("@FunctionGroup", SqlDbType.NVarChar),
			};
			parameters[0].Value = functionGroup;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByWorkcell(string workcell)
		{
			string sql = "SELECT * FROM [Project] WHERE [Workcell]=@Workcell";
			SqlParameter[] parameters = {
				new SqlParameter("@Workcell", SqlDbType.NVarChar),
			};
			parameters[0].Value = workcell;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByPM(string pM)
		{
			string sql = "SELECT * FROM [Project] WHERE [PM]=@PM";
			SqlParameter[] parameters = {
				new SqlParameter("@PM", SqlDbType.VarChar),
			};
			parameters[0].Value = pM;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListBySME(string sME)
		{
			string sql = "SELECT * FROM [Project] WHERE [SME]=@SME";
			SqlParameter[] parameters = {
				new SqlParameter("@SME", SqlDbType.VarChar),
			};
			parameters[0].Value = sME;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListBySource(string source)
		{
			string sql = "SELECT * FROM [Project] WHERE [Source]=@Source";
			SqlParameter[] parameters = {
				new SqlParameter("@Source", SqlDbType.VarChar),
			};
			parameters[0].Value = source;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByQuarter(string quarter)
		{
			string sql = "SELECT * FROM [Project] WHERE [Quarter]=@Quarter";
			SqlParameter[] parameters = {
				new SqlParameter("@Quarter", SqlDbType.VarChar),
			};
			parameters[0].Value = quarter;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByType(string type)
		{
			string sql = "SELECT * FROM [Project] WHERE [Type]=@Type";
			SqlParameter[] parameters = {
				new SqlParameter("@Type", SqlDbType.VarChar),
			};
			parameters[0].Value = type;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByScope(string scope)
		{
			string sql = "SELECT * FROM [Project] WHERE [Scope]=@Scope";
			SqlParameter[] parameters = {
				new SqlParameter("@Scope", SqlDbType.VarChar),
			};
			parameters[0].Value = scope;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListBySponsor(string sponsor)
		{
			string sql = "SELECT * FROM [Project] WHERE [Sponsor]=@Sponsor";
			SqlParameter[] parameters = {
				new SqlParameter("@Sponsor", SqlDbType.NVarChar),
			};
			parameters[0].Value = sponsor;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByIsMajor(string isMajor)
		{
			string sql = "SELECT * FROM [Project] WHERE [IsMajor]=@IsMajor";
			SqlParameter[] parameters = {
				new SqlParameter("@IsMajor", SqlDbType.VarChar),
			};
			parameters[0].Value = isMajor;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByARSNo(string aRSNo)
		{
			string sql = "SELECT * FROM [Project] WHERE [ARSNo]=@ARSNo";
			SqlParameter[] parameters = {
				new SqlParameter("@ARSNo", SqlDbType.VarChar),
			};
			parameters[0].Value = aRSNo;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByStatus(int status)
		{
			string sql = "SELECT * FROM [Project] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListBySaving(decimal saving)
		{
			string sql = "SELECT * FROM [Project] WHERE [Saving]=@Saving";
			SqlParameter[] parameters = {
				new SqlParameter("@Saving", SqlDbType.Decimal),
			};
			parameters[0].Value = saving;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByEstimatedTime(decimal estimatedTime)
		{
			string sql = "SELECT * FROM [Project] WHERE [EstimatedTime]=@EstimatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
			};
			parameters[0].Value = estimatedTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByInternalBudget(decimal internalBudget)
		{
			string sql = "SELECT * FROM [Project] WHERE [InternalBudget]=@InternalBudget";
			SqlParameter[] parameters = {
				new SqlParameter("@InternalBudget", SqlDbType.Decimal),
			};
			parameters[0].Value = internalBudget;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByExternalBudget(decimal externalBudget)
		{
			string sql = "SELECT * FROM [Project] WHERE [ExternalBudget]=@ExternalBudget";
			SqlParameter[] parameters = {
				new SqlParameter("@ExternalBudget", SqlDbType.Decimal),
			};
			parameters[0].Value = externalBudget;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByROI(decimal rOI)
		{
			string sql = "SELECT * FROM [Project] WHERE [ROI]=@ROI";
			SqlParameter[] parameters = {
				new SqlParameter("@ROI", SqlDbType.Decimal),
			};
			parameters[0].Value = rOI;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByPhase(string phase)
		{
			string sql = "SELECT * FROM [Project] WHERE [Phase]=@Phase";
			SqlParameter[] parameters = {
				new SqlParameter("@Phase", SqlDbType.NVarChar),
			};
			parameters[0].Value = phase;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByCloseDate(string closeDate)
		{
			string sql = "SELECT * FROM [Project] WHERE [CloseDate]=@CloseDate";
			SqlParameter[] parameters = {
				new SqlParameter("@CloseDate", SqlDbType.Date),
			};
			parameters[0].Value = closeDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByActualTime(decimal actualTime)
		{
			string sql = "SELECT * FROM [Project] WHERE [ActualTime]=@ActualTime";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualTime", SqlDbType.Decimal),
			};
			parameters[0].Value = actualTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByActualInternalCost(decimal actualInternalCost)
		{
			string sql = "SELECT * FROM [Project] WHERE [ActualInternalCost]=@ActualInternalCost";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualInternalCost", SqlDbType.Decimal),
			};
			parameters[0].Value = actualInternalCost;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByActualExternalCost(decimal actualExternalCost)
		{
			string sql = "SELECT * FROM [Project] WHERE [ActualExternalCost]=@ActualExternalCost";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualExternalCost", SqlDbType.Decimal),
			};
			parameters[0].Value = actualExternalCost;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;
			foreach(DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public List<ProjectModel> GetListByActualSaving(decimal actualSaving)
		{
			string sql = "SELECT * FROM [Project] WHERE [ActualSaving]=@ActualSaving";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualSaving", SqlDbType.Decimal),
			};
			parameters[0].Value = actualSaving;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			List<ProjectModel> result = new List<ProjectModel>();
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
		public List<ProjectModel> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Project] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<ProjectModel> result = new List<ProjectModel>();
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
		public List<ProjectModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Project] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<ProjectModel> result = new List<ProjectModel>();
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
		public List<ProjectModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [Project] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<ProjectModel> result = new List<ProjectModel>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public ProjectModel GetModel(int ProjectID)
		{
			string sql = "SELECT * FROM [Project] WHERE  ProjectID=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = ProjectID;

			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByProjectID(int projectID)
		{
			string sql = "SELECT * FROM [Project] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByOrgID(int orgID)
		{
			string sql = "SELECT * FROM [Project] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByProjectName(string projectName)
		{
			string sql = "SELECT * FROM [Project] WHERE [ProjectName]=@ProjectName";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectName", SqlDbType.NVarChar),
			};
			parameters[0].Value = projectName;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByTag(string tag)
		{
			string sql = "SELECT * FROM [Project] WHERE [Tag]=@Tag";
			SqlParameter[] parameters = {
				new SqlParameter("@Tag", SqlDbType.NVarChar),
			};
			parameters[0].Value = tag;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByDescription(string description)
		{
			string sql = "SELECT * FROM [Project] WHERE [Description]=@Description";
			SqlParameter[] parameters = {
				new SqlParameter("@Description", SqlDbType.NVarChar),
			};
			parameters[0].Value = description;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByCostCenter(string costCenter)
		{
			string sql = "SELECT * FROM [Project] WHERE [CostCenter]=@CostCenter";
			SqlParameter[] parameters = {
				new SqlParameter("@CostCenter", SqlDbType.VarChar),
			};
			parameters[0].Value = costCenter;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByStartDate(string startDate)
		{
			string sql = "SELECT * FROM [Project] WHERE [StartDate]=@StartDate";
			SqlParameter[] parameters = {
				new SqlParameter("@StartDate", SqlDbType.Date),
			};
			parameters[0].Value = startDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByPlanGoLiveDate(string planGoLiveDate)
		{
			string sql = "SELECT * FROM [Project] WHERE [PlanGoLiveDate]=@PlanGoLiveDate";
			SqlParameter[] parameters = {
				new SqlParameter("@PlanGoLiveDate", SqlDbType.Date),
			};
			parameters[0].Value = planGoLiveDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByDueDate(string dueDate)
		{
			string sql = "SELECT * FROM [Project] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByCreatedBy(string createdBy)
		{
			string sql = "SELECT * FROM [Project] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByCreateTime(DateTime createTime)
		{
			string sql = "SELECT * FROM [Project] WHERE [CreateTime]=@CreateTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByDepartment(string department)
		{
			string sql = "SELECT * FROM [Project] WHERE [Department]=@Department";
			SqlParameter[] parameters = {
				new SqlParameter("@Department", SqlDbType.NVarChar),
			};
			parameters[0].Value = department;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByFunctionGroup(string functionGroup)
		{
			string sql = "SELECT * FROM [Project] WHERE [FunctionGroup]=@FunctionGroup";
			SqlParameter[] parameters = {
				new SqlParameter("@FunctionGroup", SqlDbType.NVarChar),
			};
			parameters[0].Value = functionGroup;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByWorkcell(string workcell)
		{
			string sql = "SELECT * FROM [Project] WHERE [Workcell]=@Workcell";
			SqlParameter[] parameters = {
				new SqlParameter("@Workcell", SqlDbType.NVarChar),
			};
			parameters[0].Value = workcell;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByPM(string pM)
		{
			string sql = "SELECT * FROM [Project] WHERE [PM]=@PM";
			SqlParameter[] parameters = {
				new SqlParameter("@PM", SqlDbType.VarChar),
			};
			parameters[0].Value = pM;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelBySME(string sME)
		{
			string sql = "SELECT * FROM [Project] WHERE [SME]=@SME";
			SqlParameter[] parameters = {
				new SqlParameter("@SME", SqlDbType.VarChar),
			};
			parameters[0].Value = sME;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelBySource(string source)
		{
			string sql = "SELECT * FROM [Project] WHERE [Source]=@Source";
			SqlParameter[] parameters = {
				new SqlParameter("@Source", SqlDbType.VarChar),
			};
			parameters[0].Value = source;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByQuarter(string quarter)
		{
			string sql = "SELECT * FROM [Project] WHERE [Quarter]=@Quarter";
			SqlParameter[] parameters = {
				new SqlParameter("@Quarter", SqlDbType.VarChar),
			};
			parameters[0].Value = quarter;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByType(string type)
		{
			string sql = "SELECT * FROM [Project] WHERE [Type]=@Type";
			SqlParameter[] parameters = {
				new SqlParameter("@Type", SqlDbType.VarChar),
			};
			parameters[0].Value = type;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByScope(string scope)
		{
			string sql = "SELECT * FROM [Project] WHERE [Scope]=@Scope";
			SqlParameter[] parameters = {
				new SqlParameter("@Scope", SqlDbType.VarChar),
			};
			parameters[0].Value = scope;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelBySponsor(string sponsor)
		{
			string sql = "SELECT * FROM [Project] WHERE [Sponsor]=@Sponsor";
			SqlParameter[] parameters = {
				new SqlParameter("@Sponsor", SqlDbType.NVarChar),
			};
			parameters[0].Value = sponsor;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByIsMajor(string isMajor)
		{
			string sql = "SELECT * FROM [Project] WHERE [IsMajor]=@IsMajor";
			SqlParameter[] parameters = {
				new SqlParameter("@IsMajor", SqlDbType.VarChar),
			};
			parameters[0].Value = isMajor;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByARSNo(string aRSNo)
		{
			string sql = "SELECT * FROM [Project] WHERE [ARSNo]=@ARSNo";
			SqlParameter[] parameters = {
				new SqlParameter("@ARSNo", SqlDbType.VarChar),
			};
			parameters[0].Value = aRSNo;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByStatus(int status)
		{
			string sql = "SELECT * FROM [Project] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelBySaving(decimal saving)
		{
			string sql = "SELECT * FROM [Project] WHERE [Saving]=@Saving";
			SqlParameter[] parameters = {
				new SqlParameter("@Saving", SqlDbType.Decimal),
			};
			parameters[0].Value = saving;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByEstimatedTime(decimal estimatedTime)
		{
			string sql = "SELECT * FROM [Project] WHERE [EstimatedTime]=@EstimatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
			};
			parameters[0].Value = estimatedTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByInternalBudget(decimal internalBudget)
		{
			string sql = "SELECT * FROM [Project] WHERE [InternalBudget]=@InternalBudget";
			SqlParameter[] parameters = {
				new SqlParameter("@InternalBudget", SqlDbType.Decimal),
			};
			parameters[0].Value = internalBudget;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByExternalBudget(decimal externalBudget)
		{
			string sql = "SELECT * FROM [Project] WHERE [ExternalBudget]=@ExternalBudget";
			SqlParameter[] parameters = {
				new SqlParameter("@ExternalBudget", SqlDbType.Decimal),
			};
			parameters[0].Value = externalBudget;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByROI(decimal rOI)
		{
			string sql = "SELECT * FROM [Project] WHERE [ROI]=@ROI";
			SqlParameter[] parameters = {
				new SqlParameter("@ROI", SqlDbType.Decimal),
			};
			parameters[0].Value = rOI;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByPhase(string phase)
		{
			string sql = "SELECT * FROM [Project] WHERE [Phase]=@Phase";
			SqlParameter[] parameters = {
				new SqlParameter("@Phase", SqlDbType.NVarChar),
			};
			parameters[0].Value = phase;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByCloseDate(string closeDate)
		{
			string sql = "SELECT * FROM [Project] WHERE [CloseDate]=@CloseDate";
			SqlParameter[] parameters = {
				new SqlParameter("@CloseDate", SqlDbType.Date),
			};
			parameters[0].Value = closeDate;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByActualTime(decimal actualTime)
		{
			string sql = "SELECT * FROM [Project] WHERE [ActualTime]=@ActualTime";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualTime", SqlDbType.Decimal),
			};
			parameters[0].Value = actualTime;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByActualInternalCost(decimal actualInternalCost)
		{
			string sql = "SELECT * FROM [Project] WHERE [ActualInternalCost]=@ActualInternalCost";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualInternalCost", SqlDbType.Decimal),
			};
			parameters[0].Value = actualInternalCost;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByActualExternalCost(decimal actualExternalCost)
		{
			string sql = "SELECT * FROM [Project] WHERE [ActualExternalCost]=@ActualExternalCost";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualExternalCost", SqlDbType.Decimal),
			};
			parameters[0].Value = actualExternalCost;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public ProjectModel GetModelByActualSaving(decimal actualSaving)
		{
			string sql = "SELECT * FROM [Project] WHERE [ActualSaving]=@ActualSaving";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualSaving", SqlDbType.Decimal),
			};
			parameters[0].Value = actualSaving;
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}



		public int Insert(ProjectModel model)
		{
			string sql = "INSERT INTO [Project]([OrgID],[ProjectName],[Tag],[Description],[CostCenter],[StartDate],[PlanGoLiveDate],[DueDate],[CreatedBy],[CreateTime],[Department],[FunctionGroup],[Workcell],[PM],[SME],[Source],[Quarter],[Type],[Scope],[Sponsor],[IsMajor],[ARSNo],[Status],[Saving],[EstimatedTime],[InternalBudget],[ExternalBudget],[ROI],[Phase],[CloseDate],[ActualTime],[ActualInternalCost],[ActualExternalCost],[ActualSaving]) VALUES(@OrgID,@ProjectName,@Tag,@Description,@CostCenter,@StartDate,@PlanGoLiveDate,@DueDate,@CreatedBy,@CreateTime,@Department,@FunctionGroup,@Workcell,@PM,@SME,@Source,@Quarter,@Type,@Scope,@Sponsor,@IsMajor,@ARSNo,@Status,@Saving,@EstimatedTime,@InternalBudget,@ExternalBudget,@ROI,@Phase,@CloseDate,@ActualTime,@ActualInternalCost,@ActualExternalCost,@ActualSaving)";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
				new SqlParameter("@ProjectName", SqlDbType.NVarChar),
				new SqlParameter("@Tag", SqlDbType.NVarChar),
				new SqlParameter("@Description", SqlDbType.NVarChar),
				new SqlParameter("@CostCenter", SqlDbType.VarChar),
				new SqlParameter("@StartDate", SqlDbType.Date),
				new SqlParameter("@PlanGoLiveDate", SqlDbType.Date),
				new SqlParameter("@DueDate", SqlDbType.Date),
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
				new SqlParameter("@Department", SqlDbType.NVarChar),
				new SqlParameter("@FunctionGroup", SqlDbType.NVarChar),
				new SqlParameter("@Workcell", SqlDbType.NVarChar),
				new SqlParameter("@PM", SqlDbType.VarChar),
				new SqlParameter("@SME", SqlDbType.VarChar),
				new SqlParameter("@Source", SqlDbType.VarChar),
				new SqlParameter("@Quarter", SqlDbType.VarChar),
				new SqlParameter("@Type", SqlDbType.VarChar),
				new SqlParameter("@Scope", SqlDbType.VarChar),
				new SqlParameter("@Sponsor", SqlDbType.NVarChar),
				new SqlParameter("@IsMajor", SqlDbType.VarChar),
				new SqlParameter("@ARSNo", SqlDbType.VarChar),
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@Saving", SqlDbType.Decimal),
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
				new SqlParameter("@InternalBudget", SqlDbType.Decimal),
				new SqlParameter("@ExternalBudget", SqlDbType.Decimal),
				new SqlParameter("@ROI", SqlDbType.Decimal),
				new SqlParameter("@Phase", SqlDbType.NVarChar),
				new SqlParameter("@CloseDate", SqlDbType.Date),
				new SqlParameter("@ActualTime", SqlDbType.Decimal),
				new SqlParameter("@ActualInternalCost", SqlDbType.Decimal),
				new SqlParameter("@ActualExternalCost", SqlDbType.Decimal),
				new SqlParameter("@ActualSaving", SqlDbType.Decimal),
			};
			parameters[0].Value = model.OrgID == null ? (object)DBNull.Value : model.OrgID;
			parameters[1].Value = model.ProjectName == null ? (object)DBNull.Value : model.ProjectName;
			parameters[2].Value = model.Tag == null ? (object)DBNull.Value : model.Tag;
			parameters[3].Value = model.Description == null ? (object)DBNull.Value : model.Description;
			parameters[4].Value = model.CostCenter == null ? (object)DBNull.Value : model.CostCenter;
			parameters[5].Value = model.StartDate == null ? (object)DBNull.Value : model.StartDate;
			parameters[6].Value = model.PlanGoLiveDate == null ? (object)DBNull.Value : model.PlanGoLiveDate;
			parameters[7].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
			parameters[8].Value = model.CreatedBy == null ? (object)DBNull.Value : model.CreatedBy;
			parameters[9].Value = model.CreateTime == null ? (object)DBNull.Value : model.CreateTime;
			parameters[10].Value = model.Department == null ? (object)DBNull.Value : model.Department;
			parameters[11].Value = model.FunctionGroup == null ? (object)DBNull.Value : model.FunctionGroup;
			parameters[12].Value = model.Workcell == null ? (object)DBNull.Value : model.Workcell;
			parameters[13].Value = model.PM == null ? (object)DBNull.Value : model.PM;
			parameters[14].Value = model.SME == null ? (object)DBNull.Value : model.SME;
			parameters[15].Value = model.Source == null ? (object)DBNull.Value : model.Source;
			parameters[16].Value = model.Quarter == null ? (object)DBNull.Value : model.Quarter;
			parameters[17].Value = model.Type == null ? (object)DBNull.Value : model.Type;
			parameters[18].Value = model.Scope == null ? (object)DBNull.Value : model.Scope;
			parameters[19].Value = model.Sponsor == null ? (object)DBNull.Value : model.Sponsor;
			parameters[20].Value = model.IsMajor == null ? (object)DBNull.Value : model.IsMajor;
			parameters[21].Value = model.ARSNo == null ? (object)DBNull.Value : model.ARSNo;
			parameters[22].Value = model.Status == null ? (object)DBNull.Value : model.Status;
			parameters[23].Value = model.Saving == null ? (object)DBNull.Value : model.Saving;
			parameters[24].Value = model.EstimatedTime == null ? (object)DBNull.Value : model.EstimatedTime;
			parameters[25].Value = model.InternalBudget == null ? (object)DBNull.Value : model.InternalBudget;
			parameters[26].Value = model.ExternalBudget == null ? (object)DBNull.Value : model.ExternalBudget;
			parameters[27].Value = model.ROI == null ? (object)DBNull.Value : model.ROI;
			parameters[28].Value = model.Phase == null ? (object)DBNull.Value : model.Phase;
			parameters[29].Value = model.CloseDate == null ? (object)DBNull.Value : model.CloseDate;
			parameters[30].Value = model.ActualTime == null ? (object)DBNull.Value : model.ActualTime;
			parameters[31].Value = model.ActualInternalCost == null ? (object)DBNull.Value : model.ActualInternalCost;
			parameters[32].Value = model.ActualExternalCost == null ? (object)DBNull.Value : model.ActualExternalCost;
			parameters[33].Value = model.ActualSaving == null ? (object)DBNull.Value : model.ActualSaving;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update(ProjectModel model)
		{
			string sql = "UPDATE [Project] SET [OrgID]=@OrgID,[ProjectName]=@ProjectName,[Tag]=@Tag,[Description]=@Description,[CostCenter]=@CostCenter,[StartDate]=@StartDate,[PlanGoLiveDate]=@PlanGoLiveDate,[DueDate]=@DueDate,[CreatedBy]=@CreatedBy,[CreateTime]=@CreateTime,[Department]=@Department,[FunctionGroup]=@FunctionGroup,[Workcell]=@Workcell,[PM]=@PM,[SME]=@SME,[Source]=@Source,[Quarter]=@Quarter,[Type]=@Type,[Scope]=@Scope,[Sponsor]=@Sponsor,[IsMajor]=@IsMajor,[ARSNo]=@ARSNo,[Status]=@Status,[Saving]=@Saving,[EstimatedTime]=@EstimatedTime,[InternalBudget]=@InternalBudget,[ExternalBudget]=@ExternalBudget,[ROI]=@ROI,[Phase]=@Phase,[CloseDate]=@CloseDate,[ActualTime]=@ActualTime,[ActualInternalCost]=@ActualInternalCost,[ActualExternalCost]=@ActualExternalCost,[ActualSaving]=@ActualSaving WHERE ProjectID=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
				new SqlParameter("@OrgID", SqlDbType.Int),
				new SqlParameter("@ProjectName", SqlDbType.NVarChar),
				new SqlParameter("@Tag", SqlDbType.NVarChar),
				new SqlParameter("@Description", SqlDbType.NVarChar),
				new SqlParameter("@CostCenter", SqlDbType.VarChar),
				new SqlParameter("@StartDate", SqlDbType.Date),
				new SqlParameter("@PlanGoLiveDate", SqlDbType.Date),
				new SqlParameter("@DueDate", SqlDbType.Date),
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
				new SqlParameter("@Department", SqlDbType.NVarChar),
				new SqlParameter("@FunctionGroup", SqlDbType.NVarChar),
				new SqlParameter("@Workcell", SqlDbType.NVarChar),
				new SqlParameter("@PM", SqlDbType.VarChar),
				new SqlParameter("@SME", SqlDbType.VarChar),
				new SqlParameter("@Source", SqlDbType.VarChar),
				new SqlParameter("@Quarter", SqlDbType.VarChar),
				new SqlParameter("@Type", SqlDbType.VarChar),
				new SqlParameter("@Scope", SqlDbType.VarChar),
				new SqlParameter("@Sponsor", SqlDbType.NVarChar),
				new SqlParameter("@IsMajor", SqlDbType.VarChar),
				new SqlParameter("@ARSNo", SqlDbType.VarChar),
				new SqlParameter("@Status", SqlDbType.Int),
				new SqlParameter("@Saving", SqlDbType.Decimal),
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
				new SqlParameter("@InternalBudget", SqlDbType.Decimal),
				new SqlParameter("@ExternalBudget", SqlDbType.Decimal),
				new SqlParameter("@ROI", SqlDbType.Decimal),
				new SqlParameter("@Phase", SqlDbType.NVarChar),
				new SqlParameter("@CloseDate", SqlDbType.Date),
				new SqlParameter("@ActualTime", SqlDbType.Decimal),
				new SqlParameter("@ActualInternalCost", SqlDbType.Decimal),
				new SqlParameter("@ActualExternalCost", SqlDbType.Decimal),
				new SqlParameter("@ActualSaving", SqlDbType.Decimal),
			};
			parameters[0].Value = model.ProjectID;
			parameters[1].Value = model.OrgID == null ? (object)DBNull.Value : model.OrgID;
			parameters[2].Value = model.ProjectName == null ? (object)DBNull.Value : model.ProjectName;
			parameters[3].Value = model.Tag == null ? (object)DBNull.Value : model.Tag;
			parameters[4].Value = model.Description == null ? (object)DBNull.Value : model.Description;
			parameters[5].Value = model.CostCenter == null ? (object)DBNull.Value : model.CostCenter;
			parameters[6].Value = model.StartDate == null ? (object)DBNull.Value : model.StartDate;
			parameters[7].Value = model.PlanGoLiveDate == null ? (object)DBNull.Value : model.PlanGoLiveDate;
			parameters[8].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
			parameters[9].Value = model.CreatedBy == null ? (object)DBNull.Value : model.CreatedBy;
			parameters[10].Value = model.CreateTime == null ? (object)DBNull.Value : model.CreateTime;
			parameters[11].Value = model.Department == null ? (object)DBNull.Value : model.Department;
			parameters[12].Value = model.FunctionGroup == null ? (object)DBNull.Value : model.FunctionGroup;
			parameters[13].Value = model.Workcell == null ? (object)DBNull.Value : model.Workcell;
			parameters[14].Value = model.PM == null ? (object)DBNull.Value : model.PM;
			parameters[15].Value = model.SME == null ? (object)DBNull.Value : model.SME;
			parameters[16].Value = model.Source == null ? (object)DBNull.Value : model.Source;
			parameters[17].Value = model.Quarter == null ? (object)DBNull.Value : model.Quarter;
			parameters[18].Value = model.Type == null ? (object)DBNull.Value : model.Type;
			parameters[19].Value = model.Scope == null ? (object)DBNull.Value : model.Scope;
			parameters[20].Value = model.Sponsor == null ? (object)DBNull.Value : model.Sponsor;
			parameters[21].Value = model.IsMajor == null ? (object)DBNull.Value : model.IsMajor;
			parameters[22].Value = model.ARSNo == null ? (object)DBNull.Value : model.ARSNo;
			parameters[23].Value = model.Status == null ? (object)DBNull.Value : model.Status;
			parameters[24].Value = model.Saving == null ? (object)DBNull.Value : model.Saving;
			parameters[25].Value = model.EstimatedTime == null ? (object)DBNull.Value : model.EstimatedTime;
			parameters[26].Value = model.InternalBudget == null ? (object)DBNull.Value : model.InternalBudget;
			parameters[27].Value = model.ExternalBudget == null ? (object)DBNull.Value : model.ExternalBudget;
			parameters[28].Value = model.ROI == null ? (object)DBNull.Value : model.ROI;
			parameters[29].Value = model.Phase == null ? (object)DBNull.Value : model.Phase;
			parameters[30].Value = model.CloseDate == null ? (object)DBNull.Value : model.CloseDate;
			parameters[31].Value = model.ActualTime == null ? (object)DBNull.Value : model.ActualTime;
			parameters[32].Value = model.ActualInternalCost == null ? (object)DBNull.Value : model.ActualInternalCost;
			parameters[33].Value = model.ActualExternalCost == null ? (object)DBNull.Value : model.ActualExternalCost;
			parameters[34].Value = model.ActualSaving == null ? (object)DBNull.Value : model.ActualSaving;

			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete(int ProjectID)
		{
			string sql = "DELETE FROM [Project] WHERE  ProjectID=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = ProjectID;

            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByProjectID(int projectID)
		{
			string sql = "DELETE FROM [Project] WHERE [ProjectID]=@ProjectID";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectID", SqlDbType.Int),
			};
			parameters[0].Value = projectID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByOrgID(int orgID)
		{
			string sql = "DELETE FROM [Project] WHERE [OrgID]=@OrgID";
			SqlParameter[] parameters = {
				new SqlParameter("@OrgID", SqlDbType.Int),
			};
			parameters[0].Value = orgID;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByProjectName(string projectName)
		{
			string sql = "DELETE FROM [Project] WHERE [ProjectName]=@ProjectName";
			SqlParameter[] parameters = {
				new SqlParameter("@ProjectName", SqlDbType.NVarChar),
			};
			parameters[0].Value = projectName;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByTag(string tag)
		{
			string sql = "DELETE FROM [Project] WHERE [Tag]=@Tag";
			SqlParameter[] parameters = {
				new SqlParameter("@Tag", SqlDbType.NVarChar),
			};
			parameters[0].Value = tag;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDescription(string description)
		{
			string sql = "DELETE FROM [Project] WHERE [Description]=@Description";
			SqlParameter[] parameters = {
				new SqlParameter("@Description", SqlDbType.NVarChar),
			};
			parameters[0].Value = description;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCostCenter(string costCenter)
		{
			string sql = "DELETE FROM [Project] WHERE [CostCenter]=@CostCenter";
			SqlParameter[] parameters = {
				new SqlParameter("@CostCenter", SqlDbType.VarChar),
			};
			parameters[0].Value = costCenter;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStartDate(string startDate)
		{
			string sql = "DELETE FROM [Project] WHERE [StartDate]=@StartDate";
			SqlParameter[] parameters = {
				new SqlParameter("@StartDate", SqlDbType.Date),
			};
			parameters[0].Value = startDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPlanGoLiveDate(string planGoLiveDate)
		{
			string sql = "DELETE FROM [Project] WHERE [PlanGoLiveDate]=@PlanGoLiveDate";
			SqlParameter[] parameters = {
				new SqlParameter("@PlanGoLiveDate", SqlDbType.Date),
			};
			parameters[0].Value = planGoLiveDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDueDate(string dueDate)
		{
			string sql = "DELETE FROM [Project] WHERE [DueDate]=@DueDate";
			SqlParameter[] parameters = {
				new SqlParameter("@DueDate", SqlDbType.Date),
			};
			parameters[0].Value = dueDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCreatedBy(string createdBy)
		{
			string sql = "DELETE FROM [Project] WHERE [CreatedBy]=@CreatedBy";
			SqlParameter[] parameters = {
				new SqlParameter("@CreatedBy", SqlDbType.VarChar),
			};
			parameters[0].Value = createdBy;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCreateTime(DateTime createTime)
		{
			string sql = "DELETE FROM [Project] WHERE [CreateTime]=@CreateTime";
			SqlParameter[] parameters = {
				new SqlParameter("@CreateTime", SqlDbType.DateTime),
			};
			parameters[0].Value = createTime;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByDepartment(string department)
		{
			string sql = "DELETE FROM [Project] WHERE [Department]=@Department";
			SqlParameter[] parameters = {
				new SqlParameter("@Department", SqlDbType.NVarChar),
			};
			parameters[0].Value = department;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByFunctionGroup(string functionGroup)
		{
			string sql = "DELETE FROM [Project] WHERE [FunctionGroup]=@FunctionGroup";
			SqlParameter[] parameters = {
				new SqlParameter("@FunctionGroup", SqlDbType.NVarChar),
			};
			parameters[0].Value = functionGroup;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByWorkcell(string workcell)
		{
			string sql = "DELETE FROM [Project] WHERE [Workcell]=@Workcell";
			SqlParameter[] parameters = {
				new SqlParameter("@Workcell", SqlDbType.NVarChar),
			};
			parameters[0].Value = workcell;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPM(string pM)
		{
			string sql = "DELETE FROM [Project] WHERE [PM]=@PM";
			SqlParameter[] parameters = {
				new SqlParameter("@PM", SqlDbType.VarChar),
			};
			parameters[0].Value = pM;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteBySME(string sME)
		{
			string sql = "DELETE FROM [Project] WHERE [SME]=@SME";
			SqlParameter[] parameters = {
				new SqlParameter("@SME", SqlDbType.VarChar),
			};
			parameters[0].Value = sME;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteBySource(string source)
		{
			string sql = "DELETE FROM [Project] WHERE [Source]=@Source";
			SqlParameter[] parameters = {
				new SqlParameter("@Source", SqlDbType.VarChar),
			};
			parameters[0].Value = source;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByQuarter(string quarter)
		{
			string sql = "DELETE FROM [Project] WHERE [Quarter]=@Quarter";
			SqlParameter[] parameters = {
				new SqlParameter("@Quarter", SqlDbType.VarChar),
			};
			parameters[0].Value = quarter;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByType(string type)
		{
			string sql = "DELETE FROM [Project] WHERE [Type]=@Type";
			SqlParameter[] parameters = {
				new SqlParameter("@Type", SqlDbType.VarChar),
			};
			parameters[0].Value = type;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByScope(string scope)
		{
			string sql = "DELETE FROM [Project] WHERE [Scope]=@Scope";
			SqlParameter[] parameters = {
				new SqlParameter("@Scope", SqlDbType.VarChar),
			};
			parameters[0].Value = scope;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteBySponsor(string sponsor)
		{
			string sql = "DELETE FROM [Project] WHERE [Sponsor]=@Sponsor";
			SqlParameter[] parameters = {
				new SqlParameter("@Sponsor", SqlDbType.NVarChar),
			};
			parameters[0].Value = sponsor;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByIsMajor(string isMajor)
		{
			string sql = "DELETE FROM [Project] WHERE [IsMajor]=@IsMajor";
			SqlParameter[] parameters = {
				new SqlParameter("@IsMajor", SqlDbType.VarChar),
			};
			parameters[0].Value = isMajor;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByARSNo(string aRSNo)
		{
			string sql = "DELETE FROM [Project] WHERE [ARSNo]=@ARSNo";
			SqlParameter[] parameters = {
				new SqlParameter("@ARSNo", SqlDbType.VarChar),
			};
			parameters[0].Value = aRSNo;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByStatus(int status)
		{
			string sql = "DELETE FROM [Project] WHERE [Status]=@Status";
			SqlParameter[] parameters = {
				new SqlParameter("@Status", SqlDbType.Int),
			};
			parameters[0].Value = status;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteBySaving(decimal saving)
		{
			string sql = "DELETE FROM [Project] WHERE [Saving]=@Saving";
			SqlParameter[] parameters = {
				new SqlParameter("@Saving", SqlDbType.Decimal),
			};
			parameters[0].Value = saving;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByEstimatedTime(decimal estimatedTime)
		{
			string sql = "DELETE FROM [Project] WHERE [EstimatedTime]=@EstimatedTime";
			SqlParameter[] parameters = {
				new SqlParameter("@EstimatedTime", SqlDbType.Decimal),
			};
			parameters[0].Value = estimatedTime;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByInternalBudget(decimal internalBudget)
		{
			string sql = "DELETE FROM [Project] WHERE [InternalBudget]=@InternalBudget";
			SqlParameter[] parameters = {
				new SqlParameter("@InternalBudget", SqlDbType.Decimal),
			};
			parameters[0].Value = internalBudget;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByExternalBudget(decimal externalBudget)
		{
			string sql = "DELETE FROM [Project] WHERE [ExternalBudget]=@ExternalBudget";
			SqlParameter[] parameters = {
				new SqlParameter("@ExternalBudget", SqlDbType.Decimal),
			};
			parameters[0].Value = externalBudget;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByROI(decimal rOI)
		{
			string sql = "DELETE FROM [Project] WHERE [ROI]=@ROI";
			SqlParameter[] parameters = {
				new SqlParameter("@ROI", SqlDbType.Decimal),
			};
			parameters[0].Value = rOI;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByPhase(string phase)
		{
			string sql = "DELETE FROM [Project] WHERE [Phase]=@Phase";
			SqlParameter[] parameters = {
				new SqlParameter("@Phase", SqlDbType.NVarChar),
			};
			parameters[0].Value = phase;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByCloseDate(string closeDate)
		{
			string sql = "DELETE FROM [Project] WHERE [CloseDate]=@CloseDate";
			SqlParameter[] parameters = {
				new SqlParameter("@CloseDate", SqlDbType.Date),
			};
			parameters[0].Value = closeDate;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByActualTime(decimal actualTime)
		{
			string sql = "DELETE FROM [Project] WHERE [ActualTime]=@ActualTime";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualTime", SqlDbType.Decimal),
			};
			parameters[0].Value = actualTime;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByActualInternalCost(decimal actualInternalCost)
		{
			string sql = "DELETE FROM [Project] WHERE [ActualInternalCost]=@ActualInternalCost";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualInternalCost", SqlDbType.Decimal),
			};
			parameters[0].Value = actualInternalCost;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByActualExternalCost(decimal actualExternalCost)
		{
			string sql = "DELETE FROM [Project] WHERE [ActualExternalCost]=@ActualExternalCost";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualExternalCost", SqlDbType.Decimal),
			};
			parameters[0].Value = actualExternalCost;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int DeleteByActualSaving(decimal actualSaving)
		{
			string sql = "DELETE FROM [Project] WHERE [ActualSaving]=@ActualSaving";
			SqlParameter[] parameters = {
				new SqlParameter("@ActualSaving", SqlDbType.Decimal),
			};
			parameters[0].Value = actualSaving;
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}



		public ProjectModel DataRowToModel(DataRow row)
		{
			ProjectModel model = new ProjectModel();
            if (row == null) return model;

			if (row["ProjectID"] != null && row["ProjectID"].ToString() != "")
			{
				model.ProjectID = int.Parse(row["ProjectID"].ToString());
			}
			if (row["OrgID"] != null && row["OrgID"].ToString() != "")
			{
				model.OrgID = int.Parse(row["OrgID"].ToString());
			}
			if (row["ProjectName"] != null && row["ProjectName"].ToString() != "")
			{
				model.ProjectName = row["ProjectName"].ToString();
			}
			if (row["Tag"] != null && row["Tag"].ToString() != "")
			{
				model.Tag = row["Tag"].ToString();
			}
			if (row["Description"] != null && row["Description"].ToString() != "")
			{
				model.Description = row["Description"].ToString();
			}
			if (row["CostCenter"] != null && row["CostCenter"].ToString() != "")
			{
				model.CostCenter = row["CostCenter"].ToString();
			}
			if (row["StartDate"] != null && row["StartDate"].ToString() != "")
			{
				model.StartDate = row["StartDate"].ToString();
			}
			if (row["PlanGoLiveDate"] != null && row["PlanGoLiveDate"].ToString() != "")
			{
				model.PlanGoLiveDate = row["PlanGoLiveDate"].ToString();
			}
			if (row["DueDate"] != null && row["DueDate"].ToString() != "")
			{
				model.DueDate = row["DueDate"].ToString();
			}
			if (row["CreatedBy"] != null && row["CreatedBy"].ToString() != "")
			{
				model.CreatedBy = row["CreatedBy"].ToString();
			}
			if (row["CreateTime"] != null && row["CreateTime"].ToString() != "")
			{
				model.CreateTime = DateTime.Parse(row["CreateTime"].ToString());
			}
			if (row["Department"] != null && row["Department"].ToString() != "")
			{
				model.Department = row["Department"].ToString();
			}
			if (row["FunctionGroup"] != null && row["FunctionGroup"].ToString() != "")
			{
				model.FunctionGroup = row["FunctionGroup"].ToString();
			}
			if (row["Workcell"] != null && row["Workcell"].ToString() != "")
			{
				model.Workcell = row["Workcell"].ToString();
			}
			if (row["PM"] != null && row["PM"].ToString() != "")
			{
				model.PM = row["PM"].ToString();
			}
			if (row["SME"] != null && row["SME"].ToString() != "")
			{
				model.SME = row["SME"].ToString();
			}
			if (row["Source"] != null && row["Source"].ToString() != "")
			{
				model.Source = row["Source"].ToString();
			}
			if (row["Quarter"] != null && row["Quarter"].ToString() != "")
			{
				model.Quarter = row["Quarter"].ToString();
			}
			if (row["Type"] != null && row["Type"].ToString() != "")
			{
				model.Type = row["Type"].ToString();
			}
			if (row["Scope"] != null && row["Scope"].ToString() != "")
			{
				model.Scope = row["Scope"].ToString();
			}
			if (row["Sponsor"] != null && row["Sponsor"].ToString() != "")
			{
				model.Sponsor = row["Sponsor"].ToString();
			}
			if (row["IsMajor"] != null && row["IsMajor"].ToString() != "")
			{
				model.IsMajor = row["IsMajor"].ToString();
			}
			if (row["ARSNo"] != null && row["ARSNo"].ToString() != "")
			{
				model.ARSNo = row["ARSNo"].ToString();
			}
			if (row["Status"] != null && row["Status"].ToString() != "")
			{
				model.Status = int.Parse(row["Status"].ToString());
			}
			if (row["Saving"] != null && row["Saving"].ToString() != "")
			{
				model.Saving = decimal.Parse(row["Saving"].ToString());
			}
			if (row["EstimatedTime"] != null && row["EstimatedTime"].ToString() != "")
			{
				model.EstimatedTime = decimal.Parse(row["EstimatedTime"].ToString());
			}
			if (row["InternalBudget"] != null && row["InternalBudget"].ToString() != "")
			{
				model.InternalBudget = decimal.Parse(row["InternalBudget"].ToString());
			}
			if (row["ExternalBudget"] != null && row["ExternalBudget"].ToString() != "")
			{
				model.ExternalBudget = decimal.Parse(row["ExternalBudget"].ToString());
			}
			if (row["ROI"] != null && row["ROI"].ToString() != "")
			{
				model.ROI = decimal.Parse(row["ROI"].ToString());
			}
			if (row["Phase"] != null && row["Phase"].ToString() != "")
			{
				model.Phase = row["Phase"].ToString();
			}
			if (row["CloseDate"] != null && row["CloseDate"].ToString() != "")
			{
				model.CloseDate = row["CloseDate"].ToString();
			}
			if (row["ActualTime"] != null && row["ActualTime"].ToString() != "")
			{
				model.ActualTime = decimal.Parse(row["ActualTime"].ToString());
			}
			if (row["ActualInternalCost"] != null && row["ActualInternalCost"].ToString() != "")
			{
				model.ActualInternalCost = decimal.Parse(row["ActualInternalCost"].ToString());
			}
			if (row["ActualExternalCost"] != null && row["ActualExternalCost"].ToString() != "")
			{
				model.ActualExternalCost = decimal.Parse(row["ActualExternalCost"].ToString());
			}
			if (row["ActualSaving"] != null && row["ActualSaving"].ToString() != "")
			{
				model.ActualSaving = decimal.Parse(row["ActualSaving"].ToString());
			}

			return model;
		}

		#endregion
    }
}
