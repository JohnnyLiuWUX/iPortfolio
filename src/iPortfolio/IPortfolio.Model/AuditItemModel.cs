﻿/**
 * Auto Create By Code Magic 2020-01-08 11:26:58
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;

namespace IPortfolio.Model
{
    public class AuditItemModel
    {
		public int ItemID { get; set; }
		public int? AuditID { get; set; }
		public int? AuditRuleID { get; set; }
		public int? Status { get; set; }
		public string Evidence { get; set; }
		public string Comments { get; set; }
    }
}