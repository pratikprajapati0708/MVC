using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConventionalRouting.Models;

namespace ConventionalRouting.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View();
        }
        public ActionResult GetStudentAddress(int id)

        {
            var student = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault;
            return View();
        }
        private List<Student> Students()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                    Name="1 Student",
                    Class="First",
                    Address=new Address()
                    {
                        Address1="this is student1 address",
                        City="Student 1 city",
                        HomeNumber="Student1"
                    }
,
                },
                 new Student()
                {
                    Id=2,
                    Name="2 Student",
                    Class="First2",
                    Address=new Address()
                    {
                        Address1="this is student2 address",
                        City="Student 2 city",
                        HomeNumber="Student2"
                    }
,
                },
                  new Student()
                {
                    Id=3,
                    Name="3 Student",
                    Class="First3",
                    Address=new Address()
                    {
                        Address1="this is student3 address",
                        City="Student 3 city",
                        HomeNumber="Student3s"
                    }
,
                },
                    new Student()
                {
                    Id=4,
                    Name="4 Student",
                    Class="First4",
                    Address=new Address()
                    {
                        Address1="this is student4 address",
                        City="Student 4 city",
                        HomeNumber="Student4s"
                    }
,
                },
            };
        }
    }
}