using ITI_ExaminationSystem;
using ITI_ExaminationSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.SqlClient;

namespace ExamQuestionsAndChoices
{
    public partial class GetStudentExamAnswersReportPage : MaterialForm
    {
        ExaminationSystemContext db;
        Instructor currentInstructor;
        public GetStudentExamAnswersReportPage(ExaminationSystemContext examinationSystemContext, Instructor ins)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            db = examinationSystemContext;
            this.currentInstructor = ins;
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystemDB;Integrated Security=True;Encrypt=False");
        private void Form1_Load(object sender, EventArgs e)

        {
            exam_cb.DataSource = db.Exams.Select(e => new { Course_Name = e.course.Course_Name, e.Exam_ID }).ToList();

            exam_cb.DisplayMember = "Course_Name";
            exam_cb.ValueMember = "Exam_ID";

            student_cb.DataSource = db.Students.ToList();

            student_cb.DisplayMember = "Student_Name";
            student_cb.ValueMember = "Student_ID";

            this.reportViewer1.RefreshReport();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstructorProfile f = new InstructorProfile(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("GetExamQuestionsAndAnswers", con);
                command.CommandType = CommandType.StoredProcedure;

                // Check if textboxes are empty
                if (!string.IsNullOrWhiteSpace(exam_cb.SelectedValue.ToString()))
                {
                    command.Parameters.AddWithValue("@ExamID", exam_cb.SelectedValue.ToString());
                }
                if (!string.IsNullOrWhiteSpace(student_cb.SelectedValue.ToString()))
                {
                    command.Parameters.AddWithValue("@StudentID", student_cb.SelectedValue.ToString());
                }

                SqlDataAdapter d = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                d.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = Path.GetFullPath(".\\..\\..\\..\\Reports\\GetStudentAnswers.rdlc"); //"C:\\ITI\\DB Project\\Final V4\\ITI-Examination-System\\ITI-Examination-System\\ITI-Examination-System\\Reports\\GetStudentAnswers.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.RefreshReport();
            }
            catch (SqlException ex)
            {
                // Display error message to the user
                MessageBox.Show("An error occurred while fetching data. Please insert valid data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
