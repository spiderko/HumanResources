using System;

namespace HumanResources.DataAccess.Models
{
    public class BaseModel
    {
        public Guid uid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Deleted { get; set; }

    }
}
