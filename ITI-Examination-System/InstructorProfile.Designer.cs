namespace ITI_ExaminationSystem
{
    partial class InstructorProfile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorProfile));
            instructor_imgbox = new PictureBox();
            choose_img_btn = new Button();
            name_txt = new Label();
            salary_txt = new Label();
            gender_txt = new Label();
            courses_dgv = new DataGridView();
            edit_pass_btn = new Button();
            generate_exam_btn = new Button();
            change_img_btn = new Button();
            confirm_img_btn = new Button();
            cancel_change_btn = new Button();
            logout_btn = new Button();
            branch_txt = new Label();
            tracks_dgv = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            get_st_info_btn = new Button();
            get_st_grades_btn = new Button();
            get_ins_crs_btn = new Button();
            get_st_ans_btn = new Button();
            get_exam_qs_btn = new Button();
            get_crs_top_btn = new Button();
            add_qs_btn = new Button();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            groupBox3 = new GroupBox();
            pictureBox6 = new PictureBox();
            groupBox4 = new GroupBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)instructor_imgbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courses_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tracks_dgv).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // instructor_imgbox
            // 
            instructor_imgbox.Location = new Point(6, 15);
            instructor_imgbox.Margin = new Padding(3, 4, 3, 4);
            instructor_imgbox.Name = "instructor_imgbox";
            instructor_imgbox.Size = new Size(237, 171);
            instructor_imgbox.SizeMode = PictureBoxSizeMode.Zoom;
            instructor_imgbox.TabIndex = 0;
            instructor_imgbox.TabStop = false;
            // 
            // choose_img_btn
            // 
            choose_img_btn.BackColor = Color.MediumVioletRed;
            choose_img_btn.FlatAppearance.BorderColor = Color.Black;
            choose_img_btn.FlatStyle = FlatStyle.Flat;
            choose_img_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            choose_img_btn.ForeColor = Color.WhiteSmoke;
            choose_img_btn.Location = new Point(54, 194);
            choose_img_btn.Margin = new Padding(3, 4, 3, 4);
            choose_img_btn.Name = "choose_img_btn";
            choose_img_btn.Size = new Size(147, 44);
            choose_img_btn.TabIndex = 1;
            choose_img_btn.Text = "Choose Image";
            choose_img_btn.UseVisualStyleBackColor = false;
            choose_img_btn.Click += img_btn_Click;
            // 
            // name_txt
            // 
            name_txt.AutoSize = true;
            name_txt.Location = new Point(78, 281);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(119, 20);
            name_txt.TabIndex = 2;
            name_txt.Text = "Ahmed Mahfouz";
            // 
            // salary_txt
            // 
            salary_txt.AutoSize = true;
            salary_txt.Location = new Point(78, 348);
            salary_txt.Name = "salary_txt";
            salary_txt.Size = new Size(49, 20);
            salary_txt.TabIndex = 2;
            salary_txt.Text = "20000";
            // 
            // gender_txt
            // 
            gender_txt.AutoSize = true;
            gender_txt.Location = new Point(78, 421);
            gender_txt.Name = "gender_txt";
            gender_txt.Size = new Size(42, 20);
            gender_txt.TabIndex = 2;
            gender_txt.Text = "Male";
            // 
            // courses_dgv
            // 
            courses_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            courses_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            courses_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            courses_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            courses_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            courses_dgv.Location = new Point(304, 69);
            courses_dgv.Margin = new Padding(3, 4, 3, 4);
            courses_dgv.Name = "courses_dgv";
            courses_dgv.ReadOnly = true;
            courses_dgv.RowHeadersWidth = 21;
            courses_dgv.Size = new Size(274, 141);
            courses_dgv.TabIndex = 3;
            // 
            // edit_pass_btn
            // 
            edit_pass_btn.BackColor = Color.DarkCyan;
            edit_pass_btn.FlatAppearance.BorderColor = Color.Black;
            edit_pass_btn.FlatStyle = FlatStyle.Flat;
            edit_pass_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_pass_btn.ForeColor = Color.WhiteSmoke;
            edit_pass_btn.Location = new Point(54, 543);
            edit_pass_btn.Margin = new Padding(3, 4, 3, 4);
            edit_pass_btn.Name = "edit_pass_btn";
            edit_pass_btn.Size = new Size(147, 52);
            edit_pass_btn.TabIndex = 4;
            edit_pass_btn.Text = "Edit Password";
            edit_pass_btn.UseVisualStyleBackColor = false;
            edit_pass_btn.Click += edit_pass_btn_Click;
            // 
            // generate_exam_btn
            // 
            generate_exam_btn.BackColor = Color.SteelBlue;
            generate_exam_btn.BackgroundImageLayout = ImageLayout.None;
            generate_exam_btn.FlatAppearance.BorderColor = Color.Black;
            generate_exam_btn.FlatStyle = FlatStyle.Flat;
            generate_exam_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generate_exam_btn.ForeColor = Color.WhiteSmoke;
            generate_exam_btn.Location = new Point(352, 53);
            generate_exam_btn.Margin = new Padding(3, 4, 3, 4);
            generate_exam_btn.Name = "generate_exam_btn";
            generate_exam_btn.Size = new Size(191, 48);
            generate_exam_btn.TabIndex = 5;
            generate_exam_btn.Text = "Generate Exam";
            generate_exam_btn.UseVisualStyleBackColor = false;
            generate_exam_btn.Click += generate_exam_btn_Click;
            // 
            // change_img_btn
            // 
            change_img_btn.BackColor = Color.DarkCyan;
            change_img_btn.FlatAppearance.BorderColor = Color.Black;
            change_img_btn.FlatStyle = FlatStyle.Flat;
            change_img_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            change_img_btn.ForeColor = Color.WhiteSmoke;
            change_img_btn.Location = new Point(54, 194);
            change_img_btn.Margin = new Padding(3, 4, 3, 4);
            change_img_btn.Name = "change_img_btn";
            change_img_btn.Size = new Size(147, 44);
            change_img_btn.TabIndex = 1;
            change_img_btn.Text = "Change Image";
            change_img_btn.UseVisualStyleBackColor = false;
            change_img_btn.Click += change_img_btn_Click;
            // 
            // confirm_img_btn
            // 
            confirm_img_btn.BackColor = Color.ForestGreen;
            confirm_img_btn.FlatAppearance.BorderColor = Color.Black;
            confirm_img_btn.FlatStyle = FlatStyle.Flat;
            confirm_img_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_img_btn.ForeColor = Color.WhiteSmoke;
            confirm_img_btn.Location = new Point(54, 246);
            confirm_img_btn.Margin = new Padding(3, 4, 3, 4);
            confirm_img_btn.Name = "confirm_img_btn";
            confirm_img_btn.Size = new Size(147, 44);
            confirm_img_btn.TabIndex = 1;
            confirm_img_btn.Text = "Confirm";
            confirm_img_btn.UseVisualStyleBackColor = false;
            confirm_img_btn.Click += confirm_img_btn_Click;
            // 
            // cancel_change_btn
            // 
            cancel_change_btn.BackColor = Color.Firebrick;
            cancel_change_btn.FlatAppearance.BorderColor = Color.Black;
            cancel_change_btn.FlatStyle = FlatStyle.Flat;
            cancel_change_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_change_btn.ForeColor = Color.WhiteSmoke;
            cancel_change_btn.Location = new Point(54, 298);
            cancel_change_btn.Margin = new Padding(3, 4, 3, 4);
            cancel_change_btn.Name = "cancel_change_btn";
            cancel_change_btn.Size = new Size(147, 44);
            cancel_change_btn.TabIndex = 1;
            cancel_change_btn.Text = "Cancel";
            cancel_change_btn.UseVisualStyleBackColor = false;
            cancel_change_btn.Click += cancel_change_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.BackgroundImage = ITI_Examination_System.Properties.Resources.log_out1;
            logout_btn.BackgroundImageLayout = ImageLayout.Zoom;
            logout_btn.Location = new Point(11, 75);
            logout_btn.Margin = new Padding(3, 4, 3, 4);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(46, 49);
            logout_btn.TabIndex = 6;
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // branch_txt
            // 
            branch_txt.AutoSize = true;
            branch_txt.Location = new Point(78, 486);
            branch_txt.Name = "branch_txt";
            branch_txt.Size = new Size(64, 20);
            branch_txt.TabIndex = 2;
            branch_txt.Text = "Menofia";
            // 
            // tracks_dgv
            // 
            tracks_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tracks_dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tracks_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tracks_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            tracks_dgv.DefaultCellStyle = dataGridViewCellStyle4;
            tracks_dgv.Location = new Point(37, 69);
            tracks_dgv.Margin = new Padding(3, 4, 3, 4);
            tracks_dgv.Name = "tracks_dgv";
            tracks_dgv.ReadOnly = true;
            tracks_dgv.RowHeadersWidth = 71;
            tracks_dgv.Size = new Size(247, 141);
            tracks_dgv.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 24);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 2;
            label4.Text = "Courses";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 24);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 7;
            label5.Text = "Tracks";
            // 
            // get_st_info_btn
            // 
            get_st_info_btn.BackColor = Color.PaleVioletRed;
            get_st_info_btn.FlatAppearance.BorderColor = Color.Black;
            get_st_info_btn.FlatStyle = FlatStyle.Flat;
            get_st_info_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_st_info_btn.ForeColor = Color.WhiteSmoke;
            get_st_info_btn.Location = new Point(352, 40);
            get_st_info_btn.Margin = new Padding(3, 4, 3, 4);
            get_st_info_btn.Name = "get_st_info_btn";
            get_st_info_btn.Size = new Size(191, 53);
            get_st_info_btn.TabIndex = 8;
            get_st_info_btn.Text = "Get Student Information";
            get_st_info_btn.UseVisualStyleBackColor = false;
            get_st_info_btn.Click += get_st_info_btn_Click;
            // 
            // get_st_grades_btn
            // 
            get_st_grades_btn.BackColor = Color.PaleVioletRed;
            get_st_grades_btn.FlatAppearance.BorderColor = Color.Black;
            get_st_grades_btn.FlatStyle = FlatStyle.Flat;
            get_st_grades_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_st_grades_btn.ForeColor = Color.WhiteSmoke;
            get_st_grades_btn.Location = new Point(84, 161);
            get_st_grades_btn.Margin = new Padding(3, 4, 3, 4);
            get_st_grades_btn.Name = "get_st_grades_btn";
            get_st_grades_btn.Size = new Size(200, 52);
            get_st_grades_btn.TabIndex = 9;
            get_st_grades_btn.Text = "Get Student Grades";
            get_st_grades_btn.UseVisualStyleBackColor = false;
            get_st_grades_btn.Click += get_st_grades_btn_Click;
            // 
            // get_ins_crs_btn
            // 
            get_ins_crs_btn.BackColor = Color.PaleVioletRed;
            get_ins_crs_btn.FlatAppearance.BorderColor = Color.Black;
            get_ins_crs_btn.FlatStyle = FlatStyle.Flat;
            get_ins_crs_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_ins_crs_btn.ForeColor = Color.WhiteSmoke;
            get_ins_crs_btn.Location = new Point(84, 41);
            get_ins_crs_btn.Margin = new Padding(3, 4, 3, 4);
            get_ins_crs_btn.Name = "get_ins_crs_btn";
            get_ins_crs_btn.Size = new Size(200, 52);
            get_ins_crs_btn.TabIndex = 10;
            get_ins_crs_btn.Text = "Get Instructor Courses";
            get_ins_crs_btn.UseVisualStyleBackColor = false;
            get_ins_crs_btn.Click += get_ins_crs_btn_Click;
            // 
            // get_st_ans_btn
            // 
            get_st_ans_btn.BackColor = Color.PaleVioletRed;
            get_st_ans_btn.FlatAppearance.BorderColor = Color.Black;
            get_st_ans_btn.FlatStyle = FlatStyle.Flat;
            get_st_ans_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_st_ans_btn.ForeColor = Color.WhiteSmoke;
            get_st_ans_btn.Location = new Point(84, 101);
            get_st_ans_btn.Margin = new Padding(3, 4, 3, 4);
            get_st_ans_btn.Name = "get_st_ans_btn";
            get_st_ans_btn.Size = new Size(200, 52);
            get_st_ans_btn.TabIndex = 13;
            get_st_ans_btn.Text = "Get Student Answers";
            get_st_ans_btn.UseVisualStyleBackColor = false;
            get_st_ans_btn.Click += get_st_ans_btn_Click;
            // 
            // get_exam_qs_btn
            // 
            get_exam_qs_btn.BackColor = Color.PaleVioletRed;
            get_exam_qs_btn.FlatAppearance.BorderColor = Color.Black;
            get_exam_qs_btn.FlatStyle = FlatStyle.Flat;
            get_exam_qs_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_exam_qs_btn.ForeColor = Color.WhiteSmoke;
            get_exam_qs_btn.Location = new Point(352, 162);
            get_exam_qs_btn.Margin = new Padding(3, 4, 3, 4);
            get_exam_qs_btn.Name = "get_exam_qs_btn";
            get_exam_qs_btn.Size = new Size(191, 52);
            get_exam_qs_btn.TabIndex = 12;
            get_exam_qs_btn.Text = "Get Exam Questions";
            get_exam_qs_btn.UseVisualStyleBackColor = false;
            get_exam_qs_btn.Click += get_exam_qs_btn_Click;
            // 
            // get_crs_top_btn
            // 
            get_crs_top_btn.BackColor = Color.PaleVioletRed;
            get_crs_top_btn.FlatAppearance.BorderColor = Color.Black;
            get_crs_top_btn.FlatStyle = FlatStyle.Flat;
            get_crs_top_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get_crs_top_btn.ForeColor = Color.WhiteSmoke;
            get_crs_top_btn.Location = new Point(352, 102);
            get_crs_top_btn.Margin = new Padding(3, 4, 3, 4);
            get_crs_top_btn.Name = "get_crs_top_btn";
            get_crs_top_btn.Size = new Size(191, 52);
            get_crs_top_btn.TabIndex = 11;
            get_crs_top_btn.Text = "Get Course Topic";
            get_crs_top_btn.UseVisualStyleBackColor = false;
            get_crs_top_btn.Click += get_crs_top_btn_Click;
            // 
            // add_qs_btn
            // 
            add_qs_btn.BackColor = Color.MediumSeaGreen;
            add_qs_btn.FlatAppearance.BorderColor = Color.Black;
            add_qs_btn.FlatStyle = FlatStyle.Flat;
            add_qs_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_qs_btn.ForeColor = Color.WhiteSmoke;
            add_qs_btn.Location = new Point(84, 53);
            add_qs_btn.Margin = new Padding(3, 4, 3, 4);
            add_qs_btn.Name = "add_qs_btn";
            add_qs_btn.Size = new Size(200, 48);
            add_qs_btn.TabIndex = 14;
            add_qs_btn.Text = "Add Questions";
            add_qs_btn.UseVisualStyleBackColor = false;
            add_qs_btn.Click += add_qs_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(cancel_change_btn);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(choose_img_btn);
            groupBox1.Controls.Add(confirm_img_btn);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(instructor_imgbox);
            groupBox1.Controls.Add(change_img_btn);
            groupBox1.Controls.Add(name_txt);
            groupBox1.Controls.Add(salary_txt);
            groupBox1.Controls.Add(edit_pass_btn);
            groupBox1.Controls.Add(gender_txt);
            groupBox1.Controls.Add(branch_txt);
            groupBox1.Location = new Point(65, 89);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(249, 613);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = ITI_Examination_System.Properties.Resources.branch;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(23, 479);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 33);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = ITI_Examination_System.Properties.Resources.gender;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(23, 414);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 33);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = ITI_Examination_System.Properties.Resources.dollar_sign;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(23, 342);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 33);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = ITI_Examination_System.Properties.Resources.profile;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(23, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 33);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(pictureBox8);
            groupBox2.Controls.Add(pictureBox7);
            groupBox2.Controls.Add(courses_dgv);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tracks_dgv);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(340, 464);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(613, 239);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = ITI_Examination_System.Properties.Resources.book;
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(385, 24);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(33, 35);
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = ITI_Examination_System.Properties.Resources.student;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(105, 24);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(33, 35);
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(pictureBox6);
            groupBox3.Controls.Add(get_st_ans_btn);
            groupBox3.Controls.Add(get_st_grades_btn);
            groupBox3.Controls.Add(get_ins_crs_btn);
            groupBox3.Controls.Add(get_crs_top_btn);
            groupBox3.Controls.Add(get_exam_qs_btn);
            groupBox3.Controls.Add(get_st_info_btn);
            groupBox3.Location = new Point(340, 232);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(613, 224);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Reports";
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = ITI_Examination_System.Properties.Resources.form;
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(30, 40);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 35);
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(pictureBox5);
            groupBox4.Controls.Add(add_qs_btn);
            groupBox4.Controls.Add(generate_exam_btn);
            groupBox4.Location = new Point(340, 89);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(613, 135);
            groupBox4.TabIndex = 18;
            groupBox4.TabStop = false;
            groupBox4.Text = "Actions";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = ITI_Examination_System.Properties.Resources.flash;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(30, 39);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 35);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // InstructorProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1020, 737);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(logout_btn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "InstructorProfile";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor Profile";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)instructor_imgbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)courses_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)tracks_dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox instructor_imgbox;
        private Button choose_img_btn;
        private Label name_txt;
        private Label salary_txt;
        private Label gender_txt;
        private DataGridView courses_dgv;
        private Button edit_pass_btn;
        private Button generate_exam_btn;
        private Button change_img_btn;
        private Button confirm_img_btn;
        private Button cancel_change_btn;
        private Button logout_btn;
        private Label branch_txt;
        private DataGridView tracks_dgv;
        private Label label4;
        private Label label5;
        private Button get_st_info_btn;
        private Button get_st_grades_btn;
        private Button get_ins_crs_btn;
        private Button get_st_ans_btn;
        private Button get_exam_qs_btn;
        private Button get_crs_top_btn;
        private Button add_qs_btn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
    }
}
