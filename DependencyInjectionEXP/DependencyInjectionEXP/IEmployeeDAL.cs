using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionEXP
{
    public interface IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees();
    }
}
