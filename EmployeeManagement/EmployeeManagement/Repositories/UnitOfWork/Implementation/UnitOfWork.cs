using EmployeeManagement.DAL;
using EmployeeManagement.Repositories.Implementation;
using EmployeeManagement.Repositories.Interfaces;
using System;

namespace EmployeeManagement.Repositories.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDb _dbContext;

        public UnitOfWork(AppDb dbContext)
        {
            _dbContext = dbContext;
        }
        private IEmployeeRepository? _employeeRepository;
        private IDepartmentRepository? _departmentRepository;
        public IEmployeeRepository EmployeeRepository => _employeeRepository ??= new EmployeeRepository(_dbContext);
        public IDepartmentRepository DepartmentRepository => _departmentRepository ??= new DepartmentRepository(_dbContext);


        public async Task<int> SaveChangesAsync()
        {
          return  await _dbContext.SaveChangesAsync();
        }
    }
}
