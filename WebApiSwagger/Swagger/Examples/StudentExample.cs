using WebApiSwagger.Controllers;

namespace WebApiSwagger.Swagger.Examples
{
    public class StudentExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return Students.CreateStudents()[0];
        }
    }
}