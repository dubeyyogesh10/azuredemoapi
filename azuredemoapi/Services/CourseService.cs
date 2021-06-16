using azuredemoapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azuredemoapi.Services
{
    public class CourseService
    {
        public List<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course
                {
                    Id =1,
                    Name = "english",
                    Teacher = "Beta"
                },
                 new Course
                {
                    Id =2,
                    Name = "maths",
                    Teacher = "yo"
                },
                  new Course
                {
                    Id =3,
                    Name = "english",
                    Teacher = "Aplha"
                },
                   new Course
                {
                    Id =4,
                    Name = "science",
                    Teacher = "AB"
                }
            };
        }
    }
}
