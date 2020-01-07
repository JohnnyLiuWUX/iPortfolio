/**
 * Auto Create By Code Magic 2020-01-07 02:48:24
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using IPortfolio.Model;
using IPortfolio.DAL;

namespace IPortfolio.BLL
{
    public partial class NoteBll
    {
		#region Auto Create By Code Magic

		private readonly NoteDal dal = new NoteDal();

		public List<NoteModel> GetAll()
		{
			return dal.GetAll();
		}

		public List<NoteModel> GetListByNoteID(int noteID)
		{
			return dal.GetListByNoteID(noteID);
		}

		public List<NoteModel> GetListByProjectID(int projectID)
		{
			return dal.GetListByProjectID(projectID);
		}

		public List<NoteModel> GetListByTaskID(int taskID)
		{
			return dal.GetListByTaskID(taskID);
		}

		public List<NoteModel> GetListByNote(string note)
		{
			return dal.GetListByNote(note);
		}

		public List<NoteModel> GetListByCreatedBy(string createdBy)
		{
			return dal.GetListByCreatedBy(createdBy);
		}

		public List<NoteModel> GetListByCreatedTime(DateTime createdTime)
		{
			return dal.GetListByCreatedTime(createdTime);
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
		public List<NoteModel> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue)
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
		public List<NoteModel> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue)
		{
			return dal.GetListByWhereOr(whereAnd, orderName, orderValue);
		}

		public NoteModel GetModel(int NoteID)
		{
			return dal.GetModel(NoteID);
		}

		public NoteModel GetModelByNoteID(int noteID)
		{
			return dal.GetModelByNoteID(noteID);
		}

		public NoteModel GetModelByProjectID(int projectID)
		{
			return dal.GetModelByProjectID(projectID);
		}

		public NoteModel GetModelByTaskID(int taskID)
		{
			return dal.GetModelByTaskID(taskID);
		}

		public NoteModel GetModelByNote(string note)
		{
			return dal.GetModelByNote(note);
		}

		public NoteModel GetModelByCreatedBy(string createdBy)
		{
			return dal.GetModelByCreatedBy(createdBy);
		}

		public NoteModel GetModelByCreatedTime(DateTime createdTime)
		{
			return dal.GetModelByCreatedTime(createdTime);
		}



		public int Insert(NoteModel model)
		{
			return dal.Insert(model);
		}

		public int Update(NoteModel model)
		{
			return dal.Update(model);
		}

		public int Delete(int NoteID)
		{
			return dal.Delete(NoteID);
		}

		public int DeleteByNoteID(int noteID)
		{
			return dal.DeleteByNoteID(noteID);
		}

		public int DeleteByProjectID(int projectID)
		{
			return dal.DeleteByProjectID(projectID);
		}

		public int DeleteByTaskID(int taskID)
		{
			return dal.DeleteByTaskID(taskID);
		}

		public int DeleteByNote(string note)
		{
			return dal.DeleteByNote(note);
		}

		public int DeleteByCreatedBy(string createdBy)
		{
			return dal.DeleteByCreatedBy(createdBy);
		}

		public int DeleteByCreatedTime(DateTime createdTime)
		{
			return dal.DeleteByCreatedTime(createdTime);
		}



		#endregion
    }
}
