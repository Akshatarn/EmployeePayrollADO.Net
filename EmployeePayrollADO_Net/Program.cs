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
            EmpModel employeeModel = new EmpModel();
            Console.WriteLine("1 - DB Connectivity Status");
            Console.WriteLine("2 - Retrieve All Employees Details from Table in DB");
            Console.WriteLine("3 - Add new Employee Details into the Table");
            Console.WriteLine("4 - Update Salary");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    employeeRepository.CheckConnection();   //UC1 Checking Connectivity Status with the DataBase.
                    break;
                case 2:
                    employeeRepository.GetAllEmployee();    //UC2 Retrieve all data from Table.
                    break;
                case 3:
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
                    break;
                case 4:
                    employeeModel.Name = "Harish";
                    employeeModel.Id = 10;
                    employeeModel.Salary = 60000;
                    employeeRepository.UpdateEmployee(employeeModel);   //UC4 Update existing Employee Details
                    break;
                default:
                    Console.WriteLine("Invaild Option Selected! Try Again Later");
                    break;
            }

        }
    }
}
