﻿using ComsatsUni.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComsatsUni.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment_Staff> Enrollment_Staffs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}