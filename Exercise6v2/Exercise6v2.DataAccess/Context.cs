using Exercise6v2.DataAccess.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Exercise6v2.DataAccess
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "Donau.hiof.no",
                InitialCatalog = "oskarlo",
                UserID = "oskarlo",
                Password = "l9Pk8xXKCY"
            };
            optionsBuilder.UseSqlServer(builder.ConnectionString.ToString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student(1, "Oskar L.", "Ottesen"));
            modelBuilder.Entity<Student>().HasData(new Student(2, "Sara", "Nordmann"));
            modelBuilder.Entity<Student>().HasData(new Student(3, "Harald", "Nordmann"));
            modelBuilder.Entity<Student>().HasData(new Student(4, "Therese", "Nordmann"));

            modelBuilder.Entity<Subject>().HasData(new Subject(1, "dotNet Programming"));
            modelBuilder.Entity<Subject>().HasData(new Subject(2, "Kalkulus"));
            modelBuilder.Entity<Subject>().HasData(new Subject(3, "Data Security"));


            modelBuilder.Entity<Student>()
                .HasMany(a => a.Subjects)
                .WithMany(b => b.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "SubjectStudent",
                    r => r.HasOne<Subject>().WithMany().HasForeignKey("SubjectsSubjectId"),
                    l => l.HasOne<Student>().WithMany().HasForeignKey("StudentsStudenId"),
                    je =>
                    {
                        je.HasKey("StudentsStudenId", "SubjectsSubjectId");
                        je.HasData(
                            new { SubjectsSubjectId = 1, StudentsStudenId = 1 },
                            new { SubjectsSubjectId = 1, StudentsStudenId = 2 },
                            new { SubjectsSubjectId = 2, StudentsStudenId = 3 },
                            new { SubjectsSubjectId = 2, StudentsStudenId = 4 });
                    });
        }
    }
}
