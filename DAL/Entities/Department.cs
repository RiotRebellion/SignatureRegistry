﻿using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace DAL.Entities
{
    public class Department : Entity
    {
        [Required]
        public virtual string Name { get; set; }

        public virtual Department? ParentDepartment { get; set; }

        public virtual List<Department>? ChildDepartments { get; set; }

        [Required]
        public virtual List<Employee> Employees { get; set; }
    }
}
