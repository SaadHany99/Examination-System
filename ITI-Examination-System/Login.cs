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
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI_ExaminationSystem
{
    public partial class Login : MaterialForm
    {

        ExaminationSystemContext db;
        public Login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);

            db = new ExaminationSystemContext();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendResetLink();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string? User_Email = txtUser.Text;
            string? User_Password = txtpass.Text;
            if (User_Email == "" || User_Password == "")
            {
                MessageBox.Show("Please Enter Your credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var LoginResult = db.UserAccounts.FirstOrDefault(user => (user.User_Email == User_Email) && user.User_Password == User_Password);

            if (LoginResult == null)
            {
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                switch (LoginResult.Account_Type.ToString().ToLower())
                {

                    case "i":
                        this.Hide();

                        InstructorProfile instructorProfile = new InstructorProfile(db, LoginResult.instructor);
                        instructorProfile.FormClosed += (obj, args) => this.Close();
                        instructorProfile.Show();

                        break;
                    default:

                        this.Hide();

                        StudentProfile studentProfile = new StudentProfile(db, db.Students.FirstOrDefault(s => s.User_ID == LoginResult.User_ID));
                        studentProfile.FormClosed += (obj, args) => this.Close();
                        studentProfile.Show();

                        break;
                }

            }
        }


        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = cb.Checked ? '\0' : '*';
            pictureBox5.Visible = cb.Checked;
            pictureBox4.Visible = !cb.Checked;
        }


        private void SendResetLink()
        {
            if (txtUser.Text != string.Empty)
            {
                var user = db.UserAccounts.FirstOrDefault(user => user.User_Email == txtUser.Text);

                if (user != null)
                {
                    try
                    {
                        var password = GeneratePassword();

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("itiexaminationsystem@gmail.com");
                        mail.To.Add(user.User_Email);
                        mail.Subject = "Password Reset";
                        mail.Body = $"Dear User,\n\nYour password has been reset to:{password}";

                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.Port = 587;
                        smtp.Credentials = new System.Net.NetworkCredential("itiexaminationsystem@gmail.com", "sxav tnbw mnlc xxug"); //9:48*5/3/2024
                        smtp.EnableSsl = true;
                        smtp.Send(mail);

                        user.User_Password = password;
                        db.SaveChanges();

                        MessageBox.Show("New Password has been sent to your email.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Sending Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Credintials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GeneratePassword()
        {
            const string _validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_=+";

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < 12; i++)
            {
                int randomIndex = random.Next(0, _validChars.Length);
                password.Append(_validChars[randomIndex]);
            }

            return password.ToString();
        }
    }
}
