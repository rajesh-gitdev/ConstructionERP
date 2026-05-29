using ConstructionERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionERP.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();

        Task<Employee?> GetByIdAsync(int id);

        Task<Employee> AddAsync(Employee employee);

        Task<Employee?> UpdateAsync(Employee employee);

        Task<bool> DeleteAsync(int id);
    }
}
