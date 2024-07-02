using ITI_ExaminationSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ITI_ExaminationSystem
{
    public partial class StudentProfile : MaterialForm
    {
        ExaminationSystemContext db;
        Student std;

        public StudentProfile(ExaminationSystemContext examinationSystemContext, Student student)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            edit.BackColor = System.Drawing.Color.FromArgb(0, 50, 255);
            edit.ForeColor = System.Drawing.Color.White;
            edit.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            editPassword.BackColor = System.Drawing.Color.FromArgb(0, 50, 255);
            editPassword.ForeColor = System.Drawing.Color.White;
            editPassword.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            startExam_btn.BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            startExam_btn.ForeColor = System.Drawing.Color.White;
            startExam_btn.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            track.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            branch.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            name.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            age.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            email.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            gender.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            db = examinationSystemContext;
            std = student;

        }

        private void student_Load(object sender, EventArgs e)
        {
            name.Text = std.Student_Name.ToString();
            age.Text = std.Student_Age.ToString();
            gender.Text = (std.Student_Gender.ToString().ToLower() == "m") ? "Male" : "Female";

            int branchID = std.Branch_ID;
            string branchName = db.Branches.FirstOrDefault(n => n.Branch_ID == branchID).Branch_Name.ToString();
            branch.Text = branchName;

            int trackid = std.Track_ID;
            string trackhName = db.Tracks.FirstOrDefault(n => n.Track_ID == trackid).Track_Name.ToString();
            track.Text = trackhName;

            int userid = std.User_ID;
            string emailadd = db.UserAccounts.FirstOrDefault(n => n.User_ID == userid).User_Email.ToString();
            email.Text = emailadd;

            dgv.DataSource = db.Student_Exams.Where(x => x.Student_ID == std.Student_ID && x.Student_Degree != null).Select(n => new { Exam = n.exam.course.Course_Name, Degree = n.Student_Degree }).ToList();

            examsSchedule.DataSource = db.Student_Exams.Where(x => x.Student_ID == std.Student_ID && x.Student_Degree == null && x.exam.Start_Time >= DateTime.Now).Select(n => new { Exam = n.exam.course.Course_Name, Time = n.exam.Start_Time }).ToList();

            if (std.Student_Image != null)
            {
                std_image.Image = Image.FromStream(new MemoryStream(std.Student_Image));
            }
            else
            {
                std_image.Image = std_image.ErrorImage;
            }


        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    std_image.Image?.Dispose();

                    std_image.Image = Image.FromFile(openFileDialog1.FileName);

                    std.Student_Image = ImageToByteArray(std_image.Image);

                    db.SaveChanges();
                    MessageBox.Show("Your image is updated");
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void EditPassword(object sender, EventArgs e)
        {
            this.Hide();

            Change_Password change_Password = new Change_Password(db, db.UserAccounts.FirstOrDefault(user => user.student.Student_ID == std.Student_ID));
            change_Password.FormClosed += (obj, args) => this.Close();
            change_Password.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are You Sure You Want to Logout?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Hide();

                Login login = new Login();
                login.FormClosed += (obj, args) => this.Close();
                login.Show();
            }
        }

        private void startExam_btn_Click(object sender, EventArgs e)
        {

            Student_Exams? student_Exam = db.Student_Exams.Where(n =>
            n.Student_ID == std.Student_ID &&
            n.Student_Degree == null &&
            DateTime.Now >= n.exam.Start_Time && DateTime.Now <= n.exam.Start_Time.AddHours(n.exam.Exam_Duration)
            ).FirstOrDefault();

            if (student_Exam != null)
            {
                this.Hide();

                ExamPage examPage = new ExamPage(db, std);
                examPage.FormClosed += (obj, args) => this.Close();
                examPage.Show();

            }
            else
            {
                MessageBox.Show("There isn't any exams now", "Exam Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
