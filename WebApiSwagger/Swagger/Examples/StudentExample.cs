using WebApiSwagger.Controllers;
using WebApiSwagger.Models;

namespace WebApiSwagger.Swagger.Examples
{
    public class StudentExample : Student
    {
        public StudentExample()
        {
            var student = Students.CreateStudents()[0];

            DateOfBirth = student.DateOfBirth;
            Email = student.Email;
            FirstName = student.FirstName;
            LastName = student.LastName;
            UserName = student.UserName;
        }
    }
}