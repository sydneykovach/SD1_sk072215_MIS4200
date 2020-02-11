using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SD1_sk072215_MIS4200.Models;
using System.Data.Entity;

namespace SD1_sk072215_MIS4200.DAL
{
    public class MIS4200Context : DbContext 
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<AppointmentDetail> AppointmentDetails { get; set; }
    }
}