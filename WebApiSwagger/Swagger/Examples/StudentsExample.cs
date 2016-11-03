using System.Collections.Generic;
using System.Linq;
using WebApiSwagger.Controllers;
using WebApiSwagger.Models;

namespace WebApiSwagger.Swagger.Examples
{
    public class StudentsExample : List<Student>
    {
        public StudentsExample()
        {
            this.AddRange(Students.CreateStudents().Take(2));
        }
    }
}