using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ComsatsUni.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentID { get; set; }
        public string Title { get; set; }
        public string Head { get; set; }

        public virtual ICollection<Enrollment_Staff> Enrollment_Staffs { get; set; }
    }
}