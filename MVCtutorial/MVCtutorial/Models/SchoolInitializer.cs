using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCtutorial.Models
{
    public class SchoolInitializer:DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            //base.Seed(context);
            var students = new List<Student>
            {
                new Student {FirstName = "James", LastName = "Dean", EnrollmentDate = DateTime.Parse("1997-10-08") },
                new Student {FirstName = "Lynda", LastName = "Thames" }
            };

            foreach (var temp in students)
            {
                context.Students.Add(temp);
            }
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course { CourseName = "C#", TotalCredits = 4},
                new Course { CourseName = "Java", TotalCredits = 4}
            };

            foreach (var temp in courses)
            {
                context.Courses.Add(temp);
            }
            context.SaveChanges();

            var enrollment = new List<Enrollment>
            {
                new Enrollment { StudentId = 1, CourseId = 1, Grade = 3},
                new Enrollment { StudentId = 1, CourseId = 2, Grade = 4}
            };

            foreach (var temp in enrollment)
            {
                context.Enrollments.Add(temp);
            }
            context.SaveChanges();


        }
    }
}