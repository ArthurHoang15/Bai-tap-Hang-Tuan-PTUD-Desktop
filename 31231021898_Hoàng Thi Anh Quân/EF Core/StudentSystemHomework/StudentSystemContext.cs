using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentSystemHomework.Model;


namespace StudentSystemHomework
{
    public class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public string DbPath { get; }

        public StudentSystemContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = @"S:\đại học\Phát triển desktop\Bài tập\StudentSystemHomework\StudentSystemHomework\data.db";
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure many-to-many relationship between Students and Courses
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.EnrolledCourses)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.EnrolledStudents)
                .HasForeignKey(sc => sc.CourseId);

            // Configure Resource to Course relationship (one-to-many)
            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Resources)
                .HasForeignKey(r => r.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure Homework relationships
            modelBuilder.Entity<Homework>()
                .HasOne(h => h.Student)
                .WithMany(s => s.HomeworkSubmissions)
                .HasForeignKey(h => h.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Homework>()
                .HasOne(h => h.Course)
                .WithMany(c => c.HomeworkSubmissions)
                .HasForeignKey(h => h.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Add additional configurations and constraints
            modelBuilder.Entity<Student>()
                .Property(s => s.RegisteredOn)
                .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Use CURRENT_TIMESTAMP for SQLite

            modelBuilder.Entity<Course>()
                .HasCheckConstraint("CK_Course_EndDate", "EndDate > StartDate");

            modelBuilder.Entity<Homework>()
                .Property(h => h.SubmissionDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP"); // Use CURRENT_TIMESTAMP for SQLite

            // Configure homework content type for application/pdf/zip
            modelBuilder.Entity<Homework>()
                .HasCheckConstraint("CK_Homework_ContentType", "ContentType IN ('application/pdf', 'application/zip')");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");


    }
}

