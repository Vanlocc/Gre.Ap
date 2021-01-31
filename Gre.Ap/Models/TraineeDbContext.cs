using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Gre.Ap.Models
{
    public partial class TraineeDbContext : DbContext
    {
        public TraineeDbContext()
            : base("name=TraineeDbConnection")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
