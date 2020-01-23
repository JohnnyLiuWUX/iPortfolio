using System;

namespace IPortfolio.Model
{
    public class SpendingModel
    {
		public int SpendID { get; set; }
		public int? TaskID { get; set; }
		public string Title { get; set; }
		public DateTime? RecordDate { get; set; }
		public int? SpendHour { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreateTime { get; set; }
    }
}