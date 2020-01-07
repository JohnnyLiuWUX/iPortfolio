/**
 * Auto Create By Code Magic 2020-01-07 02:48:28
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;

namespace IPortfolio.Model
{
    public class SpendingModel
    {
		public int SpendID { get; set; }
		public int? TaskID { get; set; }
		public string Title { get; set; }
		public string RecordDate { get; set; }
		public int? SpendHour { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreateTime { get; set; }
    }
}