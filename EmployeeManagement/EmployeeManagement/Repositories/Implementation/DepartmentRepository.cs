using EmployeeManagement.DAL;
using EmployeeManagement.Entities;
using EmployeeManagement.Repositories.Implementation.Base;
using EmployeeManagement.Repositories.Interfaces;

namespace EmployeeManagement.Repositories.Implementation
{
    public class DepartmentRepository : GenericRepository<Department, string>,IDepartmentRepository
    {
        public DepartmentRepository(AppDb db) : base(db)
        {
        }
    }
}
