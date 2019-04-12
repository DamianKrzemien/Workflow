using System;
using System.Collections.Generic;
using System.Text;

namespace Workflow.BLL.Entities
{
    public class User
    {
        public int IdUser { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        
        public int RoleId { get; set; }
    }
}
