using DoctorOnCall.Model;
using DoctorOnCall.Model.Appointments;
using DoctorOnCall.Model.Common;
using DoctorOnCall.Model.Doctors;
using DoctorOnCall.Model.OnlineConsultations;
using DoctorOnCall.Model.Patients;
using DoctorOnCall.Model.Specialities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOnCall.Repository
{
  public  class DoctorOnCallContext : DbContext
    {
            public DoctorOnCallContext() : base("name=drconnect")
            {

            }
            public DbSet<Doctor> Doctors { get; set; }
            public DbSet<Speciality> Specialities { get; set; }
            public DbSet<Patient> Patients { get; set; }
            public DbSet<Prescription> Prescriptions { get; set; }
            public DbSet<Appointment> Appointments { get; set; }
            public DbSet<Address> Addresses { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<OnlineConsultation> OnlineConsultations { get; set; }
           public DbSet<Comment> Comments { get; set; }
        public DbSet<HealthBlog> HealthBlogs { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Doctor>().ToTable("Doctors");
                modelBuilder.Entity<Patient>().ToTable("Patients");
                base.OnModelCreating(modelBuilder);
            }

    }
    }
