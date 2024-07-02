using ITI_Examination_System.ViewModels;
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
    public partial class GetCourseTopicReportPage : MaterialForm
    {
        ExaminationSystemContext db;

        Instructor currentInstructor;

        public GetCourseTopicReportPage(ExaminationSystemContext examinationSystemContext, Instructor ins)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            db = examinationSystemContext;

            currentInstructor = ins;
        }

        private void GetCourseTopicReportPage_Load(object sender, EventArgs e)
        {
            rv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            course_cb.DataSource = db.Courses.ToList();

            course_cb.DisplayMember = "Course_Name";
            course_cb.ValueMember = "Course_ID";
        }

        private void show_report_btn_Click(object sender, EventArgs e)
        {
            var cid = db.Courses.FirstOrDefault(c => c.Course_ID == (int)course_cb.SelectedValue);

            if (cid != null)
            {
                ClearReportViewer();

                var res = db.Database.SqlQuery<TopicInfo>($"Execute dbo.Get_Course_Topic {(int)course_cb.SelectedValue}").AsNoTracking().ToList();

                DataTable dt = new DataTable();

                dt.Columns.Add("Course_Name", typeof(string));
                dt.Columns.Add("Topic_Name", typeof(string));

                foreach (var t in res)
                {
                    DataRow row = dt.NewRow();
                    row["Course_Name"] = t.Course_Name;
                    row["Topic_Name"] = t.Topic_Name;

                    dt.Rows.Add(row);
                }

                rv.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

                rv.LocalReport.ReportPath = Path.GetFullPath(".\\..\\..\\..\\Reports\\GetCourseTopicReport.rdlc"); //"C:\\ITI\\DB Project\\Final V4\\ITI-Examination-System\\ITI-Examination-System\\ITI-Examination-System\\Reports\\GetCourseTopicReport.rdlc";

                rv.RefreshReport();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Track Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearReportViewer()
        {
            rv.LocalReport.DataSources.Clear();
            rv.Clear();
            rv.RefreshReport();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstructorProfile instructorProfile = new InstructorProfile(db,currentInstructor);

            instructorProfile.FormClosed += (obj, args) => this.Close();

            instructorProfile.Show();
        }
    }
}
