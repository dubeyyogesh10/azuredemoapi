// Authored By CourseService.cs, Date 16-06-2021

namespace azuredemoapi.Services
    {
    using azuredemoapi.models;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="CourseService" />.
    /// </summary>
    public class CourseService
        {
        /// <summary>
        /// The GetCourses.
        /// </summary>
        /// <returns>The <see cref="List{Course}"/>.</returns>
        public List<Course> GetCourses ()
            {
            return new List<Course>
            {
                new Course
                {
                    Id = 1,
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
