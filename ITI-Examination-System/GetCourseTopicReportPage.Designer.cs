namespace ITI_Examination_System
{
    partial class GetCourseTopicReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetCourseTopicReportPage));
            rv = new Microsoft.Reporting.WinForms.ReportViewer();
            back_btn = new Button();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            course_cb = new MaterialSkin.Controls.MaterialComboBox();
            show_report_btn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // rv
            // 
            rv.Location = new Point(2, 145);
            rv.Name = "ReportViewer";
            rv.ServerReport.BearerToken = null;
            rv.Size = new Size(1750, 1500);
            rv.TabIndex = 0;
            // 
            // back_btn
            // 
            back_btn.BackColor = SystemColors.ButtonFace;
            back_btn.BackgroundImage = Properties.Resources.back_red_button_icon_227868;
            back_btn.BackgroundImageLayout = ImageLayout.Zoom;
            back_btn.FlatAppearance.BorderColor = Color.Black;
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Location = new Point(15, 67);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(34, 26);
            back_btn.TabIndex = 18;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(204, 98);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(100, 19);
            materialLabel1.TabIndex = 19;
            materialLabel1.Text = "Course Name:";
            // 
            // course_cb
            // 
            course_cb.AutoResize = false;
            course_cb.BackColor = Color.FromArgb(255, 255, 255);
            course_cb.Depth = 0;
            course_cb.DrawMode = DrawMode.OwnerDrawVariable;
            course_cb.DropDownHeight = 174;
            course_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            course_cb.DropDownWidth = 121;
            course_cb.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            course_cb.ForeColor = Color.FromArgb(222, 0, 0, 0);
            course_cb.FormattingEnabled = true;
            course_cb.IntegralHeight = false;
            course_cb.ItemHeight = 43;
            course_cb.Location = new Point(305, 88);
            course_cb.Margin = new Padding(3, 2, 3, 2);
            course_cb.MaxDropDownItems = 4;
            course_cb.MouseState = MaterialSkin.MouseState.OUT;
            course_cb.Name = "course_cb";
            course_cb.Size = new Size(201, 49);
            course_cb.StartIndex = 0;
            course_cb.TabIndex = 20;
            // 
            // show_report_btn
            // 
            show_report_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            show_report_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            show_report_btn.Depth = 0;
            show_report_btn.HighEmphasis = true;
            show_report_btn.Icon = null;
            show_report_btn.Location = new Point(550, 88);
            show_report_btn.Margin = new Padding(4, 4, 4, 4);
            show_report_btn.MouseState = MaterialSkin.MouseState.HOVER;
            show_report_btn.Name = "show_report_btn";
            show_report_btn.NoAccentTextColor = Color.Empty;
            show_report_btn.Size = new Size(64, 36);
            show_report_btn.TabIndex = 21;
            show_report_btn.Text = "Show";
            show_report_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            show_report_btn.UseAccentColor = false;
            show_report_btn.UseVisualStyleBackColor = true;
            show_report_btn.Click += show_report_btn_Click;
            // 
            // GetCourseTopicReportPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(show_report_btn);
            Controls.Add(course_cb);
            Controls.Add(materialLabel1);
            Controls.Add(back_btn);
            Controls.Add(rv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GetCourseTopicReportPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Topic";
            Load += GetCourseTopicReportPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv;
        private Button back_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox course_cb;
        private MaterialSkin.Controls.MaterialButton show_report_btn;
    }
}