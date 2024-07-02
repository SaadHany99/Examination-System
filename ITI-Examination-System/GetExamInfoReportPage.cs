using ITI_ExaminationSystem;
using ITI_ExaminationSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExamQuestionsAndChoices
{
    public partial class GetExamInfoReportPage : MaterialForm
    {
        ExaminationSystemContext db;
        Instructor currentInstructor;
        public GetExamInfoReportPage(ExaminationSystemContext examinationSystemContext, Instructor ins)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            db = examinationSystemContext;

            currentInstructor = ins;
        }

        private void GetExamInfoReportPage_Load(object sender, EventArgs e)
        {
            exam_cb.DataSource = db.Exams.Select(e => new { Course_Name = e.course.Course_Name, e.Exam_ID }).ToList();

            exam_cb.DisplayMember = "Course_Name";
            exam_cb.ValueMember = "Exam_ID";
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystemDB;Integrated Security=True;Encrypt=False");

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstructorProfile f = new InstructorProfile(db, currentInstructor);

            f.FormClosed += (obj, args) => this.Close();

            f.Show();
        }

        private void show_btn_click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("getExam", con);
                command.CommandType = CommandType.StoredProcedure;

                // Check if textboxes are empty
                if (!string.IsNullOrWhiteSpace(exam_cb.SelectedValue.ToString()))
                {
                    command.Parameters.AddWithValue("@exam_id", exam_cb.SelectedValue.ToString());
                }

                SqlDataAdapter d = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                d.Fill(dt);
                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource source = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.ReportPath = Path.GetFullPath(".\\..\\..\\..\\Reports\\GetExamInfo.rdlc"); //"C:\\ITI\\DB Project\\Final V4\\ITI-Examination-System\\ITI-Examination-System\\ITI-Examination-System\\Reports\\GetExamInfo.rdlc";
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
