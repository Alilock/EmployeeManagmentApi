﻿using EmployeeManagement.Entities.Base;

namespace EmployeeManagement.Entities
{
    public class Department : BaseAuditable
    {
        public string Name { get; set; } = null!;
        public string ParentDepartmentId { get; set; } = null!;
        public Department? ParentDepartment { get; set; }
        public ICollection<Department>? ChildDepartments{ get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
