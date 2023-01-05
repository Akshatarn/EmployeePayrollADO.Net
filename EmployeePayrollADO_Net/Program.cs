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
            employeeRepository.GetAllEmployee();    //UC2 Retrieve all data from Table.
            EmpModel employeeModel = new EmpModel();
            employeeModel.Name = "Sparsha";
            employeeModel.Salary = 40000;
            employeeModel.StartDate = DateTime.Now;
            employeeModel.Gender = "M";
            employeeModel.empPhone = 86682721;
            employeeModel.Address = "karnataka";
            employeeModel.Department = "HR";
            employeeModel.Deductions = 564.56;
            employeeModel.Taxable_Pay = 1300;
            employeeModel.Income_Tax = 13400;
            employeeModel.Net_Pay = 33333.34;
            employeeRepository.AddEmployee(employeeModel);
        }
    }
}
