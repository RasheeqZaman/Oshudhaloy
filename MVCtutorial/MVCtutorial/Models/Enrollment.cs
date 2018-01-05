using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCtutorial.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public decimal? Grade { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }
}