using System;
using System.Collections.Generic;
using WebApiSwagger.Models;

namespace WebApiSwagger.Swagger.Examples
{
    public class StudentsExample : IProvideExamples
    {
        public object GetExamples()
        {

            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < studentNames.Length; i++)
            {
                var nameGenderMail = SplitValue(studentNames[i]);
                var student = new Student()
                {
                    Email = String.Format("{0}.{1}@{2}", nameGenderMail[0], nameGenderMail[1], nameGenderMail[3]),
                    UserName = String.Format("{0}{1}", nameGenderMail[0], nameGenderMail[1]),
                    FirstName = nameGenderMail[0],
                    LastName = nameGenderMail[1],
                    DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(7000, 8000)),
                };

                studentsList.Add(student);
            }

            return studentsList;
        }
        static string[] studentNames =
        {
            "Taiseer,Joudeh,Male,hotmail.com",
            "Hasan,Ahmad,Male,mymail.com"
        };

        private static string[] SplitValue(string val)
        {
            return val.Split(',');
        }
    }
}