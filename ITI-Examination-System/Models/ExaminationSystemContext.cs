using ITI_Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_ExaminationSystem.Models
{
    public class ExaminationSystemContext : DbContext
    {
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<Branch_Tracks> Branch_Tracks { get; set; }
        public virtual DbSet<Exam_Questions> Exam_Questions { get; set; }
        public virtual DbSet<Instructor_Tracks> Instructor_Tracks { get; set; }
        public virtual DbSet<Question_Choices>  Question_Choices { get; set; }
        public virtual DbSet<Student_Exams> Student_Exams { get; set; }
        public virtual DbSet<Track_Courses> Track_Courses { get; set; }
        public virtual DbSet<Student_Answers> Student_Answers { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExaminationSystemDB;Trusted_Connection=True;TrustServerCertificate=True").UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.instructor)
                .WithMany(i => i.Exams)
                .HasForeignKey(e => e.Instructor_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Exam>()
                .HasOne(e => e.course)
                .WithMany(c => c.Exams)
                .HasForeignKey(e => e.Course_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Instructor>()
                .HasOne(ins => ins.User)
                .WithOne(u => u.instructor)
                .HasForeignKey<Instructor>(ins => ins.User_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>()
                .HasOne(s => s.User)
                .WithOne(u => u.student)
                .HasForeignKey<Student>(s => s.User_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>()
                .HasOne(s => s.track)
                .WithMany(t => t.Students)
                .HasForeignKey(s => s.Track_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student>()
                .HasOne(s => s.branch)
                .WithMany(b => b.Students)
                .HasForeignKey(s => s.Branch_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Branch_Tracks>()
                .HasOne(s => s.branch)
                .WithMany(b => b.Branches)
                .HasForeignKey(s => s.Branch_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Branch_Tracks>()
                .HasOne(s => s.track)
                .WithMany(b => b.Branches)
                .HasForeignKey(s => s.Track_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Instructor>()
                .HasOne(s => s.branch)
                .WithMany(b => b.Instructors)
                .HasForeignKey(s => s.Branch_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Course>()
                .HasOne(s => s.instructor)
                .WithMany(b => b.Courses)
                .HasForeignKey(s => s.Instructor_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Course>()
                .HasOne(s => s.topic)
                .WithMany(b => b.Courses)
                .HasForeignKey(s => s.Topic_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Instructor_Tracks>()
                .HasOne(s => s.track)
                .WithMany(b => b.Instructors)
                .HasForeignKey(s => s.Track_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Instructor_Tracks>()
                .HasOne(s => s.instructor)
                .WithMany(b => b.Instructors)
                .HasForeignKey(s => s.InstructorTrack_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Question>()
                .HasOne(s => s.course)
                .WithMany(b => b.Questions)
                .HasForeignKey(s => s.Course_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Question>()
                .HasOne(s => s.instructor)
                .WithMany(b => b.Questions)
                .HasForeignKey(s => s.Instructor_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Track_Courses>()
                .HasOne(s => s.track)
                .WithMany(b => b.Tracks)
                .HasForeignKey(s => s.Track_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Track_Courses>()
                .HasOne(s => s.course)
                .WithMany(b => b.Tracks)
                .HasForeignKey(s => s.Course_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student_Exams>()
                .HasOne(s => s.student)
                .WithMany(b => b.Students)
                .HasForeignKey(s => s.Student_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student_Exams>()
                .HasOne(s => s.exam)
                .WithMany(b => b.Students)
                .HasForeignKey(s => s.Exam_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Exam_Questions>()
                .HasOne(s => s.exam)
                .WithMany(b => b.Exams)
                .HasForeignKey(s => s.Exam_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Exam_Questions>()
                .HasOne(s => s.question)
                .WithMany(b => b.Exams)
                .HasForeignKey(s => s.Question_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Question_Choices>()
                .HasOne(s => s.question)
                .WithMany(b => b.Questions)
                .HasForeignKey(s => s.Question_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student_Answers>()
                .HasOne(s => s.student)
                .WithMany(b => b.student_answers)
                .HasForeignKey(s => s.Student_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student_Answers>()
                .HasOne(s => s.exam)
                .WithMany(b => b.student_answers)
                .HasForeignKey(s => s.Exam_ID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Student_Answers>()
                .HasOne(s => s.question)
                .WithMany(b => b.student_answers)
                .HasForeignKey(s => s.Question_ID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Branch_Tracks>()
                .HasKey("Branch_ID", "Track_ID");

            modelBuilder.Entity<Track_Courses>()
               .HasKey("Track_ID", "Course_ID");

            modelBuilder.Entity<Exam_Questions>()
                .HasKey("Exam_ID", "Question_ID");

            modelBuilder.Entity<Question_Choices>()
               .HasKey("Question_ID", "Choice_ID");

            modelBuilder.Entity<Instructor_Tracks>()
               .HasKey("InstructorTrack_ID", "Track_ID");

            modelBuilder.Entity<Student_Exams>()
               .HasKey("Student_ID", "Exam_ID");

            modelBuilder.Entity<Student_Answers>()
                .HasKey("Student_ID", "Exam_ID", "Question_ID");

        }

    }
}
