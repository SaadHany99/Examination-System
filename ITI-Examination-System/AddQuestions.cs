using ITI_ExaminationSystem;
using ITI_ExaminationSystem.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ITI_Examination_System
{
    public partial class AddQuestions : MaterialForm
    {
        ExaminationSystemContext db;
        Instructor currentInstructor;
        public AddQuestions(ExaminationSystemContext examinationSystemContext, Instructor ins)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            label6.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            label1.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            label2.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            label3.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            label4.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            label5.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            c1_txt.BackColor = System.Drawing.Color.White;
            c1_txt.Font = new System.Drawing.Font("Segoe UI", 12f);
            c2_txt.BackColor = System.Drawing.Color.White;
            c2_txt.Font = new System.Drawing.Font("Segoe UI", 12f);
            c3_txt.BackColor = System.Drawing.Color.White;
            c3_txt.Font = new System.Drawing.Font("Segoe UI", 12f);
            c4_txt.BackColor = System.Drawing.Color.White;
            c4_txt.Font = new System.Drawing.Font("Segoe UI", 12f);

            qheader_txt.BackColor = System.Drawing.Color.White;
            qheader_txt.Font = new System.Drawing.Font("Segoe UI", 14f);

            db = examinationSystemContext;

            currentInstructor = ins;
        }

        private void AddQuestions_Load(object sender, EventArgs e)
        {
            var courses = db.Courses.Where(c => c.Instructor_ID == currentInstructor.Instructor_ID).ToList();

            courses_cb.DataSource = courses;

            courses_cb.DisplayMember = "Course_Name";

            courses_cb.ValueMember = "Course_ID";
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (tof_rb.Checked)
            {
                ShoworHideElements(0);
            }
            else if (mc_rb.Checked)
            {
                ShoworHideElements(1);
            }
        }

        public void ShoworHideElements(int flag)
        {
            if (flag == 0)
            {
                c1_txt.Enabled = false;
                c2_txt.Enabled = false;
                c3_txt.Enabled = false;
                c4_txt.Enabled = false;
                c1_rb.Visible = false;
                c2_rb.Visible = false;
                c3_rb.Visible = false;
                c4_rb.Visible = false;
                true_rb.Visible = true;
                false_rb.Visible = true;
            }
            else
            {
                c1_txt.Enabled = true;
                c2_txt.Enabled = true;
                c3_txt.Enabled = true;
                c4_txt.Enabled = true;
                c1_rb.Visible = true;
                c2_rb.Visible = true;
                c3_rb.Visible = true;
                c4_rb.Visible = true;
                true_rb.Visible = false;
                false_rb.Visible = false;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mc_rb.Checked)
                {
                    if ((c1_rb.Checked || c2_rb.Checked || c3_rb.Checked || c4_rb.Checked) && c1_txt.Text != string.Empty && c2_txt.Text != string.Empty && c3_txt.Text != string.Empty && c4_txt.Text != string.Empty && qheader_txt.Text != string.Empty)
                    {
                        var ma = (c1_rb.Checked) ? c1_txt.Text : (c2_rb.Checked) ? c2_txt.Text : (c3_rb.Checked) ? c3_txt.Text : (c4_rb.Checked) ? c4_txt.Text : "";

                        db.Questions.Add(new Question()
                        {
                            Question_Header = qheader_txt.Text,
                            Question_Type = 'M',
                            Instructor_ID = currentInstructor.Instructor_ID,
                            Course_ID = (int)courses_cb.SelectedValue,
                            Model_Answer = ma
                        });

                        db.SaveChanges();

                        var q = db.Questions.FirstOrDefault(q => q.Question_Header == qheader_txt.Text && q.Question_Type == 'M' && q.Instructor_ID == currentInstructor.Instructor_ID && q.Course_ID == (int)courses_cb.SelectedValue && q.Model_Answer == ma);

                        var choiceIdCounter = db.Question_Choices.Max(qc => qc.Choice_ID);

                        choiceIdCounter++;

                        db.Question_Choices.Add(new Question_Choices()
                        {
                            Question_ID = q.Question_ID,
                            Choice_ID = choiceIdCounter,
                            Choice = c1_txt.Text,
                        });

                        choiceIdCounter++;

                        db.Question_Choices.Add(new Question_Choices()
                        {
                            Question_ID = q.Question_ID,
                            Choice_ID = choiceIdCounter,
                            Choice = c2_txt.Text,
                        });

                        choiceIdCounter++;

                        db.Question_Choices.Add(new Question_Choices()
                        {
                            Question_ID = q.Question_ID,
                            Choice_ID = choiceIdCounter,
                            Choice = c3_txt.Text,
                        });

                        choiceIdCounter++;

                        db.Question_Choices.Add(new Question_Choices()
                        {
                            Question_ID = q.Question_ID,
                            Choice_ID = choiceIdCounter,
                            Choice = c4_txt.Text,
                        });

                        db.SaveChanges();

                        MessageBox.Show("Question Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Fill The Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (tof_rb.Checked)
                {
                    if ((false_rb.Checked || true_rb.Checked) && qheader_txt.Text != string.Empty)
                    {
                        var ma = (true_rb.Checked) ? "True" : (false_rb.Checked) ? "False" : "";

                        db.Questions.Add(new Question()
                        {
                            Question_Header = qheader_txt.Text,
                            Question_Type = 'T',
                            Instructor_ID = currentInstructor.Instructor_ID,
                            Course_ID = (int)courses_cb.SelectedValue,
                            Model_Answer = ma
                        });

                        db.SaveChanges();

                        MessageBox.Show("Question Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please Fill The Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please Fill The Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There Was a Problem, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Reset();
            }
        }

        public void Reset()
        {
            c1_txt.Text = string.Empty;
            c2_txt.Text = string.Empty;
            c3_txt.Text = string.Empty;
            c4_txt.Text = string.Empty;
            qheader_txt.Text = string.Empty;
            c1_rb.Checked = false;
            c2_rb.Checked = false;
            c3_rb.Checked = false;
            c4_rb.Checked = false;
            false_rb.Checked = false;
            true_rb.Checked = false;
            tof_rb.Checked = false;
            mc_rb.Checked = false;
            courses_cb.SelectedIndex = 0;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstructorProfile instructorProfile = new InstructorProfile(db, currentInstructor);

            instructorProfile.FormClosed += (obj, args) => this.Close();

            instructorProfile.Show();
        }
    }
}
