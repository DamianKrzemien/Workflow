using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.BLL.Entities
{
    public class ReportedHours
    {
        public int IdReportedHours { get; set; }

        public DateTime Date { get; set; }

        public decimal NumberOfHours { get; set; }
    }
}
