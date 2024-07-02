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

namespace ITI_ExaminationSystem
{
    public partial class Change_Password : MaterialForm
    {
        ExaminationSystemContext db;
        UserAccount userAccount;
        public Change_Password(ExaminationSystemContext examinationSystemContext, UserAccount user)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            lbl_old.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            lbl_old.ForeColor = Color.Red;
            lbl_new.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            lbl_new.ForeColor = Color.Red;
            label1.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            label2.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            label3.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);

            db = examinationSystemContext;
            userAccount = user;
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            if (txt_oldpassword.Text != "" && txt_newpassword.Text != "" && txt_confirmpassword.Text != "")
            {
                if (txt_oldpassword.Text == userAccount.User_Password)
                {
                    lbl_old.Visible = false;
                    if (txt_newpassword.Text == txt_confirmpassword.Text)
                    {
                        lbl_new.Visible = false;
                        userAccount.User_Password = txt_newpassword.Text;
                        db.SaveChanges();


                        MessageBox.Show("Password Changed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_oldpassword.Text = txt_newpassword.Text = txt_confirmpassword.Text = "";

                        if (userAccount.Account_Type.ToString().ToLower() == "i")
                        {
                            InstructorProfile instructorProfile = new InstructorProfile(db, db.Instructors.FirstOrDefault(i => i.User_ID == userAccount.User_ID));
                            this.Hide();
                            instructorProfile.FormClosed += (obj, args) => this.Close();
                            instructorProfile.Show();
                        }
                        else
                        {
                            StudentProfile studentProfile = new StudentProfile(db, db.Students.FirstOrDefault(s => s.User_ID == userAccount.User_ID));
                            this.Hide();
                            studentProfile.FormClosed += (obj, args) => this.Close();
                            studentProfile.Show();
                        }

                    }
                    else
                    {
                        lbl_new.Visible = true;
                    }
                }
                else
                {
                    txt_oldpassword.Text = "";
                    lbl_old.Visible = true;
                }



            }
            else
            {
                MessageBox.Show("please fill in Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (userAccount.Account_Type.ToString().ToLower() == "i")
            {
                InstructorProfile instructorProfile = new InstructorProfile(db, db.Instructors.FirstOrDefault(i => i.User_ID == userAccount.User_ID));
                this.Hide();
                instructorProfile.FormClosed += (obj, args) => this.Close();
                instructorProfile.Show();
            }
            else
            {
                StudentProfile studentProfile = new StudentProfile(db, db.Students.FirstOrDefault(s => s.User_ID == userAccount.User_ID));
                this.Hide();
                studentProfile.FormClosed += (obj, args) => this.Close();
                studentProfile.Show();
            }

        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            txt_oldpassword.PasswordChar = cb.Checked ? '\0' : '*';
            txt_newpassword.PasswordChar = cb.Checked ? '\0' : '*';
            txt_confirmpassword.PasswordChar = cb.Checked ? '\0' : '*';
            pictureBox6.Visible = cb.Checked;
            pictureBox7.Visible = !cb.Checked;
        }
    }
}
