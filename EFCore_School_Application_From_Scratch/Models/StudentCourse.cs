using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_School_Application_From_Scratch.Models
{
    public class StudentCourse
    {
        
        public int ID { get; set; }

        //Into database
        [ForeignKey("CourseID")]
        public int CourseID { get; set; }
        

        //Into database
        [ForeignKey("StudentID")]
        public int StudentID { get; set; }
        

        //For the View
        public Course Course { get; set; }
        
        
        //For the View
        public Student Student { get; set; }
        
        
    }
}
