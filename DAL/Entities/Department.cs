using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Department : NamedEntity
    {
        public virtual Department? ParentDepartment { get; set; }

        public virtual List<Department>? ChildDepartments { get; set; } = new();
    }
}
