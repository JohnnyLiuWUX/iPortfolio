using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
	public partial class ProjectBll
	{
		private readonly ProjectDal dal = new ProjectDal();

		public List<ProjectModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<ProjectModel> GetListByProjectID(int projectID)
		{
			return dal.GetListByProjectID(projectID);
		}

		public List<ProjectModel> GetListByOrgID(int orgID)
		{
			return dal.GetListByOrgID(orgID);
		}

		public List<ProjectModel> GetListByProjectName(string projectName)
		{
			return dal.GetListByProjectName(projectName);
		}

		public List<ProjectModel> GetListByTag(string tag)
		{
			return dal.GetListByTag(tag);
		}

		public List<ProjectModel> GetListByDescription(string description)
		{
			return dal.GetListByDescription(description);
		}

		public List<ProjectModel> GetListByCostCenter(string costCenter)
		{
			return dal.GetListByCostCenter(costCenter);
		}

		public List<ProjectModel> GetListByStartDate(string startDate)
		{
			return dal.GetListByStartDate(startDate);
		}

		public List<ProjectModel> GetListByPlanGoLiveDate(string planGoLiveDate)
		{
			return dal.GetListByPlanGoLiveDate(planGoLiveDate);
		}

		public List<ProjectModel> GetListByDueDate(string dueDate)
		{
			return dal.GetListByDueDate(dueDate);
		}

		public List<ProjectModel> GetListByCreatedBy(string createdBy)
		{
			return dal.GetListByCreatedBy(createdBy);
		}

		public List<ProjectModel> GetListByCreateTime(DateTime createTime)
		{
			return dal.GetListByCreateTime(createTime);
		}

		public List<ProjectModel> GetListByDepartment(string department)
		{
			return dal.GetListByDepartment(department);
		}

		public List<ProjectModel> GetListByFunctionGroup(string functionGroup)
		{
			return dal.GetListByFunctionGroup(functionGroup);
		}

		public List<ProjectModel> GetListByWorkcell(string workcell)
		{
			return dal.GetListByWorkcell(workcell);
		}

		public List<ProjectModel> GetListByPM(string pM)
		{
			return dal.GetListByPM(pM);
		}

		public List<ProjectModel> GetListBySME(string sME)
		{
			return dal.GetListBySME(sME);
		}

		public List<ProjectModel> GetListBySource(string source)
		{
			return dal.GetListBySource(source);
		}

		public List<ProjectModel> GetListByQuarter(string quarter)
		{
			return dal.GetListByQuarter(quarter);
		}

		public List<ProjectModel> GetListByType(string type)
		{
			return dal.GetListByType(type);
		}

		public List<ProjectModel> GetListByScope(string scope)
		{
			return dal.GetListByScope(scope);
		}

		public List<ProjectModel> GetListBySponsor(string sponsor)
		{
			return dal.GetListBySponsor(sponsor);
		}

		public List<ProjectModel> GetListByIsMajor(string isMajor)
		{
			return dal.GetListByIsMajor(isMajor);
		}

		public List<ProjectModel> GetListByARSNo(string aRSNo)
		{
			return dal.GetListByARSNo(aRSNo);
		}

		public List<ProjectModel> GetListByStatus(int status)
		{
			return dal.GetListByStatus(status);
		}

		public List<ProjectModel> GetListBySaving(decimal saving)
		{
			return dal.GetListBySaving(saving);
		}

		public List<ProjectModel> GetListByEstimatedTime(decimal estimatedTime)
		{
			return dal.GetListByEstimatedTime(estimatedTime);
		}

		public List<ProjectModel> GetListByInternalBudget(decimal internalBudget)
		{
			return dal.GetListByInternalBudget(internalBudget);
		}

		public List<ProjectModel> GetListByExternalBudget(decimal externalBudget)
		{
			return dal.GetListByExternalBudget(externalBudget);
		}

		public List<ProjectModel> GetListByROI(decimal rOI)
		{
			return dal.GetListByROI(rOI);
		}

		public List<ProjectModel> GetListByPhase(string phase)
		{
			return dal.GetListByPhase(phase);
		}

		public List<ProjectModel> GetListByCloseDate(string closeDate)
		{
			return dal.GetListByCloseDate(closeDate);
		}

		public List<ProjectModel> GetListByActualTime(decimal actualTime)
		{
			return dal.GetListByActualTime(actualTime);
		}

		public List<ProjectModel> GetListByActualInternalCost(decimal actualInternalCost)
		{
			return dal.GetListByActualInternalCost(actualInternalCost);
		}

		public List<ProjectModel> GetListByActualExternalCost(decimal actualExternalCost)
		{
			return dal.GetListByActualExternalCost(actualExternalCost);
		}

		public List<ProjectModel> GetListByActualSaving(decimal actualSaving)
		{
			return dal.GetListByActualSaving(actualSaving);
		}

		public List<ProjectModel> GetListByDonePercent(int donePercent)
		{
			return dal.GetListByDonePercent(donePercent);
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
			return dal.GetListByWhere(where, orderName, orderValue);
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
		public List<ProjectModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereAnd(whereAnd, orderName, orderValue);
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
		public List<ProjectModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public ProjectModel GetModel(int ProjectID)
		{
			return dal.GetModel(ProjectID);
		}

		public ProjectModel GetModelByProjectID(int projectID)
		{
			return dal.GetModelByProjectID(projectID);
		}

		public ProjectModel GetModelByOrgID(int orgID)
		{
			return dal.GetModelByOrgID(orgID);
		}

		public ProjectModel GetModelByProjectName(string projectName)
		{
			return dal.GetModelByProjectName(projectName);
		}

		public ProjectModel GetModelByTag(string tag)
		{
			return dal.GetModelByTag(tag);
		}

		public ProjectModel GetModelByDescription(string description)
		{
			return dal.GetModelByDescription(description);
		}

		public ProjectModel GetModelByCostCenter(string costCenter)
		{
			return dal.GetModelByCostCenter(costCenter);
		}

		public ProjectModel GetModelByStartDate(string startDate)
		{
			return dal.GetModelByStartDate(startDate);
		}

		public ProjectModel GetModelByPlanGoLiveDate(string planGoLiveDate)
		{
			return dal.GetModelByPlanGoLiveDate(planGoLiveDate);
		}

		public ProjectModel GetModelByDueDate(string dueDate)
		{
			return dal.GetModelByDueDate(dueDate);
		}

		public ProjectModel GetModelByCreatedBy(string createdBy)
		{
			return dal.GetModelByCreatedBy(createdBy);
		}

		public ProjectModel GetModelByCreateTime(DateTime createTime)
		{
			return dal.GetModelByCreateTime(createTime);
		}

		public ProjectModel GetModelByDepartment(string department)
		{
			return dal.GetModelByDepartment(department);
		}

		public ProjectModel GetModelByFunctionGroup(string functionGroup)
		{
			return dal.GetModelByFunctionGroup(functionGroup);
		}

		public ProjectModel GetModelByWorkcell(string workcell)
		{
			return dal.GetModelByWorkcell(workcell);
		}

		public ProjectModel GetModelByPM(string pM)
		{
			return dal.GetModelByPM(pM);
		}

		public ProjectModel GetModelBySME(string sME)
		{
			return dal.GetModelBySME(sME);
		}

		public ProjectModel GetModelBySource(string source)
		{
			return dal.GetModelBySource(source);
		}

		public ProjectModel GetModelByQuarter(string quarter)
		{
			return dal.GetModelByQuarter(quarter);
		}

		public ProjectModel GetModelByType(string type)
		{
			return dal.GetModelByType(type);
		}

		public ProjectModel GetModelByScope(string scope)
		{
			return dal.GetModelByScope(scope);
		}

		public ProjectModel GetModelBySponsor(string sponsor)
		{
			return dal.GetModelBySponsor(sponsor);
		}

		public ProjectModel GetModelByIsMajor(string isMajor)
		{
			return dal.GetModelByIsMajor(isMajor);
		}

		public ProjectModel GetModelByARSNo(string aRSNo)
		{
			return dal.GetModelByARSNo(aRSNo);
		}

		public ProjectModel GetModelByStatus(int status)
		{
			return dal.GetModelByStatus(status);
		}

		public ProjectModel GetModelBySaving(decimal saving)
		{
			return dal.GetModelBySaving(saving);
		}

		public ProjectModel GetModelByEstimatedTime(decimal estimatedTime)
		{
			return dal.GetModelByEstimatedTime(estimatedTime);
		}

		public ProjectModel GetModelByInternalBudget(decimal internalBudget)
		{
			return dal.GetModelByInternalBudget(internalBudget);
		}

		public ProjectModel GetModelByExternalBudget(decimal externalBudget)
		{
			return dal.GetModelByExternalBudget(externalBudget);
		}

		public ProjectModel GetModelByROI(decimal rOI)
		{
			return dal.GetModelByROI(rOI);
		}

		public ProjectModel GetModelByPhase(string phase)
		{
			return dal.GetModelByPhase(phase);
		}

		public ProjectModel GetModelByCloseDate(string closeDate)
		{
			return dal.GetModelByCloseDate(closeDate);
		}

		public ProjectModel GetModelByActualTime(decimal actualTime)
		{
			return dal.GetModelByActualTime(actualTime);
		}

		public ProjectModel GetModelByActualInternalCost(decimal actualInternalCost)
		{
			return dal.GetModelByActualInternalCost(actualInternalCost);
		}

		public ProjectModel GetModelByActualExternalCost(decimal actualExternalCost)
		{
			return dal.GetModelByActualExternalCost(actualExternalCost);
		}

		public ProjectModel GetModelByActualSaving(decimal actualSaving)
		{
			return dal.GetModelByActualSaving(actualSaving);
		}

		public ProjectModel GetModelByDonePercent(int donePercent)
		{
			return dal.GetModelByDonePercent(donePercent);
		}



		public int Insert(ProjectModel model)
		{
			return dal.Insert(model);
		}

		public int Update(ProjectModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int ProjectID)
		{
			return dal.Delete(ProjectID);
		}

		public int DeleteByProjectID(int projectID)
		{
			return dal.DeleteByProjectID(projectID);
		}

		public int DeleteByOrgID(int orgID)
		{
			return dal.DeleteByOrgID(orgID);
		}

		public int DeleteByProjectName(string projectName)
		{
			return dal.DeleteByProjectName(projectName);
		}

		public int DeleteByTag(string tag)
		{
			return dal.DeleteByTag(tag);
		}

		public int DeleteByDescription(string description)
		{
			return dal.DeleteByDescription(description);
		}

		public int DeleteByCostCenter(string costCenter)
		{
			return dal.DeleteByCostCenter(costCenter);
		}

		public int DeleteByStartDate(string startDate)
		{
			return dal.DeleteByStartDate(startDate);
		}

		public int DeleteByPlanGoLiveDate(string planGoLiveDate)
		{
			return dal.DeleteByPlanGoLiveDate(planGoLiveDate);
		}

		public int DeleteByDueDate(string dueDate)
		{
			return dal.DeleteByDueDate(dueDate);
		}

		public int DeleteByCreatedBy(string createdBy)
		{
			return dal.DeleteByCreatedBy(createdBy);
		}

		public int DeleteByCreateTime(DateTime createTime)
		{
			return dal.DeleteByCreateTime(createTime);
		}

		public int DeleteByDepartment(string department)
		{
			return dal.DeleteByDepartment(department);
		}

		public int DeleteByFunctionGroup(string functionGroup)
		{
			return dal.DeleteByFunctionGroup(functionGroup);
		}

		public int DeleteByWorkcell(string workcell)
		{
			return dal.DeleteByWorkcell(workcell);
		}

		public int DeleteByPM(string pM)
		{
			return dal.DeleteByPM(pM);
		}

		public int DeleteBySME(string sME)
		{
			return dal.DeleteBySME(sME);
		}

		public int DeleteBySource(string source)
		{
			return dal.DeleteBySource(source);
		}

		public int DeleteByQuarter(string quarter)
		{
			return dal.DeleteByQuarter(quarter);
		}

		public int DeleteByType(string type)
		{
			return dal.DeleteByType(type);
		}

		public int DeleteByScope(string scope)
		{
			return dal.DeleteByScope(scope);
		}

		public int DeleteBySponsor(string sponsor)
		{
			return dal.DeleteBySponsor(sponsor);
		}

		public int DeleteByIsMajor(string isMajor)
		{
			return dal.DeleteByIsMajor(isMajor);
		}

		public int DeleteByARSNo(string aRSNo)
		{
			return dal.DeleteByARSNo(aRSNo);
		}

		public int DeleteByStatus(int status)
		{
			return dal.DeleteByStatus(status);
		}

		public int DeleteBySaving(decimal saving)
		{
			return dal.DeleteBySaving(saving);
		}

		public int DeleteByEstimatedTime(decimal estimatedTime)
		{
			return dal.DeleteByEstimatedTime(estimatedTime);
		}

		public int DeleteByInternalBudget(decimal internalBudget)
		{
			return dal.DeleteByInternalBudget(internalBudget);
		}

		public int DeleteByExternalBudget(decimal externalBudget)
		{
			return dal.DeleteByExternalBudget(externalBudget);
		}

		public int DeleteByROI(decimal rOI)
		{
			return dal.DeleteByROI(rOI);
		}

		public int DeleteByPhase(string phase)
		{
			return dal.DeleteByPhase(phase);
		}

		public int DeleteByCloseDate(string closeDate)
		{
			return dal.DeleteByCloseDate(closeDate);
		}

		public int DeleteByActualTime(decimal actualTime)
		{
			return dal.DeleteByActualTime(actualTime);
		}

		public int DeleteByActualInternalCost(decimal actualInternalCost)
		{
			return dal.DeleteByActualInternalCost(actualInternalCost);
		}

		public int DeleteByActualExternalCost(decimal actualExternalCost)
		{
			return dal.DeleteByActualExternalCost(actualExternalCost);
		}

		public int DeleteByActualSaving(decimal actualSaving)
		{
			return dal.DeleteByActualSaving(actualSaving);
		}

		public int DeleteByDonePercent(int donePercent)
		{
			return dal.DeleteByDonePercent(donePercent);
		}


	}
}
