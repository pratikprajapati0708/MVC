using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;

namespace MyApp.Db.DbOperations
{
    public class EmployeeRepository
    {
        public int AddEmployee(Employee model) // return type is int so need to return integer type
        {
            using (var context = new EmployeeDBEntities()) //Create conncetion with database
            {
                Employee emp = new Employee() // created new model object of database and set the property coming from database
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code,
                };
                context.Employee.Add(emp); // Which table in ehich data needs to be added
                context.SaveChanges();
                return emp.Id; // returned employee id 
            }
        }

        public int AddEmployee(EmployeeModel model)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAllEmployees()
        {
            using (var context = new EmployeeDBEntities())
            {
                var result = context.Employee.Select(x => new EmployeeModel()
                {
                    Id = x.Id,
                    AddressId = x.AddressId,
                    Code = x.Code,
                    Email = x.Email,
                    FirstName=x.FirstName,
                    LastName=x.LastName

                }).ToList();
            }
        }
    }
}
