using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionEXP
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployee = new List<Employee>();
            {
                new Employee() { Id = 1, Name = "Pranaya", Department = "IT" };
                new Employee() { Id = 2, Name = "Kumar", Department = "HR" };
                new Employee() { Id = 3, Name = "Rout", Department = "Payroll" };
            };
            return ListEmployee;
        }
    }
}
