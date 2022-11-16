using EmployeeManagement.Entities;
using EmployeeManagement.Repositories.Interfaces.Base;

namespace EmployeeManagement.Repositories.Interfaces
{
    public interface IDepartmentRepository :IGenericRepository<Department,string>
    {
    }
}
