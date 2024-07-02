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
    public partial class GetStudentsByTrackReportPage : MaterialForm
    {
        ExaminationSystemContext db;

        Instructor currentInstructor;
        public GetStudentsByTrackReportPage(ExaminationSystemContext examinationSystemContext, Instructor ins)
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

        private void ReportPage_Load(object sender, EventArgs e)
        {
            rv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            tracks_cb.DataSource = db.Tracks.ToList();

            tracks_cb.DisplayMember = "Track_Name";
            tracks_cb.ValueMember = "Track_ID";
        }

        private void show_report_btn_Click(object sender, EventArgs e)
        {
            var tid = db.Tracks.FirstOrDefault(t => t.Track_ID == (int)tracks_cb.SelectedValue);

            if (tid != null)
            {
                ClearReportViewer();

                var res = db.Database.SqlQuery<StudentInfo>($"Execute dbo.Get_Student_by_Track {(int)tracks_cb.SelectedValue}").AsNoTracking().ToList();

                DataTable dt = new DataTable();

                dt.Columns.Add("Student_ID", typeof(int));
                dt.Columns.Add("Student_Name", typeof(string));
                dt.Columns.Add("Student_Age", typeof(int));
                dt.Columns.Add("Student_Gender", typeof(string));
                dt.Columns.Add("User_Email", typeof(string));
                dt.Columns.Add("Branch_Name", typeof(string));
                dt.Columns.Add("Track_Name", typeof(string));

                foreach (var st in res)
                {
                    DataRow row = dt.NewRow();
                    row["Student_ID"] = st.Student_ID;
                    row["Student_Name"] = st.Student_Name;
                    row["Student_Age"] = st.Student_Age;
                    row["Student_Gender"] = (st.Student_Gender.ToString().ToLower() == "m") ? "Male" : "Female";
                    row["User_Email"] = st.User_Email;
                    row["Branch_Name"] = st.Branch_Name;
                    row["Track_Name"] = st.Track_Name;
                    dt.Rows.Add(row);
                }

                rv.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));

                rv.LocalReport.ReportPath = Path.GetFullPath(".\\..\\..\\..\\Reports\\GetStudentByTrack.rdlc"); 
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

            InstructorProfile instructorProfile = new InstructorProfile(db, currentInstructor);

            instructorProfile.FormClosed += (obj, args) => this.Close();

            instructorProfile.Show();
        }
    }
}
