using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.BLL.Entities
{
    public class Expense
    {
        public int IdExpense { get; set; }

        public DateTime DateOfExpense { get; set; }

        public decimal Amount { get; set; }

        public string ExpenseDescription { get; set; }
    }
}
