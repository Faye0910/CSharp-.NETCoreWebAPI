using Microsoft.AspNetCore.SignalR;
using WebApiTest.Models;

namespace WebApiTest.Service
{
    public class StudentService
    {
        static List<Student> students { get; }
        static int id = 2;
        static StudentService() 
        {
            students = new List<Student>
            {
                new Student{Id=1,Class="1A",Name="May" },
                new Student{Id=2,Class="1B",Name="Eve" },
            };
        }

        public static List<Student> GetAll() => students;
        public static Student? Get(int id) => students.FirstOrDefault(p => p.Id == id);
        public static void Add(Student student)
        {
            student.Id =id+1;
            id= student.Id;
            students.Add(student);
        }

        public static void Delete(int id) 
        {
            var student = Get(id);
            if(student != null) 
            {
                students.Remove(student);
            }
        }
        public static void Update(Student student)
        {
            var stu= students.FindIndex(p =>p.Id==student.Id);
            if(stu != -1) 
            {
                students[stu]=student;
            }
        }
    }
}
