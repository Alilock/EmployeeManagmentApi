using EmployeeManagement.Entities;
using EmployeeManagement.Repositories.Interfaces.Base;

namespace EmployeeManagement.Repositories.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee,string>
    {
    }
}
