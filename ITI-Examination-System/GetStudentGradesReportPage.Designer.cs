namespace ExamQuestionsAndChoices
{
    partial class GetStudentGradesReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStudentGradesReportPage));
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            back_btn = new Button();
            show_btn = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            student_cb = new MaterialSkin.Controls.MaterialComboBox();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(0, 119);
            reportViewer1.Margin = new Padding(3, 2, 3, 2);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1182, 600);
            reportViewer1.TabIndex = 0;
            // 
            // back_btn
            // 
            back_btn.BackColor = SystemColors.ButtonFace;
            back_btn.BackgroundImage = ITI_Examination_System.Properties.Resources.back_red_button_icon_227868;
            back_btn.BackgroundImageLayout = ImageLayout.Zoom;
            back_btn.FlatAppearance.BorderColor = Color.Black;
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Location = new Point(14, 64);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(29, 31);
            back_btn.TabIndex = 9;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // show_btn
            // 
            show_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            show_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            show_btn.Depth = 0;
            show_btn.HighEmphasis = true;
            show_btn.Icon = null;
            show_btn.Location = new Point(697, 68);
            show_btn.Margin = new Padding(4);
            show_btn.MouseState = MaterialSkin.MouseState.HOVER;
            show_btn.Name = "show_btn";
            show_btn.NoAccentTextColor = Color.Empty;
            show_btn.Size = new Size(64, 36);
            show_btn.TabIndex = 11;
            show_btn.Text = "Show";
            show_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            show_btn.UseAccentColor = false;
            show_btn.UseVisualStyleBackColor = true;
            show_btn.Click += show_btn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(312, 76);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 19);
            materialLabel1.TabIndex = 12;
            materialLabel1.Text = "Student Name:";
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
            student_cb.Location = new Point(435, 67);
            student_cb.Margin = new Padding(3, 2, 3, 2);
            student_cb.MaxDropDownItems = 4;
            student_cb.MouseState = MaterialSkin.MouseState.OUT;
            student_cb.Name = "student_cb";
            student_cb.Size = new Size(201, 49);
            student_cb.StartIndex = 0;
            student_cb.TabIndex = 13;
            // 
            // GetStudentGradesReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1181, 591);
            Controls.Add(student_cb);
            Controls.Add(materialLabel1);
            Controls.Add(show_btn);
            Controls.Add(back_btn);
            Controls.Add(reportViewer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(100, 100);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GetStudentGradesReportPage";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Grades";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Button back_btn;
        private MaterialSkin.Controls.MaterialButton show_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox student_cb;
    }
}