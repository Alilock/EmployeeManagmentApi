using EmployeeManagement.Repositories.Interfaces;

namespace EmployeeManagement.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
         IDepartmentRepository DepartmentRepository { get;  }
         IEmployeeRepository EmployeeRepository { get;  }
         Task<int> SaveChangesAsync();
    }
}
