namespace ITI_ExaminationSystem
{
    partial class Generate_Exam
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
            dtp_examtime = new DateTimePicker();
            nudExamDuration = new NumericUpDown();
            btn_generateexam = new MaterialSkin.Controls.MaterialButton();
            cb_course = new MaterialSkin.Controls.MaterialComboBox();
            close_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudExamDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dtp_examtime
            // 
            dtp_examtime.Cursor = Cursors.Hand;
            dtp_examtime.Location = new Point(468, 587);
            dtp_examtime.Margin = new Padding(3, 4, 3, 4);
            dtp_examtime.MaxDate = new DateTime(2124, 12, 31, 0, 0, 0, 0);
            dtp_examtime.MinDate = new DateTime(2021, 1, 1, 0, 0, 0, 0);
            dtp_examtime.Name = "dtp_examtime";
            dtp_examtime.Size = new Size(292, 27);
            dtp_examtime.TabIndex = 13;
            dtp_examtime.Value = new DateTime(2024, 2, 29, 0, 0, 0, 0);
            // 
            // nudExamDuration
            // 
            nudExamDuration.BorderStyle = BorderStyle.FixedSingle;
            nudExamDuration.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudExamDuration.Location = new Point(468, 483);
            nudExamDuration.Margin = new Padding(3, 4, 3, 4);
            nudExamDuration.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudExamDuration.Name = "nudExamDuration";
            nudExamDuration.Size = new Size(292, 27);
            nudExamDuration.TabIndex = 6;
            nudExamDuration.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_generateexam
            // 
            btn_generateexam.AutoSize = false;
            btn_generateexam.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_generateexam.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            btn_generateexam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_generateexam.Depth = 0;
            btn_generateexam.HighEmphasis = true;
            btn_generateexam.Icon = null;
            btn_generateexam.Location = new Point(369, 662);
            btn_generateexam.Margin = new Padding(5);
            btn_generateexam.MouseState = MaterialSkin.MouseState.HOVER;
            btn_generateexam.Name = "btn_generateexam";
            btn_generateexam.NoAccentTextColor = Color.Empty;
            btn_generateexam.Size = new Size(147, 50);
            btn_generateexam.TabIndex = 8;
            btn_generateexam.Text = "Generate Exam";
            btn_generateexam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_generateexam.UseAccentColor = false;
            btn_generateexam.UseVisualStyleBackColor = true;
            btn_generateexam.Click += btn_generateexam_Click;
            // 
            // cb_course
            // 
            cb_course.AutoResize = false;
            cb_course.BackColor = Color.FromArgb(255, 255, 255);
            cb_course.Depth = 0;
            cb_course.DrawMode = DrawMode.OwnerDrawVariable;
            cb_course.DropDownHeight = 174;
            cb_course.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_course.DropDownWidth = 121;
            cb_course.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cb_course.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cb_course.FormattingEnabled = true;
            cb_course.IntegralHeight = false;
            cb_course.ItemHeight = 43;
            cb_course.Location = new Point(468, 384);
            cb_course.MaxDropDownItems = 4;
            cb_course.MouseState = MaterialSkin.MouseState.OUT;
            cb_course.Name = "cb_course";
            cb_course.Size = new Size(292, 49);
            cb_course.StartIndex = 0;
            cb_course.TabIndex = 1;
            // 
            // close_btn
            // 
            close_btn.BackColor = SystemColors.ButtonFace;
            close_btn.BackgroundImage = ITI_Examination_System.Properties.Resources.left_arrow;
            close_btn.BackgroundImageLayout = ImageLayout.Zoom;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Location = new Point(17, 88);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(49, 41);
            close_btn.TabIndex = 14;
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 385);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 15;
            label1.Text = "Course Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 483);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 16;
            label2.Text = "Exam Duration(Hours):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 592);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 17;
            label3.Text = "Exam Time:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = ITI_Examination_System.Properties.Resources._145_prev_ui;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(294, 68);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 266);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = ITI_Examination_System.Properties.Resources.online_training;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(107, 377);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 48);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = ITI_Examination_System.Properties.Resources.hourglass;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(107, 476);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 48);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = ITI_Examination_System.Properties.Resources.calendar;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(107, 583);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 48);
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = ITI_Examination_System.Properties.Resources.output_onlinegiftools__1_1;
            pictureBox5.Location = new Point(294, 68);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(339, 266);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            // 
            // Generate_Exam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 745);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close_btn);
            Controls.Add(cb_course);
            Controls.Add(btn_generateexam);
            Controls.Add(nudExamDuration);
            Controls.Add(dtp_examtime);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Generate_Exam";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generate Exam";
            Load += Generate_Exam_Load;
            ((System.ComponentModel.ISupportInitialize)nudExamDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtp_examtime;
        private NumericUpDown nudExamDuration;
        private MaterialSkin.Controls.MaterialButton btn_generateexam;
        private MaterialSkin.Controls.MaterialComboBox cb_course;
        private Button close_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}