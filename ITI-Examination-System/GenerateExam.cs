using ITI_ExaminationSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_ExaminationSystem
{
    public partial class Generate_Exam : MaterialForm
    {
        ExaminationSystemContext db;
        Instructor currentInstructor;
        public Generate_Exam(ExaminationSystemContext examinationSystemContext, Instructor instructor)
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            label1.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            label2.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            label3.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            nudExamDuration.Font = new System.Drawing.Font("Segoe UI", 14f);
            nudExamDuration.Controls[1].Font = new System.Drawing.Font("Segoe UI", 14f);
            nudExamDuration.BackColor = Color.White;
            dtp_examtime.Font = new System.Drawing.Font("Segoe UI", 14f);


            db = examinationSystemContext;
            currentInstructor = instructor;
        }

        private void Generate_Exam_Load(object sender, EventArgs e)
        {
            var courses = currentInstructor.Courses;
            cb_course.DataSource = courses;
            cb_course.ValueMember = "Course_ID";
            cb_course.DisplayMember = "Course_Name";

            dtp_examtime.Format = DateTimePickerFormat.Custom;
            dtp_examtime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtp_examtime.ShowUpDown = true;
            dtp_examtime.Value = DateTime.Now;
        }

        private void btn_generateexam_Click(object sender, EventArgs e)
        {

            var newExam = new Exam()
            {
                Course_ID = (int)cb_course.SelectedValue,
                Exam_Duration = (int)nudExamDuration.Value,
                Instructor_ID = currentInstructor.Instructor_ID,
                Start_Time = dtp_examtime.Value,

            };
            DateTime validDate = DateTime.Now;
            var examList =  db.Exams.Where(e => e.Course_ID == (int)cb_course.SelectedValue).ToList();
            if(examList.Count > 0)
            {
                MessageBox.Show("The Exam for this course already exixts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtp_examtime.Value < validDate)
            {
                MessageBox.Show("You Can`t Choose Previous Date !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var res = MessageBox.Show("A New Exam Will be added, Are You Sure?", "Adding Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    db.Database.ExecuteSql($"Execute Generate_Exam {newExam.Exam_Duration}, {newExam.Start_Time} ,{newExam.Course_ID}, {currentInstructor.Instructor_ID}");
                    
                    db.SaveChanges();

                    
                    var students = db.Students.Where(s => db.Track_Courses.FirstOrDefault(tc => tc.Course_ID == newExam.Course_ID).Track_ID == s.Track_ID);
                    var examId = db.Exams.FirstOrDefault(e => e.Course_ID == newExam.Course_ID).Exam_ID;
                    foreach (var s in students)
                    {
                        db.Student_Exams.Add(new Student_Exams() { Exam_ID = examId, Student_ID = s.Student_ID });
                    }

                    db.SaveChanges();
                    MessageBox.Show("Exam Added Successfuly", "Exam Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    InstructorProfile instructorProfile = new InstructorProfile(db, currentInstructor);
                    instructorProfile.FormClosed += (obj, args) => this.Close();
                    instructorProfile.Show();
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstructorProfile instructorProfile = new InstructorProfile(db, currentInstructor);
            instructorProfile.FormClosed += (obj, args)=> this.Close();
            instructorProfile.Show();
        }
    }
}
