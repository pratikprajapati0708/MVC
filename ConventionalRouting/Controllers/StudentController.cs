using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConventionalRouting.Models;

namespace ConventionalRouting.Controllers
{
    [RoutePrefix("students")]    //-----------------> Common part of the route we can write here and delete rest in route 
    public class StudentController : Controller
    {
        // GET: Student
        [Route("students")]
        public ActionResult GetAllStudents()
        {
            var students = Students();
            return View(students);
        }
        [Route("students/{id}")]
        public ActionResult GetStudent(int id)
        {
            var student = Students().FirstOrDefault(x => x.Id == id);
            return View();
        }
        public ActionResult GetStudentAddress(int id)

        {
            var studentAddress = Students().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
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