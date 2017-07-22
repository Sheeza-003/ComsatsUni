using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ComsatsUni.Models;



namespace ComsatsUni.DAL
{
    public class SchoolInitializer : System.Data.Entity.
DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
 {
 new
Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
 new
Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
 new
Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
 new
Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
 new
Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
 new
Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
 new
Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
 new
Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
 };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
 {
 new Course{CourseID=1050,Title="Chemistry",Credits=3,},
 new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
 new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
 new Course{CourseID=1045,Title="Calculus",Credits=4,},
 new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
 new Course{CourseID=2021,Title="Composition",Credits=3,},
 new Course{CourseID=2042,Title="Literature",Credits=4,}
 };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
 {
 new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
 new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
 new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
 new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
 new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
 new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
 new Enrollment{StudentID=3,CourseID=1050},
 new Enrollment{StudentID=4,CourseID=1050,},
 new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
 new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
 new Enrollment{StudentID=6,CourseID=1045},
 new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
 };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();



            var instructors = new List<Instructor>
            {
                new Instructor { FirstMidName = "Ali",LastName = "Khan", EnrollmentDate = DateTime.Parse("2010-09-01") },
                new Instructor { FirstMidName = "Ahmed",LastName = "Mani",EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Instructor { FirstMidName = "Waqar",LastName = "Ali",EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Instructor { FirstMidName = "Sarah",LastName = "Mehmood",EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Instructor { FirstMidName = "Mehvish",LastName = "Asim",EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Instructor { FirstMidName = "Maliha",LastName = "Sanam", EnrollmentDate = DateTime.Parse("2011-09-01") },
                new Instructor { FirstMidName = "Asim",LastName = "Hussain",EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Instructor { FirstMidName = "Shella",LastName = "Agha",EnrollmentDate = DateTime.Parse("2005-08-11") }
            };
            instructors.ForEach(s => context.Instructors.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
 {
 new Department{DepartmentID=001,Title="Computer Science", Head="Sir Mehmood Alam"},
 new Department{DepartmentID=002,Title="Biology",Head="Prof. Hira Abbas"},
 new Department{DepartmentID=003,Title="Economics",Head="Sir Mehmood Alam"},
 new Department{DepartmentID=004,Title="Mathematics",Head="Prof. Saima Tauqer"},
 new Department{DepartmentID=005,Title="Chemistry",Head="Prof. Irfan Majeed"},
 new Department{DepartmentID=006,Title="Arts",Head="Sir Hafees Alam"},
 new Department{DepartmentID=007,Title="Literature",Head="Madam Sana Abbas"}
 };
            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var enrollment_staffs = new List<Enrollment_Staff>
 {
 new Enrollment_Staff{InstructorID=1,DepartmentID=001},
 new Enrollment_Staff{InstructorID=1,DepartmentID=002},
 new Enrollment_Staff{InstructorID=1,DepartmentID=003},
 new Enrollment_Staff{InstructorID=2,DepartmentID=004},
 new Enrollment_Staff{InstructorID=2,DepartmentID=005},
 new Enrollment_Staff{InstructorID=2,DepartmentID=006},
 new Enrollment_Staff{InstructorID=3,DepartmentID=007},
 new Enrollment_Staff{InstructorID=4,DepartmentID=001},
 new Enrollment_Staff{InstructorID=4,DepartmentID=002},
 new Enrollment_Staff{InstructorID=5,DepartmentID=001},
 new Enrollment_Staff{InstructorID=6,DepartmentID=001},
 new Enrollment_Staff{InstructorID=7,DepartmentID=001}
 };
            enrollment_staffs.ForEach(s => context.Enrollment_Staffs.Add(s));
            context.SaveChanges();
        }

    }
}