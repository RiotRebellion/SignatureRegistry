using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    internal class Department : NamedEntity
    {
        public Department ParentDepartment { get; set; } 

        public IEnumerable<Department> ChildDepartments { get; set; }
    }
}
