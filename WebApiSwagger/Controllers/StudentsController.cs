using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Swashbuckle.Swagger.Annotations;
using WebApiSwagger.Models;
using WebApiSwagger.Swagger;

namespace WebApiSwagger.Controllers
{
    [RoutePrefix("api/Students")]
    public class StudentsController : ApiController
    {

        private static List<Student> StudentsList;

        public StudentsController()
        {
            if (StudentsList == null)
            {
                StudentsList = Students.CreateStudents();
            }

        }

        /// <summary>
        /// Get all students
        /// </summary>
        /// <remarks>Get an array of all students</remarks>
        [Route("")]
        [ResponseType(typeof(List<Student>))]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<Student>))]
        [SwaggerResponseExamples(typeof(IEnumerable<Student>), typeof(StudentsExample))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, "Internal Server Error")]
        public IHttpActionResult Get()
        {
            return Ok(StudentsList);
        }

        /// <summary>
        /// Get student
        /// </summary>
        /// <param name="userName">Unique username</param>
        /// <remarks>Get signle student by providing username</remarks>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [Route("{userName:alpha}", Name = "GetStudentByUserName")]
        [ResponseType(typeof(Student))]
        public IHttpActionResult Get(string userName)
        {

            var student = StudentsList.Where(s => s.UserName == userName).FirstOrDefault();

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        /// <summary>
        /// Add new student
        /// </summary>
        /// <param name="student">Student Model</param>
        /// <remarks>Insert new student</remarks>
        /// <response code="400">Bad request</response>
        /// <response code="500">Internal Server Error</response>
        [Route("")]
        [ResponseType(typeof(Student))]
        [SwaggerRequestExamples(typeof(Student), typeof(StudentExample))]
        public IHttpActionResult Post(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (StudentsList.Any(s => s.UserName == student.UserName))
            {
                return BadRequest("Username already exists");
            }

            StudentsList.Add(student);

            string uri = Url.Link("GetStudentByUserName", new { userName = student.UserName });

            return Created(uri, student);
        }

        /// <summary>
        /// Delete student
        /// </summary>
        /// <param name="userName">Unique username</param>
        /// <remarks>Delete existing student</remarks>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal Server Error</response>
        [Route("{userName:alpha}")]
        public HttpResponseMessage Delete(string userName)
        {

            var student = StudentsList.Where(s => s.UserName == userName).FirstOrDefault();

            if (student == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            StudentsList.Remove(student);

            return Request.CreateResponse(HttpStatusCode.NoContent);

        }

    }
}
