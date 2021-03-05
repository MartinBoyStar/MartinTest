using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_School_Application_From_Scratch.Models
{
    public class Course
    {
        
        public int CourseID { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; }
        public int TeacherID { get; set; }

        [ForeignKey("TeacherID")]
        public Teacher Teacher { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<Assignment> Assignments { get; set; }

       
    }
}
