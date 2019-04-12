using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.BLL.Entities
{
    public class Project
    {
        public int IdProject { get; set; }

        public string ProjectName { get; set; }

        public decimal? ProjectValue { get; set; }

        public decimal? SquareMeterPrice { get; set; }

        public bool IsProjectFinished { get; set; }

        public string ProjectDescription { get; set; }
    }
}
