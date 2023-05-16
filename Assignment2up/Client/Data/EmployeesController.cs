using Assignment2up.Client.Pages;
using Assignment2up.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;

namespace Assignment2up.Data
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _dbContext;

        public EmployeesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Assignment2up.Models.Employee>> GetEmployees()
        {
            var employees = _dbContext.Employees.ToList();
            return (employees);
        }

        [HttpPut]
        public ActionResult<Assignment2up.Models.Employee> AddEmployee(Assignment2up.Models.Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return (employee);
        }

        private ActionResult<Employee> Ok(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
