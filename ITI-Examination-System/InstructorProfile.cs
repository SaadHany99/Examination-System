using ExamQuestionsAndChoices;
using ITI_Examination_System;
using ITI_ExaminationSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace ITI_ExaminationSystem
{
    public partial class InstructorProfile : MaterialForm
    {
        ExaminationSystemContext db;

        Instructor currentInstructor;

        public InstructorProfile(ExaminationSystemContext examinationSystemContext, Instructor ins)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            groupBox4.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            groupBox3.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            label5.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            label4.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            add_qs_btn.BackColor = System.Drawing.Color.FromArgb(0, 100, 255);
            add_qs_btn.ForeColor = System.Drawing.Color.White;
            add_qs_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            get_st_info_btn.BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            get_st_info_btn.ForeColor = System.Drawing.Color.White;
            get_st_info_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            get_st_grades_btn.BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            get_st_grades_btn.ForeColor = System.Drawing.Color.White;
            get_st_grades_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            get_ins_crs_btn.BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            get_ins_crs_btn.ForeColor = System.Drawing.Color.White;
            get_ins_crs_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            get_exam_qs_btn.BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            get_exam_qs_btn.ForeColor = System.Drawing.Color.White;
            get_exam_qs_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            get_crs_top_btn.BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            get_crs_top_btn.ForeColor = System.Drawing.Color.White;
            get_crs_top_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            change_img_btn.BackColor = System.Drawing.Color.FromArgb(0, 50, 255);
            change_img_btn.ForeColor = System.Drawing.Color.White;
            change_img_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            edit_pass_btn.BackColor = System.Drawing.Color.FromArgb(0, 50, 255);
            edit_pass_btn.ForeColor = System.Drawing.Color.White;
            edit_pass_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            generate_exam_btn.BackColor = System.Drawing.Color.FromArgb(0, 100, 255);
            generate_exam_btn.ForeColor = System.Drawing.Color.White;
            generate_exam_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            get_st_ans_btn.BackColor = System.Drawing.Color.FromArgb(0, 150, 255);
            get_st_ans_btn.ForeColor = System.Drawing.Color.White;
            get_st_ans_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            choose_img_btn.BackColor = System.Drawing.Color.FromArgb(0, 50, 255);
            choose_img_btn.ForeColor = System.Drawing.Color.White;
            choose_img_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            confirm_img_btn.BackColor = System.Drawing.Color.FromArgb(0, 128, 0);
            confirm_img_btn.ForeColor = System.Drawing.Color.White;
            confirm_img_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            cancel_change_btn.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
            cancel_change_btn.ForeColor = System.Drawing.Color.White;
            cancel_change_btn.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            name_txt.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            salary_txt.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            gender_txt.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            branch_txt.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);





            db = examinationSystemContext;

            currentInstructor = ins;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hide_Elements();

            GetIndstructorData();
        }

        public void GetIndstructorData()
        {
            courses_dgv.DataSource = currentInstructor.Courses.Select(c => new { c.Course_ID, c.Course_Name, c.Course_Duration, c.Instructor_ID, c.instructor, c.Topic_ID, c.topic, c.topic.Topic_Name }).ToList();

            tracks_dgv.DataSource = db.Tracks.Where(t => t.Track_ID == db.Instructor_Tracks.FirstOrDefault(it => it.InstructorTrack_ID == currentInstructor.Instructor_ID).Track_ID).ToList();

            name_txt.Text = currentInstructor.Instructor_Name;
            salary_txt.Text = currentInstructor.Instructor_Salary.ToString();
            gender_txt.Text = (currentInstructor.Instructor_Gender.ToString().ToLower() == "m") ? "Male" : "Female";
            branch_txt.Text = currentInstructor.branch.Branch_Name;
            try
            {
                instructor_imgbox.Image = Image.FromStream(new MemoryStream(currentInstructor.Instructor_Image));
            }
            catch (Exception)
            { }

            courses_dgv.Columns["Course_Id"].Visible = false;
            courses_dgv.Columns["instructor_Id"].Visible = false;
            courses_dgv.Columns["Topic_Id"].Visible = false;
            courses_dgv.Columns["instructor"].Visible = false;
            courses_dgv.Columns["topic"].Visible = false;

            tracks_dgv.Columns["Track_ID"].Visible = false;
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void img_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    instructor_imgbox.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                { }
            }
        }

        private void hide_Elements(string opt = "some")
        {
            if (opt == "all")
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

                courses_dgv.Visible = false;
                tracks_dgv.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                gender_txt.Visible = false;
                name_txt.Visible = false;
                salary_txt.Visible = false;
                branch_txt.Visible = false;
                edit_pass_btn.Visible = false;
                generate_exam_btn.Visible = false;
                logout_btn.Visible = false;
                change_img_btn.Visible = false;
                get_crs_top_btn.Visible = false;
                get_exam_qs_btn.Visible = false;
                get_ins_crs_btn.Visible = false;
                get_st_ans_btn.Visible = false;
                get_st_grades_btn.Visible = false;
                get_st_info_btn.Visible = false;
                add_qs_btn.Visible = false;
            }
            else
            {
                confirm_img_btn.Visible = false;
                cancel_change_btn.Visible = false;
                choose_img_btn.Visible = false;
            }

        }

        private void show_Elements(string opt = "some")
        {
            if (opt == "all")
            {
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;

                courses_dgv.Visible = true;
                tracks_dgv.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                gender_txt.Visible = true;
                name_txt.Visible = true;
                salary_txt.Visible = true;
                branch_txt.Visible = true;
                edit_pass_btn.Visible = true;
                generate_exam_btn.Visible = true;
                logout_btn.Visible = true;
                change_img_btn.Visible = true;
                get_crs_top_btn.Visible = true;
                get_exam_qs_btn.Visible = true;
                get_ins_crs_btn.Visible = true;
                get_st_ans_btn.Visible = true;
                get_st_grades_btn.Visible = true;
                get_st_info_btn.Visible = true;
                add_qs_btn.Visible = true;
            }
            else
            {
                confirm_img_btn.Visible = true;
                cancel_change_btn.Visible = true;
                choose_img_btn.Visible = true;
            }

        }

        private void confirm_img_btn_Click(object sender, EventArgs e)
        {
            try
            {
                currentInstructor.Instructor_Image = ImageToByteArray(instructor_imgbox.Image);

                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            finally
            {
                show_Elements("all");
                hide_Elements();
            }
        }

        private void change_img_btn_Click(object sender, EventArgs e)
        {
            show_Elements();
            hide_Elements("all");
        }

        private void cancel_change_btn_Click(object sender, EventArgs e)
        {
            try
            {
                instructor_imgbox.Image = Image.FromStream(new MemoryStream(currentInstructor.Instructor_Image));
            }
            catch (Exception)
            { }

            show_Elements("all");
            hide_Elements();
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

        private void generate_exam_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Generate_Exam generate_Exam = new Generate_Exam(db, currentInstructor);
            generate_Exam.FormClosed += (obj, args) => this.Close();
            generate_Exam.Show();
        }

        private void edit_pass_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Change_Password change_Password = new Change_Password(db, db.UserAccounts.FirstOrDefault(user => user.instructor.Instructor_ID == currentInstructor.Instructor_ID));
            change_Password.FormClosed += (obj, args) => this.Close();
            change_Password.Show();
        }

        private void get_st_info_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            GetStudentsByTrackReportPage f = new GetStudentsByTrackReportPage(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }

        private void get_crs_top_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            GetCourseTopicReportPage f = new GetCourseTopicReportPage(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }

        private void get_st_grades_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            GetStudentGradesReportPage f = new GetStudentGradesReportPage(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }

        private void get_ins_crs_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            GetInstructorCoursesReportPage f = new GetInstructorCoursesReportPage(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }

        private void get_exam_qs_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            GetExamInfoReportPage f = new GetExamInfoReportPage(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }

        private void get_st_ans_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            GetStudentExamAnswersReportPage f = new GetStudentExamAnswersReportPage(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }

        private void add_qs_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddQuestions f = new AddQuestions(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }
    }
}
