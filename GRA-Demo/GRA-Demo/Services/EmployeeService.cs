using GRA_Demo.Models;
using Microsoft.AspNetCore.Mvc;
namespace GRA_Demo.Services
{
    public class EmployeeService
    {
        private readonly List<Employee> employees = new()
        {
            new Employee { EmployeeId = 1, EmpName = "John Doe", EmpDesignation = Employee.Designation.JrITHelp },
            new Employee { EmployeeId = 2, EmpName = "Jane Smith", EmpDesignation = Employee.Designation.SrITHelp },
            new Employee { EmployeeId = 3, EmpName = "Bob Johnson", EmpDesignation = Employee.Designation.HeadOfIT }
        };

        public async Task<Employee> GetEmployeeById(int empId)
        {
            return employees.FirstOrDefault(e => e.EmployeeId == empId);
        }
    }
}
