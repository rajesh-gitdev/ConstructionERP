using ConstructionERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionERP.Infrastructure.Repositories
{
    public class EmployeeRepository
    {
        private readonly Context.ApplicationDbContext _context;

        public EmployeeRepository(Context.ApplicationDbContext context)
        {
            _context = context;
        }

        // Get All Employees
        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        // Get Employee By Id
        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        // Add Employee
        public async Task<Employee> AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);

            await _context.SaveChangesAsync();

            return employee;
        }

        // Update Employee
        public async Task<Employee?> UpdateAsync(Employee employee)
        {
            var existingEmployee = await _context.Employees.FindAsync(employee.Id);

            if (existingEmployee == null)
            {
                return null;
            }

            existingEmployee.Name = employee.Name;
            //existingEmployee.Email = employee.Email;
            existingEmployee.Phone = employee.Phone;

            await _context.SaveChangesAsync();

            return existingEmployee;
        }

        // Delete Employee
        public async Task<bool> DeleteAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return false;
            }

            _context.Employees.Remove(employee);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
