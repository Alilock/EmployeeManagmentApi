using EmployeeManagement.Entities.Base;

namespace EmployeeManagement.Entities
{
    public class Employee : BaseAuditable
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string DepartmentId { get; set; } = null!;
        public Department Department { get; set; } = null!; 
    }
}
