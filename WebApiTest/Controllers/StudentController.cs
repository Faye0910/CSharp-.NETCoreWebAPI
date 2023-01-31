using Microsoft.AspNetCore.Mvc;
using System;
using WebApiTest.Models;
using WebApiTest.Service;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase  //Controller執行
    {
        [HttpGet]
        public ActionResult<List<Student>> GetAll() =>StudentService.GetAll();

        [HttpPost]
        public ActionResult<List<Student>> Add(string Class,string name)
        {
            Student student = new Student { Id=4, Class = Class, Name = name };
            StudentService.Add(student);
            return StudentService.GetAll();
        }
    }
}
