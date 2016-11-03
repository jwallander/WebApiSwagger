using System.Collections.Generic;
using System.Linq;

namespace WebApiSwagger.Models
{
    public class StudentsExample : List<Student>
    {
        public StudentsExample()
        {
            this.AddRange(Students.CreateStudents().Take(2));
        }
    }
}