using System.Data.Entity;

namespace MVC_Web_Forms.Models
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Patient> patient { get; set; }

        public DbSet<Appointment> apt { get; set; }

    }
}