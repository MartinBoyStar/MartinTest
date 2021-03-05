using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_School_Application_From_Scratch.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        [ForeignKey("CourseID")]
        public int CourseID { get; set; }
      
        public Course Course { get; set; }
        
    }
}
