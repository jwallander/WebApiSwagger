using System.Linq;
using WebApiSwagger.Controllers;

namespace WebApiSwagger.Swagger.Examples
{
    public class StudentsExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return Students.CreateStudents().Take(2);
        }
    }
}