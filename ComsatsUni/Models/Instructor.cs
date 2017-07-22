using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComsatsUni.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment_Staff> Enrollment_Staffs { get; set; } // the Enrollments property of a Student entity will hold all of the Enrollment entities that are related to that Student entity. In other words, if a given Student row in the database has two related Enrollment rows (rows that contain that student's primary key value in their StudentID foreign key column), that Student entity's Enrollments navigation property will contain those two Enrollment entities.
    }
}