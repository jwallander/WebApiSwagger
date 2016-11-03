namespace WebApiSwagger.Models
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