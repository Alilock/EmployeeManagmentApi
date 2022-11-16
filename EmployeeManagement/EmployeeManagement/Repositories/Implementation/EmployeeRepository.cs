using EmployeeManagement.DAL;
using EmployeeManagement.Entities;
using EmployeeManagement.Repositories.Implementation.Base;
using EmployeeManagement.Repositories.Interfaces;

namespace EmployeeManagement.Repositories.Implementation
{
    public class EmployeeRepository : GenericRepository<Employee, string>,IEmployeeRepository
    {
        public EmployeeRepository(AppDb db) : base(db)
        {
        }
    }
}
