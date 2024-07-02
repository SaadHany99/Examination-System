namespace ITI_ExaminationSystem
{
    partial class StudentProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfile));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            branch = new Label();
            track = new Label();
            gender = new Label();
            age = new Label();
            email = new Label();
            name = new Label();
            edit = new Button();
            editPassword = new Button();
            groupBox1 = new GroupBox();
            dgv = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            std_image = new PictureBox();
            logout_btn = new Button();
            startExam_btn = new Button();
            groupBox2 = new GroupBox();
            examsSchedule = new DataGridView();
            groupBox3 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)std_image).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examsSchedule).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // branch
            // 
            branch.AutoSize = true;
            branch.Font = new Font("Segoe UI", 14.25F);
            branch.Location = new Point(109, 162);
            branch.Name = "branch";
            branch.Size = new Size(78, 32);
            branch.TabIndex = 12;
            branch.Text = "label7";
            // 
            // track
            // 
            track.AutoSize = true;
            track.Font = new Font("Segoe UI", 14.25F);
            track.Location = new Point(109, 65);
            track.Name = "track";
            track.Size = new Size(78, 32);
            track.TabIndex = 11;
            track.Text = "label8";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 14.25F);
            gender.Location = new Point(92, 444);
            gender.Name = "gender";
            gender.Size = new Size(78, 32);
            gender.TabIndex = 10;
            gender.Text = "label9";
            // 
            // age
            // 
            age.AutoSize = true;
            age.Font = new Font("Segoe UI", 14.25F);
            age.Location = new Point(92, 336);
            age.Name = "age";
            age.Size = new Size(91, 32);
            age.TabIndex = 9;
            age.Text = "label10";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 14.25F);
            email.Location = new Point(92, 390);
            email.Name = "email";
            email.Size = new Size(91, 32);
            email.TabIndex = 8;
            email.Text = "label11";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 14.25F);
            name.Location = new Point(92, 282);
            name.Name = "name";
            name.Size = new Size(91, 32);
            name.TabIndex = 7;
            name.Text = "label12";
            // 
            // edit
            // 
            edit.BackColor = Color.DarkCyan;
            edit.FlatAppearance.BorderColor = Color.Black;
            edit.FlatStyle = FlatStyle.Flat;
            edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit.ForeColor = Color.WhiteSmoke;
            edit.Location = new Point(92, 216);
            edit.Margin = new Padding(3, 4, 3, 4);
            edit.Name = "edit";
            edit.Size = new Size(147, 44);
            edit.TabIndex = 13;
            edit.Text = "Edit Image";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // editPassword
            // 
            editPassword.BackColor = Color.DarkCyan;
            editPassword.FlatAppearance.BorderColor = Color.Black;
            editPassword.FlatStyle = FlatStyle.Flat;
            editPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editPassword.ForeColor = Color.WhiteSmoke;
            editPassword.Location = new Point(92, 486);
            editPassword.Margin = new Padding(3, 4, 3, 4);
            editPassword.Name = "editPassword";
            editPassword.Size = new Size(147, 44);
            editPassword.TabIndex = 14;
            editPassword.Text = "Change Password";
            editPassword.UseVisualStyleBackColor = false;
            editPassword.Click += EditPassword;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dgv);
            groupBox1.Location = new Point(791, 341);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(345, 283);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exams Degree";
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.GridColor = SystemColors.GrayText;
            dgv.Location = new Point(13, 28);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(320, 245);
            dgv.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // std_image
            // 
            std_image.ErrorImage = (Image)resources.GetObject("std_image.ErrorImage");
            std_image.Location = new Point(43, 28);
            std_image.Margin = new Padding(3, 4, 3, 4);
            std_image.Name = "std_image";
            std_image.Size = new Size(237, 171);
            std_image.SizeMode = PictureBoxSizeMode.Zoom;
            std_image.TabIndex = 17;
            std_image.TabStop = false;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Transparent;
            logout_btn.BackgroundImage = ITI_Examination_System.Properties.Resources.log_out1;
            logout_btn.BackgroundImageLayout = ImageLayout.Zoom;
            logout_btn.Location = new Point(15, 78);
            logout_btn.Margin = new Padding(3, 4, 3, 4);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(46, 49);
            logout_btn.TabIndex = 13;
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // startExam_btn
            // 
            startExam_btn.BackColor = Color.MediumSeaGreen;
            startExam_btn.FlatAppearance.BorderColor = Color.Black;
            startExam_btn.FlatStyle = FlatStyle.Flat;
            startExam_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startExam_btn.ForeColor = Color.WhiteSmoke;
            startExam_btn.Location = new Point(454, 105);
            startExam_btn.Margin = new Padding(3, 4, 3, 4);
            startExam_btn.Name = "startExam_btn";
            startExam_btn.Size = new Size(132, 46);
            startExam_btn.TabIndex = 14;
            startExam_btn.Text = "Start Exam";
            startExam_btn.UseVisualStyleBackColor = false;
            startExam_btn.Click += startExam_btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(examsSchedule);
            groupBox2.Location = new Point(440, 341);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(322, 283);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Exams schedule";
            // 
            // examsSchedule
            // 
            examsSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            examsSchedule.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            examsSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            examsSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            examsSchedule.DefaultCellStyle = dataGridViewCellStyle4;
            examsSchedule.GridColor = SystemColors.GrayText;
            examsSchedule.Location = new Point(19, 28);
            examsSchedule.Margin = new Padding(3, 4, 3, 4);
            examsSchedule.Name = "examsSchedule";
            examsSchedule.ReadOnly = true;
            examsSchedule.RowHeadersWidth = 51;
            examsSchedule.Size = new Size(288, 245);
            examsSchedule.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(std_image);
            groupBox3.Controls.Add(editPassword);
            groupBox3.Controls.Add(edit);
            groupBox3.Controls.Add(email);
            groupBox3.Controls.Add(name);
            groupBox3.Controls.Add(age);
            groupBox3.Controls.Add(gender);
            groupBox3.Location = new Point(77, 78);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(320, 546);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = ITI_Examination_System.Properties.Resources.gender;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(30, 438);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 33);
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = ITI_Examination_System.Properties.Resources.email10;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(30, 384);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 33);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = ITI_Examination_System.Properties.Resources.age;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(30, 330);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 33);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ITI_Examination_System.Properties.Resources.profile;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(30, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 33);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(pictureBox6);
            groupBox4.Controls.Add(pictureBox5);
            groupBox4.Controls.Add(startExam_btn);
            groupBox4.Controls.Add(branch);
            groupBox4.Controls.Add(track);
            groupBox4.Location = new Point(440, 78);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(696, 243);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = ITI_Examination_System.Properties.Resources.branch;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(43, 146);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 59);
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = ITI_Examination_System.Properties.Resources.student;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(43, 49);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 59);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // StudentProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1212, 641);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(logout_btn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Profile";
            Load += student_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)std_image).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)examsSchedule).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label branch;
        private Label track;
        private Label gender;
        private Label age;
        private Label email;
        private Label name;
        private Button edit;
        private Button editPassword;
        private GroupBox groupBox1;
        private DataGridView dgv;
        private OpenFileDialog openFileDialog1;
        private PictureBox std_image;
        private Button logout_btn;
        private Button startExam_btn;
        private GroupBox groupBox2;
        private DataGridView examsSchedule;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}