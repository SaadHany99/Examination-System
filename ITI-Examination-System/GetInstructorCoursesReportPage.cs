using ITI_Examination_System.viewModel;
using ITI_ExaminationSystem;
using ITI_ExaminationSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_Examination_System
{
    public partial class GetInstructorCoursesReportPage : MaterialForm
    {
        ExaminationSystemContext db;

        Instructor currentInstructor;

        DataSet1 dataSet = new DataSet1();
        public GetInstructorCoursesReportPage(ExaminationSystemContext examinationSystemContext, Instructor ins)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            label1.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);

            db = examinationSystemContext;

            currentInstructor = ins;
        }

        private void getdata_Click(object sender, EventArgs e)
        {

            int instID = (int)cm.SelectedValue;


            using (var context = new ExaminationSystemContext())
            {
                var list = db.Database.SqlQuery<instructorCourses>($"EXEC dbo.GetInstructorCourses {instID}")
                                      .AsNoTracking()
                                      .ToList();

                // Clear previous data
                dataSet.GetInstructorCourses.Clear();

                foreach (var item in list)
                {
                    var row = dataSet.GetInstructorCourses.NewGetInstructorCoursesRow();
                    row.Course_Name = item.Course_Name;
                    row.NumOfStudents = item.NumOfStudents;
                    dataSet.GetInstructorCourses.AddGetInstructorCoursesRow(row);
                }
            }
            instReportViewer.LocalReport.ReportPath = Path.GetFullPath(".\\..\\..\\..\\Reports\\GetInstCousesAndStudentsNum.rdlc"); //"C:\\ITI\\DB Project\\Final V4\\ITI-Examination-System\\ITI-Examination-System\\ITI-Examination-System\\Reports\\getInstCousesAndStudentsNum.rdlc";
            instReportViewer.LocalReport.DataSources.Clear();

            instReportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataSet.Tables["GetInstructorCourses"]));

            instReportViewer.LocalReport.ReportEmbeddedResource = "ITI-Examination-System.getInstCousesAndStudentsNum.rdlc";

            instReportViewer.RefreshReport();
        }

        private void InstructorCourses_Load(object sender, EventArgs e)
        {
            cm.DataSource = db.Instructors.ToList();
            cm.ValueMember = "Instructor_ID";
            cm.DisplayMember = "Instructor_Name";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstructorProfile instructorProfile = new InstructorProfile(db, currentInstructor);

            instructorProfile.FormClosed += (obj, args) => this.Close();

            instructorProfile.Show();
        }
    }
}
