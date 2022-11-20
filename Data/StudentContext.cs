using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<ExamType> ExamType { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ClassRoom> ClassRoom { get; set; }
        public DbSet<ClassRoomStudent> ClassRoomStudent { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<ExamResult> ExamResult { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Attendence> Attendence { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamType>()
               .HasMany(g => g.Exam)
               .WithOne(s => s.ExmpType)
               .HasForeignKey(s => s.ExamTypeId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Exam>()
               .HasMany(g => g.ExamResult)
               .WithOne(s => s.Exam)
               .HasForeignKey(s => s.ExamId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Student>()
               .HasMany(g => g.ExamResult)
               .WithOne(s => s.Student)
               .HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Course>()
              .HasMany(g => g.ExamResult)
              .WithOne(s => s.Course)
              .HasForeignKey(s => s.CourseId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Grade>()
              .HasMany(g => g.Course)
              .WithOne(s => s.Grade)
              .HasForeignKey(s => s.GradeId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Grade>()
             .HasMany(g => g.ClassRoom)
             .WithOne(s => s.Grade)
             .HasForeignKey(s => s.GradeId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Teacher>()
            .HasMany(g => g.ClassRoom)
            .WithOne(s => s.Teacher)
            .HasForeignKey(s => s.TeacherId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ClassRoom>()
            .HasMany(g => g.ClassRoomStudent)
            .WithOne(s => s.ClassRoom)
            .HasForeignKey(s => s.ClassRoomId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Student>()
           .HasMany(g => g.ClassRoomStudent)
           .WithOne(s => s.Student)
           .HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Parent>()
           .HasMany(g => g.Student)
           .WithOne(s => s.Parent)
           .HasForeignKey(s => s.ParentId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student>()
          .HasMany(g => g.Attendence)
          .WithOne(s => s.Student)
          .HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
    }
}
