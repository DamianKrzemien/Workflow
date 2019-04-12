using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.BLL.Entities
{
    public class PaymentOnAccount
    {
        public int IdPaymentOnAccount { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
