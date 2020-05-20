using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnMicroServicesApp.Context;
using Microsoft.AspNetCore.Mvc;
using Model = LearnMicroServicesApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnMicroServicesApp.Controllers
{
    [Route("api/[controller]")]
    public class Employee : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Model.Employee> Get()
        {
            using (EFDataContext dataContext = new EFDataContext())
            {
                var employees = dataContext.Employee.ToList();
                return employees;
            }
        }

        // GET api/<controller>/5
        [HttpGet("{EmployeeID}")]
        public Model.Employee Get(int EmployeeID)
        {
            using (EFDataContext dataContext = new EFDataContext())
            {
                var employee = dataContext.Employee.FirstOrDefault(emp => emp.EmployeeID == EmployeeID);
                return employee;
            }
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Model.Employee employee)
        {
            
            using (EFDataContext dataContext = new EFDataContext())
            {
                var emp = dataContext.Employee.Add(employee);
                dataContext.SaveChanges();
                

            }
        }

        // PUT api/<controller>/5
        [HttpPut("{EmployeeID}")]
        public void Put(int EmployeeID,[FromBody]Model.Employee employee)
        {
            using (EFDataContext dataContext = new EFDataContext())
            {
                var emp = dataContext.Employee.FirstOrDefault(e => e.EmployeeID == EmployeeID);

                if(emp!=null)
                {
                    emp.EmployeeFirstName = employee.EmployeeFirstName;
                    emp.EmployeeLastName = employee.EmployeeLastName;
                    emp.Gender = employee.Gender;
                    emp.Designation = employee.Designation;
                    emp.Department = employee.Department;
                }



                dataContext.SaveChanges();

             

            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{EmployeeID}")]
        public void Delete(int EmployeeID)
        {
            using (EFDataContext dataContext = new EFDataContext())
            {
                var employee = dataContext.Employee.FirstOrDefault(emp => emp.EmployeeID == EmployeeID);
                if (employee != null)
                {
                    dataContext.Employee.Remove(employee);
                }

                dataContext.SaveChanges();

            }
        }
    }
}
