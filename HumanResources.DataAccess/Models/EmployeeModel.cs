using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResources.DataAccess.Models
{
    public class EmployeeModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
    }
}
