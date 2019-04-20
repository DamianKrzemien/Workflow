using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.BLL.Entities
{
    public class Worker
    {
        public int WorkerId { get; set; }

        public decimal Bid { get; set; }

        public PaymentOnAccount PaymentOnAccount { get; set; }

        public WorkerAddress WorkerAddress { get; set; }

        public ReportedHours ReportedHours { get; set; }
    }
}
