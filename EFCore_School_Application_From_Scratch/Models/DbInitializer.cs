using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_School_Application_From_Scratch.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander"},
            new Student{FirstName="Meredith",LastName="Alonso"},
            new Student{FirstName="Arturo",LastName="Anand"},
            new Student{FirstName="Gytis",LastName="Barzdukas"},
            new Student{FirstName="Yan",LastName="Li"},
            new Student{FirstName="Peggy",LastName="Justice"},
            new Student{FirstName="Laura",LastName="Norman"},
            new Student{FirstName="Nino",LastName="Olivetto"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var teachers = new Teacher[]
            {
            new Teacher {CourseID=1,Name="Carson"},
            
            };
            foreach (Teacher s in teachers)
            {
                context.Teachers.Add(s);
            }
            context.SaveChanges();

            

            var courses = new Course[]
            {
            new Course{Name="Chemistry",TeacherID=1},
            //new Course{CourseID=4022,Name="Microeconomics",TeacherID=2},
            //new Course{CourseID=4041,Name="Macroeconomics",TeacherID=3},
            //new Course{CourseID=1045,Name="Calculus",TeacherID=4},
            
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var studentCourses = new StudentCourse[]
            {
            new StudentCourse{StudentID=1,CourseID=1},
            //new StudentCourse{StudentID=1,CourseID=4022},
            //new StudentCourse{StudentID=1,CourseID=4041},
            //new StudentCourse{StudentID=2,CourseID=1045},
            //new StudentCourse{StudentID=2,CourseID=3141},
            
            };
            foreach (StudentCourse e in studentCourses)
            {
                context.StudentCourse.Add(e);
            }
            context.SaveChanges();
        }
    }
}