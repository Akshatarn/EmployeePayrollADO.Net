using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollADO_Net
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo employeeRepository = new EmployeeRepo();
            employeeRepository.CheckConnection();   //UC1 Checking Connectivity Status with the DataBase.
            employeeRepository.GetAllEmployee();
        }
    }
}
