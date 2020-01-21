using System;

namespace IPortfolio.Web.Controllers
{
    public class NoteViewModel
    {
		public int NoteID { get; set; }
		public int ProjectID { get; set; }
		public int TaskID { get; set; }
		public string Note { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedTime { get; set; }
    }
}