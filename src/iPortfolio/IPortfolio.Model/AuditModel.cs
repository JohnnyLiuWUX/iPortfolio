﻿/**
 * Auto Create By Code Magic 2020-01-08 11:26:57
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;

namespace IPortfolio.Model
{
    public class AuditModel
    {
		public int AuditID { get; set; }
		public int? ProjectID { get; set; }
		public int? Status { get; set; }
		public string DueDate { get; set; }
		public string Auditor { get; set; }
		public DateTime? CreatedTime { get; set; }
    }
}