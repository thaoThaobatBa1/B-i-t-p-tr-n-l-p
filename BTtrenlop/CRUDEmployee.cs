using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtrenlop
{
    public class CRUDEmployee
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(int id, Employee updatedEmployee)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employee.FirstName = updatedEmployee.FirstName;
                employee.LastName = updatedEmployee.LastName;
                employee.Email = updatedEmployee.Email;
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}
