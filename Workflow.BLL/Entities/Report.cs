using System;

namespace Workflow.BLL.Entities
{
    public class Report
    {
        public int IdReport { get; set; }

        public string ReportName { get; set; }

        public string ReportDescription { get; set; }

        public int? ProjectProgress { get; set; }

        public string Attachment { get; set; }

        public DateTime DateOfReport { get; set; }
    }
}