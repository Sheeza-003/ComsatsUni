using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComsatsUni.Models
{
    

    public class Enrollment_Staff
    {
        public int Enrollment_StaffID { get; set; }
        public int DepartmentID { get; set; }
        public int InstructorID { get; set; }
        public string Staff_Title { get; set; }

        public virtual Department Department { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}