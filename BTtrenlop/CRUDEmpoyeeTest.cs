using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtrenlop
{
    public class CRUDEmpoyeeTest
    {
        private CRUDEmployee crudEmployee;

        [SetUp]
        public void Setup()
        {
            crudEmployee = new CRUDEmployee();
        }

        [Test]
        public void TestAddEmployee()
        {
            var employee = new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
            crudEmployee.AddEmployee(employee);

            var allEmployees = crudEmployee.GetAllEmployees();
            Assert.AreEqual(1, allEmployees.Count);
            Assert.AreEqual(employee.Id, allEmployees[0].Id);
            Assert.AreEqual(employee.FirstName, allEmployees[0].FirstName);
            Assert.AreEqual(employee.LastName, allEmployees[0].LastName);
            Assert.AreEqual(employee.Email, allEmployees[0].Email);
        }

        [Test]
        public void TestUpdateEmployee()
        {
            var employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
            crudEmployee.AddEmployee(employee1);

            var updatedEmployee = new Employee { Id = 1, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@example.com" };
            crudEmployee.UpdateEmployee(1, updatedEmployee);

            var allEmployees = crudEmployee.GetAllEmployees();
            Assert.AreEqual(1, allEmployees.Count);
            Assert.AreEqual(updatedEmployee.Id, allEmployees[0].Id);
            Assert.AreEqual(updatedEmployee.FirstName, allEmployees[0].FirstName);
            Assert.AreEqual(updatedEmployee.LastName, allEmployees[0].LastName);
            Assert.AreEqual(updatedEmployee.Email, allEmployees[0].Email);
        }

        [Test]
        public void TestDeleteEmployee()
        {
            var employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
            crudEmployee.AddEmployee(employee1);

            crudEmployee.DeleteEmployee(1);

            var allEmployees = crudEmployee.GetAllEmployees();
            Assert.AreEqual(0, allEmployees.Count);
        }
    }
}
