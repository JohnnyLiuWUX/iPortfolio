/**
 * Auto Create By Code Magic 2020-01-07 02:48:23
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;

namespace IPortfolio.Model
{
    public class NoteModel
    {
		public int NoteID { get; set; }
		public int? ProjectID { get; set; }
		public int? TaskID { get; set; }
		public string Note { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreatedTime { get; set; }
    }
}