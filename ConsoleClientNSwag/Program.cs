using System;
using WebApiSwaggerClient;

namespace ConsoleClientNSwag
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new StudentsClient();

            var observableStudents = client.GetAllAsync().Result;
            
            foreach (var student in observableStudents)
            {
                Console.WriteLine(student.ToJson());
            }
        }
    }
}
