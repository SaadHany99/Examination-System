namespace ExamQuestionsAndChoices
{
    partial class GetStudentExamAnswersReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStudentExamAnswersReportPage));
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            show_btn = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            back_btn = new Button();
            exam_cb = new MaterialSkin.Controls.MaterialComboBox();
            student_cb = new MaterialSkin.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 123);
            reportViewer1.Margin = new Padding(3, 2, 3, 2);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1050, 638);
            reportViewer1.TabIndex = 0;
            // 
            // show_btn
            // 
            show_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            show_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            show_btn.Depth = 0;
            show_btn.HighEmphasis = true;
            show_btn.Icon = null;
            show_btn.Location = new Point(801, 68);
            show_btn.Margin = new Padding(4, 4, 4, 4);
            show_btn.MouseState = MaterialSkin.MouseState.HOVER;
            show_btn.Name = "show_btn";
            show_btn.NoAccentTextColor = Color.Empty;
            show_btn.Size = new Size(64, 36);
            show_btn.TabIndex = 12;
            show_btn.Text = "Show";
            show_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            show_btn.UseAccentColor = false;
            show_btn.UseVisualStyleBackColor = true;
            show_btn.Click += show_btn_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(520, 76);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(106, 19);
            materialLabel2.TabIndex = 14;
            materialLabel2.Text = "Student Name:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(244, 76);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(91, 19);
            materialLabel1.TabIndex = 15;
            materialLabel1.Text = "Exam Name:";
            // 
            // back_btn
            // 
            back_btn.BackColor = SystemColors.ButtonFace;
            back_btn.BackgroundImage = ITI_Examination_System.Properties.Resources.back_red_button_icon_227868;
            back_btn.BackgroundImageLayout = ImageLayout.Zoom;
            back_btn.FlatAppearance.BorderColor = Color.Black;
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Location = new Point(15, 65);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(29, 33);
            back_btn.TabIndex = 16;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // exam_cb
            // 
            exam_cb.AutoResize = false;
            exam_cb.BackColor = Color.FromArgb(255, 255, 255);
            exam_cb.Depth = 0;
            exam_cb.DrawMode = DrawMode.OwnerDrawVariable;
            exam_cb.DropDownHeight = 174;
            exam_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            exam_cb.DropDownWidth = 121;
            exam_cb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            exam_cb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            exam_cb.FormattingEnabled = true;
            exam_cb.IntegralHeight = false;
            exam_cb.ItemHeight = 43;
            exam_cb.Location = new Point(329, 65);
            exam_cb.Margin = new Padding(3, 2, 3, 2);
            exam_cb.MaxDropDownItems = 4;
            exam_cb.MouseState = MaterialSkin.MouseState.OUT;
            exam_cb.Name = "exam_cb";
            exam_cb.Size = new Size(173, 49);
            exam_cb.StartIndex = 0;
            exam_cb.TabIndex = 17;
            // 
            // student_cb
            // 
            student_cb.AutoResize = false;
            student_cb.BackColor = Color.FromArgb(255, 255, 255);
            student_cb.Depth = 0;
            student_cb.DrawMode = DrawMode.OwnerDrawVariable;
            student_cb.DropDownHeight = 174;
            student_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            student_cb.DropDownWidth = 121;
            student_cb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            student_cb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            student_cb.FormattingEnabled = true;
            student_cb.IntegralHeight = false;
            student_cb.ItemHeight = 43;
            student_cb.Location = new Point(618, 65);
            student_cb.Margin = new Padding(3, 2, 3, 2);
            student_cb.MaxDropDownItems = 4;
            student_cb.MouseState = MaterialSkin.MouseState.OUT;
            student_cb.Name = "student_cb";
            student_cb.Size = new Size(177, 49);
            student_cb.StartIndex = 0;
            student_cb.TabIndex = 18;
            // 
            // GetStudentExamAnswersReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1050, 591);
            Controls.Add(student_cb);
            Controls.Add(exam_cb);
            Controls.Add(back_btn);
            Controls.Add(materialLabel1);
            Controls.Add(materialLabel2);
            Controls.Add(show_btn);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "GetStudentExamAnswersReportPage";
            Padding = new Padding(3, 48, 3, 2);
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Answers";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MaterialSkin.Controls.MaterialButton show_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Button back_btn;
        private MaterialSkin.Controls.MaterialComboBox exam_cb;
        private MaterialSkin.Controls.MaterialComboBox student_cb;
    }
}
